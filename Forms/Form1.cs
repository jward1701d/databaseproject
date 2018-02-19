using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace The_Database_Project
{
    public partial class Form1 : Form
    {
        #region Variables
        string _type;
        string t_vhs;
        string t_dvd;
        string t_bluray;

        string title;
        string id;

        string g_action, g_anime, g_animated, g_childrens, g_comedy, g_drama, g_documentary, g_horror, g_scifi, g_thriller;
        string _genre;

        string _location;
        string l_home, l_loaned;

        string[] tableHeading = { "@mID", "@mTitle", "@mType", "@mGenre", "@mLocation", "@mLoaned" };
        string[] table = {" "," "," "," "," "," "};
        DBmanager db = new DBmanager();
        #endregion

        #region Constrctor
        public Form1()
        {
            InitializeComponent();
            Grid.DataSource = db.UpdateDataGrid(sqLiteConnection1);
            Grid.CellMouseDown += new DataGridViewCellMouseEventHandler(Grid_CellMouseDown);
        }
        #endregion

        #region Exit Menu Option
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Update Button
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (_mTitle.Text == "" || _mID.Text == "")
                return;
            title = _mTitle.Text;
            id = _mID.Text;
            _type = t_vhs + " " + t_dvd + " " + t_bluray;

            _genre = g_action + g_anime +  g_animated +  g_childrens +  g_comedy +  g_documentary +  g_drama +  g_horror +  g_scifi +  g_thriller;
            _location = l_home + " "+ l_loaned;
            textBox1.Text = "";
            try
            {
                string SQL = "UPDATE MOVIES SET Title = @mTitle, Type = @mType, ";
                SQL += "Genre = @mGenre, Location = @mLocation,LoanedTo = @mLoaned WHERE ID = @mID";
                table[0] = id;
                table[1] = title;
                table[2] = _type;
                table[3] = _genre;
                table[4] = _location;
                table[5] = _mLoaned.Text;
                
                db.UpdateData(tableHeading, table, SQL, sqLiteConnection1);

                Grid.DataSource = db.UpdateDataGrid(sqLiteConnection1);
            }
            catch
            {
                MessageBox.Show("Updating database failed.", "Error", MessageBoxButtons.OK);
            }
            Reset();
        }
        #endregion

        #region AddButton
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (_mTitle.Text == "" || _mID.Text == "")
                return;
            title = _mTitle.Text;
            id = _mID.Text;
            _type = t_vhs + " " + t_dvd + " " + t_bluray;
            _genre = g_action + g_anime + g_animated + g_childrens + g_comedy + g_documentary + g_drama + g_horror + g_scifi + g_thriller;
            _location = l_home +" "+ l_loaned;
            textBox1.Text = "";
            try
            {
                string SQL = "INSERT INTO MOVIES (ID,Title,Type,Genre,Location,LoanedTo) VALUES";
                SQL += "( @mID, @mTitle, @mType, @mGenre, @mLocation, @mLoaned)";
                table[0] = id;
                table[1] = title;
                table[2] = _type;
                table[3] = _genre;
                table[4] = _location;
                table[5] = _mLoaned.Text;
                db.AddData(tableHeading, table, SQL, sqLiteConnection1);
               
                Grid.DataSource = db.UpdateDataGrid(sqLiteConnection1);
            }
            catch
            {
                MessageBox.Show("ID or Title already exist.", "Error", MessageBoxButtons.OK);
            }
            Reset();
        }
        #endregion

        #region Delete Button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                db.DeleteData(_mID.Text, sqLiteConnection1);
                Grid.DataSource = db.UpdateDataGrid(sqLiteConnection1);

                #region Reset
                Reset();
                #endregion


            }
            catch
            {
                MessageBox.Show("Entry deletion failed.", "Error", MessageBoxButtons.OK);
            }
        }
        #endregion

        #region Media Type
        private void _vhs_CheckedChanged(object sender, EventArgs e)
        {
            if (_vhs.Checked)
                t_vhs = "VHS";
            if (!_vhs.Checked)
                t_vhs = "";
        }

        private void _dvd_CheckedChanged(object sender, EventArgs e)
        {
            if (_dvd.Checked)
                t_dvd = "DVD";
            if (!_dvd.Checked)
                t_dvd = "";
        }

        private void _blueray_CheckedChanged(object sender, EventArgs e)
        {
            if (_blueray.Checked)
                t_bluray = "BlueRay";
            if (!_blueray.Checked)
                t_bluray = "";
        }
        #endregion

        #region Genre
        private void Action_CheckedChanged(object sender, EventArgs e)
        {
            if (Action.Checked)
            {
                g_action = "Action ";
            }
            if (!Action.Checked)
                g_action = " ";
        }

        private void Anime_CheckedChanged(object sender, EventArgs e)
        {
            if (Anime.Checked)
            {
                g_anime = "Anime ";
            }
            if (!Anime.Checked)
                g_anime = " ";
        }

        private void Animated_CheckedChanged(object sender, EventArgs e)
        {
            if (Animated.Checked)
            {
                g_animated = "Animated ";
            }
            if (!Animated.Checked)
                g_animated = " ";
        }

        private void Children_CheckedChanged(object sender, EventArgs e)
        {
            if (Children.Checked)
            {
                g_childrens = "Childrens ";
            }
            if (!Children.Checked)
                g_childrens = " ";
        }

        private void Comedy_CheckedChanged(object sender, EventArgs e)
        {
            if (Comedy.Checked)
            {
                g_comedy = "Comedy ";
            }
            if (!Comedy.Checked)
                g_comedy = " ";
        }

        private void Drama_CheckedChanged(object sender, EventArgs e)
        {
            if (Drama.Checked)
            {
                g_drama = "Drama ";
            }
            if (!Drama.Checked)
                g_drama = " ";
        }

        private void Documentary_CheckedChanged(object sender, EventArgs e)
        {
            if (Documentary.Checked)
            {
                g_documentary = "Documentary ";
            }
            if (!Documentary.Checked)
                g_documentary = " ";
        }

        private void Horror_CheckedChanged(object sender, EventArgs e)
        {
            if (Horror.Checked)
            {
                g_horror = "Horror ";
            }
            if (!Horror.Checked)
                g_horror = " ";
        }

        private void Scifi_CheckedChanged(object sender, EventArgs e)
        {
            if (Scifi.Checked)
            {
                g_scifi = "Scifi/Fantasy ";
            }
            if (!Scifi.Checked)
                g_scifi = " ";
        }

        private void Thriller_CheckedChanged(object sender, EventArgs e)
        {
            if (Thriller.Checked)
            {
                g_thriller = "Thriller ";
            }
            if (!Thriller.Checked)
                g_thriller = " ";
        }
        #endregion

        #region Location
        private void _home_CheckedChanged(object sender, EventArgs e)
        {
            if (_home.Checked)
            {
                _loaned.Checked = false;
                _loaned.Enabled = false;
                _loanedToLabel.Enabled = false;
                _mLoaned.Enabled = false;
                l_home = "Home";
                _mLoaned.Text = "";
            }
            if (!_home.Checked)
            {
                _loaned.Enabled = true;
                _loanedToLabel.Enabled = true;
                _mLoaned.Enabled = true;
                l_home = "";
            }
        }

        private void _loaned_CheckedChanged(object sender, EventArgs e)
        {
            if (_loaned.Checked)
            {
                _home.Enabled = false;
                l_loaned = "Loaned";
            }
            if (!_loaned.Checked)
            {
                _home.Enabled = true;
                l_loaned = "";
            }

        }
        #endregion

        #region GRID MOUSE CLICK
        private void Grid_CellMouseDown(Object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                _mID.Text = "";
                _mTitle.Text = "";
                _mLoaned.Text = "";
                textBox1.Text = "";

                _mID.Text = Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                _mTitle.Text = Grid.Rows[e.RowIndex].Cells[1].Value.ToString();
               _mLoaned.Text = Grid.Rows[e.RowIndex].Cells[5].Value.ToString();



                if (Grid.Rows[e.RowIndex].Cells[2].Value.ToString() != null)
                {
                    #region CHECKBOX DEFUALTS
                    _vhs.Checked = false;
                    _dvd.Checked = false;
                    _blueray.Checked = false;
                    Action.Checked = false;
                    Anime.Checked = false;
                    Animated.Checked = false;
                    Children.Checked = false;
                    Comedy.Checked = false;
                    Drama.Checked = false;
                    Documentary.Checked = false;
                    Horror.Checked = false;
                    Scifi.Checked = false;
                    Thriller.Checked = false;
                    _home.Checked = false;
                    _loaned.Checked = false;
                    #endregion

                    #region TYPE CHECKBOXES
                    var type = Grid.Rows[e.RowIndex].Cells[2].Value.ToString().Split(' ');
                    if(type.Contains<string>("VHS"))
                        _vhs.Checked = true;
                    if(type.Contains<string>("DVD"))
                        _dvd.Checked = true;
                    if(type.Contains<string>("BlueRay"))
                        _blueray.Checked = true;
                    #endregion

                    #region GENRE CHECKBOXES
                    var genre = Grid.Rows[e.RowIndex].Cells[3].Value.ToString().Split(' ');
                    if (genre.Contains<string>("Action"))
                        Action.Checked = true;
                    if (genre.Contains<string>("Anime"))
                        Anime.Checked = true;
                    if (genre.Contains<string>("Animated"))
                        Animated.Checked = true;
                    if (genre.Contains<string>("Childrens"))
                        Children.Checked = true;
                    if (genre.Contains<string>("Comedy"))
                        Comedy.Checked = true;
                    if (genre.Contains<string>("Drama"))
                        Drama.Checked = true;
                    if (genre.Contains<string>("Documentary"))
                        Documentary.Checked = true;
                    if (genre.Contains<string>("Horror"))
                        Horror.Checked = true;
                    if (genre.Contains<string>("Scifi/Fantasy"))
                        Scifi.Checked = true;
                    if (genre.Contains<string>("Thriller"))
                        Thriller.Checked = true;
                    #endregion

                    #region Location CHECKBOXES
                    var location = Grid.Rows[e.RowIndex].Cells[4].Value.ToString().Split(' ');
                    if (location.Contains<string>("Home"))
                        _home.Checked = true;
                    if (location.Contains<string>("Loaned"))
                        _loaned.Checked = true;
                    #endregion
                }
            }
        }

        #endregion

        #region ABOUT BOX
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            DialogResult dialogResult = about.ShowDialog();
        }
        #endregion

        #region Search function
        // handles searching the data grid based on the user input.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(db.UpdateDataGrid(sqLiteConnection1));
            DV.RowFilter = string.Format("title LIKE '%{0}%'", textBox1.Text);
            Grid.DataSource = DV;
            if (textBox1.Text == " ")
            {
                Grid.DataSource = db.UpdateDataGrid(sqLiteConnection1);
            }
        }
        #endregion

        #region RESET
        private void Reset()
        {
            _mID.Text = "";
            _mTitle.Text = "";
            _mLoaned.Text = "";
            textBox1.Text = "";
            _vhs.Checked = false;
            _dvd.Checked = false;
            _blueray.Checked = false;
            Action.Checked = false;
            Anime.Checked = false;
            Animated.Checked = false;
            Children.Checked = false;
            Comedy.Checked = false;
            Drama.Checked = false;
            Documentary.Checked = false;
            Horror.Checked = false;
            Scifi.Checked = false;
            Thriller.Checked = false;
            _home.Checked = false;
            _loaned.Checked = false;
        }
        #endregion
    }
}
