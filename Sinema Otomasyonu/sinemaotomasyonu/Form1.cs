using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace sinemaotomasyonu
{
    public partial class FrmAcilis : Form
    {
        public FrmAcilis()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            formbiletal frm2 = new formbiletal();
            frm2.ShowDialog();
            
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmAcilis_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.ShowDialog();
        }
    }
}
