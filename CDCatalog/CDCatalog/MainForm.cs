using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDCatalog
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildFormsExcept("AddAlbumForm");
            this.IsMdiContainer = true;
            var AddAlbumForm = new AddAlbumForm();
            AddAlbumForm.MdiParent = this;
            AddAlbumForm.WindowState = FormWindowState.Maximized;
            AddAlbumForm.Show();
        }

        private void songToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildFormsExcept("AddSongForm");
            this.IsMdiContainer = true;
            var AddSongForm = new AddSongForm();
            AddSongForm.MdiParent = this;
            AddSongForm.WindowState = FormWindowState.Maximized;
            AddSongForm.Show();
        }

        public void CloseChildFormsExcept(string name)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                if (Application.OpenForms[i].Name != name && Application.OpenForms[i].Name !="MainForm")
                    Application.OpenForms[i].Close();
        }

        private void byArtistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildFormsExcept("SearchForm");
            this.IsMdiContainer = true;
            var SearchForm = new SearchForm("Artist");
            SearchForm.MdiParent = this;
            SearchForm.WindowState = FormWindowState.Maximized;
            SearchForm.Show();
        }

        private void byGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildFormsExcept("SearchForm");
            this.IsMdiContainer = true;
            var SearchForm = new SearchForm("Genre");
            SearchForm.MdiParent = this;
            SearchForm.WindowState = FormWindowState.Maximized;
            SearchForm.Show();
        }

        private void byTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildFormsExcept("SearchForm");
            this.IsMdiContainer = true;
            var SearchForm = new SearchForm("Title");
            SearchForm.MdiParent = this;
            SearchForm.WindowState = FormWindowState.Maximized;
            SearchForm.Show();
        }

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildFormsExcept("PlaylistForm");
            this.IsMdiContainer = true;
            var PlaylistForm = new PlaylistForm();
            PlaylistForm.MdiParent = this;
            PlaylistForm.WindowState = FormWindowState.Maximized;
            PlaylistForm.Show();
        }

        private void rateAlbumSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildFormsExcept("RateForm");
            this.IsMdiContainer = true;
            var RateForm = new RateForm();
            RateForm.MdiParent = this;
            RateForm.WindowState = FormWindowState.Maximized;
            RateForm.Show();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildFormsExcept("AddGenreForm");
            this.IsMdiContainer = true;
            var AddGenreForm = new AddGenreForm();
            AddGenreForm.MdiParent = this;
            AddGenreForm.WindowState = FormWindowState.Maximized;
            AddGenreForm.Show();
        }

        private void artistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildFormsExcept("AddArtistForm");
            this.IsMdiContainer = true;
            var AddArtistForm = new AddArtistForm();
            AddArtistForm.MdiParent = this;
            AddArtistForm.WindowState = FormWindowState.Maximized;
            AddArtistForm.Show();
        }
    }
}