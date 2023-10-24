using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.Main.View.CommandsView
{
    public partial class ControlCommandsView : Form
    {
        private SpeechSynthesizer voice = new SpeechSynthesizer();

        public ControlCommandsView()
        {
            InitializeComponent();
            AddControlsToView();
            ReadControlCommands();
        }

        private void ReadControlCommands()
        {
            var msg_exit = this.label_exit.Text + " ";
            var msg_play = this.label_play.Text + " ";
            var msg_pause = this.label_pause.Text + " ";
            var msg_resume = this.label_resume.Text + " ";
            var msg_stop = this.label_stop.Text + " ";
            var msg_increaseVolume = this.label_increaseVolume.Text + " ";
            var msg_decreaseVolume = this.label_decreaseVolume.Text + " ";
            var msg_increaseRate = this.label_increaseRate.Text + " ";
            var msg_decreaseRate = this.label_decreaseRate.Text + " ";
            var msg_femaleVoice = this.label_female.Text + " ";
            var msg_maleVoice = this.label_male.Text;
 /*
            var msg = msg_exit + msg_play + msg_pause + msg_resume + msg_stop +
                      msg_increaseVolume + msg_decreaseVolume +
                      msg_increaseRate + msg_decreaseRate +
                      msg_femaleVoice + msg_maleVoice;
*/
            voice.Rate = 1;
            voice.SelectVoiceByHints(VoiceGender.Female);
            voice.SpeakAsync(msg_exit);
            voice.SpeakAsync(msg_play);
            voice.SpeakAsync(msg_pause);
            voice.SpeakAsync(msg_resume);
            voice.SpeakAsync(msg_stop);
            voice.SpeakAsync(msg_increaseVolume);
            voice.SpeakAsync(msg_decreaseVolume);
            voice.SpeakAsync(msg_increaseRate);
            voice.SpeakAsync(msg_decreaseRate);
            voice.SpeakAsync(msg_femaleVoice);
            voice.SpeakAsync(msg_maleVoice);

            
        }

        private void AddControlsToView()
        {
            this.Controls.Add(this.flowLayoutPanel_content);
            this.Refresh();
        }

        private void ControlCommandsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            voice.SpeakAsyncCancelAll();
        }

        private void ControlCommandsView_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
