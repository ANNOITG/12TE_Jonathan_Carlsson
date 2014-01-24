using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQ_projct
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bandDGV.DataSource = bandBS;
            bandBS.DataSource = from data in db.Bands
                                select data;

            recordDGV.DataSource = recordBS;
            recordBS.DataSource = from data in db.Records
                                  select data;

            bandCbx.DataSource = from data in db.Bands
                                 orderby data.Band_Name
                                 select data;
            bandCbx.DisplayMember = "Band_Name";
            bandCbx.ValueMember = "Band_ID";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bandBS.DataSource = from allBands in db.Bands select allBands;
        }

        private void bandAddBtn_Click(object sender, EventArgs e)
        {
            Band b = new Band();

            try
            {
                b.Band_Name = bandNameTbx.Text;
                b.Members = int.Parse(bandCountTbx.Text);
                b.From_Location = bandFromTbx.Text;
                b.Info = bandInfoTbx.Text;
                b.Startyear = bandStartYearTbx.Text;

                db.Bands.InsertOnSubmit(b);
                db.SubmitChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            bandBS.DataSource = from data in db.Bands
                                orderby data.Band_Name
                                select data;
            bandCbx.DataSource = from cbxData in db.Bands
                                 orderby cbxData.Band_Name
                                 select cbxData;

        }

        private void bandRemoveBtn_Click(object sender, EventArgs e)
        {
            if (bandDGV.SelectedRows.Count == 1)
            {
                int selected_id = (int)bandDGV.SelectedRows[0].Cells[0].Value;
                Band b = db.Bands.Single(band => band.Band_ID == selected_id);
                db.Bands.DeleteOnSubmit(b);
                db.SubmitChanges();

                bandBS.DataSource = from data in db.Bands
                                    orderby data.Band_Name
                                    select data;
                bandCbx.DataSource = from cbxData in db.Bands
                                     orderby cbxData.Band_Name
                                     select cbxData;
            }
        }

        int changeState = 0;
        int tempID;
        private void bandChangeBtn_Click(object sender, EventArgs e)
        {
            if (changeState == 0)
            {
                if (bandDGV.SelectedRows.Count == 1)
                {
                    int selected_id = (int)bandDGV.SelectedRows[0].Cells[0].Value;

                    Band b = db.Bands.Single(band => band.Band_ID == selected_id);

                    tempID = b.Band_ID;
                    bandNameTbx.Text = b.Band_Name;
                    bandCountTbx.Text = b.Members.ToString();
                    bandFromTbx.Text = b.From_Location;
                    bandInfoTbx.Text = b.Info;
                    bandStartYearTbx.Text = b.Startyear;

                    changeState = 1;
                    bandBS.DataSource = from data in db.Bands
                                        orderby data.Band_Name
                                        select data;
                    bandCbx.DataSource = from cbxData in db.Bands
                                         orderby cbxData.Band_Name
                                         select cbxData;
                }
            }
            else
            {
                try
                {
                    Band b = db.Bands.Single(band => band.Band_ID == tempID);
                    b.Band_Name = bandNameTbx.Text;
                    b.Members = int.Parse(bandCountTbx.Text);
                    b.From_Location = bandFromTbx.Text;
                    b.Info = bandInfoTbx.Text;
                    b.Startyear = bandStartYearTbx.Text;

                    db.SubmitChanges();
                    bandBS.DataSource = from data in db.Bands
                                        orderby data.Band_Name
                                        select data;
                    bandCbx.DataSource = from cbxData in db.Bands
                                         orderby cbxData.Band_Name
                                         select cbxData;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                changeState = 0;
            }
        }

        private void bandSrchBtn_Click(object sender, EventArgs e)
        {
            if (bandSrchTbx.Text.Trim().Length > 0)
            {
                string srchWord = bandSrchTbx.Text.Trim().ToLower();

                var srchResult = from result in db.Bands
                                 where result.Band_ID.ToString().Contains(srchWord)
                                   || result.Band_Name.ToLower().Contains(srchWord)
                                   || result.Members.ToString().Contains(srchWord)
                                   || result.From_Location.ToLower().Contains(srchWord)
                                   || result.Info.ToLower().Contains(srchWord)
                                   || result.Startyear.Contains(srchWord)
                                 orderby result.Band_Name
                                 select result;

                bandBS.DataSource = srchResult;
            }
            else
            {
                bandBS.DataSource = from data in db.Bands
                                    orderby data.Band_Name
                                    select data;
                bandCbx.DataSource = from cbxData in db.Bands
                                     orderby cbxData.Band_Name
                                     select cbxData;
            }
        }

        private void recordSaveBtn_Click(object sender, EventArgs e)
        {
            Record r = new Record();

            try
            {
                r.Record_name = recordNameTbx.Text;
            }

        }

        private void recordChangeBtn_Click(object sender, EventArgs e)
        {

        }

        private void recordRemoveBtn_Click(object sender, EventArgs e)
        {

        }

        private void recordSearchBtn_Click(object sender, EventArgs e)
        {

        }
    }
}