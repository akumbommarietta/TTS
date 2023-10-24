namespace Windows.Main.View.CommandsView
{
    partial class ControlCommandsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel_content = new System.Windows.Forms.FlowLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label_exit = new System.Windows.Forms.Label();
            this.groupBox_voice = new System.Windows.Forms.GroupBox();
            this.label_male = new System.Windows.Forms.Label();
            this.label_female = new System.Windows.Forms.Label();
            this.groupBox_playControls = new System.Windows.Forms.GroupBox();
            this.label_decreaseRate = new System.Windows.Forms.Label();
            this.label_increaseRate = new System.Windows.Forms.Label();
            this.label_decreaseVolume = new System.Windows.Forms.Label();
            this.label_increaseVolume = new System.Windows.Forms.Label();
            this.label_play = new System.Windows.Forms.Label();
            this.label_stop = new System.Windows.Forms.Label();
            this.label_pause = new System.Windows.Forms.Label();
            this.label_resume = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.flowLayoutPanel_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.groupBox_voice.SuspendLayout();
            this.groupBox_playControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_content
            // 
            this.flowLayoutPanel_content.Controls.Add(this.groupControl2);
            this.flowLayoutPanel_content.Controls.Add(this.groupControl1);
            this.flowLayoutPanel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_content.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_content.Name = "flowLayoutPanel_content";
            this.flowLayoutPanel_content.Size = new System.Drawing.Size(429, 455);
            this.flowLayoutPanel_content.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.Controls.Add(this.label_exit);
            this.groupControl2.Controls.Add(this.groupBox_voice);
            this.groupControl2.Controls.Add(this.groupBox_playControls);
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(425, 449);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Play Control Commands";
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_exit.Location = new System.Drawing.Point(80, 36);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(170, 13);
            this.label_exit.TabIndex = 10;
            this.label_exit.Text = "Press escape key to Exit Windows";
            // 
            // groupBox_voice
            // 
            this.groupBox_voice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox_voice.Controls.Add(this.label_male);
            this.groupBox_voice.Controls.Add(this.label_female);
            this.groupBox_voice.Location = new System.Drawing.Point(83, 325);
            this.groupBox_voice.Name = "groupBox_voice";
            this.groupBox_voice.Size = new System.Drawing.Size(242, 102);
            this.groupBox_voice.TabIndex = 5;
            this.groupBox_voice.TabStop = false;
            this.groupBox_voice.Text = "Voice Controls";
            // 
            // label_male
            // 
            this.label_male.AutoSize = true;
            this.label_male.Location = new System.Drawing.Point(18, 73);
            this.label_male.Name = "label_male";
            this.label_male.Size = new System.Drawing.Size(114, 13);
            this.label_male.TabIndex = 9;
            this.label_male.Text = "Press M for Male voice";
            // 
            // label_female
            // 
            this.label_female.AutoSize = true;
            this.label_female.Location = new System.Drawing.Point(18, 36);
            this.label_female.Name = "label_female";
            this.label_female.Size = new System.Drawing.Size(124, 13);
            this.label_female.TabIndex = 8;
            this.label_female.Text = "Press F for Female voice";
            // 
            // groupBox_playControls
            // 
            this.groupBox_playControls.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox_playControls.Controls.Add(this.label_decreaseRate);
            this.groupBox_playControls.Controls.Add(this.label_increaseRate);
            this.groupBox_playControls.Controls.Add(this.label_decreaseVolume);
            this.groupBox_playControls.Controls.Add(this.label_increaseVolume);
            this.groupBox_playControls.Controls.Add(this.label_play);
            this.groupBox_playControls.Controls.Add(this.label_stop);
            this.groupBox_playControls.Controls.Add(this.label_pause);
            this.groupBox_playControls.Controls.Add(this.label_resume);
            this.groupBox_playControls.Location = new System.Drawing.Point(83, 61);
            this.groupBox_playControls.Name = "groupBox_playControls";
            this.groupBox_playControls.Size = new System.Drawing.Size(242, 246);
            this.groupBox_playControls.TabIndex = 4;
            this.groupBox_playControls.TabStop = false;
            this.groupBox_playControls.Text = "Play Controls";
            // 
            // label_decreaseRate
            // 
            this.label_decreaseRate.AutoSize = true;
            this.label_decreaseRate.Location = new System.Drawing.Point(18, 230);
            this.label_decreaseRate.Name = "label_decreaseRate";
            this.label_decreaseRate.Size = new System.Drawing.Size(179, 13);
            this.label_decreaseRate.TabIndex = 7;
            this.label_decreaseRate.Text = "Press down arrow to decrease Rate";
            // 
            // label_increaseRate
            // 
            this.label_increaseRate.AutoSize = true;
            this.label_increaseRate.Location = new System.Drawing.Point(20, 197);
            this.label_increaseRate.Name = "label_increaseRate";
            this.label_increaseRate.Size = new System.Drawing.Size(161, 13);
            this.label_increaseRate.TabIndex = 6;
            this.label_increaseRate.Text = "Press up arrow to increase Rate";
            // 
            // label_decreaseVolume
            // 
            this.label_decreaseVolume.AutoSize = true;
            this.label_decreaseVolume.Location = new System.Drawing.Point(18, 168);
            this.label_decreaseVolume.Name = "label_decreaseVolume";
            this.label_decreaseVolume.Size = new System.Drawing.Size(183, 13);
            this.label_decreaseVolume.TabIndex = 5;
            this.label_decreaseVolume.Text = "Press left arrow  to decrease Volume";
            // 
            // label_increaseVolume
            // 
            this.label_increaseVolume.AutoSize = true;
            this.label_increaseVolume.Location = new System.Drawing.Point(18, 140);
            this.label_increaseVolume.Name = "label_increaseVolume";
            this.label_increaseVolume.Size = new System.Drawing.Size(178, 13);
            this.label_increaseVolume.TabIndex = 4;
            this.label_increaseVolume.Text = "Press righ arrow to increase Volume";
            // 
            // label_play
            // 
            this.label_play.AutoSize = true;
            this.label_play.Location = new System.Drawing.Point(18, 30);
            this.label_play.Name = "label_play";
            this.label_play.Size = new System.Drawing.Size(81, 13);
            this.label_play.TabIndex = 0;
            this.label_play.Text = "Press P  to play";
            // 
            // label_stop
            // 
            this.label_stop.AutoSize = true;
            this.label_stop.Location = new System.Drawing.Point(18, 114);
            this.label_stop.Name = "label_stop";
            this.label_stop.Size = new System.Drawing.Size(82, 13);
            this.label_stop.TabIndex = 3;
            this.label_stop.Text = "Press Q to Stop";
            // 
            // label_pause
            // 
            this.label_pause.AutoSize = true;
            this.label_pause.Location = new System.Drawing.Point(18, 56);
            this.label_pause.Name = "label_pause";
            this.label_pause.Size = new System.Drawing.Size(129, 13);
            this.label_pause.TabIndex = 1;
            this.label_pause.Text = "Press Space Bar to Pause";
            // 
            // label_resume
            // 
            this.label_resume.AutoSize = true;
            this.label_resume.Location = new System.Drawing.Point(18, 84);
            this.label_resume.Name = "label_resume";
            this.label_resume.Size = new System.Drawing.Size(138, 13);
            this.label_resume.TabIndex = 2;
            this.label_resume.Text = "Press Space Bar to Resume";
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Location = new System.Drawing.Point(3, 458);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(4, 3);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "C";
            // 
            // ControlCommandsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 455);
            this.Controls.Add(this.flowLayoutPanel_content);
            this.Name = "ControlCommandsView";
            this.Text = "ControlCommandsView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlCommandsView_FormClosing);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ControlCommandsView_PreviewKeyDown);
            this.flowLayoutPanel_content.ResumeLayout(false);
            this.flowLayoutPanel_content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.groupBox_voice.ResumeLayout(false);
            this.groupBox_voice.PerformLayout();
            this.groupBox_playControls.ResumeLayout(false);
            this.groupBox_playControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_content;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.GroupBox groupBox_voice;
        private System.Windows.Forms.Label label_male;
        private System.Windows.Forms.Label label_female;
        private System.Windows.Forms.GroupBox groupBox_playControls;
        private System.Windows.Forms.Label label_decreaseRate;
        private System.Windows.Forms.Label label_increaseRate;
        private System.Windows.Forms.Label label_decreaseVolume;
        private System.Windows.Forms.Label label_increaseVolume;
        private System.Windows.Forms.Label label_play;
        private System.Windows.Forms.Label label_stop;
        private System.Windows.Forms.Label label_pause;
        private System.Windows.Forms.Label label_resume;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label_exit;
    }
}