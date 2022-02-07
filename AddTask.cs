using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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
            addTime.Format = DateTimePickerFormat.Time;
            addTime.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
            DateTime date = new DateTime(dateAddTask.Value.Ticks);
            DateTime s = new DateTime(addTime.Value.Ticks);            
            string s1 = date.ToLongDateString();
            string s2 = s.ToShortTimeString();
            //string markedTime = "'" + s2 + "'";
            //string markedDate = "'" + s1 + "'";

            DataBases db = new DataBases();

            if (checkBoxTime.Checked)
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `tasks` (`type`, `headTask`, `detailTask`, `date`, `time`) VALUES (@typeTask, @headerTask, @detailTask, @dataTask, @timeTask) ", db.getConnection());
                command.Parameters.Add("@typeTask", MySqlDbType.VarChar).Value = comboBoxEnum.Text;
                command.Parameters.Add("@headerTask", MySqlDbType.VarChar).Value = headTask.Text;
                command.Parameters.Add("@detailTask", MySqlDbType.VarChar).Value = detailTask.Text;
                command.Parameters.Add("@dataTask", MySqlDbType.VarChar).Value = s1;
                command.Parameters.Add("@timeTask", MySqlDbType.VarChar).Value = s2;

                /*ПРОВЕРКА НА СУЩЕСТВУЮЩИЕ ЗАПИСИ В ЗАДАВАЕМОЕ ВРЕМЯ*/
                string checkSQLRowws = "SELECT  count(*) FROM `tasks` WHERE date = " + "'" + s1 + "'" + "AND time =" + "'" + s2 + "'";
                db.OpenConnection();
                MySqlCommand cmdCheck = new MySqlCommand(checkSQLRowws, db.getConnection());
                int totalRows = GetRowsCount(cmdCheck);
                if (totalRows > 0)
                {
                    MessageBox.Show("Измените дату или время. Ячейка занята.");
                    return;
                }
                /*ПРОВЕРКА НА СУЩЕСТВУЮЩИЕ ЗАПИСИ В ЗАДАВАЕМОЕ ВРЕМЯ*/

                //db.OpenConnection();
                command.ExecuteNonQuery();                
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `tasks` (`type`, `headTask`, `detailTask`, `date`, `time`) VALUES (@typeTask, @headerTask, @detailTask, @dataTask, @timeTask)", db.getConnection());
                cmd.Parameters.Add("@typeTask", MySqlDbType.VarChar).Value = comboBoxEnum.Text;
                cmd.Parameters.Add("@headerTask", MySqlDbType.VarChar).Value = headTask.Text;
                cmd.Parameters.Add("@detailTask", MySqlDbType.VarChar).Value = detailTask.Text;
                cmd.Parameters.Add("@dataTask", MySqlDbType.VarChar).Value = s1;
                cmd.Parameters.Add("@timeTask", MySqlDbType.VarChar).Value = "-";


                db.OpenConnection();
                cmd.ExecuteNonQuery();
            }
            db.CloseConnection();
            this.Close();            
        }

        public static int GetRowsCount(MySqlCommand command)
        {
            int rowsCount = Convert.ToInt32(command.ExecuteScalar());
            return rowsCount;
        }

    }
}
