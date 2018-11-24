using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _13_11_2018.Models;

namespace _13_11_2018
{
    public partial class AddStadium : Form
    {
        StadiumEntities db = new StadiumEntities();
        private Form1 MainForm;
        public AddStadium(Form1 form)
        {
            MainForm = form;
            InitializeComponent();
        }

        private void btnAddStadium_Click(object sender, EventArgs e)
        {
            int countError = 0;
            if (string.IsNullOrEmpty(txtStdName.Text))
            {
                countError++;
                LblstdName.ForeColor = Color.IndianRed;
            }
            else
            {
                countError--;
                LblstdName.ForeColor = SystemColors.ControlText;
            }
            if (countError>0)
            {
                return;
            }


            if (db.Areas.FirstOrDefault(a=>a.Name==txtStdName.Text)==null)
            {
                Area area = new Area
                {
                    Name = txtStdName.Text
                };
                db.Areas.Add(area);
                db.SaveChanges();

                MainForm.GiveFromDatabaseStadiumName(area);

                this.Close();
            }
            else
            {
                MessageBox.Show("Yazdiginiz adli stadion bazada movcuddur");
                txtStdName.Text = "";
            }
              
        }
    }
}
