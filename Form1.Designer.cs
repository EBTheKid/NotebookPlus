namespace Notes_
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.NoteSelectionComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SaveButton = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.NoteNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.NoteTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel8 = new MetroFramework.Controls.MetroPanel();
            this.AutoSaveTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.AutoSaveCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.NoteLocationTextBox = new MetroFramework.Controls.MetroTextBox();
            this.DeleteNoteButton = new MetroFramework.Controls.MetroButton();
            this.NoteListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.ThemeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.StyleComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.ChangePasswordButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ChangePasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AutoSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroPanel7.SuspendLayout();
            this.metroPanel8.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(591, 370);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.Controls.Add(this.NoteTextBox);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(583, 328);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Write Notes";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.NoteSelectionComboBox);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.SaveButton);
            this.metroPanel1.Controls.Add(this.NoteNameTextBox);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 267);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(583, 61);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // NoteSelectionComboBox
            // 
            this.NoteSelectionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteSelectionComboBox.FormattingEnabled = true;
            this.NoteSelectionComboBox.ItemHeight = 23;
            this.NoteSelectionComboBox.Location = new System.Drawing.Point(3, 29);
            this.NoteSelectionComboBox.Name = "NoteSelectionComboBox";
            this.NoteSelectionComboBox.Size = new System.Drawing.Size(577, 29);
            this.NoteSelectionComboBox.TabIndex = 3;
            this.NoteSelectionComboBox.UseSelectable = true;
            this.NoteSelectionComboBox.UseStyleColors = true;
            this.NoteSelectionComboBox.DropDown += new System.EventHandler(this.metroComboBox1_DropDown);
            this.NoteSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(3, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 23);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Note File Name:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseStyleColors = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Image = null;
            this.SaveButton.Location = new System.Drawing.Point(505, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseSelectable = true;
            this.SaveButton.UseStyleColors = true;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.metroTextButton1_Click);
            // 
            // NoteNameTextBox
            // 
            this.NoteNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.NoteNameTextBox.CustomButton.Image = null;
            this.NoteNameTextBox.CustomButton.Location = new System.Drawing.Point(363, 1);
            this.NoteNameTextBox.CustomButton.Name = "";
            this.NoteNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoteNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoteNameTextBox.CustomButton.TabIndex = 1;
            this.NoteNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoteNameTextBox.CustomButton.UseSelectable = true;
            this.NoteNameTextBox.CustomButton.Visible = false;
            this.NoteNameTextBox.Lines = new string[0];
            this.NoteNameTextBox.Location = new System.Drawing.Point(114, 3);
            this.NoteNameTextBox.MaxLength = 32767;
            this.NoteNameTextBox.Name = "NoteNameTextBox";
            this.NoteNameTextBox.PasswordChar = '\0';
            this.NoteNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NoteNameTextBox.SelectedText = "";
            this.NoteNameTextBox.SelectionLength = 0;
            this.NoteNameTextBox.SelectionStart = 0;
            this.NoteNameTextBox.ShortcutsEnabled = true;
            this.NoteNameTextBox.Size = new System.Drawing.Size(385, 23);
            this.NoteNameTextBox.TabIndex = 0;
            this.NoteNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NoteNameTextBox.UseSelectable = true;
            this.NoteNameTextBox.UseStyleColors = true;
            this.NoteNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NoteNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.NoteTextBox.CustomButton.Image = null;
            this.NoteTextBox.CustomButton.Location = new System.Drawing.Point(317, 1);
            this.NoteTextBox.CustomButton.Name = "";
            this.NoteTextBox.CustomButton.Size = new System.Drawing.Size(265, 265);
            this.NoteTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoteTextBox.CustomButton.TabIndex = 1;
            this.NoteTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoteTextBox.CustomButton.UseSelectable = true;
            this.NoteTextBox.CustomButton.Visible = false;
            this.NoteTextBox.Lines = new string[0];
            this.NoteTextBox.Location = new System.Drawing.Point(0, 0);
            this.NoteTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.NoteTextBox.MaxLength = 2147483647;
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.PasswordChar = '\0';
            this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextBox.SelectedText = "";
            this.NoteTextBox.SelectionLength = 0;
            this.NoteTextBox.SelectionStart = 0;
            this.NoteTextBox.ShortcutsEnabled = true;
            this.NoteTextBox.ShowClearButton = true;
            this.NoteTextBox.Size = new System.Drawing.Size(583, 267);
            this.NoteTextBox.TabIndex = 1;
            this.NoteTextBox.UseSelectable = true;
            this.NoteTextBox.UseStyleColors = true;
            this.NoteTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NoteTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroPanel7);
            this.metroTabPage2.Controls.Add(this.metroPanel6);
            this.metroTabPage2.Controls.Add(this.metroPanel4);
            this.metroTabPage2.Controls.Add(this.metroPanel2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(583, 328);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Settings";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroPanel7
            // 
            this.metroPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel7.Controls.Add(this.metroPanel8);
            this.metroPanel7.Controls.Add(this.metroLabel8);
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(3, 254);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(200, 74);
            this.metroPanel7.TabIndex = 5;
            this.metroPanel7.UseStyleColors = true;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            // 
            // metroPanel8
            // 
            this.metroPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel8.Controls.Add(this.AutoSaveTextBox);
            this.metroPanel8.Controls.Add(this.metroLabel7);
            this.metroPanel8.Controls.Add(this.AutoSaveCheckbox);
            this.metroPanel8.HorizontalScrollbarBarColor = true;
            this.metroPanel8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel8.HorizontalScrollbarSize = 10;
            this.metroPanel8.Location = new System.Drawing.Point(0, 22);
            this.metroPanel8.Name = "metroPanel8";
            this.metroPanel8.Size = new System.Drawing.Size(198, 51);
            this.metroPanel8.TabIndex = 3;
            this.metroPanel8.UseStyleColors = true;
            this.metroPanel8.VerticalScrollbarBarColor = true;
            this.metroPanel8.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel8.VerticalScrollbarSize = 10;
            // 
            // AutoSaveTextBox
            // 
            // 
            // 
            // 
            this.AutoSaveTextBox.CustomButton.Image = null;
            this.AutoSaveTextBox.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.AutoSaveTextBox.CustomButton.Name = "";
            this.AutoSaveTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AutoSaveTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AutoSaveTextBox.CustomButton.TabIndex = 1;
            this.AutoSaveTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AutoSaveTextBox.CustomButton.UseSelectable = true;
            this.AutoSaveTextBox.CustomButton.Visible = false;
            this.AutoSaveTextBox.Lines = new string[0];
            this.AutoSaveTextBox.Location = new System.Drawing.Point(94, 19);
            this.AutoSaveTextBox.MaxLength = 32767;
            this.AutoSaveTextBox.Name = "AutoSaveTextBox";
            this.AutoSaveTextBox.PasswordChar = '\0';
            this.AutoSaveTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AutoSaveTextBox.SelectedText = "";
            this.AutoSaveTextBox.SelectionLength = 0;
            this.AutoSaveTextBox.SelectionStart = 0;
            this.AutoSaveTextBox.ShortcutsEnabled = true;
            this.AutoSaveTextBox.Size = new System.Drawing.Size(99, 23);
            this.AutoSaveTextBox.TabIndex = 6;
            this.AutoSaveTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AutoSaveTextBox.UseSelectable = true;
            this.AutoSaveTextBox.UseStyleColors = true;
            this.AutoSaveTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AutoSaveTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Location = new System.Drawing.Point(0, 19);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(88, 23);
            this.metroLabel7.TabIndex = 5;
            this.metroLabel7.Text = "Interval (ms)";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel7.UseStyleColors = true;
            // 
            // AutoSaveCheckbox
            // 
            this.AutoSaveCheckbox.AutoSize = true;
            this.AutoSaveCheckbox.Location = new System.Drawing.Point(3, 3);
            this.AutoSaveCheckbox.Name = "AutoSaveCheckbox";
            this.AutoSaveCheckbox.Size = new System.Drawing.Size(125, 15);
            this.AutoSaveCheckbox.TabIndex = 2;
            this.AutoSaveCheckbox.Text = "Enable Auto Saving";
            this.AutoSaveCheckbox.UseSelectable = true;
            this.AutoSaveCheckbox.UseStyleColors = true;
            this.AutoSaveCheckbox.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel8.Location = new System.Drawing.Point(0, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(198, 19);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "AutoSave Settings";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroPanel6
            // 
            this.metroPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel6.Controls.Add(this.metroLabel11);
            this.metroPanel6.Controls.Add(this.NoteLocationTextBox);
            this.metroPanel6.Controls.Add(this.DeleteNoteButton);
            this.metroPanel6.Controls.Add(this.NoteListView);
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(209, 3);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(374, 325);
            this.metroPanel6.TabIndex = 4;
            this.metroPanel6.UseStyleColors = true;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel11.Location = new System.Drawing.Point(3, 275);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(366, 19);
            this.metroLabel11.TabIndex = 6;
            this.metroLabel11.Text = "Waiting for selection...";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel11.UseStyleColors = true;
            // 
            // NoteLocationTextBox
            // 
            this.NoteLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.NoteLocationTextBox.CustomButton.Image = null;
            this.NoteLocationTextBox.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.NoteLocationTextBox.CustomButton.Name = "";
            this.NoteLocationTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NoteLocationTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NoteLocationTextBox.CustomButton.TabIndex = 1;
            this.NoteLocationTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NoteLocationTextBox.CustomButton.UseSelectable = true;
            this.NoteLocationTextBox.CustomButton.Visible = false;
            this.NoteLocationTextBox.Lines = new string[0];
            this.NoteLocationTextBox.Location = new System.Drawing.Point(3, 297);
            this.NoteLocationTextBox.MaxLength = 32767;
            this.NoteLocationTextBox.Name = "NoteLocationTextBox";
            this.NoteLocationTextBox.PasswordChar = '\0';
            this.NoteLocationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NoteLocationTextBox.SelectedText = "";
            this.NoteLocationTextBox.SelectionLength = 0;
            this.NoteLocationTextBox.SelectionStart = 0;
            this.NoteLocationTextBox.ShortcutsEnabled = true;
            this.NoteLocationTextBox.Size = new System.Drawing.Size(285, 23);
            this.NoteLocationTextBox.TabIndex = 5;
            this.NoteLocationTextBox.UseSelectable = true;
            this.NoteLocationTextBox.UseStyleColors = true;
            this.NoteLocationTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NoteLocationTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DeleteNoteButton
            // 
            this.DeleteNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteNoteButton.Location = new System.Drawing.Point(294, 297);
            this.DeleteNoteButton.Name = "DeleteNoteButton";
            this.DeleteNoteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteNoteButton.TabIndex = 4;
            this.DeleteNoteButton.Text = "Delete Note";
            this.DeleteNoteButton.UseSelectable = true;
            this.DeleteNoteButton.UseStyleColors = true;
            this.DeleteNoteButton.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // NoteListView
            // 
            this.NoteListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.NoteListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NoteListView.FullRowSelect = true;
            this.NoteListView.Location = new System.Drawing.Point(0, 0);
            this.NoteListView.Margin = new System.Windows.Forms.Padding(0);
            this.NoteListView.Name = "NoteListView";
            this.NoteListView.OwnerDraw = true;
            this.NoteListView.Size = new System.Drawing.Size(372, 270);
            this.NoteListView.TabIndex = 3;
            this.NoteListView.UseCompatibleStateImageBehavior = false;
            this.NoteListView.UseSelectable = true;
            this.NoteListView.UseStyleColors = true;
            this.NoteListView.View = System.Windows.Forms.View.Details;
            this.NoteListView.SelectedIndexChanged += new System.EventHandler(this.metroListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Note Name";
            this.columnHeader1.Width = 339;
            // 
            // metroPanel4
            // 
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel4.Controls.Add(this.metroPanel5);
            this.metroPanel4.Controls.Add(this.metroLabel5);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(3, 114);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(200, 135);
            this.metroPanel4.TabIndex = 3;
            this.metroPanel4.UseStyleColors = true;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroPanel5
            // 
            this.metroPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel5.Controls.Add(this.ThemeComboBox);
            this.metroPanel5.Controls.Add(this.metroLabel6);
            this.metroPanel5.Controls.Add(this.StyleComboBox);
            this.metroPanel5.Controls.Add(this.metroLabel4);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(0, 22);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(198, 111);
            this.metroPanel5.TabIndex = 3;
            this.metroPanel5.UseStyleColors = true;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.FormattingEnabled = true;
            this.ThemeComboBox.ItemHeight = 23;
            this.ThemeComboBox.Items.AddRange(new object[] {
            "Light",
            "Dark"});
            this.ThemeComboBox.Location = new System.Drawing.Point(3, 76);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(190, 29);
            this.ThemeComboBox.TabIndex = 7;
            this.ThemeComboBox.UseSelectable = true;
            this.ThemeComboBox.UseStyleColors = true;
            this.ThemeComboBox.SelectedIndexChanged += new System.EventHandler(this.metroComboBox3_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Location = new System.Drawing.Point(-2, 54);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(200, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Theme";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel6.UseStyleColors = true;
            // 
            // StyleComboBox
            // 
            this.StyleComboBox.FormattingEnabled = true;
            this.StyleComboBox.ItemHeight = 23;
            this.StyleComboBox.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Brown",
            "Lime",
            "Magenta",
            "Orange",
            "Pink",
            "Purple",
            "Red",
            "Silver",
            "Teal",
            "White",
            "Yellow"});
            this.StyleComboBox.Location = new System.Drawing.Point(3, 22);
            this.StyleComboBox.Name = "StyleComboBox";
            this.StyleComboBox.Size = new System.Drawing.Size(190, 29);
            this.StyleComboBox.TabIndex = 5;
            this.StyleComboBox.UseSelectable = true;
            this.StyleComboBox.UseStyleColors = true;
            this.StyleComboBox.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel4.Location = new System.Drawing.Point(0, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(196, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Style";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel5.Location = new System.Drawing.Point(0, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(198, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Color/Style Settings";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.metroPanel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(200, 105);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.UseStyleColors = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.ChangePasswordButton);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Controls.Add(this.ChangePasswordTextBox);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 22);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(198, 81);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.UseStyleColors = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(3, 51);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(190, 23);
            this.ChangePasswordButton.TabIndex = 4;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.UseSelectable = true;
            this.ChangePasswordButton.UseStyleColors = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel3.Location = new System.Drawing.Point(0, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(196, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Change Password";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel3.UseStyleColors = true;
            // 
            // ChangePasswordTextBox
            // 
            // 
            // 
            // 
            this.ChangePasswordTextBox.CustomButton.Image = null;
            this.ChangePasswordTextBox.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.ChangePasswordTextBox.CustomButton.Name = "";
            this.ChangePasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ChangePasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ChangePasswordTextBox.CustomButton.TabIndex = 1;
            this.ChangePasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ChangePasswordTextBox.CustomButton.UseSelectable = true;
            this.ChangePasswordTextBox.CustomButton.Visible = false;
            this.ChangePasswordTextBox.Lines = new string[0];
            this.ChangePasswordTextBox.Location = new System.Drawing.Point(3, 22);
            this.ChangePasswordTextBox.MaxLength = 32767;
            this.ChangePasswordTextBox.Name = "ChangePasswordTextBox";
            this.ChangePasswordTextBox.PasswordChar = '\0';
            this.ChangePasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ChangePasswordTextBox.SelectedText = "";
            this.ChangePasswordTextBox.SelectionLength = 0;
            this.ChangePasswordTextBox.SelectionStart = 0;
            this.ChangePasswordTextBox.ShortcutsEnabled = true;
            this.ChangePasswordTextBox.Size = new System.Drawing.Size(190, 23);
            this.ChangePasswordTextBox.TabIndex = 2;
            this.ChangePasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChangePasswordTextBox.UseSelectable = true;
            this.ChangePasswordTextBox.UseStyleColors = true;
            this.ChangePasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ChangePasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel2.Location = new System.Drawing.Point(0, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(198, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Password Settings";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.UseStyleColors = true;
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AutoSaveTimer
            // 
            this.AutoSaveTimer.Interval = 10000;
            this.AutoSaveTimer.Tick += new System.EventHandler(this.AutoSaveTimer_Tick);
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel10.Location = new System.Drawing.Point(24, 50);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(583, 23);
            this.metroLabel10.TabIndex = 1;
            this.metroLabel10.Text = "Version 1.1";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "NotebookPlus";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroPanel7.ResumeLayout(false);
            this.metroPanel8.ResumeLayout(false);
            this.metroPanel8.PerformLayout();
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox NoteTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox NoteNameTextBox;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton SaveButton;
        private MetroFramework.Controls.MetroComboBox NoteSelectionComboBox;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton ChangePasswordButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox ChangePasswordTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroComboBox StyleComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroComboBox ThemeComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private MetroFramework.Controls.MetroListView NoteListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private MetroFramework.Controls.MetroPanel metroPanel8;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroCheckBox AutoSaveCheckbox;
        private MetroFramework.Controls.MetroTextBox AutoSaveTextBox;
        private System.Windows.Forms.Timer AutoSaveTimer;
        private MetroFramework.Controls.MetroButton DeleteNoteButton;
        private MetroFramework.Controls.MetroTextBox NoteLocationTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}

