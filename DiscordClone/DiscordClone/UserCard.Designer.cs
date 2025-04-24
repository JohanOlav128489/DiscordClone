namespace DiscordClone
{
    partial class UserCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCard));
            tPUserCardMain = new TableLayoutPanel();
            tPUserCardInfo = new TableLayoutPanel();
            label1 = new Label();
            lblUserCardName = new Label();
            picUserCardIcon = new PictureBox();
            picUserCardChat = new PictureBox();
            picUserCardMore = new PictureBox();
            tPUserCardMain.SuspendLayout();
            tPUserCardInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUserCardIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUserCardChat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picUserCardMore).BeginInit();
            SuspendLayout();
            // 
            // tPUserCardMain
            // 
            tPUserCardMain.BackColor = Color.DimGray;
            tPUserCardMain.ColumnCount = 4;
            tPUserCardMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tPUserCardMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tPUserCardMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tPUserCardMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tPUserCardMain.Controls.Add(tPUserCardInfo, 1, 0);
            tPUserCardMain.Controls.Add(picUserCardIcon, 0, 0);
            tPUserCardMain.Controls.Add(picUserCardChat, 2, 0);
            tPUserCardMain.Controls.Add(picUserCardMore, 3, 0);
            tPUserCardMain.Dock = DockStyle.Fill;
            tPUserCardMain.Location = new Point(0, 0);
            tPUserCardMain.Name = "tPUserCardMain";
            tPUserCardMain.RowCount = 1;
            tPUserCardMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tPUserCardMain.Size = new Size(426, 69);
            tPUserCardMain.TabIndex = 5;
            // 
            // tPUserCardInfo
            // 
            tPUserCardInfo.ColumnCount = 1;
            tPUserCardInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tPUserCardInfo.Controls.Add(label1, 0, 1);
            tPUserCardInfo.Controls.Add(lblUserCardName, 0, 0);
            tPUserCardInfo.Dock = DockStyle.Fill;
            tPUserCardInfo.Location = new Point(63, 3);
            tPUserCardInfo.Name = "tPUserCardInfo";
            tPUserCardInfo.RowCount = 2;
            tPUserCardInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tPUserCardInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tPUserCardInfo.Size = new Size(240, 63);
            tPUserCardInfo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(3, 38);
            label1.Name = "label1";
            label1.Size = new Size(234, 25);
            label1.TabIndex = 1;
            label1.Text = "Online";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblUserCardName
            // 
            lblUserCardName.AutoSize = true;
            lblUserCardName.Dock = DockStyle.Fill;
            lblUserCardName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserCardName.ForeColor = Color.White;
            lblUserCardName.Location = new Point(3, 0);
            lblUserCardName.Name = "lblUserCardName";
            lblUserCardName.Size = new Size(234, 38);
            lblUserCardName.TabIndex = 0;
            lblUserCardName.Text = "Iverended";
            lblUserCardName.TextAlign = ContentAlignment.MiddleLeft;
            lblUserCardName.Click += lblUserCardName_Click;
            // 
            // picUserCardIcon
            // 
            picUserCardIcon.Dock = DockStyle.Fill;
            picUserCardIcon.Image = (Image)resources.GetObject("picUserCardIcon.Image");
            picUserCardIcon.Location = new Point(3, 3);
            picUserCardIcon.Name = "picUserCardIcon";
            picUserCardIcon.Size = new Size(54, 63);
            picUserCardIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picUserCardIcon.TabIndex = 1;
            picUserCardIcon.TabStop = false;
            // 
            // picUserCardChat
            // 
            picUserCardChat.Dock = DockStyle.Fill;
            picUserCardChat.Image = Properties.Resources.Screenshot_2025_03_03_140532;
            picUserCardChat.Location = new Point(309, 3);
            picUserCardChat.Name = "picUserCardChat";
            picUserCardChat.Size = new Size(54, 63);
            picUserCardChat.SizeMode = PictureBoxSizeMode.Zoom;
            picUserCardChat.TabIndex = 2;
            picUserCardChat.TabStop = false;
            // 
            // picUserCardMore
            // 
            picUserCardMore.AccessibleName = "";
            picUserCardMore.Dock = DockStyle.Fill;
            picUserCardMore.Image = Properties.Resources.Screenshot_2025_03_03_140616;
            picUserCardMore.Location = new Point(369, 3);
            picUserCardMore.Name = "picUserCardMore";
            picUserCardMore.Size = new Size(54, 63);
            picUserCardMore.SizeMode = PictureBoxSizeMode.Zoom;
            picUserCardMore.TabIndex = 3;
            picUserCardMore.TabStop = false;
            // 
            // UserCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tPUserCardMain);
            Name = "UserCard";
            Size = new Size(426, 69);
            tPUserCardMain.ResumeLayout(false);
            tPUserCardInfo.ResumeLayout(false);
            tPUserCardInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUserCardIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUserCardChat).EndInit();
            ((System.ComponentModel.ISupportInitialize)picUserCardMore).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tPUserCardMain;
        private TableLayoutPanel tPUserCardInfo;
        private PictureBox picUserCardIcon;
        private PictureBox picUserCardChat;
        private PictureBox picUserCardMore;
        private Label label1;
        private Label lblUserCardName;
    }
}
