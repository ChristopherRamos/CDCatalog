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
    public partial class AddGenreForm : Form
    {
        public AddGenreForm()
        {
            InitializeComponent();
        }

        private int GetGenreId(string p)
        {
            try
            {
                using (var context = new CDCatalogContext())
                {

                    var genreID = context.Genres
                        .Where(a => a.Name.ToUpper() == p.ToString().ToUpper());

                    //First check to see if Genre already in database

                    if (genreID.Any())
                    {
                        return genreID.FirstOrDefault().ID;
                    }
                    else
                    {
                        // Genre is not in the database, Insert new genre and return ID
                        InsertNewGenre(p);

                        var genreID2 = context.Genres
                        .Where(a => a.Name.ToUpper() == p.ToString().ToUpper());

                        return genreID2.FirstOrDefault().ID;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem getting Genre Id:" + ex.Message.ToString());
                return 0;
            }
        }

        private static void InsertNewGenre(string p)
        {
            var genre = new Genre
            {
                Name = p
            };
            try
            { 
                using (var context = new CDCatalogContext())
                {
                    context.Genres.Add(genre);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem inserting Genre in the database:" + ex.Message.ToString());
            }
        }

        private void buttonAddGenre_Click(object sender, EventArgs e)
        {
            GetGenreId(textBoxAddGenre.Text);
        }
    }
}
