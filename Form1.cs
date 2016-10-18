using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MetroFramework;
using System.Threading;

namespace Notes_
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            DialogResult dr = new DialogResult();
            Form2 frm2 = new Form2();
            dr = frm2.ShowDialog();
            if (dr == DialogResult.OK)
            {
                InitializeComponent();
                GetStyle();
                ApplyAll();
            }
            else
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            AutoSaveTimer.Start();
            AutoSaveTimer.Interval = Properties.Settings.Default.SaveInterval;
            AutoSaveCheckbox.Checked = Properties.Settings.Default.AutoSave;
            AutoSaveTextBox.Text = Properties.Settings.Default.SaveInterval.ToString();
            NoteListView.Items.Clear();
            string[] filePaths = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");
            foreach (string file in filePaths)
            {
                string Filenamewithslash = file.Replace(Directory.GetCurrentDirectory(), "");
                string FileName = Filenamewithslash.Replace("\\", "");
                NoteListView.Items.Add(FileName);
            }
            StyleComboBox.Text = Properties.Settings.Default.Style.ToString();
            ThemeComboBox.Text = Properties.Settings.Default.Theme.ToString();
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {
            if (NoteNameTextBox.Text != "" && !NoteNameTextBox.Text.Contains(".txt"))
            {
                File.WriteAllText(NoteNameTextBox.Text + ".txt", StringCipher.Encrypt(NoteTextBox.Text, "SuperMemes"));
            }
            if (NoteNameTextBox.Text != "" && NoteNameTextBox.Text.Contains(".txt"))
            {
                File.WriteAllText(NoteNameTextBox.Text, StringCipher.Encrypt(NoteTextBox.Text, "SuperMemes"));
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NoteTextBox.Text = "";
            if (NoteSelectionComboBox.Text != "")
            {
                NoteTextBox.Text = StringCipher.Decrypt(File.ReadAllText(NoteSelectionComboBox.Text), "SuperMemes");
                string PartialName = NoteSelectionComboBox.Text.Replace(Directory.GetCurrentDirectory(), "");
                NoteNameTextBox.Text = PartialName.Replace("\\", "");
            }
        }

        private void metroComboBox1_DropDown(object sender, EventArgs e)
        {
            NoteSelectionComboBox.Items.Clear();
            string[] filePaths = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");
            foreach (string file in filePaths)
            {
                NoteSelectionComboBox.Items.Add(file);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (ChangePasswordTextBox.Text != "")
            {
                Properties.Settings.Default.Password = ChangePasswordTextBox.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void GetStyle()
        {
            msmMain.Theme = Properties.Settings.Default.Theme;
            msmMain.Style = Properties.Settings.Default.Style;
        }

        private void ApplyAll()
        {
            // Apply theme
            metroLabel1.Theme = msmMain.Theme;
            metroLabel2.Theme = msmMain.Theme;
            metroLabel3.Theme = msmMain.Theme;
            metroLabel4.Theme = msmMain.Theme;
            metroLabel5.Theme = msmMain.Theme;
            metroLabel6.Theme = msmMain.Theme;
            metroLabel7.Theme = msmMain.Theme;
            metroLabel8.Theme = msmMain.Theme;
            //metroLabel9.Theme = msmMain.Theme;
            //metroLabel0.Theme = msmMain.Theme;
            //metroLabel11.Theme = msmMain.Theme;
            this.Theme = msmMain.Theme;
            metroTabControl1.Theme = msmMain.Theme;
            metroTabPage1.Theme = msmMain.Theme;
            metroTabPage2.Theme = msmMain.Theme;
            NoteTextBox.Theme = msmMain.Theme;
            NoteNameTextBox.Theme = msmMain.Theme;
            ChangePasswordTextBox.Theme = msmMain.Theme;
            AutoSaveTextBox.Theme = msmMain.Theme;
            //metroTextBox5.Theme = msmMain.Theme;
            //metroTextBox6.Theme = msmMain.Theme;
            NoteSelectionComboBox.Theme = msmMain.Theme;
            StyleComboBox.Theme = msmMain.Theme;
            ThemeComboBox.Theme = msmMain.Theme;
            metroPanel1.Theme = msmMain.Theme;
            metroPanel2.Theme = msmMain.Theme;
            metroPanel3.Theme = msmMain.Theme;
            metroPanel4.Theme = msmMain.Theme;
            metroPanel5.Theme = msmMain.Theme;
            metroPanel6.Theme = msmMain.Theme;
            metroPanel7.Theme = msmMain.Theme;
            metroPanel8.Theme = msmMain.Theme;
            ChangePasswordButton.Theme = msmMain.Theme;
            NoteListView.Theme = msmMain.Theme;
            AutoSaveCheckbox.Theme = msmMain.Theme;
            // Apply Style
            this.Style = msmMain.Style;
            NoteSelectionComboBox.Style = msmMain.Style;
            StyleComboBox.Style = msmMain.Style;
            ThemeComboBox.Style = msmMain.Style;
            metroTabControl1.Style = msmMain.Style;
            metroLabel1.Style = msmMain.Style;
            metroLabel2.Style = msmMain.Style;
            metroLabel3.Style = msmMain.Style;
            metroLabel4.Style = msmMain.Style;
            metroLabel5.Style = msmMain.Style;
            metroLabel6.Style = msmMain.Style;
            metroLabel7.Style = msmMain.Style;
            metroLabel8.Style = msmMain.Style;
            //metroLabel9.Style = msmMain.Style;
            //metroLabel0.Style = msmMain.Style;
            //metroLabel11.Style = msmMain.Style;
            NoteTextBox.Style = msmMain.Style;
            NoteNameTextBox.Style = msmMain.Style;
            ChangePasswordTextBox.Style = msmMain.Style;
            AutoSaveTextBox.Style = msmMain.Style;
            //metroTextBox5.Style = msmMain.Style;
            //metroTextBox6.Style = msmMain.Style;
            metroPanel1.Style = msmMain.Style;
            metroPanel2.Style = msmMain.Style;
            metroPanel3.Style = msmMain.Style;
            metroPanel4.Style = msmMain.Style;
            metroPanel5.Style = msmMain.Style;
            metroPanel6.Style = msmMain.Style;
            metroPanel7.Style = msmMain.Style;
            metroPanel8.Style = msmMain.Style;
            ChangePasswordButton.Style = msmMain.Style;
            NoteListView.Style = msmMain.Style;
            AutoSaveCheckbox.Style = msmMain.Style;
            Refresh();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StyleComboBox.Text == "Black")
            {
                msmMain.Style = MetroColorStyle.Black;
            }
            if (StyleComboBox.Text == "Blue")
            {
                msmMain.Style = MetroColorStyle.Blue;
            }
            if (StyleComboBox.Text == "Brown")
            {
                msmMain.Style = MetroColorStyle.Brown;
            }
            if (StyleComboBox.Text == "Green")
            {
                msmMain.Style = MetroColorStyle.Green;
            }
            if (StyleComboBox.Text == "Lime")
            {
                msmMain.Style = MetroColorStyle.Lime;
            }
            if (StyleComboBox.Text == "Magenta")
            {
                msmMain.Style = MetroColorStyle.Magenta;
            }
            if (StyleComboBox.Text == "Orange")
            {
                msmMain.Style = MetroColorStyle.Orange;
            }
            if (StyleComboBox.Text == "Pink")
            {
                msmMain.Style = MetroColorStyle.Pink;
            }
            if (StyleComboBox.Text == "Purple")
            {
                msmMain.Style = MetroColorStyle.Purple;
            }
            if (StyleComboBox.Text == "Red")
            {
                msmMain.Style = MetroColorStyle.Red;
            }
            if (StyleComboBox.Text == "Silver")
            {
                msmMain.Style = MetroColorStyle.Silver;
            }
            if (StyleComboBox.Text == "Teal")
            {
                msmMain.Style = MetroColorStyle.Teal;
            }
            if (StyleComboBox.Text == "White")
            {
                msmMain.Style = MetroColorStyle.White;
            }
            if (StyleComboBox.Text == "Yellow")
            {
                msmMain.Style = MetroColorStyle.Yellow;
            }
            Properties.Settings.Default.Style = msmMain.Style;
            Properties.Settings.Default.Save();
            ApplyAll();
            Refresh();
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ThemeComboBox.Text == "Light")
            {
                msmMain.Theme = MetroThemeStyle.Light;
            }
            if (ThemeComboBox.Text == "Dark")
            {
                msmMain.Theme = MetroThemeStyle.Dark;
            }
            Properties.Settings.Default.Theme = msmMain.Theme;
            Properties.Settings.Default.Save();
            ApplyAll();
            Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NoteListView.Items.Clear();
            string[] filePaths = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");
            foreach (string file in filePaths)
            {
                string Filenamewithslash = file.Replace(Directory.GetCurrentDirectory(), "");
                string FileName = Filenamewithslash.Replace("\\", "");
                NoteListView.Items.Add(FileName);
            }
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoSave = AutoSaveCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SaveInterval = int.Parse(AutoSaveTextBox.Text.ToString());
            Properties.Settings.Default.Save();
        }

        private void AutoSaveTimer_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AutoSave)
            {
                if (NoteNameTextBox.Text != "" && !NoteNameTextBox.Text.Contains(".txt"))
                {
                    File.WriteAllText(NoteNameTextBox.Text + ".txt", StringCipher.Encrypt(NoteTextBox.Text, "SuperMemes"));
                }
                if (NoteNameTextBox.Text != "" && NoteNameTextBox.Text.Contains(".txt"))
                {
                    File.WriteAllText(NoteNameTextBox.Text, StringCipher.Encrypt(NoteTextBox.Text, "SuperMemes"));
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (NoteListView.SelectedItems.Count > 0)
            {
                if (NoteLocationTextBox.Text != "")
                {
                    File.Delete(NoteLocationTextBox.Text);
                    NoteListView.Items.Remove(NoteListView.SelectedItems[0]);
                    NoteLocationTextBox.Clear();
                    timer1.Start();
                }
            }
        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NoteListView.SelectedItems.Count > 0)
            {
                NoteLocationTextBox.Text = (Directory.GetCurrentDirectory() + "\\" + NoteListView.SelectedItems[0].Text);
                //string file = (Directory.GetCurrentDirectory() + "\\" + NoteListView.SelectedItems[0]);
                metroLabel11.Text = " [Size: " + NoteListView.SelectedItems[0].Text.Length.ToString() + " Bytes]" + " [Last Modified: " + File.GetLastWriteTime(NoteListView.SelectedItems[0].Text).ToString() + "]";
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (NoteListView.Items.Count == 0)
            {
                columnHeader1.Width = NoteListView.Width - 4;
            }
            else
            {
                columnHeader1.Width = NoteListView.Width - 21;
            }
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            if (this.Location.X < 0)
            {
                int yint = this.Location.Y;
                this.Location = new Point(0, yint);
            }
            if (this.Location.Y < 0)
            {
                int xint = this.Location.X;
                this.Location = new Point(xint, 0);
            }
            if (this.Location.X + this.Width > Screen.FromControl(this).Bounds.Width)
            {
                int yint = this.Location.Y;
                this.Location = new Point(Screen.FromControl(this).Bounds.Width - this.Width, yint);
            }
            if (this.Location.Y + this.Height > Screen.FromControl(this).Bounds.Height)
            {
                int xint = this.Location.X;
                this.Location = new Point(xint, Screen.FromControl(this).Bounds.Height - this.Height);
            }
        }
    }

    public static class StringCipher
    {
        // This constant is used to determine the keysize of the encryption algorithm in bits.
        // We divide this by 8 within the code below to get the equivalent number of bytes.
        private const int Keysize = 256;

        // This constant determines the number of iterations for the password bytes generation function.
        private const int DerivationIterations = 1000;

        public static string Encrypt(string plainText, string passPhrase)
        {
            // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
            // so that the same Salt and IV values can be used when decrypting.  
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        public static string Decrypt(string cipherText, string passPhrase)
        {
            // Get the complete stream of bytes that represent:
            // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
    }
}
