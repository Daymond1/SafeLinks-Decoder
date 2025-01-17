using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace SafeLinks_Decoder
{
    public partial class SafeLinksDecoder : Form
    {
        private NotifyIcon trayIcon;
        private ContextMenuStrip trayMenu;

        public SafeLinksDecoder()
        {
            InitializeComponent();
            InitializeTrayIcon();
            SafeLinkTextBox.TextChanged += SafeLinkTextBox_TextChanged;
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            this.ShowInTaskbar = false;

            // Prevent multiple instances by checking and closing any existing ones
            if (IsAlreadyRunning())
            {
                MessageBox.Show("SafeLinks Decoder is already running.", "SafeLinks Decoder", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Exit();
                return;
            }
        }

        private bool IsAlreadyRunning()
        {
            Process currentProcess = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(currentProcess.ProcessName);

            if (processes.Length > 1)
            {
                // Find the second instance and close it
                foreach (var process in processes)
                {
                    // Ensure it's not the current instance
                    if (process.Id != currentProcess.Id)
                    {
                        process.Kill(); // Close the second instance
                        break;
                    }
                }
                return true;
            }

            return false;
        }


        private void OnApplicationExit(object sender, EventArgs e)
        {
            Application.Exit();
            trayIcon.Dispose(); 
        }

        private void SafeLinksDecoder_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;

            var screen = Screen.PrimaryScreen.WorkingArea;

            int newX = screen.Right - this.Width;
            int newY = screen.Bottom - this.Height;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(newX, newY);
            this.Hide();
        }

        private void InitializeTrayIcon()
        {
            trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("Open", null, Open_Click);
            trayMenu.Items.Add("Add/Remove to autorun", null, AddToStartupMenuItem_Click);
            trayMenu.Items.Add("Exit", null, Exit_Click);

            trayIcon = new NotifyIcon
            {
                Text = "SafeLinks Decoder",
                ContextMenuStrip = trayMenu,
                Visible = true
            };
        }

        private void Open_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit(); 
        }

        public void decode()
        {
            string safeLink = SafeLinkTextBox.Text;

            if (!Uri.IsWellFormedUriString(safeLink, UriKind.Absolute))
            {
                DecodedUrlTextBox.Text = "Enter the correct SafeLink.";
                return;
            }

            try
            {
                Uri uri = new Uri(safeLink);
                var queryParameters = System.Web.HttpUtility.ParseQueryString(uri.Query);
                string encodedUrl = queryParameters["url"];

                if (!string.IsNullOrEmpty(encodedUrl))
                {
                    string decodedUrl = System.Web.HttpUtility.UrlDecode(encodedUrl);
                    DecodedUrlTextBox.Text = decodedUrl;
                }
                else
                {
                    DecodedUrlTextBox.Text = "Not correct link.";
                }
            }
            catch (Exception ex)
            {
                DecodedUrlTextBox.Text = $"Error: {ex.Message}\\Details: {ex.StackTrace}";
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                base.WndProc(ref m);
                if ((int)m.Result == 0x1)
                    m.Result = (IntPtr)0x2;
                return;
            }

            base.WndProc(ref m);
        }

        private void SafeLinkTextBox_TextChanged(object sender, EventArgs e)
        {
            decode();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            SafeLinkTextBox.Clear();
            DecodedUrlTextBox.Clear();
        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            string decodedUrl = DecodedUrlTextBox.Text;
            if (decodedUrl.Length < 0)
            {
                Clipboard.SetText("");
            }
            if (decodedUrl.Length > 0)
            {
                Clipboard.SetText(decodedUrl);
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
                ShowContextMenu();
            }
        }

        private void ShowContextMenu()
        {
            trayMenu.Show(Cursor.Position);
        }

        private void AddToStartupMenuItem_Click(object sender, EventArgs e)
        {
            string appPath = Application.ExecutablePath;
            try
            {
                using (var key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    if (key.GetValue("SafeLinksDecoder") != null)
                    {
                        key.DeleteValue("SafeLinksDecoder");
                        MessageBox.Show("Removed from autorun", "SafeLinks Decoder");
                    }
                    else
                    {
                        key.SetValue("SafeLinksDecoder", appPath);
                        MessageBox.Show("Added to autorun", "SafeLinks Decoder");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not change the autorun setting: {ex.Message}", "SafeLinks Decoder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
