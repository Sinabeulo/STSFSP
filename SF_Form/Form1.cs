using SF_Form.DgvSample;
using SF_Form.EncrySample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SF_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_DgvSample_Click(object sender, EventArgs e)
        {
            DataGridViewSample form = new DataGridViewSample();
            form.ShowDialog();
        }

        private void btn_SimpleEncryption_Click(object sender, EventArgs e)
        {
            SimpleEncryptionForm form = new SimpleEncryptionForm();
            form.ShowDialog();
        }
    }
}
