namespace PasswordGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroTextBoxClipboard = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroTextBoxLength = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBoxUppercase = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxLowercase = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxNumbers = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxSymbols = new MetroFramework.Controls.MetroCheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.metroButtonGeneratePassword = new MetroFramework.Controls.MetroButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 74);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(69, 457);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 11;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(439, 74);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(69, 457);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 11;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroTextBoxClipboard);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(89, 74);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(350, 94);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 11;
            // 
            // metroTextBoxClipboard
            // 
            // 
            // 
            // 
            this.metroTextBoxClipboard.CustomButton.Image = global::PasswordGenerator.Properties.Resources.copy_48x48;
            this.metroTextBoxClipboard.CustomButton.Location = new System.Drawing.Point(310, 1);
            this.metroTextBoxClipboard.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTextBoxClipboard.CustomButton.Name = "";
            this.metroTextBoxClipboard.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.metroTextBoxClipboard.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxClipboard.CustomButton.TabIndex = 1;
            this.metroTextBoxClipboard.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxClipboard.CustomButton.UseSelectable = true;
            this.metroTextBoxClipboard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTextBoxClipboard.Enabled = false;
            this.metroTextBoxClipboard.Lines = new string[0];
            this.metroTextBoxClipboard.Location = new System.Drawing.Point(0, 53);
            this.metroTextBoxClipboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTextBoxClipboard.MaxLength = 32767;
            this.metroTextBoxClipboard.Multiline = true;
            this.metroTextBoxClipboard.Name = "metroTextBoxClipboard";
            this.metroTextBoxClipboard.PasswordChar = '\0';
            this.metroTextBoxClipboard.ReadOnly = true;
            this.metroTextBoxClipboard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxClipboard.SelectedText = "";
            this.metroTextBoxClipboard.SelectionLength = 0;
            this.metroTextBoxClipboard.SelectionStart = 0;
            this.metroTextBoxClipboard.ShortcutsEnabled = true;
            this.metroTextBoxClipboard.ShowButton = true;
            this.metroTextBoxClipboard.Size = new System.Drawing.Size(350, 41);
            this.metroTextBoxClipboard.TabIndex = 2;
            this.metroTextBoxClipboard.UseSelectable = true;
            this.metroTextBoxClipboard.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxClipboard.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxClipboard.Click += new System.EventHandler(this.metroTextBoxClipboard_Click);
            this.metroTextBoxClipboard.CustomButton.Click += new System.EventHandler(this.customButtonClick);
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.flowLayoutPanel2);
            this.metroPanel4.Controls.Add(this.flowLayoutPanel1);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(89, 168);
            this.metroPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(350, 363);
            this.metroPanel4.TabIndex = 3;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel2.Controls.Add(this.metroTextBoxLength);
            this.flowLayoutPanel2.Controls.Add(this.metroCheckBoxUppercase);
            this.flowLayoutPanel2.Controls.Add(this.metroCheckBoxLowercase);
            this.flowLayoutPanel2.Controls.Add(this.metroCheckBoxNumbers);
            this.flowLayoutPanel2.Controls.Add(this.metroCheckBoxSymbols);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(268, -1);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(83, 364);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // metroTextBoxLength
            // 
            // 
            // 
            // 
            this.metroTextBoxLength.CustomButton.Image = null;
            this.metroTextBoxLength.CustomButton.Location = new System.Drawing.Point(14, 2);
            this.metroTextBoxLength.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBoxLength.CustomButton.Name = "";
            this.metroTextBoxLength.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBoxLength.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxLength.CustomButton.TabIndex = 1;
            this.metroTextBoxLength.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxLength.CustomButton.UseSelectable = true;
            this.metroTextBoxLength.CustomButton.Visible = false;
            this.metroTextBoxLength.Lines = new string[] {
        "8"};
            this.metroTextBoxLength.Location = new System.Drawing.Point(41, 12);
            this.metroTextBoxLength.Margin = new System.Windows.Forms.Padding(41, 12, 0, 18);
            this.metroTextBoxLength.MaxLength = 32767;
            this.metroTextBoxLength.Name = "metroTextBoxLength";
            this.metroTextBoxLength.PasswordChar = '\0';
            this.metroTextBoxLength.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLength.SelectedText = "";
            this.metroTextBoxLength.SelectionLength = 0;
            this.metroTextBoxLength.SelectionStart = 0;
            this.metroTextBoxLength.ShortcutsEnabled = true;
            this.metroTextBoxLength.Size = new System.Drawing.Size(40, 28);
            this.metroTextBoxLength.TabIndex = 5;
            this.metroTextBoxLength.Text = "8";
            this.metroTextBoxLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.metroTextBoxLength.UseSelectable = true;
            this.metroTextBoxLength.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLength.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxLength_KeyPress);
            // 
            // metroCheckBoxUppercase
            // 
            this.metroCheckBoxUppercase.Checked = true;
            this.metroCheckBoxUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBoxUppercase.Location = new System.Drawing.Point(60, 69);
            this.metroCheckBoxUppercase.Margin = new System.Windows.Forms.Padding(60, 11, 0, 18);
            this.metroCheckBoxUppercase.Name = "metroCheckBoxUppercase";
            this.metroCheckBoxUppercase.Size = new System.Drawing.Size(17, 18);
            this.metroCheckBoxUppercase.TabIndex = 1;
            this.metroCheckBoxUppercase.UseSelectable = true;
            // 
            // metroCheckBoxLowercase
            // 
            this.metroCheckBoxLowercase.Checked = true;
            this.metroCheckBoxLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBoxLowercase.Location = new System.Drawing.Point(60, 117);
            this.metroCheckBoxLowercase.Margin = new System.Windows.Forms.Padding(60, 12, 0, 18);
            this.metroCheckBoxLowercase.Name = "metroCheckBoxLowercase";
            this.metroCheckBoxLowercase.Size = new System.Drawing.Size(17, 18);
            this.metroCheckBoxLowercase.TabIndex = 2;
            this.metroCheckBoxLowercase.UseSelectable = true;
            // 
            // metroCheckBoxNumbers
            // 
            this.metroCheckBoxNumbers.Checked = true;
            this.metroCheckBoxNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBoxNumbers.Location = new System.Drawing.Point(60, 167);
            this.metroCheckBoxNumbers.Margin = new System.Windows.Forms.Padding(60, 14, 0, 18);
            this.metroCheckBoxNumbers.Name = "metroCheckBoxNumbers";
            this.metroCheckBoxNumbers.Size = new System.Drawing.Size(17, 18);
            this.metroCheckBoxNumbers.TabIndex = 3;
            this.metroCheckBoxNumbers.UseSelectable = true;
            // 
            // metroCheckBoxSymbols
            // 
            this.metroCheckBoxSymbols.Checked = true;
            this.metroCheckBoxSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBoxSymbols.Location = new System.Drawing.Point(60, 218);
            this.metroCheckBoxSymbols.Margin = new System.Windows.Forms.Padding(60, 15, 0, 18);
            this.metroCheckBoxSymbols.Name = "metroCheckBoxSymbols";
            this.metroCheckBoxSymbols.Size = new System.Drawing.Size(17, 18);
            this.metroCheckBoxSymbols.TabIndex = 4;
            this.metroCheckBoxSymbols.UseSelectable = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.metroLabel1);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel2);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel3);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel4);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 6, 3, 2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(269, 363);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 15);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(0, 9, 3, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(109, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Password length";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 62);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(0, 9, 3, 18);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(159, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Include uppercase letter";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(0, 109);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(0, 9, 3, 18);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(156, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Include lowercase letter";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(0, 156);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(0, 9, 3, 18);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(113, 20);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Include numbers";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(0, 203);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(0, 9, 3, 18);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(108, 20);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Include symbols";
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.metroButtonGeneratePassword);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(89, 428);
            this.metroPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(350, 103);
            this.metroPanel5.TabIndex = 4;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 11;
            // 
            // metroButtonGeneratePassword
            // 
            this.metroButtonGeneratePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroButtonGeneratePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButtonGeneratePassword.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonGeneratePassword.ForeColor = System.Drawing.Color.White;
            this.metroButtonGeneratePassword.Location = new System.Drawing.Point(0, 0);
            this.metroButtonGeneratePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButtonGeneratePassword.Name = "metroButtonGeneratePassword";
            this.metroButtonGeneratePassword.Size = new System.Drawing.Size(350, 39);
            this.metroButtonGeneratePassword.TabIndex = 2;
            this.metroButtonGeneratePassword.Text = "Generate password";
            this.metroButtonGeneratePassword.UseCustomBackColor = true;
            this.metroButtonGeneratePassword.UseCustomForeColor = true;
            this.metroButtonGeneratePassword.UseSelectable = true;
            this.metroButtonGeneratePassword.Click += new System.EventHandler(this.metroButtonGeneratePassword_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 551);
            this.Controls.Add(this.metroPanel5);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Resizable = false;
            this.Text = "Password Generator";
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroTextBox metroTextBoxClipboard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroButton metroButtonGeneratePassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxUppercase;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxLowercase;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxNumbers;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxSymbols;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLength;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

