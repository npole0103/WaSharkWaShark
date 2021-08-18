namespace WaSharkWaShark
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.패킷정보저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwPacket = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SrcIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SrcMac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SrcDomain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DesIp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DesMac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DesDomain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RawPacket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JsonView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnJsonView = new System.Windows.Forms.Button();
            this.btnHexView = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.txtDialog = new System.Windows.Forms.RichTextBox();
            this.pbState = new System.Windows.Forms.ProgressBar();
            this.lblPb = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1526, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.패킷정보저장SToolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.파일FToolStripMenuItem.Text = "File(&F)";
            // 
            // 패킷정보저장SToolStripMenuItem
            // 
            this.패킷정보저장SToolStripMenuItem.Name = "패킷정보저장SToolStripMenuItem";
            this.패킷정보저장SToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.패킷정보저장SToolStripMenuItem.Text = "패킷정보 저장(&S)";
            this.패킷정보저장SToolStripMenuItem.Click += new System.EventHandler(this.패킷정보저장SToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말ToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpToolStripMenuItem.Text = "Help(&H)";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.도움말ToolStripMenuItem.Text = "도움말";
            this.도움말ToolStripMenuItem.Click += new System.EventHandler(this.도움말ToolStripMenuItem_Click);
            // 
            // lvwPacket
            // 
            this.lvwPacket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Time,
            this.SrcIP,
            this.SrcMac,
            this.SrcDomain,
            this.DesIp,
            this.DesMac,
            this.DesDomain,
            this.Length,
            this.URI,
            this.RawPacket,
            this.JsonView});
            this.lvwPacket.HideSelection = false;
            this.lvwPacket.Location = new System.Drawing.Point(36, 27);
            this.lvwPacket.Name = "lvwPacket";
            this.lvwPacket.Size = new System.Drawing.Size(1446, 237);
            this.lvwPacket.TabIndex = 1;
            this.lvwPacket.UseCompatibleStateImageBehavior = false;
            this.lvwPacket.SelectedIndexChanged += new System.EventHandler(this.lvwPacket_SelectedIndexChanged);
            // 
            // No
            // 
            this.No.Text = "No";
            this.No.Width = 40;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 300;
            // 
            // SrcIP
            // 
            this.SrcIP.Text = "SrcIP";
            this.SrcIP.Width = 100;
            // 
            // SrcMac
            // 
            this.SrcMac.Text = "SrcMac";
            this.SrcMac.Width = 120;
            // 
            // SrcDomain
            // 
            this.SrcDomain.Text = "SrcDomain";
            this.SrcDomain.Width = 120;
            // 
            // DesIp
            // 
            this.DesIp.Text = "DesIp";
            this.DesIp.Width = 100;
            // 
            // DesMac
            // 
            this.DesMac.Text = "DesMac";
            this.DesMac.Width = 120;
            // 
            // DesDomain
            // 
            this.DesDomain.Text = "DesDomain";
            this.DesDomain.Width = 120;
            // 
            // Length
            // 
            this.Length.Text = "Length";
            // 
            // URI
            // 
            this.URI.Text = "URI";
            this.URI.Width = 300;
            // 
            // RawPacket
            // 
            this.RawPacket.Text = "RawPacket";
            this.RawPacket.Width = 0;
            // 
            // JsonView
            // 
            this.JsonView.Text = "JsonView";
            this.JsonView.Width = 0;
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(1157, 448);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(149, 49);
            this.btnExtract.TabIndex = 3;
            this.btnExtract.Text = "Extract Pcap";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnJsonView
            // 
            this.btnJsonView.Location = new System.Drawing.Point(392, 448);
            this.btnJsonView.Name = "btnJsonView";
            this.btnJsonView.Size = new System.Drawing.Size(149, 49);
            this.btnJsonView.TabIndex = 4;
            this.btnJsonView.Text = "Json View";
            this.btnJsonView.UseVisualStyleBackColor = true;
            this.btnJsonView.Click += new System.EventHandler(this.btnJsonView_Click);
            // 
            // btnHexView
            // 
            this.btnHexView.Location = new System.Drawing.Point(215, 448);
            this.btnHexView.Name = "btnHexView";
            this.btnHexView.Size = new System.Drawing.Size(149, 49);
            this.btnHexView.TabIndex = 5;
            this.btnHexView.Text = "Hex View";
            this.btnHexView.UseVisualStyleBackColor = true;
            this.btnHexView.Click += new System.EventHandler(this.btnHexView_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(36, 448);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 49);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Follow Stream\r\nSave as Json";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1333, 448);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 49);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // txtDialog
            // 
            this.txtDialog.Location = new System.Drawing.Point(36, 270);
            this.txtDialog.Name = "txtDialog";
            this.txtDialog.Size = new System.Drawing.Size(1446, 163);
            this.txtDialog.TabIndex = 8;
            this.txtDialog.Text = "";
            // 
            // pbState
            // 
            this.pbState.Location = new System.Drawing.Point(686, 461);
            this.pbState.Name = "pbState";
            this.pbState.Size = new System.Drawing.Size(420, 23);
            this.pbState.TabIndex = 9;
            // 
            // lblPb
            // 
            this.lblPb.AutoSize = true;
            this.lblPb.Location = new System.Drawing.Point(606, 466);
            this.lblPb.Name = "lblPb";
            this.lblPb.Size = new System.Drawing.Size(33, 12);
            this.lblPb.TabIndex = 10;
            this.lblPb.Text = "State";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 518);
            this.Controls.Add(this.lblPb);
            this.Controls.Add(this.pbState);
            this.Controls.Add(this.txtDialog);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnHexView);
            this.Controls.Add(this.btnJsonView);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.lvwPacket);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "WaShark-WaShark";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 패킷정보저장SToolStripMenuItem;
        private System.Windows.Forms.ListView lvwPacket;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader SrcIP;
        private System.Windows.Forms.ColumnHeader SrcDomain;
        private System.Windows.Forms.ColumnHeader DesIp;
        private System.Windows.Forms.ColumnHeader DesDomain;
        private System.Windows.Forms.ColumnHeader Length;
        private System.Windows.Forms.ColumnHeader URI;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Button btnJsonView;
        private System.Windows.Forms.Button btnHexView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader SrcMac;
        private System.Windows.Forms.ColumnHeader DesMac;
        private System.Windows.Forms.ColumnHeader RawPacket;
        private System.Windows.Forms.ColumnHeader JsonView;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.RichTextBox txtDialog;
        private System.Windows.Forms.ProgressBar pbState;
        private System.Windows.Forms.Label lblPb;
    }
}

