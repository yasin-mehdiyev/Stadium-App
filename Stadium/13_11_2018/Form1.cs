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
    public partial class Form1 : Form
    {

        StadiumEntities db = new StadiumEntities();

        private TimeSpan starttime = new TimeSpan(10, 0, 0);
        private TimeSpan endtime = new TimeSpan(2, 0, 0);

        public Form1()
        {
            InitializeComponent();
            FillCategoryAll();
            FillCmbStadiumData();
            fillGame();
        }


        #region Register

        private void FillCmbStadiumData()
        {
            cmbStadium.Items.Clear();
            cmbFltrStad.Items.Clear();
            foreach (Area area in db.Areas.ToList())
            {
                cmbStadium.Items.Add(area.Name);
                cmbFltrStad.Items.Add(area.Name);
            }
        }


        private void FillHours()
        {
            if (string.IsNullOrEmpty(cmbStadium.Text))
            {
                MessageBox.Show("Ilk olaraq meydança seçin");
                return;
            }

          
            cmbHours.Items.Clear();
            cmbHours.Text = "";

            LblPerson.Visible = false;
            cmbPerson.Visible = false;
            AddPerson.Visible = false;
            AddDatabaseDatas.Visible = false;
            cmbPerson.Items.Clear();
            cmbPerson.Text = "";
         

            Area areas = db.Areas.FirstOrDefault(a => a.Name == cmbStadium.Text);

            int interval = (int)(endtime.Subtract(starttime).TotalHours + 24);

            TimeSpan tmp = starttime;

            for (int i = 0; i < interval; i++)
            {
                int count = db.Bookings.Where(b => b.AreasId == areas.Id && b.Date == dtpStadiumDate.Value.Date && b.Time == tmp).Count();

                if (count==0)
                {
                    cmbHours.Items.Add(tmp.ToString(@"hh\:mm"));
                }

                tmp = tmp.Add(new TimeSpan(1, 0, 0));
                if (tmp.Hours==0)
                {
                    tmp = new TimeSpan(0, 0, 0);
                }
            }
        }

        private void cmbStadium_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillHours();
        }

        private void dtpStadiumDate_ValueChanged(object sender, EventArgs e)
        {
            FillHours();
        }

        private void FillContactsData()
        {
            cmbPerson.Items.Clear();
            foreach (Contact cnt in db.Contacts.OrderBy(c=>c.Name).OrderBy(c=>c.Surname).ToList())
            {
                cmbPerson.Items.Add(cnt.Name + " " + cnt.Surname + "-" + cnt.Phone);
            }
        }

        private void cmbHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbHours.Text))
            {
                FillContactsData();
                LblPerson.Visible = true;
                cmbPerson.Visible = true;
                AddPerson.Visible = true;
                AddDatabaseDatas.Visible = true;
            }
        }

        public void GiveFromDatabase(Contact cnt)
        {
            FillContactsData();
            cmbPerson.SelectedItem = cnt.Name + " " + cnt.Surname + "-" + cnt.Phone;
        }

        public void GiveFromDatabaseStadiumName(Area area)
        {
            FillCmbStadiumData();
            cmbStadium.SelectedItem = area.Name;
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            AddUser user = new AddUser(this);
            user.ShowDialog();
        }

        private void btnAddStat_Click(object sender,EventArgs e)
        {
            AddStadium stadium = new AddStadium(this);
            stadium.ShowDialog();

        }

        private void AddDatabaseDatas_Click(object sender, EventArgs e)
        {
            // ONCELIK FILTER MENTIQI
            if (string.IsNullOrEmpty(cmbStadium.Text))
            {
                MessageBox.Show("Stadionu secin");
                return;
            }
            if (string.IsNullOrEmpty(cmbHours.Text))
            {
                MessageBox.Show("Saatı seçin");
                return;
            }
            if (string.IsNullOrEmpty(cmbPerson.Text))
            {
                MessageBox.Show("Şəxsi secin");
                return;
            }

           
            TimeSpan time = new TimeSpan(Convert.ToInt32(cmbHours.Text.Split(':')[0]), 0, 0);

            string phone = cmbPerson.Text.Split('-')[1];


            DateTime dtp = dtpStadiumDate.Value.Date;

            if (time.Hours < starttime.Hours)
            {
                dtp = dtp.AddDays(1);
            }

            Booking book = NewMethod(time, phone, dtp);
            db.Bookings.Add(book);
            db.SaveChanges();

            //Reset Actions

            cmbHours.Items.Clear();
            cmbHours.Text = "";

            LblPerson.Visible = false;
            cmbPerson.Visible = false;
            AddPerson.Visible = false;
            AddDatabaseDatas.Visible = false;
            cmbPerson.Items.Clear();
            cmbPerson.Text = "";

            dtpStadiumDate.Value = DateTime.Now;
            cmbStadium.Text = "";
        }

        private Booking NewMethod(TimeSpan time, string phone, DateTime date)
        {
            return new Booking
            {
                AreasId = db.Areas.FirstOrDefault(a => a.Name == cmbStadium.Text).Id,
                Date = date,
                Time = time,
                ContactsId = db.Contacts.FirstOrDefault(c => c.Phone == phone).Id,
                CreatedAt = DateTime.Now
            };
        }
        #endregion


        #region ShowAllGames


        private void fillGame()
        {
            foreach (Booking item in db.Bookings.Where(b=>b.Date==dtpFltDate.Value.Date).OrderBy(b=>b.Area.Name).ThenBy(b=>b.Time).ToList())
            {
                dgwPlaysforDate.Rows.Add(item.Id,
                                         item.Area.Name,
                                         item.Contact.Name + " " + item.Contact.Surname,
                                         item.Contact.Phone,
                                         item.Date.ToString("dd.MM.yyyy"),
                                         item.Time.ToString(@"hh\:mm"));
            }
        }

        private void FillCategoryAll()
        {
            cmbFltrStad.Items.Add("Hamısı");
            cmbFltrStad.SelectedItem = "Hamısı";
        }

        private void Btnfilter_Click(object sender, EventArgs e)
        {
            dgwPlaysforDate.Rows.Clear();
            int stadiumId = 0;

            if (!string.IsNullOrEmpty(cmbFltrStad.Text) && cmbFltrStad.Text!= "Hamısı")
            {
                stadiumId = db.Areas.FirstOrDefault(a => a.Name == cmbFltrStad.Text).Id;
            }
            List<Booking> bookings = db.Bookings.Where(b => b.Date == dtpFltDate.Value.Date && (stadiumId != 0 ? b.AreasId == stadiumId : true)).OrderBy(b => b.Area.Name).ThenBy(b => b.Time).ToList();

            foreach (Booking item in bookings)
            {
                dgwPlaysforDate.Rows.Add(item.Id,
                                         item.Area.Name,
                                         item.Contact.Name + " " + item.Contact.Surname,
                                         item.Contact.Phone,
                                         item.Date.ToString("dd.MM.yyyy"),
                                         item.Time.ToString(@"hh\:mm"));
            }
        }


        #endregion


    }
}
