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
    public partial class frmIddia : Form
    {
        public frmIddia()
        {
            InitializeComponent();
        }
        public string konu
        {
            get { return txtKonu.Text; }
            set { txtKonu.Text = value; }
        }
        public string aciklama
        {
            get { return txtAciklama.Text; }
            set { txtAciklama.Text = value; }
        }
        public DateTime tarih
        {
            get { return dtpTarih.Value; }
            set { dtpTarih.Value = value; }
        }
        public string sahip
        {
            get { return txtSahip.Text; }
            set { txtSahip.Text = value; }
        }
        public string durum
        {
            get { return txtDurum.Text; }
            set { txtDurum.Text = value; }
        }

        private void bnTamam_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
