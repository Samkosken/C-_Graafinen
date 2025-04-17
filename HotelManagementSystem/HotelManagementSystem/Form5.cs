using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Huoneikkuna : Form
    {
        Class4 huoneet = new Class4();
        public Huoneikkuna()
        {
            InitializeComponent();
        }

        private void tyhjennaBT_Click(object sender, EventArgs e)
        {
            huoneNroTB.Text = "";
            huonetyyppiCB.SelectedIndex = 0;
            puhelinTB.Text = "";

        }

        private void huoneetDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            huoneNroTB.Text = huoneetDG.CurrentRow.Cells[0].Value.ToString();
            huonetyyppiCB.SelectedValue = huoneetDG.CurrentRow.Cells[1].Value.ToString();
            puhelinTB.Text = huoneetDG.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void lisaaUusiHuoneBT_Click(object sender, EventArgs e)
        {
            String hunumero = huoneNroTB.Text;
            String hutyyppi = huonetyyppiCB.SelectedValue.ToString();
            String puhelin = puhelinTB.Text;
           
            
            if (huoneet.LisaaHuone(hunumero, hutyyppi, puhelin, "Kyllä"))
            {
                MessageBox.Show("Huone lisätty onnistuneesti", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huonetta ei voitu lisätä", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            huoneetDG.DataSource = huoneet.HaeHuoneet();
        }

        private void muokkaaBT_Click(object sender, EventArgs e)
        {
            String hunumero = huoneNroTB.Text;
            String hutyyppi = huonetyyppiCB.SelectedValue.ToString();
            String puhelin = puhelinTB.Text;
            String vapaa = "";
            
            
            if (kyllaRB.Checked)
            {
                vapaa = "Kyllä";
            }
            else
            {
                vapaa = "Ei";
            }
            if (huoneet.MuokkaaHuone(hunumero, hutyyppi, puhelin, vapaa))
            {    
                MessageBox.Show("Huone muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huonetta ei voitu muokata", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            huoneetDG.DataSource = huoneet.HaeHuoneet();
        }

        private void poistaBT_Click(object sender, EventArgs e)
        {
            String hunumero = huoneNroTB.Text;
            if (huoneet.PoistaHuone(hunumero))
            {
                huoneetDG.DataSource = huoneet.HaeHuoneet();
                MessageBox.Show("Huone poistettu onnistuneesti", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huonetta ei pystytty poistamaan", "Huöne poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaBT.PerformClick();
        }

        private void Huoneikkuna_Load(object sender, EventArgs e)
        {
            huonetyyppiCB.DataSource = huoneet.HaeHuoneTyyppi();
            huonetyyppiCB.DisplayMember = "huonetyyppi";
            huonetyyppiCB.ValueMember = "kategoriaid";

            huoneetDG.DataSource = huoneet.HaeHuoneet();
        }
    }
}
