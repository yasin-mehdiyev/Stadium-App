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
    public partial class AddUser : Form
    {
        StadiumEntities db = new StadiumEntities();
        private Form1 HomeForm;
        public AddUser(Form1 frm)
        {
            HomeForm = frm;
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            int countError = 0;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                countError++;
                LblName.ForeColor = Color.IndianRed;
            }
            else
            {
                countError--;
                LblName.ForeColor = SystemColors.ControlText;
            }

            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                countError++;
                LblSurname.ForeColor = Color.IndianRed;
            }
            else
            {
                countError--;
                LblSurname.ForeColor = SystemColors.ControlText;
            }

            if (string.IsNullOrEmpty(TxtPhone.Text))
            {
                countError++;
                LblPhone.ForeColor = Color.IndianRed;
            }
            else
            {
                countError--;
                LblPhone.ForeColor = SystemColors.ControlText;
            }

            if (countError>0)
            {
                return;
            }

            //Database-də textboxa yazilan telefon nomrəsini tapmirsa (FirstOrDefault-null qaytarir)
            //First ise hemin datani tapmiyanda error verir
            
            if (db.Contacts.FirstOrDefault(c=>c.Phone==TxtPhone.Text)==null)
            {
                Contact cnt = new Contact
                {
                    Name=txtName.Text,
                    Surname=txtSurname.Text,
                    Phone=TxtPhone.Text
                };

                db.Contacts.Add(cnt);
                db.SaveChanges();

                HomeForm.GiveFromDatabase(cnt);

                this.Close();

            }


        }
    }
}
