using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Windows.Main.Controllers;
using DevExpress.XtraWaitForm;

namespace Windows.Main.UserControls
{
    public partial class PlayUserContro_1 : DevExpress.XtraEditors.XtraUserControl
    {
        public EventHandler LibraryButtonClicked;
        public EventHandler PlayButtonClicked;
        public EventHandler PauseButtonClicked;
        public EventHandler ResumeButtonClicked;
        public EventHandler StopButtonClicked;
        public EventHandler ConvertButtonClicked;
        public EventHandler VoiceChanged;
        public EventHandler VolumeChanged;
        public EventHandler RateChanged;
        public CurrentChangingEventHandler RateVoiceVolumeChanging;
        public EventHandler SourceLanguageChanged;
        public EventHandler DestinationLanguageChanged;
        public EventHandler TranslateTextButtonClicked;
        public EventHandler VoiceLanguageChanged;


        public PlayUserContro_1()
        {
            InitializeComponent();

            DisableControls();
            ProgressPanel.Hide();
        }

        public void DisableControls()
        {
            this.simpleButton_pause.Enabled = false;
            this.simpleButton_resume.Enabled = false;
            this.simpleButton_stop.Enabled = false;
            this.simpleButton_play.Enabled = true;
        }

        //Properties

        public ProgressPanel ProgressPanel
        {
            get { return this.progressPanel_translate; }
        }
        
        public ComboBoxEdit VoiceLanguage
        {
            get { return this.comboBoxEdit_voiceLanguage; }
        }

        public ComboBoxEdit Voice
        {
            get { return this.comboBox_voice; }
        }

        public TrackBarControl Rate
        {
            get { return this.trackBarControl_rate; }
            set { this.trackBarControl_rate = value; }
        }

        public TrackBarControl Volume
        {
            get { return this.trackBarControl_volume; }
            set { this.trackBarControl_volume = value; }
        }

        public ComboBoxEdit SourceLanguage
        {
            get { return this.comboBoxEdit_source; }
        }
        public ComboBoxEdit DestinationLanguage
        {
            get { return this.comboBoxEdit_destination; }
        }


        // Events
        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton_library_Click(object sender, EventArgs e)
        {
            LibraryButtonClicked(this, new EventArgs());
        }

        private void simpleButton_play_Click(object sender, EventArgs e)
        {
            EnableControls();
            PlayButtonClicked(this, new EventArgs());
        }

        public void EnableControls()
        {
            this.simpleButton_stop.Enabled = true;
            this.simpleButton_pause.Enabled = true;
        }

        private void simpleButton_pause_Click(object sender, EventArgs e)
        {
            this.simpleButton_pause.Enabled = false;
            this.simpleButton_resume.Enabled = true;
            PauseButtonClicked(this, new EventArgs());
        }

        private void simpleButton_resume_Click(object sender, EventArgs e)
        {
            this.simpleButton_pause.Enabled = true;
            this.simpleButton_resume.Enabled = false;
            ResumeButtonClicked(this, new EventArgs());
        }

        private void simpleButton_stop_Click(object sender, EventArgs e)
        {
            DisableControls();
            StopButtonClicked(this, new EventArgs());
        }

        private void simpleButton_convert_Click(object sender, EventArgs e)
        {
            ConvertButtonClicked(this, new EventArgs());
        }

        private void comboBox_voice_SelectedIndexChanged(object sender, EventArgs e)
        {
            VoiceChanged(this, new EventArgs());
        }

        private void trackBarControl_rate_EditValueChanged(object sender, EventArgs e)
        {
            RateChanged(this, new EventArgs());
        }

        private void trackBarControl_volume_EditValueChanged(object sender, EventArgs e)
        {
            VolumeChanged(this, new EventArgs());
        }

/*
        private void trackBarControl_rateVoiceVolume_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            var newValue = (int)e.NewValue;
            if (sender.Equals(this.trackBarControl_rate))
            {
                this.trackBarControl_rate.Value = newValue;
            }
            if (sender.Equals(this.trackBarControl_volume))
            {
                 this.trackBarControl_volume.Value = newValue;
            }
           // RateVoiceVolumeChanging(this, new CurrentChangingEventArgs());
        }
        */
        private void comboBoxEdit_SourceDestinationLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            SourceLanguageChanged(this, new EventArgs());
            DestinationLanguageChanged(this, new EventArgs());
        }

        private void simpleButton_translateText_Click(object sender, EventArgs e)
        {
            TranslateTextButtonClicked(this, new EventArgs());
        }

        private void comboBoxEdit_sourceDestination_EditValueChanged(object sender, EventArgs e)
        {
            
            DestinationLanguageChanged(this, new EventArgs());
        }

        private void trackBarControl_rate_EditValueChanged_1(object sender, EventArgs e)
        {
            RateChanged(this, new EventArgs());
        }

        private void comboBox_voice_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            VoiceChanged(this, new EventArgs());
        }

        private void trackBarControl_rate_EditValueChanged_2(object sender, EventArgs e)
        {
            RateChanged(this, e);
        }

        private void trackBarControl_volume_EditValueChanged_1(object sender, EventArgs e)
        {
            VolumeChanged(this, e);
        }

        private void comboBoxEdit_voiceLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            VoiceLanguageChanged(this, new EventArgs());
        }

        private void comboBoxEdit_source_SelectedIndexChanged(object sender, EventArgs e)
        {
            SourceLanguageChanged(this, new EventArgs());
        }

        private void comboBoxEdit_destination_SelectedIndexChanged(object sender, EventArgs e)
        {
            DestinationLanguageChanged(this, new EventArgs());
        }


    }
}
