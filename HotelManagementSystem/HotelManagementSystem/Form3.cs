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
    public partial class paaikkunaForm : Form
    {
        public paaikkunaForm()
        {
            InitializeComponent();
        }

        private void paaikkunaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void hallitseAsiakkaitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asiakkaidenHallintaForm ahlomeke = new asiakkaidenHallintaForm();
            ahlomeke.ShowDialog();
        }

        private void hallitseVarauksiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            varaustenHallintaForm vhlomake = new varaustenHallintaForm();
            vhlomake.ShowDialog();
        }

        private void hallitseHuoneitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Huoneikkuna hhlomake = new Huoneikkuna();
            hhlomake.ShowDialog();
        }
    }
}
