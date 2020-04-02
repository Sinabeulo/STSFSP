using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace SF_Form.Common
{
    public class CommonCode
    {
        private static CommonCode _instance;
        public static CommonCode Method
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CommonCode();
                }
                return _instance;
            }
        }

        public bool CheckStateWhenFormClosing(ControlCollection collection)
        {
            foreach (var control in collection) 
            {
                if (!(control is DataGridView dgv)) continue;

                if (!(dgv.DataSource is DataTable table)) continue;

                // Row 상태 확인하여 메시지 출력
                foreach (DataRow row in table.Rows)
                {
                    if (row.RowState != DataRowState.Unchanged)
                    {
                        var result = MessageBox.Show("저장되지 않은 항목이 있습니다. 종료하시겠습니까?", "알림", MessageBoxButtons.OKCancel);

                        if (result == DialogResult.Cancel)  // 아니오
                        {
                            //e.Cancel = true; // 이벤트 취소 == 예
                            return true;
                        }
                        else if (result == DialogResult.OK)  // 예
                        {
                            //e.Cancel = false; // 이벤트 취소 == 아니오
                            return false;
                        }
                    }
                }
            }
            return false;
        }

    }
}
