using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SF_Form.EncrySample
{
    public partial class SimpleEncryptionForm : Form
    {
        private SelectType _selectedType;

        public SimpleEncryptionForm()
        {
            InitializeComponent();

            rb_Type1.CheckedChanged += RadioButtonCheckedChanged;
            rb_Type2.CheckedChanged += RadioButtonCheckedChanged;
            rb_Type3.CheckedChanged += RadioButtonCheckedChanged;

            rb_Type3.Select();
        }

        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            switch((sender as RadioButton).Text)
            {
                case nameof(SelectType.SimpleEncry):
                    _selectedType = SelectType.SimpleEncry;
                    break;
                case nameof(SelectType.AES128):
                    _selectedType = SelectType.AES128;
                    break;
                case nameof(SelectType.AES256):
                    _selectedType = SelectType.AES256;
                    break;
            }
        }

        private void btn_Encry_Click(object sender, EventArgs e)
        {
            switch (_selectedType)
            {
                case SelectType.AES128:
                    tb_Encry.Text = AESEncrypt.AES.AES128Encry(tb_Plain.Text, tb_EnKey.Text);
                    break;
                case SelectType.AES256:
                    tb_Encry.Text = AESEncrypt.AES.AES256Encry(tb_Plain.Text, tb_EnKey.Text);
                    break;
                case SelectType.SimpleEncry:
                    tb_Encry.Text = SimpleEncryption.EnDecry.LineEncry(tb_Plain.Text, tb_EnKey.Text);
                    break;
            }
        }

        private void btn_Decry_Click(object sender, EventArgs e)
        {
            switch (_selectedType)
            {
                case SelectType.AES128:
                    tb_Plain.Text = AESEncrypt.AES.AES128Decry(tb_Encry.Text, tb_DecKey.Text);
                    break;
                case SelectType.AES256:
                    tb_Plain.Text = AESEncrypt.AES.AES256Decry(tb_Encry.Text, tb_DecKey.Text);
                    break;
                case SelectType.SimpleEncry:
                    tb_Plain.Text = SimpleEncryption.EnDecry.LineDecry(tb_Encry.Text, tb_DecKey.Text);
                    break;
            }
        }
    }

    enum SelectType
    {
        SimpleEncry,
        AES128,
        AES256,
    }
}
