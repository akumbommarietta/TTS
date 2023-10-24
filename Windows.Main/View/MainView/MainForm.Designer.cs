namespace Windows.Main.View
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sidePanel_top = new DevExpress.XtraEditors.SidePanel();
            this.simpleButton_commands = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_settings = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_Editor = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_pdf = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_text = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel_conten = new DevExpress.XtraEditors.SidePanel();
            this.progressPanel_pageLoading = new DevExpress.XtraWaitForm.ProgressPanel();
            this.groupBox_actionKeys = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_textEditor = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_pdfFile = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_textFile = new DevExpress.XtraEditors.LabelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.sidePanel_top.SuspendLayout();
            this.sidePanel_conten.SuspendLayout();
            this.groupBox_actionKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel_top
            // 
            this.sidePanel_top.AllowResize = false;
            this.sidePanel_top.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sidePanel_top.Appearance.Options.UseBackColor = true;
            this.sidePanel_top.BackgroundImage = global::Windows.Main.Properties.Resources.audio_speakers_red_background_18815930;
            this.sidePanel_top.Controls.Add(this.simpleButton_commands);
            this.sidePanel_top.Controls.Add(this.simpleButton_settings);
            this.sidePanel_top.Controls.Add(this.simpleButton_Editor);
            this.sidePanel_top.Controls.Add(this.simpleButton_pdf);
            this.sidePanel_top.Controls.Add(this.simpleButton_text);
            this.sidePanel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel_top.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidePanel_top.Location = new System.Drawing.Point(0, 0);
            this.sidePanel_top.Name = "sidePanel_top";
            this.sidePanel_top.Size = new System.Drawing.Size(1281, 150);
            this.sidePanel_top.TabIndex = 1;
            this.sidePanel_top.Text = "sidePanel1";
            // 
            // simpleButton_commands
            // 
            this.simpleButton_commands.Appearance.BackColor = System.Drawing.Color.Black;
            this.simpleButton_commands.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_commands.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton_commands.Appearance.Options.UseBackColor = true;
            this.simpleButton_commands.Appearance.Options.UseFont = true;
            this.simpleButton_commands.Appearance.Options.UseForeColor = true;
            this.simpleButton_commands.AppearanceHovered.BackColor = System.Drawing.Color.Blue;
            this.simpleButton_commands.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton_commands.BackgroundImage = global::Windows.Main.Properties.Resources._1;
            this.simpleButton_commands.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton_commands.Location = new System.Drawing.Point(1060, 68);
            this.simpleButton_commands.Name = "simpleButton_commands";
            this.simpleButton_commands.Size = new System.Drawing.Size(209, 40);
            this.simpleButton_commands.TabIndex = 3;
            this.simpleButton_commands.Text = "Control Commands";
            this.simpleButton_commands.Click += new System.EventHandler(this.simpleButton_commands_Click);
            // 
            // simpleButton_settings
            // 
            this.simpleButton_settings.Appearance.BackColor = System.Drawing.Color.Black;
            this.simpleButton_settings.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_settings.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton_settings.Appearance.Options.UseBackColor = true;
            this.simpleButton_settings.Appearance.Options.UseFont = true;
            this.simpleButton_settings.Appearance.Options.UseForeColor = true;
            this.simpleButton_settings.AppearanceHovered.BackColor = System.Drawing.Color.Blue;
            this.simpleButton_settings.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton_settings.BackgroundImage = global::Windows.Main.Properties.Resources._1;
            this.simpleButton_settings.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton_settings.Location = new System.Drawing.Point(839, 66);
            this.simpleButton_settings.Name = "simpleButton_settings";
            this.simpleButton_settings.Size = new System.Drawing.Size(196, 40);
            this.simpleButton_settings.TabIndex = 4;
            this.simpleButton_settings.Text = "Default Settings";
            this.simpleButton_settings.Click += new System.EventHandler(this.simpleButton_settings_Click);
            // 
            // simpleButton_Editor
            // 
            this.simpleButton_Editor.Appearance.BackColor = System.Drawing.Color.Black;
            this.simpleButton_Editor.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_Editor.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton_Editor.Appearance.Options.UseBackColor = true;
            this.simpleButton_Editor.Appearance.Options.UseFont = true;
            this.simpleButton_Editor.Appearance.Options.UseForeColor = true;
            this.simpleButton_Editor.AppearanceHovered.BackColor = System.Drawing.Color.Blue;
            this.simpleButton_Editor.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton_Editor.BackgroundImage = global::Windows.Main.Properties.Resources._1;
            this.simpleButton_Editor.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton_Editor.Location = new System.Drawing.Point(500, 64);
            this.simpleButton_Editor.Name = "simpleButton_Editor";
            this.simpleButton_Editor.Size = new System.Drawing.Size(199, 40);
            this.simpleButton_Editor.TabIndex = 1;
            this.simpleButton_Editor.Text = "Open Text Editor";
            this.simpleButton_Editor.Click += new System.EventHandler(this.simpleButton_Editor_Click);
            // 
            // simpleButton_pdf
            // 
            this.simpleButton_pdf.Appearance.BackColor = System.Drawing.Color.Black;
            this.simpleButton_pdf.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_pdf.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton_pdf.Appearance.Options.UseBackColor = true;
            this.simpleButton_pdf.Appearance.Options.UseFont = true;
            this.simpleButton_pdf.Appearance.Options.UseForeColor = true;
            this.simpleButton_pdf.AppearanceHovered.BackColor = System.Drawing.Color.Blue;
            this.simpleButton_pdf.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton_pdf.BackgroundImage = global::Windows.Main.Properties.Resources._1;
            this.simpleButton_pdf.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton_pdf.Location = new System.Drawing.Point(263, 64);
            this.simpleButton_pdf.Name = "simpleButton_pdf";
            this.simpleButton_pdf.Size = new System.Drawing.Size(198, 40);
            this.simpleButton_pdf.TabIndex = 2;
            this.simpleButton_pdf.Text = "Open Pdf File";
            this.simpleButton_pdf.Click += new System.EventHandler(this.simpleButton_pdf_Click);
            // 
            // simpleButton_text
            // 
            this.simpleButton_text.Appearance.BackColor = System.Drawing.Color.Black;
            this.simpleButton_text.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_text.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton_text.Appearance.Options.UseBackColor = true;
            this.simpleButton_text.Appearance.Options.UseFont = true;
            this.simpleButton_text.Appearance.Options.UseForeColor = true;
            this.simpleButton_text.AppearanceHovered.BackColor = System.Drawing.Color.Blue;
            this.simpleButton_text.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton_text.BackgroundImage = global::Windows.Main.Properties.Resources._1;
            this.simpleButton_text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.simpleButton_text.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton_text.Location = new System.Drawing.Point(12, 64);
            this.simpleButton_text.Name = "simpleButton_text";
            this.simpleButton_text.Size = new System.Drawing.Size(213, 40);
            this.simpleButton_text.TabIndex = 0;
            this.simpleButton_text.Text = " Open text file";
            this.simpleButton_text.Click += new System.EventHandler(this.simpleButton_text_Click);
            // 
            // sidePanel_conten
            // 
            this.sidePanel_conten.BackgroundImage = global::Windows.Main.Properties.Resources.music_production_software;
            this.sidePanel_conten.Controls.Add(this.label1);
            this.sidePanel_conten.Controls.Add(this.progressPanel_pageLoading);
            this.sidePanel_conten.Controls.Add(this.groupBox_actionKeys);
            this.sidePanel_conten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel_conten.Location = new System.Drawing.Point(0, 150);
            this.sidePanel_conten.Margin = new System.Windows.Forms.Padding(3, 229, 3, 3);
            this.sidePanel_conten.Name = "sidePanel_conten";
            this.sidePanel_conten.Size = new System.Drawing.Size(1281, 323);
            this.sidePanel_conten.TabIndex = 1;
            this.sidePanel_conten.Text = "sidePanel2";
            this.sidePanel_conten.Enter += new System.EventHandler(this.sidePanel_conten_Enter);
            this.sidePanel_conten.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.sidePanel_conten_PreviewKeyDown);
            // 
            // progressPanel_pageLoading
            // 
            this.progressPanel_pageLoading.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel_pageLoading.Appearance.ForeColor = System.Drawing.Color.White;
            this.progressPanel_pageLoading.Appearance.Options.UseBackColor = true;
            this.progressPanel_pageLoading.Appearance.Options.UseForeColor = true;
            this.progressPanel_pageLoading.BarAnimationElementThickness = 2;
            this.progressPanel_pageLoading.Location = new System.Drawing.Point(463, 225);
            this.progressPanel_pageLoading.Name = "progressPanel_pageLoading";
            this.progressPanel_pageLoading.Size = new System.Drawing.Size(185, 98);
            this.progressPanel_pageLoading.TabIndex = 1;
            this.progressPanel_pageLoading.Text = "Loading";
            // 
            // groupBox_actionKeys
            // 
            this.groupBox_actionKeys.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_actionKeys.Controls.Add(this.labelControl2);
            this.groupBox_actionKeys.Controls.Add(this.labelControl1);
            this.groupBox_actionKeys.Controls.Add(this.labelControl_textEditor);
            this.groupBox_actionKeys.Controls.Add(this.labelControl_pdfFile);
            this.groupBox_actionKeys.Controls.Add(this.labelControl_textFile);
            this.groupBox_actionKeys.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox_actionKeys.Location = new System.Drawing.Point(3, 10);
            this.groupBox_actionKeys.Name = "groupBox_actionKeys";
            this.groupBox_actionKeys.Size = new System.Drawing.Size(320, 301);
            this.groupBox_actionKeys.TabIndex = 0;
            this.groupBox_actionKeys.TabStop = false;
            this.groupBox_actionKeys.Text = "Library action keys";
            this.groupBox_actionKeys.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.sidePanel_conten_PreviewKeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(133, 221);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(139, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "4 - Set default control Values";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(133, 270);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(131, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "5 - Show control commands";
            // 
            // labelControl_textEditor
            // 
            this.labelControl_textEditor.Location = new System.Drawing.Point(133, 179);
            this.labelControl_textEditor.Name = "labelControl_textEditor";
            this.labelControl_textEditor.Size = new System.Drawing.Size(96, 13);
            this.labelControl_textEditor.TabIndex = 6;
            this.labelControl_textEditor.Text = "3 - Open text editor";
            // 
            // labelControl_pdfFile
            // 
            this.labelControl_pdfFile.Location = new System.Drawing.Point(133, 124);
            this.labelControl_pdfFile.Name = "labelControl_pdfFile";
            this.labelControl_pdfFile.Size = new System.Drawing.Size(78, 13);
            this.labelControl_pdfFile.TabIndex = 5;
            this.labelControl_pdfFile.Text = "2 - Open Pdf file";
            // 
            // labelControl_textFile
            // 
            this.labelControl_textFile.Location = new System.Drawing.Point(133, 66);
            this.labelControl_textFile.Name = "labelControl_textFile";
            this.labelControl_textFile.Size = new System.Drawing.Size(82, 13);
            this.labelControl_textFile.TabIndex = 4;
            this.labelControl_textFile.Text = "1 - Open text file";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "McSkin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1221, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "@Marietta";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::Windows.Main.Properties.Resources.music_production_software;
            this.ClientSize = new System.Drawing.Size(1281, 473);
            this.Controls.Add(this.sidePanel_conten);
            this.Controls.Add(this.sidePanel_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.sidePanel_top.ResumeLayout(false);
            this.sidePanel_conten.ResumeLayout(false);
            this.sidePanel_conten.PerformLayout();
            this.groupBox_actionKeys.ResumeLayout(false);
            this.groupBox_actionKeys.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel_top;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Editor;
        private DevExpress.XtraEditors.SimpleButton simpleButton_text;
        private DevExpress.XtraEditors.SidePanel sidePanel_conten;
        private DevExpress.XtraEditors.SimpleButton simpleButton_pdf;
        private DevExpress.XtraEditors.SimpleButton simpleButton_commands;
        private System.Windows.Forms.GroupBox groupBox_actionKeys;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl_textEditor;
        private DevExpress.XtraEditors.LabelControl labelControl_pdfFile;
        private DevExpress.XtraEditors.LabelControl labelControl_textFile;
        private DevExpress.XtraEditors.SimpleButton simpleButton_settings;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel_pageLoading;
        private System.Windows.Forms.Label label1;
    }
}