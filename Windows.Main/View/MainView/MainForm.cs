using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using DevExpress.XtraEditors;
using Windows.Main.UserControls;
using Windows.Main.View.DefaultSettingsView;
using DevExpress.XtraWaitForm;

namespace Windows.Main.View
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public EventHandler AddTextButtonClicked;
        public EventHandler AddPdfButtonClicked;
        public EventHandler OpenEditorButtonClicked;
        public EventHandler CommandsButtonClicked;

        public EventHandler OpenDefaultSettingsView;

        public EventHandler TextFileKeyPressed;
        public EventHandler PdfFileKeyPressed;
        public EventHandler TextEditorKeyPressed;
        public EventHandler ControlCommandsKeyPressed;
        public EventHandler SettingsKeyPressed;
        public EventHandler SingleKeyCommandPressed;
        public EventHandler DoubleKeyCommandPressed;


        SpeechSynthesizer voice = new SpeechSynthesizer();

        public MainForm()
        {
            InitializeComponent();
            ActionKeysGroup.Hide();
            ContentBody.Controls.Remove(PageLoadingInProgess);
        }

        // properties
   
        public SidePanel ContentBody
        {
            get { return this.sidePanel_conten; }
        }

        public ProgressPanel PageLoadingInProgess
        {
            get { return this.progressPanel_pageLoading; }
        }

        public SidePanel TopHeader
        {
            get { return this.sidePanel_top; }
        }

        public SimpleButton EditorButton
        {
            get { return this.simpleButton_Editor; }
        }

        public SimpleButton TextButton
        {
            get { return this.simpleButton_text; }
        }

        public SimpleButton PdfButton
        {
            get { return this.simpleButton_pdf; }
        }

        public SimpleButton CommandListButton
        {
            get { return this.simpleButton_commands; }
        }
        public SimpleButton SettingsButton
        {
            get { return this.simpleButton_settings; }
        }
/*
        public SimpleButton ActivationButton
        {
            get { return this.simpleButton_one; }
        }
*/
        public GroupBox ActionKeysGroup
        {
            get { return this.groupBox_actionKeys; }
        }

        //events

        private void simpleButton_text_Click(object sender, EventArgs e)
        {
            voice.SpeakAsyncCancelAll();
            AddTextButtonClicked(this, new EventArgs());
        }

        private void simpleButton_pdf_Click(object sender, EventArgs e)
        {
            voice.SpeakAsyncCancelAll();
            AddPdfButtonClicked(this, new EventArgs());
        }

        private void simpleButton_Editor_Click(object sender, EventArgs e)
        {
            voice.SpeakAsyncCancelAll();
            OpenEditorButtonClicked(this, new EventArgs());
        }

        private void simpleButton_commands_Click(object sender, EventArgs e)
        {
            voice.SpeakAsyncCancelAll();
            CommandsButtonClicked(this, new EventArgs());
        }

        private void simpleButton_KeyUp(object sender, KeyEventArgs e)
        {
            var key = e.KeyCode;


            switch (key)
            {
                case Keys.D1:
                        TextFileKeyPressed(this, new KeyEventArgs(Keys.D1));  
                    break;
                case Keys.D2:
                        PdfFileKeyPressed(this, new KeyEventArgs(Keys.D2));
                    break;
                case Keys.D3:
                        OpenEditorButtonClicked(this, new KeyEventArgs(Keys.D3));
                    break;
                case Keys.D4:
                     SettingsKeyPressed(this, new KeyEventArgs(Keys.D3));
                    break;
                case Keys.D5:
                     ControlCommandsKeyPressed(this, new KeyEventArgs(Keys.D4));
                    break;
            }
        }
  

        private void sidePanel_conten_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var key = e.KeyCode;
            voice.SpeakAsyncCancelAll();
            switch (key)
            {
                case Keys.D1:
                    TextFileKeyPressed(this, new KeyEventArgs(Keys.D1));
                    break;
                case Keys.D2:
                    PdfFileKeyPressed(this, new KeyEventArgs(Keys.D2));
                    break;
                case Keys.D3:
                    OpenEditorButtonClicked(this, new KeyEventArgs(Keys.D3));
                    break;
                case Keys.D4:
                     SettingsKeyPressed(this, new KeyEventArgs(Keys.D3));
                    break;
                case Keys.D5:
                     ControlCommandsKeyPressed(this, new KeyEventArgs(Keys.D4));
                    break;
            }

        }

        private void sidePanel_conten_Enter(object sender, EventArgs e)
        {
            var msge = "Press 1 to open text file, 2 to open pdf file, 3 to open text editor, 4 for control settings and 5 for control commands";
         /*   if (this.ContentBody.Contains(this.groupBox_actionKeys))
            {
                voice.SpeakAsync(msge);
            }
            else
            {
                voice.SpeakAsyncCancelAll();
            }  
            */ 
        }

        private void simpleButton_settings_Click(object sender, EventArgs e)
        {
            voice.SpeakAsyncCancelAll();
            OpenDefaultSettingsView(this, new EventArgs());
        }
    }
}
