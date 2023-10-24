using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.Main.View.DefaultSettingsView
{
    public partial class DefaultSettingsView : DevExpress.XtraEditors.XtraForm
    {

        public EventHandler VolumeKeyUp;
        public EventHandler VolumeKeyDown;
        public EventHandler RateKeyUp;
        public EventHandler RateKeyDown;
        public EventHandler FemaleKeyPressed;
        public EventHandler MaleKeyPressed;

        public DefaultSettingsView()
        {
            InitializeComponent();
        }

        // properties

        public TrackBarControl Volume
        {
            get { return trackBarControl_volume; }
        }

        public GroupBox VolumeContainer
        {
            get { return this.groupBox_volume; }
        }

        public TrackBarControl Rate
        {
            get { return trackBarControl_rate; }
        }

        public GroupBox RateContainer
        {
            get { return this.groupBox_rate; }
        }

        public ComboBoxEdit voice
        {
            get { return this.comboBoxEdit_voice; }
        }

        public GroupBox VoiceContainer
        {
            get { return this.groupBox_voice; }
        }

        public GroupControl Contents
        {
            get { return this.groupControl_Contents; }
        }

        private void flyoutPanelControl1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            var key = e.KeyCode;
            switch (key)
            {
                case Keys.Right:
                      VolumeKeyUp(this, new EventArgs());
                    break;
                case Keys.Left:
                      VolumeKeyDown(this, new EventArgs());
                    break;
                case Keys.Up:
                     RateKeyUp(this, new EventArgs());
                    break;
                case Keys.Down:
                    RateKeyDown(this, new EventArgs());
                    break;
                case Keys.F:
                    FemaleKeyPressed(this, new EventArgs());
                    break;
                case Keys.M:
                    MaleKeyPressed(this, new EventArgs());
                    break;
            }

        }
    }
}
