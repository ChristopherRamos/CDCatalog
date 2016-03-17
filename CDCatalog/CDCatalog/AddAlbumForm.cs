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
    public partial class AddAlbumForm : Form
    {
        public AddAlbumForm()
        {
            InitializeComponent();
            refreshComboBoxes();
        }

        private void btnAddCD_Click(object sender, EventArgs e)
        {

            var album = new Album
            {
                ArtistId = Convert.ToInt32(comboBoxAddCDArtist.SelectedValue),
                Title = textBoxAddCDTitle.Text,
                Year = Convert.ToInt32(numericUpDownAddCDYear.Value),
            };

            using (var context = new CDCatalogContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Albums.Add(album);
                context.SaveChanges();
            }

            refreshComboBoxes();
        }

        private void refreshComboBoxes()
        {
            using (var context = new CDCatalogContext())
            {
                var Artistlist = context.Artists.OrderBy(a => a.Name).ToList();
                var Genrelist = context.Genres.OrderBy(g => g.Name).ToList();
                var Songlist = context.Songs.OrderBy(s => s.Title).ToList();
                var CDlist = context.Albums.OrderBy(c => c.Title).ToList();

                var MergedSongCDlist = new List<CombinedSongsAlbums>();

                foreach (var item in Songlist)
                {
                    MergedSongCDlist.Add(new CombinedSongsAlbums()
                    {
                        Title = "Song - " + item.Title,
                        ID = item.Id,
                        AssetType = "Song"
                    });

                }

                foreach (var item in CDlist)
                {
                    MergedSongCDlist.Add(new CombinedSongsAlbums()
                    {
                        Title = "CD - " + item.Title,
                        ID = item.Id,
                        AssetType = "Album"
                    });
                }

                this.comboBoxAddCDArtist.DataSource = Artistlist;
                this.comboBoxAddCDArtist.DisplayMember = "Name";
                this.comboBoxAddCDArtist.ValueMember = "ID";
            }
        }
    }
}
