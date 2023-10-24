using DevExpress.XtraRichEdit;
using System;
using System.Text;
using System.Windows.Forms;
using Windows.Main.UserControls;
using Windows.Main.View;
using System.IO;
using System.Speech.Synthesis;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Windows.Main.View.CommandsView;
using System.ComponentModel;
using Windows.Main.View.DefaultSettingsView;
using System.Net;
using GoogleApi.Entities.Translate.Common.Enums;
using System.Globalization;
using HtmlAgilityPack;
using DevExpress.XtraRichEdit.API.Native;
using System.Net.Http;
using HtmlDocument = System.Windows.Forms.HtmlDocument;
using System.Threading;
using System.Threading.Tasks;
using GoogleApi.Entities.Maps.Directions.Response;
using Newtonsoft.Json;

namespace Windows.Main.Controllers
{
    class MainFormController : BaseController
    {
        public MainForm View;
        private OpenFileDialog ofd = new OpenFileDialog();
        private SaveFileDialog sfd = new SaveFileDialog();
        private PlayUserContro_1 playUC = new PlayUserContro_1();
        private PdfUserControl1 pdfUC = new PdfUserControl1();
        private CommandsUserControl1 cmdUC = new CommandsUserControl1();
        private TextDocumentUserControl1 textUC = new TextDocumentUserControl1();
        private DefaultSettingsView settingsView;

        private Language SourceLanguage;
        private Language DestinationLanguage;
        private string sourceLanguageCode;
        private string targetLanguageCode;


        private SpeechSynthesizer voice;
        private string voiceLanguageCulture;

        private static readonly string key = "6dc04dbd57ca4df0b0e24a5bc2111f7d";
        private static readonly string location = "centralus";
        private static readonly string endpoint = "https://api.cognitive.microsofttranslator.com";



        public MainFormController(MainForm view)
        {
            this.View = view;
            this.voice = new SpeechSynthesizer();
            this.settingsView = new DefaultSettingsView();

            SourceLanguage = Language.English;
            DestinationLanguage = Language.French;
            sourceLanguageCode = "en";
            targetLanguageCode = "fr";
            voiceLanguageCulture = "en-US";

            Initialize();
        }
        private void Initialize()
        {
            View.AddPdfButtonClicked += Load_PdfFile;
            View.OpenEditorButtonClicked += Open_Editor;
            View.AddTextButtonClicked += Load_TextFile;
            View.CommandsButtonClicked += Load_CommandsettingsView;
            //KeyPressed EventHandlers
            View.TextFileKeyPressed += Load_TextFile;
            View.PdfFileKeyPressed += Load_PdfFile;
            View.TextEditorKeyPressed += Open_Editor;
            View.ControlCommandsKeyPressed += Load_CommandsettingsView;
            View.SettingsKeyPressed += Load_SettingsView;
            View.SingleKeyCommandPressed += Execute_SingleKeyCommand;
            View.DoubleKeyCommandPressed += Execute_DoubleKeyCommand;
            View.OpenDefaultSettingsView += Load_SettingsView;

            // playUserControl EventHandlers
            playUC.LibraryButtonClicked += ResetMainForm;
            playUC.PlayButtonClicked += Play;
            playUC.PauseButtonClicked += Pause;
            playUC.ResumeButtonClicked += Resume;
            playUC.StopButtonClicked += Stop;
            playUC.VolumeChanged += ChangeVolume;
            playUC.VoiceChanged += ChangeVoice;
            playUC.RateChanged += ChangeRate;
            playUC.ConvertButtonClicked += SaveAudioFile;
            playUC.TranslateTextButtonClicked += TranslateTextButtonClickedAsync;
            playUC.SourceLanguageChanged += SetSourceLanguage;
            playUC.DestinationLanguageChanged += SetDestinationLanguage;
            playUC.VoiceLanguageChanged += VoiceLanguageChanged_Event;

            //  playUC.RateVoiceVolumeChanging += RateVoiceVolumeChanging;

            //Commands User Control Event Handlers


        }

        private void VoiceLanguageChanged_Event(object sender, EventArgs e)
        {
            var lang = playUC.VoiceLanguage.SelectedItem.ToString();
            switch (lang)
            {
                case "English":
                    voiceLanguageCulture = "en";
                    break;
                case "French":
                    voiceLanguageCulture = "fr";
                    break;
                case "Chinese":
                    voiceLanguageCulture = "zh";
                    break;
                case "German":
                    voiceLanguageCulture = "de";
                    break;
            }
        }

        private async void TranslateTextButtonClickedAsync(object sender, EventArgs e)
        {
            voice.SpeakAsyncCancelAll();
            var speaker = new SpeechSynthesizer();
            var source = sourceLanguageCode.ToCharArray();
            var target = targetLanguageCode.ToCharArray();
            var languagePair = new StringBuilder();
            languagePair.Append(source.GetValue(0)).Append(source.GetValue(1)).Append("|")
                 .Append(target.GetValue(0)).Append(target.GetValue(1));

            if (View.ContentBody.Controls.Contains(pdfUC))
            {
              
                textUC.TextBoxControl.Document.Text = await TranslatePdfAsync(ReadPdf(ofd), languagePair.ToString());
            }
            else if (View.ContentBody.Controls.Contains(textUC))
            {
                textUC.TextBoxControl.Document.Text = await TranslateTextAsync(languagePair.ToString());
            }

            View.ContentBody.Controls.Clear();
            textUC.Dock = DockStyle.Fill;
            View.ContentBody.Controls.Add(textUC);
            var msg = "text successfully translated"; // from " + SourceLanguage + " to " + DestinationLanguage;
            speaker.Speak(msg);
            //MessageBox.Show(msg, "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ConvertEnglishToFrench()
        {

        }
        private void Load_SettingsView(object sender, EventArgs e)
        {
            settingsView.Show();

            settingsView.VolumeKeyUp += DefaultSettings_VolumeKeyUp;
            settingsView.VolumeKeyDown += DefaultSettings_VolumeKeyDown;
            settingsView.RateKeyUp += DefaultSettings_RateKeyUp;
            settingsView.RateKeyDown += DefaultSettings_RateKeyDown;
            settingsView.FemaleKeyPressed += DefaultSettings_FemaleKeyPressed;
            settingsView.MaleKeyPressed += DefaultSettings_MaleKeyPressed;
        }

        private void DefaultSettings_VolumeKeyUp(object sender, EventArgs e)
        {
            settingsView.Volume.Value += 1;
            playUC.Volume.Value = settingsView.Volume.Value;
        }

        private void DefaultSettings_VolumeKeyDown(object sender, EventArgs e)
        {
            settingsView.Volume.Value -= 1;
            playUC.Volume.Value = settingsView.Volume.Value;
        }

        private void DefaultSettings_RateKeyUp(object sender, EventArgs e)
        {
            settingsView.Rate.Value += 1;
            playUC.Rate.Value = settingsView.Volume.Value;
        }

        private void DefaultSettings_RateKeyDown(object sender, EventArgs e)
        {
            settingsView.Rate.Value -= 1;
            playUC.Rate.Value = settingsView.Volume.Value;
        }

        private void DefaultSettings_FemaleKeyPressed(object sender, EventArgs e)
        {

        }

        private void DefaultSettings_MaleKeyPressed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RateVoiceVolumeChanging(object sender, CurrentChangingEventArgs e)
        {
            if (e.Equals(SynthesizerState.Speaking))
            {
                var spokenText = voice.GetCurrentlySpokenPrompt().ToString();
                var textToSpeak = "";
                voice.Pause();
                if (View.ContentBody.Contains(pdfUC))
                {
                    textToSpeak = ReadPdf(ofd).Substring(spokenText.Length);
                }
                else if (View.ContentBody.Contains(textUC))
                {
                    textToSpeak = ReadText().Substring(spokenText.Length);
                }
                voice.SpeakAsync(textToSpeak);
            }
        }

        private void Execute_DoubleKeyCommand(object sender, EventArgs e)
        {
            var keyCode = Keys.KeyCode;
            if (voice.State == SynthesizerState.Speaking)
            {
                switch (keyCode)
                {
                    case Keys.Space:
                        voice.Pause();
                        break;
                    case Keys.Q:
                        voice.SpeakAsyncCancelAll();
                        break;
                }
            }
            else if (voice.State == SynthesizerState.Paused)
            {
                switch (keyCode)
                {
                    case Keys.Space:
                        voice.Resume();
                        break;
                    case Keys.Q:
                        voice.SpeakAsyncCancelAll();
                        break;
                }
            }
            else
            {
                switch (keyCode)
                {
                    case Keys.F:
                        voice.SelectVoiceByHints(VoiceGender.Female);
                        break;
                    case Keys.M:
                        voice.SelectVoiceByHints(VoiceGender.Male);
                        break;
                }
            }
        }

        private void Execute_SingleKeyCommand(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Load_CommandsettingsView(object sender, EventArgs e)
        {
            ControlCommandsView commandView = new ControlCommandsView();
            commandView.Show();
        }

        private void SaveAudioFile(object sender, EventArgs e)
        {
            SetSaveFileDialogProperties(sfd);
            ConvertFIleToAudio(sfd);
        }

        private void SetSaveFileDialogProperties(SaveFileDialog sfd)
        {
            sfd.InitialDirectory = @"C:\";
            sfd.CheckPathExists = true;

            sfd.DefaultExt = "wav";
            sfd.Filter = "audio files(*.wav,*.mp3,*.wma)|*.wav,*.mp3,*.wma";
            sfd.Title = "Save audio file";

        }

        private void ConvertFIleToAudio(SaveFileDialog sfd)
        {
            //StreamWriter write = new StreamWriter(sfd.OpenFile());

            if (sfd.ShowDialog() == DialogResult.OK && voice.State != SynthesizerState.Speaking)
            {

                FileStream write = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);

                voice.SetOutputToWaveStream(write);
                ReadPdfOrTextSynchronously();
                write.Close();
                var successVoice = new SpeechSynthesizer();
                successVoice.SpeakAsync("file successfully saved.");
                MessageBox.Show("Successfully Converted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                successVoice.SpeakAsyncCancelAll();
            }
            else
            {
                voice.SpeakAsyncCancelAll();
                var errorVoice = new SpeechSynthesizer();
                errorVoice.SpeakAsync("Stop voice before saving.");
                MessageBox.Show("Stop voice before saving", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorVoice.SpeakAsyncCancelAll();
            }

        }

        private void ResetMainForm(object sender, EventArgs e)
        {

            //voice.GetInstalledVoices()
            voice.SpeakAsyncCancelAll();
            View.ContentBody.Controls.Clear();
            View.TopHeader.Controls.Clear();
            playUC.DisableControls();
            textUC.TextBoxControl.ResetText();
            pdfUC.PdfViewer.ResetText();

            View.TopHeader.Controls.Add(View.TextButton);
            View.TopHeader.Controls.Add(View.PdfButton);
            View.TopHeader.Controls.Add(View.EditorButton);
            View.TopHeader.Controls.Add(View.CommandListButton);
            View.TopHeader.Controls.Add(View.SettingsButton);
            View.TopHeader.Refresh();

            View.ContentBody.Controls.Add(View.ActionKeysGroup);
            View.ActionKeysGroup.Focus();

            View.ContentBody.Refresh();
            View.ContentBody.Focus();
            View.ContentBody.Select();

            View.Refresh();

        }

        private void Open_Editor(object sender, EventArgs e)
        {

            voice.SpeakAsyncCancelAll();

            textUC.Dock = DockStyle.Fill;
            //View.controlsHeader.Controls.Add(playControls);
            View.ContentBody.Controls.Remove(pdfUC);
            View.ContentBody.Controls.Remove(View.ActionKeysGroup);
            View.TopHeader.Controls.Clear();

            View.TopHeader.Controls.Add(playUC);
            View.ContentBody.Controls.Add(textUC);

        }

        private void Load_TextFile(object sender, EventArgs e)
        {
            var richEC = new RichEditControl();

            voice.SpeakAsyncCancelAll();

            SetDefaultOpenFileDialogueProperties(ofd);
            ofd.DefaultExt = "txt";
            ofd.Filter = "Text files(*.txt)|*.txt";

            View.ContentBody.Controls.Remove(pdfUC);
            View.ContentBody.Controls.Remove(View.ActionKeysGroup);

            View.ContentBody.Refresh();

            textUC.Dock = DockStyle.Fill;
            textUC.BringToFront();
            View.TopHeader.Controls.Clear();
            View.TopHeader.Controls.Add(playUC);

            LoadText(ofd, textUC);
            View.ContentBody.Controls.Add(textUC);

        }

        private void LoadText(OpenFileDialog file, TextDocumentUserControl1 textUc)
        {
            if (file.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(file.OpenFile());
                textUc.TextBoxControl.ReadOnly = false;
                textUc.TextBoxControl.Text = reader.ReadToEnd();

                reader.Close();
            }
        }

        private void SetDefaultOpenFileDialogueProperties(OpenFileDialog ofd)
        {

            ofd.InitialDirectory = @"C:\\";
            ofd.CheckPathExists = true;

            ofd.CheckFileExists = true;
            ofd.Title = "Open file";
            ofd.RestoreDirectory = true;
            ofd.ShowReadOnly = false;
        }

        private void Load_PdfFile(object sender, EventArgs e)
        {
            voice.SpeakAsyncCancelAll();
            View.ContentBody.Controls.Remove(textUC);
            View.ContentBody.Controls.Remove(View.ActionKeysGroup);

            View.ContentBody.Refresh();

            SetDefaultOpenFileDialogueProperties(ofd);
            ofd.DefaultExt = "pdf";
            ofd.Filter = "Pdf files(*.pdf)|*.pdf";

            View.TopHeader.Controls.Clear();
            View.TopHeader.Controls.Add(playUC);


            LoadPdfFile(ofd, pdfUC);
            View.ContentBody.Controls.Add(pdfUC);
        }

        private void LoadPdfFile(OpenFileDialog ofd, PdfUserControl1 pdfUC)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(ofd.OpenFile());

                pdfUC.PdfViewer.ReadOnly = true;
                pdfUC.Dock = DockStyle.Fill;
                pdfUC.PdfViewer.DocumentFilePath = ofd.FileName;

                reader.Close();
            }
        }



        public override void Play(object sender, EventArgs e)
        {
            ChangeVolume(this, e);
            ChangeRate(this, e);
            ChangeVoice(this, e);
            ReadPdfOrTextAsynchronously();
        }

        private void ReadPdfOrTextAsynchronously()
        {
            if (View.ContentBody.Controls.Contains(textUC))
            {
                if (!ReadText().Equals(""))
                {
                    voice.SpeakAsync(ReadText());
                }
                else
                {
                    voice.SpeakAsync(DefaultText());
                }

            }
            else if (View.ContentBody.Controls.Contains(pdfUC))
            {
                if (!ReadPdf(ofd).Equals(""))
                {
                    voice.SpeakAsync(ReadPdf(ofd));
                }
                else
                {
                    voice.SpeakAsync(DefaultText());
                }

            }
        }

        private void ReadPdfOrTextSynchronously()
        {
            if (View.ContentBody.Contains(textUC))
            {
                if (!ReadText().Equals(""))
                {
                    voice.Speak(ReadText());
                }
                else
                {
                    voice.Speak(DefaultText());
                }

            }
            else if (View.ContentBody.Contains(pdfUC))
            {
                if (!ReadPdf(ofd).Equals(""))
                {
                    voice.Speak(ReadPdf(ofd));
                }
                else
                {
                    voice.Speak(DefaultText());
                }

            }
        }

        private string DefaultText()
        {
            string msg = "No text to read";
            return msg;
        }

        private string ReadText()
        {

            return textUC.TextBoxControl.Text;
        }

        private string ReadPdf(OpenFileDialog ofd)
        {
            StringBuilder text = new StringBuilder();
            if (!ofd.FileName.Equals(""))
            {
                var pdfReader = new PdfReader(ofd.OpenFile());

                for (int i = 1; i <= pdfReader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(pdfReader, i));
                }
            }

            return text.ToString();
        }

        public override void Pause(object sender, EventArgs e)
        {
            voice.Pause();
        }

        public override void Resume(object sender, EventArgs e)
        {
            voice.Resume();
        }

        public override void Stop(object sender, EventArgs e)
        {
            voice.SpeakAsyncCancelAll();
        }

        public override void ChangeVolume(object sender, EventArgs e)
        {
            voice.Volume = playUC.Volume.Value * 10;
        }

        public override void ChangeVoice(object sender, EventArgs e)
        {
            var selectedVoice = playUC.Voice.SelectedItem.ToString();
            // var culture = CultureInfo.GetCultureInfoByIetfLanguageTag(voiceLanguageCulture);
            var culture = new CultureInfo(voiceLanguageCulture);
           

            switch (selectedVoice)
            {
                case "Female":
                    voice.SelectVoiceByHints(VoiceGender.Female);
                    voice.SelectVoiceByHints(VoiceGender.Female,VoiceAge.NotSet,0,culture);
                    break;
                case "Male":
                    voice.SelectVoiceByHints(VoiceGender.Male);
                    voice.SelectVoiceByHints(VoiceGender.Male, VoiceAge.NotSet, 0, culture);
                    break;
                default:
                    voice.SelectVoiceByHints(VoiceGender.Neutral,VoiceAge.NotSet,0,culture);
                    break;
            }
        }

        public override void ChangeRate(object sender, EventArgs e)
        {
            voice.Rate = playUC.Rate.Value;
        }


        public SpeechSynthesizer GetSynthenthesizer()
        {
            return this.voice;
        }

 
        private void SetDestinationLanguage(object sender, EventArgs e)
        {
            var lang = playUC.DestinationLanguage.SelectedItem.ToString();
            switch (lang)
            {
                case "English":
                    DestinationLanguage = Language.English;
                    this.targetLanguageCode = "en";
                    break;
                case "French":
                    DestinationLanguage = Language.French;
                    this.targetLanguageCode = "fr";
                    break;
                case "Chinese":
                    DestinationLanguage = Language.Chinese;
                    this.targetLanguageCode = "zh";
                    break;
                case "German":
                    DestinationLanguage = Language.German;
                    this.targetLanguageCode = "de";
                    break;
            }
        }

        private void SetSourceLanguage(object sender , EventArgs e)
        {
            var lang = playUC.SourceLanguage.SelectedItem.ToString();
            switch (lang)
            {
                case "English":
                    SourceLanguage = Language.English;
                    this.sourceLanguageCode = "en";
                    break;
                case "French":
                    SourceLanguage = Language.French;
                    this.sourceLanguageCode = "fr";
                    break;
                case "Chinese":
                    SourceLanguage = Language.Chinese;
                    this.sourceLanguageCode = "zh";
                    break;
                case "German":
                    SourceLanguage = Language.German;
                    this.sourceLanguageCode = "de";
                    break;
            }
        }
        public async Task<string> LoadUrl(string url)
        {
            var tcs = new TaskCompletionSource<string>();
            Thread thread = new Thread(() => {
                try
                {
                    Func<string> f = () => {
                        using (WebBrowser browser = new WebBrowser())
                        {
                            browser.ScriptErrorsSuppressed = true;
                            browser.Navigate(url);
                            while (browser.ReadyState != WebBrowserReadyState.Complete)
                            {
                                System.Windows.Forms.Application.DoEvents();
                            }
                            return browser.DocumentText;
                        }
                    };
                    tcs.SetResult(f());
                }
                catch (Exception e)
                {
                    tcs.SetException(e);
                }
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.IsBackground = true;
            thread.Start();
            return  await tcs.Task;
        }
        private HtmlDocument PrintHelpPage(string url)
        {
            // Create a WebBrowser instance. 
            WebBrowser webBrowserForPrinting = new WebBrowser();

            // Add an event handler that prints the document after it loads.
            webBrowserForPrinting.DocumentCompleted +=
                new WebBrowserDocumentCompletedEventHandler(PrintDocument);

            // Set the Url property to load the document.
            webBrowserForPrinting.Url = new Uri(url);
            webBrowserForPrinting.Navigate(url);

            return webBrowserForPrinting.Document;
        }

        private void PrintDocument(object sender,
            WebBrowserDocumentCompletedEventArgs e)
        {
            // Print the document now that it is fully loaded.
            ((WebBrowser)sender).Print();

            // Dispose the WebBrowser now that the task is complete. 
            ((WebBrowser)sender).Dispose();
        }
        public async Task<string> TranslateFileAsync(string inputText,string languagePair)
        {
            var speaker = new SpeechSynthesizer();

            //inputText = inputText.Replace('\t', ' ');


            //string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&langpair={1}&text={0}",WebUtility.UrlEncode(inputText),languagePair);
            var route = $"/translate?api-version=3.0&from={sourceLanguageCode}&to={targetLanguageCode}";
            object[] body = new object[] { new { Text = inputText } };
            var requestBody = JsonConvert.SerializeObject(body);
            try
            {
                using (var client = new HttpClient())
                using (var request = new HttpRequestMessage())
                {
                    // Build the request.
                    request.Method = HttpMethod.Post;
                    request.RequestUri = new Uri(endpoint + route);
                    request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                    request.Headers.Add("Ocp-Apim-Subscription-Key", key);
                    // location required if you're using a multi-service or regional (not global) resource.
                    request.Headers.Add("Ocp-Apim-Subscription-Region", location);

                    // Send the request and get response.
                    HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
                    // Read response as a string.
                    string result = await response.Content.ReadAsStringAsync();
                    var dynamicText = JsonConvert.DeserializeObject<dynamic>(result);
                    var translation = dynamicText[0].translations[0].text;
                    return translation;
                }
            }
            catch(Exception ex)
            {
                throw;
            }

        }


        public async Task<string> TranslatePdfAsync(string inputText, string languagePair)
        {
            PdfReader pdfReader = new PdfReader(ofd.FileName);
            var feedback = new SpeechSynthesizer();
            var text = new StringBuilder();
            var translation = inputText;
            try
            {

                for (int i = 1; i <= pdfReader.NumberOfPages; i++)
                {
                    var generatedString = "";
                    text.Append(PdfTextExtractor.GetTextFromPage(pdfReader, i));
                    generatedString = text.ToString();
                    translation = await TranslateFileAsync(generatedString, languagePair);
                }
                var successMessage = "Text successfully translated from " + SourceLanguage + " to " + DestinationLanguage;
                feedback.Speak(successMessage);
                var hintMessage = "Don't forget to change language before speaking or converting to audio";
                MessageBox.Show(hintMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            catch
            {
                var errorMessage = "Error occurred while translating, Check your internet connection!";
                MessageBox.Show(errorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                feedback.Speak(errorMessage);
            }
            
            //fix translation
            translation = translation.Trim();
            translation = translation.Replace("&#39;", "\'");
            translation = translation.Replace("&quote;", "\"");
            translation = translation.Replace("&#39;&quote;", "\"");

            return translation;
        }

        private async Task<string> TranslateTextAsync(string languagePair)
        {
            var document = textUC.TextBoxControl.Document;
            var numberOfPages = document.Sections.Count;
            var translation = " ";
            try
            {
                for (int i = 1; i <= numberOfPages; i++)
                {
                   // var pos = document.CreatePosition(i);
                    //var range = document.CreateRange(pos, i + 1);
                    var text = document.Text;//document.GetText(range);
                    translation = await TranslateFileAsync(text, languagePair);

                }
            }
            catch
            {

            }

            return translation;
        }

    }
}
