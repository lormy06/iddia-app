using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace io_Neset_Goktug_Gorukoglu.UI
{
    public partial class frmBahis : Form
    {
        public frmBahis()
        {
            InitializeComponent();
        }

        public string bahis_yapan
        {
            get { return txtAd.Text; }
            set { txtAd.Text = value; }
        }
        public string bahis_miktari
        {
            get { return txtMiktar.Text; }
            set { txtMiktar.Text = value; }
        }
        public DateTime bahis_tarihi
        {
            get { return dtpBahisTarih.Value; }
            set { dtpBahisTarih.Value = value; }
        }
        public string bahis_durumu
        {
            get { return txtDurum.Text; }
            set { txtDurum.Text = value; }
        }


        private void frmBahis_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
