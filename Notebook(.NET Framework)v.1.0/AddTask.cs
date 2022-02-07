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
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
            comboBoxEnum.DataSource = Enum.GetValues(typeof(EnumTask));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTime.Checked)
            {
                numericHour.Enabled = true;
                numericMinute.Enabled = true;
            }
            else
            {
                numericHour.Enabled = false;
                numericMinute.Enabled = false;
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
