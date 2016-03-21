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
    public partial class AddSongForm : Form
    {
        public AddSongForm()
        {
            InitializeComponent();
            refreshComboBoxes();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
           
            int alId = Convert.ToInt32(comboBoxAddSongAlbum.SelectedValue);
            var song = new Song
            {
                ArtistId = Convert.ToInt32(comboBoxAddSongArtist.SelectedValue),
                Title = textBoxAddSongTitle.Text,
                AlbumId = Convert.ToInt32(comboBoxAddSongAlbum.SelectedValue),
                TrackNumber = Convert.ToInt32(numericUpDownAddSongTrackNumber.Value),
                GenreID = Convert.ToInt32(comboBoxAddSongGenre.SelectedValue),
                TrackLength = Convert.ToInt32(numericUpDownAddSongTrackLength.Value),
            };

            try
            {
                using (var context = new CDCatalogContext())
                    {
                        if (context.Songs.Any(x => x.AlbumId == alId && x.Title == textBoxAddSongTitle.Text))
                        {
                          MessageBox.Show("Cannot add duplicate songs on the same album ");
                        }
                        else
                        {
                          context.Songs.Add(song);
                          context.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem adding/saving this song:" + ex.Message.ToString());
                }
        }
        
        private void refreshComboBoxes()
        {
            try
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

                    this.comboBoxAddSongArtist.DataSource = Artistlist;
                    this.comboBoxAddSongArtist.DisplayMember = "Name";
                    this.comboBoxAddSongArtist.ValueMember = "ID";

                    this.comboBoxAddSongAlbum.DataSource = CDlist;
                    this.comboBoxAddSongAlbum.DisplayMember = "Title";
                    this.comboBoxAddSongAlbum.ValueMember = "Id";

                    this.comboBoxAddSongGenre.DataSource = Genrelist;
                    this.comboBoxAddSongGenre.DisplayMember = "Name";
                    this.comboBoxAddSongGenre.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem refreshing combo boxes:" + ex.Message.ToString());
            }

        }
    }
}
