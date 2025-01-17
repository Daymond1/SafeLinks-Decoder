namespace SafeLinks_Decoder
{
    partial class SafeLinksDecoder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SafeLinksDecoder));
            textBox2 = new TextBox();
            SafeLinkTextBox = new TextBox();
            moonLabel1 = new ReaLTaiizor.Controls.MoonLabel();
            DecodedUrlTextBox = new TextBox();
            moonLabel2 = new ReaLTaiizor.Controls.MoonLabel();
            button_Clear = new ReaLTaiizor.Controls.Button();
            button_Copy = new ReaLTaiizor.Controls.Button();
            spaceMinimize1 = new ReaLTaiizor.Controls.SpaceMinimize();
            notifyIcon1 = new NotifyIcon(components);
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // SafeLinkTextBox
            // 
            SafeLinkTextBox.BackColor = Color.FromArgb(40, 48, 51);
            SafeLinkTextBox.BorderStyle = BorderStyle.FixedSingle;
            SafeLinkTextBox.ForeColor = Color.Gray;
            SafeLinkTextBox.Location = new Point(12, 32);
            SafeLinkTextBox.Multiline = true;
            SafeLinkTextBox.Name = "SafeLinkTextBox";
            SafeLinkTextBox.ScrollBars = ScrollBars.Vertical;
            SafeLinkTextBox.Size = new Size(459, 84);
            SafeLinkTextBox.TabIndex = 4;
            SafeLinkTextBox.TextChanged += SafeLinkTextBox_TextChanged;
            // 
            // moonLabel1
            // 
            moonLabel1.AutoSize = true;
            moonLabel1.BackColor = Color.Transparent;
            moonLabel1.ForeColor = Color.Gray;
            moonLabel1.Location = new Point(12, 9);
            moonLabel1.Name = "moonLabel1";
            moonLabel1.Size = new Size(162, 20);
            moonLabel1.TabIndex = 5;
            moonLabel1.Text = "Paste SafeLinks URL:";
            // 
            // DecodedUrlTextBox
            // 
            DecodedUrlTextBox.BackColor = Color.FromArgb(40, 48, 51);
            DecodedUrlTextBox.BorderStyle = BorderStyle.FixedSingle;
            DecodedUrlTextBox.ForeColor = Color.Gray;
            DecodedUrlTextBox.Location = new Point(12, 142);
            DecodedUrlTextBox.Multiline = true;
            DecodedUrlTextBox.Name = "DecodedUrlTextBox";
            DecodedUrlTextBox.ReadOnly = true;
            DecodedUrlTextBox.ScrollBars = ScrollBars.Vertical;
            DecodedUrlTextBox.Size = new Size(459, 84);
            DecodedUrlTextBox.TabIndex = 6;
            // 
            // moonLabel2
            // 
            moonLabel2.AutoSize = true;
            moonLabel2.BackColor = Color.Transparent;
            moonLabel2.ForeColor = Color.Gray;
            moonLabel2.Location = new Point(12, 119);
            moonLabel2.Name = "moonLabel2";
            moonLabel2.Size = new Size(115, 20);
            moonLabel2.TabIndex = 7;
            moonLabel2.Text = "Decoded URL:";
            // 
            // button_Clear
            // 
            button_Clear.BackColor = Color.Transparent;
            button_Clear.BorderColor = Color.FromArgb(32, 34, 37);
            button_Clear.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button_Clear.EnteredColor = Color.FromArgb(32, 34, 37);
            button_Clear.Font = new Font("Microsoft Sans Serif", 12F);
            button_Clear.Image = null;
            button_Clear.ImageAlign = ContentAlignment.MiddleLeft;
            button_Clear.InactiveColor = Color.FromArgb(32, 34, 37);
            button_Clear.Location = new Point(12, 244);
            button_Clear.Name = "button_Clear";
            button_Clear.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button_Clear.PressedColor = Color.FromArgb(165, 37, 37);
            button_Clear.Size = new Size(120, 40);
            button_Clear.TabIndex = 11;
            button_Clear.Text = "Clear";
            button_Clear.TextAlignment = StringAlignment.Center;
            button_Clear.Click += button_Clear_Click;
            // 
            // button_Copy
            // 
            button_Copy.BackColor = Color.Transparent;
            button_Copy.BorderColor = Color.FromArgb(32, 34, 37);
            button_Copy.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button_Copy.EnteredColor = Color.FromArgb(32, 34, 37);
            button_Copy.Font = new Font("Microsoft Sans Serif", 12F);
            button_Copy.Image = null;
            button_Copy.ImageAlign = ContentAlignment.MiddleLeft;
            button_Copy.InactiveColor = Color.FromArgb(32, 34, 37);
            button_Copy.Location = new Point(156, 244);
            button_Copy.Name = "button_Copy";
            button_Copy.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button_Copy.PressedColor = Color.FromArgb(165, 37, 37);
            button_Copy.Size = new Size(315, 40);
            button_Copy.TabIndex = 12;
            button_Copy.Text = "Copy";
            button_Copy.TextAlignment = StringAlignment.Center;
            button_Copy.Click += button_Copy_Click;
            // 
            // spaceMinimize1
            // 
            spaceMinimize1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spaceMinimize1.Customization = "G4qM/3LEtP8yMjL/Kioq/yPJzP8bioz//v7+/yMjI/8qKir/";
            spaceMinimize1.DefaultAnchor = true;
            spaceMinimize1.DefaultLocation = false;
            spaceMinimize1.Font = new Font("Verdana", 8F);
            spaceMinimize1.Image = null;
            spaceMinimize1.Location = new Point(468, -5);
            spaceMinimize1.Name = "spaceMinimize1";
            spaceMinimize1.NoRounding = false;
            spaceMinimize1.Size = new Size(23, 21);
            spaceMinimize1.TabIndex = 15;
            spaceMinimize1.Text = "_";
            spaceMinimize1.Transparent = false;
            spaceMinimize1.WindowState = FormWindowState.Normal;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "SafeLinks Decoder";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            // 
            // SafeLinksDecoder
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 48, 51);
            ClientSize = new Size(490, 295);
            Controls.Add(spaceMinimize1);
            Controls.Add(button_Copy);
            Controls.Add(button_Clear);
            Controls.Add(moonLabel2);
            Controls.Add(DecodedUrlTextBox);
            Controls.Add(moonLabel1);
            Controls.Add(SafeLinkTextBox);
            Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximumSize = new Size(490, 295);
            MinimumSize = new Size(490, 295);
            Name = "SafeLinksDecoder";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "themeForm1";
            TransparencyKey = Color.Fuchsia;
            Load += SafeLinksDecoder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox SafeLinkTextBox;
        private ReaLTaiizor.Controls.MoonLabel moonLabel1;
        private TextBox DecodedUrlTextBox;
        private ReaLTaiizor.Controls.MoonLabel moonLabel2;
        private ReaLTaiizor.Controls.Button button_Clear;
        private ReaLTaiizor.Controls.Button button_Copy;
        private ReaLTaiizor.Controls.SpaceMinimize spaceMinimize1;
        private NotifyIcon notifyIcon1;
    }
}
