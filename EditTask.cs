using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook_.NET_Framework_v._1._0
{
    public partial class EditTask : Form
    {
        public EditTask()
        {
            InitializeComponent();
            comboBoxEnum.DataSource = Enum.GetValues(typeof(EnumTask));
            addTime.Format = DateTimePickerFormat.Time;
            addTime.Enabled = false;
        }

        private void checkBoxTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTime.Checked)
            {
                addTime.Enabled = true;
            }
            else
            {
                addTime.Enabled = false;
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdOk_Click(object sender, EventArgs e)
        {

        }
    }
}
