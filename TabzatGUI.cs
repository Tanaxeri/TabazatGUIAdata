using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabazatGUIAdata
{
    public partial class TabzatGUI : Form
    {
        Database adat = new Database("localhost", "root", "", "gyumolcsok");
        public TabzatGUI()
        {
            InitializeComponent();
        }

        private void TabzatGUI_Load(object sender, EventArgs e)
        {
            numericUpDown_EgysegAr.Maximum = Decimal.MaxValue;
            numericUpDown_Mennyiseg.Maximum = Decimal.MaxValue;
            DataGridView_felepitese();
            DataGridView_update();

        }

        private void DataGridView_update()
        {

            dataGridView_Gyumolcsok.Rows.Clear();

            foreach(GyumolcsAdat rekord in adat.getAllGyumolcs())
            {

                //-- Rekord adatainak beírása egy sor cellájába --
                int SorIndex = dataGridView_Gyumolcsok.Rows.Add();
                DataGridViewRow getujsor =  dataGridView_Gyumolcsok.Rows[SorIndex];
                getujsor.Cells["id"].Value = rekord.Id;
                getujsor.Cells["nev"].Value = rekord.Gyumnev;
                getujsor.Cells["egysegar"].Value = rekord.Egysegar;
                getujsor.Cells["mennyiseg"].Value = rekord.Mennyiseg;

            }

        }

        private void DataGridView_felepitese()
        {
            
            DataGridViewColumn col_ID = new DataGridViewColumn();
            {

                //--col_ID jellemzőinek a beállításai ------
                col_ID.Name = "id";
                col_ID.ReadOnly = true;
                col_ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ID.HeaderText = "Gyümölcs azonosító";

            }
            dataGridView_Gyumolcsok.Columns.Add(col_ID);

            DataGridViewColumn col_Nev = new DataGridViewColumn();
            {

                col_Nev.Name = "nev";
                col_Nev.HeaderText = "Gyümölcs név";
                col_Nev.CellTemplate = new DataGridViewTextBoxCell();

            }
            dataGridView_Gyumolcsok.Columns.Add(col_Nev);

            DataGridViewColumn col_Egysegar = new DataGridViewColumn();
            {

                col_Egysegar.Name = "egysegar";
                col_Egysegar.HeaderText = "Gyümölcs egységára";
                col_Egysegar.CellTemplate = new DataGridViewTextBoxCell();

            }
            dataGridView_Gyumolcsok.Columns.Add(col_Egysegar);

            DataGridViewColumn col_Mennyiseg = new DataGridViewColumn();
            {

                col_Mennyiseg.Name = "mennyiseg";
                col_Mennyiseg.HeaderText = "Gyümölcs mennyisége";
                col_Mennyiseg.CellTemplate = new DataGridViewTextBoxCell();

            }
            dataGridView_Gyumolcsok.Columns.Add(col_Mennyiseg);

            //-- Egész táblázatra vonatkozó beállítások --
            dataGridView_Gyumolcsok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void dataGridView_Gyumolcsok_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView_Gyumolcsok.SelectedRows[0];
            if (row.Cells["id"].Value == null)
            {

                return;

            }
            textBox_Gyumazonosito.Text = row.Cells["id"].Value.ToString();
            textBox_GyumNev.Text = row.Cells["nev"].Value.ToString();
            numericUpDown_EgysegAr.Value = decimal.Parse(row.Cells["egysegar"].Value.ToString());
            numericUpDown_Mennyiseg.Value = decimal.Parse(row.Cells["mennyiseg"].Value.ToString());

        }
    }
}
