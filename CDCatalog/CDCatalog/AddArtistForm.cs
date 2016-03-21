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
    public partial class AddArtistForm : Form
    {
        public AddArtistForm()
        {
            InitializeComponent();
        }

        private int GetArtistId(string p)
        {
            try
            {
                using (var context = new CDCatalogContext())
                {
                    var artistid = context.Artists
                        .Where(a => a.Name.ToUpper() == p.ToString().ToUpper());

                    //First check to see if Artist already in database

                    if (artistid.Any())
                    {
                        return artistid.FirstOrDefault().ID;
                    }
                    else
                    {
                        // Artist is not in the database, Insert new artist and return ID
                        InsertNewArtist(p);

                        var artistid2 = context.Artists
                        .Where(a => a.Name.ToUpper() == p.ToString().ToUpper());

                        return artistid2.FirstOrDefault().ID;
                    }
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show("There was a problem getting the Artist ID:" + ex.Message.ToString());
                 return 0;
            }
        }

        private static void InsertNewArtist(string p)
        {
            var artist = new Artist
            {
                Name = p
            };

            try
            {
                using (var context = new CDCatalogContext())
                {
                    context.Artists.Add(artist);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem inserting an Artist into the database:" + ex.Message.ToString());
            }
        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            GetArtistId(textBoxAddArtist.Text);
        }
    }
}
