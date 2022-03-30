using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroTextBoxLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void metroButtonGeneratePassword_Click(object sender, EventArgs e)
        {
            int textLength = Convert.ToInt32(metroTextBoxLength.Text);
            bool useLowercase = true;
            bool useUppercase = true;
            bool useNumbers = true;
            bool useSymbols = true;


            if (textLength < 8)
            {
                metroTextBoxLength.Text = "8";
            }

            if (textLength > 32)
            {
                metroTextBoxLength.Text = "32";
            }

            if (!metroCheckBoxLowercase.Checked)
            {
                useLowercase = false;
            }

            if (!metroCheckBoxUppercase.Checked)
            {
                useUppercase = false;
            }

            if (!metroCheckBoxSymbols.Checked)
            {
                useSymbols = false;
            }

            if (!metroCheckBoxNumbers.Checked)
            {
                useNumbers = false;
            }

            textLength = Convert.ToInt32(metroTextBoxLength.Text);
            string textPassword = GeneratePassword(textLength, useNumbers, useLowercase, useUppercase, useSymbols);

            metroTextBoxClipboard.Text = textPassword;
            metroTextBoxClipboard.Enabled = true;
        }
        private String GeneratePassword(int textLength, bool usenumbers, bool uselowalphabets, bool usehighalphabets, bool usesymbols)
        {

            var upperCase = new char[]
                {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z'
                };

            var lowerCase = new char[]
                {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
                'v', 'w', 'x', 'y', 'z'
                };

            var numerals = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            var symbols = new char[]
                {
                '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '{', '[', '}', ']', '-', '_', '=', '+', ':',
                ';', '|', '/', '?', ',', '.',
                };

            char[] total = (new char[0])
                            .Concat(usehighalphabets ? upperCase : new char[0])
                            .Concat(uselowalphabets ? lowerCase : new char[0])
                            .Concat(usenumbers ? numerals : new char[0])
                            .Concat(usesymbols ? symbols : new char[0])
                            .ToArray();

            var rnd = new Random();

            var chars = Enumerable
                .Repeat<int>(0, textLength)
                .Select(i => total[rnd.Next(total.Length)])
                .ToArray();

            return new string(chars);
        }

        private void metroTextBoxClipboard_Click(object sender, EventArgs e)
        {
            if (metroTextBoxClipboard != null)
            {
                Clipboard.SetText(metroTextBoxClipboard.Text);

                var imageUri = Path.GetFullPath("C:\\Users\\MuhamadRizky\\source\\repos\\PasswordGenerator\\PasswordGenerator\\Resources\\Icons8-Copy.ico");

                new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddArgument("conversationId", 9813)
                    .AddText("Password Generator")
                    .AddText("Text copied to clipboard")
                    .AddAppLogoOverride(new Uri(imageUri))
                    .Show();
            }
        }

        private void customButtonClick(object sender, EventArgs e)
        {
            if (metroTextBoxClipboard != null)
            {
                Clipboard.SetText(metroTextBoxClipboard.Text);

                var imageUri = Path.GetFullPath("C:\\Users\\MuhamadRizky\\source\\repos\\PasswordGenerator\\PasswordGenerator\\Resources\\Icons8-Copy.ico");

                new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddArgument("conversationId", 9813)
                    .AddText("Password Generator")
                    .AddText("Text copied to clipboard")
                    .AddAppLogoOverride(new Uri(imageUri))
                    .Show();
            }
        }
    }
}
