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
    public partial class PlaylistForm : Form
    {
        public PlaylistForm()
        {
            InitializeComponent();
        }

        private void generatePlaylist(int maxplaylistLength)
        {
            try
            {
                using (var context = new CDCatalogContext())
                {
                
                    var SongArtistAlbumList =
                                         from ts in context.Songs
                                         join n in context.Artists on ts.ArtistId equals n.ID
                                         join a in context.Albums on ts.AlbumId equals a.Id
                                         where ts.TrackLength <= maxplaylistLength
                                         //changes index numbers (shuffles list)
                                         orderby Guid.NewGuid()
                                         select new { ts, n, a };

                    var playlistDetails = new List<Details>();

                    int totalTime = 0;

                    //If a song is less than the max playlist length and if added to the playlist will make 
                    //the total playlist time less than or equal to the max playlist length, then add the song to the playlist.
                    foreach (var item in SongArtistAlbumList)
                    {
                        int songTrackLength = item.ts.TrackLength;

                        if (songTrackLength <= maxplaylistLength && (totalTime + songTrackLength) <= maxplaylistLength)
                        {
                            playlistDetails.Add(new Details()
                            {
                                Title = item.ts.Title.ToString(),
                                Artist = item.n.Name,
                                AlbumTitle = item.a.Title,
                                TrackLength = item.ts.TrackLength
                            });

                            totalTime = totalTime + songTrackLength;
                        }

                    }

                    dataGridViewPlaylist.DataSource = playlistDetails;
                    dataGridViewPlaylist.Columns[0].Visible = false;
                    dataGridViewPlaylist.Columns[4].Visible = false;
                    dataGridViewPlaylist.Columns[5].Visible = false;
                    dataGridViewPlaylist.Columns[7].Visible = false;
                    dataGridViewPlaylist.Columns[8].Visible = false;
                }
            }
            catch (Exception ex)
            {
              MessageBox.Show("There was a problem generating playlist:" + ex.Message.ToString());
            }
        }

        private void buttonCreatePlaylist_Click(object sender, EventArgs e)
        {
            int playlistlength = (Convert.ToInt32(numericUpDownCreatePlaylist.Value)) * 60;
            generatePlaylist(playlistlength);
        }
    }
}
