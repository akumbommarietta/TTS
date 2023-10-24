namespace Windows.Main.UserControls
{
    partial class CommandsUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.popupContainerControl1 = new DevExpress.XtraEditors.PopupContainerControl();
            this.popupMenu_Commands = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem_addTextFile = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_addPdfFile = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_openTextEditor = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_controlCommands = new DevExpress.XtraBars.BarButtonItem();
            this.barManager_Commands = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu_Commands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager_Commands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.popupContainerControl1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(529, 343);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // popupContainerControl1
            // 
            this.popupContainerControl1.AutoSize = true;
            this.popupContainerControl1.Location = new System.Drawing.Point(3, 3);
            this.popupContainerControl1.Name = "popupContainerControl1";
            this.popupContainerControl1.Size = new System.Drawing.Size(0, 0);
            this.popupContainerControl1.TabIndex = 0;
            // 
            // popupMenu_Commands
            // 
            this.popupMenu_Commands.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_addTextFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_addPdfFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_openTextEditor),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_controlCommands)});
            this.popupMenu_Commands.Manager = this.barManager_Commands;
            this.popupMenu_Commands.Name = "popupMenu_Commands";
            this.popupMenu_Commands.ShowCaption = true;
            // 
            // barButtonItem_addTextFile
            // 
            this.barButtonItem_addTextFile.Caption = "1";
            this.barButtonItem_addTextFile.Id = 2;
            this.barButtonItem_addTextFile.Name = "barButtonItem_addTextFile";
            this.barButtonItem_addTextFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_addTextFile_ItemClick);
            this.barButtonItem_addTextFile.ItemPress += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_addTextFile_ItemPress);
            // 
            // barButtonItem_addPdfFile
            // 
            this.barButtonItem_addPdfFile.Caption = "2";
            this.barButtonItem_addPdfFile.Id = 3;
            this.barButtonItem_addPdfFile.Name = "barButtonItem_addPdfFile";
            this.barButtonItem_addPdfFile.ItemPress += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_addPdfFile_ItemPress);
            // 
            // barButtonItem_openTextEditor
            // 
            this.barButtonItem_openTextEditor.Caption = "3";
            this.barButtonItem_openTextEditor.Id = 4;
            this.barButtonItem_openTextEditor.Name = "barButtonItem_openTextEditor";
            this.barButtonItem_openTextEditor.ItemPress += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_openTextEditor_ItemPress);
            // 
            // barButtonItem_controlCommands
            // 
            this.barButtonItem_controlCommands.Caption = "4";
            this.barButtonItem_controlCommands.Id = 5;
            this.barButtonItem_controlCommands.Name = "barButtonItem_controlCommands";
            this.barButtonItem_controlCommands.ItemPress += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_controlCommands_ItemPress);
            // 
            // barManager_Commands
            // 
            this.barManager_Commands.DockControls.Add(this.barDockControlTop);
            this.barManager_Commands.DockControls.Add(this.barDockControlBottom);
            this.barManager_Commands.DockControls.Add(this.barDockControlLeft);
            this.barManager_Commands.DockControls.Add(this.barDockControlRight);
            this.barManager_Commands.Form = this;
            this.barManager_Commands.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem_addTextFile,
            this.barButtonItem_addPdfFile,
            this.barButtonItem_openTextEditor,
            this.barButtonItem_controlCommands});
            this.barManager_Commands.MaxItemId = 6;
            this.barManager_Commands.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPopupContainerEdit1});
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager_Commands;
            this.barDockControlTop.Size = new System.Drawing.Size(529, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 343);
            this.barDockControlBottom.Manager = this.barManager_Commands;
            this.barDockControlBottom.Size = new System.Drawing.Size(529, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager_Commands;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 343);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(529, 0);
            this.barDockControlRight.Manager = this.barManager_Commands;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 343);
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // CommandsUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CommandsUserControl1";
            this.Size = new System.Drawing.Size(529, 343);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupContainerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu_Commands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager_Commands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl1;
        private DevExpress.XtraBars.PopupMenu popupMenu_Commands;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_addTextFile;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_addPdfFile;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_openTextEditor;
        private DevExpress.XtraBars.BarManager barManager_Commands;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_controlCommands;
    }
}
