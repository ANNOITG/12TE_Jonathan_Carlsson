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
                                select data;

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
                                    select data;
            }
        }
    }
}
