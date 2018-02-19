namespace The_Database_Project
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._vhs = new System.Windows.Forms.CheckBox();
            this._dvd = new System.Windows.Forms.CheckBox();
            this._blueray = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this._home = new System.Windows.Forms.CheckBox();
            this._loaned = new System.Windows.Forms.CheckBox();
            this._loanedToLabel = new System.Windows.Forms.Label();
            this._mTitle = new System.Windows.Forms.TextBox();
            this._mLoaned = new System.Windows.Forms.TextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this._mID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Action = new System.Windows.Forms.CheckBox();
            this.Anime = new System.Windows.Forms.CheckBox();
            this.Animated = new System.Windows.Forms.CheckBox();
            this.Comedy = new System.Windows.Forms.CheckBox();
            this.Drama = new System.Windows.Forms.CheckBox();
            this.Documentary = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Children = new System.Windows.Forms.CheckBox();
            this.Horror = new System.Windows.Forms.CheckBox();
            this.Thriller = new System.Windows.Forms.CheckBox();
            this.Scifi = new System.Windows.Forms.CheckBox();
            this.sqLiteConnection1 = new System.Data.SQLite.SQLiteConnection();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type :";
            // 
            // _vhs
            // 
            this._vhs.AutoSize = true;
            this._vhs.Location = new System.Drawing.Point(30, 123);
            this._vhs.Name = "_vhs";
            this._vhs.Size = new System.Drawing.Size(48, 17);
            this._vhs.TabIndex = 3;
            this._vhs.Text = "VHS";
            this._vhs.UseVisualStyleBackColor = true;
            this._vhs.CheckedChanged += new System.EventHandler(this._vhs_CheckedChanged);
            // 
            // _dvd
            // 
            this._dvd.AutoSize = true;
            this._dvd.Location = new System.Drawing.Point(30, 146);
            this._dvd.Name = "_dvd";
            this._dvd.Size = new System.Drawing.Size(49, 17);
            this._dvd.TabIndex = 4;
            this._dvd.Text = "DVD";
            this._dvd.UseVisualStyleBackColor = true;
            this._dvd.CheckedChanged += new System.EventHandler(this._dvd_CheckedChanged);
            // 
            // _blueray
            // 
            this._blueray.AutoSize = true;
            this._blueray.Location = new System.Drawing.Point(30, 169);
            this._blueray.Name = "_blueray";
            this._blueray.Size = new System.Drawing.Size(69, 17);
            this._blueray.TabIndex = 5;
            this._blueray.Text = "Blue Ray";
            this._blueray.UseVisualStyleBackColor = true;
            this._blueray.CheckedChanged += new System.EventHandler(this._blueray_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Location :";
            // 
            // _home
            // 
            this._home.AutoSize = true;
            this._home.Location = new System.Drawing.Point(30, 229);
            this._home.Name = "_home";
            this._home.Size = new System.Drawing.Size(54, 17);
            this._home.TabIndex = 7;
            this._home.Text = "Home";
            this._home.UseVisualStyleBackColor = true;
            this._home.CheckedChanged += new System.EventHandler(this._home_CheckedChanged);
            // 
            // _loaned
            // 
            this._loaned.AutoSize = true;
            this._loaned.Location = new System.Drawing.Point(30, 252);
            this._loaned.Name = "_loaned";
            this._loaned.Size = new System.Drawing.Size(82, 17);
            this._loaned.TabIndex = 8;
            this._loaned.Text = "Loaned Out";
            this._loaned.UseVisualStyleBackColor = true;
            this._loaned.CheckedChanged += new System.EventHandler(this._loaned_CheckedChanged);
            // 
            // _loanedToLabel
            // 
            this._loanedToLabel.AutoSize = true;
            this._loanedToLabel.Location = new System.Drawing.Point(130, 253);
            this._loanedToLabel.Name = "_loanedToLabel";
            this._loanedToLabel.Size = new System.Drawing.Size(65, 13);
            this._loanedToLabel.TabIndex = 9;
            this._loanedToLabel.Text = "Loaned To :";
            // 
            // _mTitle
            // 
            this._mTitle.Location = new System.Drawing.Point(52, 35);
            this._mTitle.Name = "_mTitle";
            this._mTitle.Size = new System.Drawing.Size(604, 20);
            this._mTitle.TabIndex = 10;
            // 
            // _mLoaned
            // 
            this._mLoaned.Location = new System.Drawing.Point(201, 249);
            this._mLoaned.Name = "_mLoaned";
            this._mLoaned.Size = new System.Drawing.Size(369, 20);
            this._mLoaned.TabIndex = 11;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Grid.Location = new System.Drawing.Point(12, 341);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid.Size = new System.Drawing.Size(644, 163);
            this.Grid.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Movie List";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(581, 123);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(581, 94);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 16;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID : ";
            // 
            // _mID
            // 
            this._mID.Location = new System.Drawing.Point(52, 60);
            this._mID.Name = "_mID";
            this._mID.Size = new System.Drawing.Size(100, 20);
            this._mID.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Genre :";
            // 
            // Action
            // 
            this.Action.AutoSize = true;
            this.Action.Location = new System.Drawing.Point(9, 30);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(56, 17);
            this.Action.TabIndex = 20;
            this.Action.Text = "Action";
            this.Action.UseVisualStyleBackColor = true;
            this.Action.CheckedChanged += new System.EventHandler(this.Action_CheckedChanged);
            // 
            // Anime
            // 
            this.Anime.AutoSize = true;
            this.Anime.Location = new System.Drawing.Point(9, 54);
            this.Anime.Name = "Anime";
            this.Anime.Size = new System.Drawing.Size(55, 17);
            this.Anime.TabIndex = 21;
            this.Anime.Text = "Anime";
            this.Anime.UseVisualStyleBackColor = true;
            this.Anime.CheckedChanged += new System.EventHandler(this.Anime_CheckedChanged);
            // 
            // Animated
            // 
            this.Animated.AutoSize = true;
            this.Animated.Location = new System.Drawing.Point(9, 78);
            this.Animated.Name = "Animated";
            this.Animated.Size = new System.Drawing.Size(70, 17);
            this.Animated.TabIndex = 22;
            this.Animated.Text = "Animated";
            this.Animated.UseVisualStyleBackColor = true;
            this.Animated.CheckedChanged += new System.EventHandler(this.Animated_CheckedChanged);
            // 
            // Comedy
            // 
            this.Comedy.AutoSize = true;
            this.Comedy.Location = new System.Drawing.Point(110, 52);
            this.Comedy.Name = "Comedy";
            this.Comedy.Size = new System.Drawing.Size(64, 17);
            this.Comedy.TabIndex = 23;
            this.Comedy.Text = "Comedy";
            this.Comedy.UseVisualStyleBackColor = true;
            this.Comedy.CheckedChanged += new System.EventHandler(this.Comedy_CheckedChanged);
            // 
            // Drama
            // 
            this.Drama.AutoSize = true;
            this.Drama.Location = new System.Drawing.Point(110, 78);
            this.Drama.Name = "Drama";
            this.Drama.Size = new System.Drawing.Size(57, 17);
            this.Drama.TabIndex = 24;
            this.Drama.Text = "Drama";
            this.Drama.UseVisualStyleBackColor = true;
            this.Drama.CheckedChanged += new System.EventHandler(this.Drama_CheckedChanged);
            // 
            // Documentary
            // 
            this.Documentary.AutoSize = true;
            this.Documentary.Location = new System.Drawing.Point(191, 29);
            this.Documentary.Name = "Documentary";
            this.Documentary.Size = new System.Drawing.Size(89, 17);
            this.Documentary.TabIndex = 25;
            this.Documentary.Text = "Documentary";
            this.Documentary.UseVisualStyleBackColor = true;
            this.Documentary.CheckedChanged += new System.EventHandler(this.Documentary_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Children);
            this.panel1.Controls.Add(this.Horror);
            this.panel1.Controls.Add(this.Thriller);
            this.panel1.Controls.Add(this.Scifi);
            this.panel1.Controls.Add(this.Documentary);
            this.panel1.Controls.Add(this.Drama);
            this.panel1.Controls.Add(this.Comedy);
            this.panel1.Controls.Add(this.Animated);
            this.panel1.Controls.Add(this.Anime);
            this.panel1.Controls.Add(this.Action);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(133, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 106);
            this.panel1.TabIndex = 26;
            // 
            // Children
            // 
            this.Children.AutoSize = true;
            this.Children.Location = new System.Drawing.Point(110, 29);
            this.Children.Name = "Children";
            this.Children.Size = new System.Drawing.Size(69, 17);
            this.Children.TabIndex = 29;
            this.Children.Text = "Childrens";
            this.Children.UseVisualStyleBackColor = true;
            this.Children.CheckedChanged += new System.EventHandler(this.Children_CheckedChanged);
            // 
            // Horror
            // 
            this.Horror.AutoSize = true;
            this.Horror.Location = new System.Drawing.Point(191, 52);
            this.Horror.Name = "Horror";
            this.Horror.Size = new System.Drawing.Size(55, 17);
            this.Horror.TabIndex = 28;
            this.Horror.Text = "Horror";
            this.Horror.UseVisualStyleBackColor = true;
            this.Horror.CheckedChanged += new System.EventHandler(this.Horror_CheckedChanged);
            // 
            // Thriller
            // 
            this.Thriller.AutoSize = true;
            this.Thriller.Location = new System.Drawing.Point(291, 29);
            this.Thriller.Name = "Thriller";
            this.Thriller.Size = new System.Drawing.Size(57, 17);
            this.Thriller.TabIndex = 27;
            this.Thriller.Text = "Thriller";
            this.Thriller.UseVisualStyleBackColor = true;
            this.Thriller.CheckedChanged += new System.EventHandler(this.Thriller_CheckedChanged);
            // 
            // Scifi
            // 
            this.Scifi.AutoSize = true;
            this.Scifi.Location = new System.Drawing.Point(191, 75);
            this.Scifi.Name = "Scifi";
            this.Scifi.Size = new System.Drawing.Size(100, 17);
            this.Scifi.TabIndex = 26;
            this.Scifi.Text = "Sci-Fi / Fanatsy";
            this.Scifi.UseVisualStyleBackColor = true;
            this.Scifi.CheckedChanged += new System.EventHandler(this.Scifi_CheckedChanged);
            // 
            // sqLiteConnection1
            // 
            this.sqLiteConnection1.ConnectionString = "data source=\"D:\\Database Project\\The Database Project\\Database\\movie.s3db\"";
            this.sqLiteConnection1.DefaultTimeout = 30;
            this.sqLiteConnection1.Flags = ((System.Data.SQLite.SQLiteConnectionFlags)((System.Data.SQLite.SQLiteConnectionFlags.LogCallbackException | System.Data.SQLite.SQLiteConnectionFlags.LogModuleException)));
            this.sqLiteConnection1.ParseViaFramework = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(391, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 509);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._mID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this._mLoaned);
            this.Controls.Add(this._mTitle);
            this.Controls.Add(this._loanedToLabel);
            this.Controls.Add(this._loaned);
            this.Controls.Add(this._home);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._blueray);
            this.Controls.Add(this._dvd);
            this.Controls.Add(this._vhs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Database";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox _vhs;
        private System.Windows.Forms.CheckBox _dvd;
        private System.Windows.Forms.CheckBox _blueray;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox _home;
        private System.Windows.Forms.CheckBox _loaned;
        private System.Windows.Forms.Label _loanedToLabel;
        private System.Windows.Forms.TextBox _mTitle;
        private System.Windows.Forms.TextBox _mLoaned;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _mID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox Action;
        private System.Windows.Forms.CheckBox Anime;
        private System.Windows.Forms.CheckBox Animated;
        private System.Windows.Forms.CheckBox Comedy;
        private System.Windows.Forms.CheckBox Drama;
        private System.Windows.Forms.CheckBox Documentary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Children;
        private System.Windows.Forms.CheckBox Horror;
        private System.Windows.Forms.CheckBox Thriller;
        private System.Windows.Forms.CheckBox Scifi;
        private System.Data.SQLite.SQLiteConnection sqLiteConnection1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}

