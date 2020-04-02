using SF_Form.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SF_Form.DgvSample
{
    public partial class OtherForm : Form
    { // 소스용 테이블
        public DataTable MasterSource = new DataTable();
        public DataTable DetailSource = new DataTable();

        // 구분용 숫자
        private int _masterIdx;
        private int _detailIdx;

        // 난수
        private Random random = new Random();

        public OtherForm()
        {
            InitializeComponent();

            // 마스터 그리드 뷰 컬럼 설정
            MasterSource.Columns.Add("Name");
            MasterSource.Columns.Add("Age");

            // 디테일 그리드 뷰 컬럼 설정
            DetailSource.Columns.Add("City");
            DetailSource.Columns.Add("Post-Code");

            // 그리드 뷰 소스 설정
            DGV_MasterB.DataSource = MasterSource;
            DGV_DetailB.DataSource = DetailSource;
        }

        private void btn_Add_MasterB_Click(object sender, EventArgs e)
        {
            DetailSource.Rows.Add("city " + _detailIdx, random.Next(30000, 80000));
            _detailIdx++;
        }

        private void btn_Add_DetailB_Click(object sender, EventArgs e)
        {
            MasterSource.Rows.Add("name " + _masterIdx, random.Next(10, 80));
            _masterIdx++;
        }

        private void OtherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = CommonCode.Method.CheckStateWhenFormClosing(this.Controls);
        }
    }
}
