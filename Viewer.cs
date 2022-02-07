using MySql.Data.MySqlClient;
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
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
            DataGridViewCellStyle style = dataGridContent.ColumnHeadersDefaultCellStyle;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridContent.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn DateTask;
            DateTask = new DataGridViewTextBoxColumn();
            DateTask.Name = "dateTasks";
            DateTask.HeaderText = "Дата";
            DateTask.Width = 80;

            DataGridViewTextBoxColumn Completed;
            Completed = new DataGridViewTextBoxColumn();
            Completed.Name = "completed";
            Completed.HeaderText = "Выполнено";
            Completed.Width = 70;
            
            DataGridViewTextBoxColumn TimeTasks;
            TimeTasks = new DataGridViewTextBoxColumn();
            TimeTasks.Name = "timeTasks";
            TimeTasks.HeaderText = "Время";
            TimeTasks.Width = 70;

            DataGridViewTextBoxColumn TypeTasks;
            TypeTasks = new DataGridViewTextBoxColumn();
            TypeTasks.Name = "typeTasks";
            TypeTasks.HeaderText = "Тип задачи";
            TypeTasks.Width = 90;

            DataGridViewTextBoxColumn HeadTask;
            HeadTask = new DataGridViewTextBoxColumn();
            HeadTask.Name = "headTasks";
            HeadTask.HeaderText = "Краткое содержание";
            HeadTask.Width = 200;

            DataGridViewTextBoxColumn DetailTasks;
            DetailTasks = new DataGridViewTextBoxColumn();
            DetailTasks.Name = "detailTasks";
            DetailTasks.HeaderText = "Подробное содержание задачи";
            DetailTasks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridContent.Columns.AddRange(new DataGridViewColumn[] { Completed, DateTask, TimeTasks, TypeTasks, HeadTask, DetailTasks });            
        }

        private void updateDataGridDetail()
        {
            dataGridContent.Rows.Clear();
            /*Получение выбранной даты*/
            string dateDetail = "'" + labelViewer.Text + "'";
            /*Запрос Sql*/
            string sqlComandUpdateDetail = "SELECT completed, date, time, type, headTask, detailTask FROM tasks WHERE date =" + dateDetail + "ORDER BY ABS (time)";

            /*выборка и показ данных в dataGrid*/
            /*Подключение к базе данных*/
            DataBases dataBasesDetail = new DataBases();
            dataBasesDetail.OpenConnection();
            MySqlCommand cmdUpdateDetail = new MySqlCommand
                (sqlComandUpdateDetail, dataBasesDetail.getConnection());
            MySqlDataReader rd = cmdUpdateDetail.ExecuteReader();
            List<string[]> listStr = new List<string[]>();
            while (rd.Read())
            {
                listStr.Add(new string[6]);
                listStr[listStr.Count - 1][0] = rd[0].ToString();
                listStr[listStr.Count - 1][1] = rd[1].ToString();
                listStr[listStr.Count - 1][2] = rd[2].ToString();
                listStr[listStr.Count - 1][3] = rd[3].ToString();
                listStr[listStr.Count - 1][4] = rd[4].ToString();
                listStr[listStr.Count - 1][5] = rd[5].ToString();
            }

            foreach (string[] str in listStr)
            {
                dataGridContent.Rows.Add(str);
            }
            rd.Close();
            dataBasesDetail.CloseConnection();
            for (int i = 0; i < (dataGridContent.Rows.Count); i++)
            {
                if (dataGridContent.Rows[i].Cells[0].Value.ToString() == "True")
                {
                    completedTasks(i);
                }
            }

        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateDataGridDetail();            
        }

        private void dataGridContent_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestNode = dataGridContent.HitTest(e.X, e.Y);

                if (hitTestNode.RowIndex != -1)
                {
                    dataGridContent.ClearSelection();
                    dataGridContent.Rows[hitTestNode.RowIndex].Selected = true;
                    dataGridContent.CurrentCell = dataGridContent.Rows[hitTestNode.RowIndex].Cells[0];
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridContent.CurrentRow.Index;

            string type;
            string header;
            string timeTask;
            string dateTask = "'" + labelViewer.Text + "'";
            string completedTask;
            string id;
            string searchIdSql;

            type = "'" + dataGridContent.Rows[indexRow].Cells["typeTasks"].Value.ToString() + "'";
            header = "'" + dataGridContent.Rows[indexRow].Cells["headTasks"].Value.ToString() + "'";
            timeTask = "'" + dataGridContent.Rows[indexRow].Cells["timeTasks"].Value.ToString() + "'";
            dateTask = "'" + labelViewer.Text + "'";
            completedTask = dataGridContent.Rows[indexRow].Cells["completed"].Value.ToString();

            searchIdSql = "SELECT ID FROM `tasks` WHERE type = " + type + "AND " + "headTask = " + header + " AND " + " date = " + dateTask + " AND " + " time = " + timeTask;

            DataBases db = new DataBases();
            db.OpenConnection();
            MySqlCommand searchIdCmd = new MySqlCommand(searchIdSql, db.getConnection());
            MySqlDataReader rd = searchIdCmd.ExecuteReader();
            rd.Read();
            id = rd["id"].ToString();
            db.CloseConnection();

            DataBases dbase = new DataBases();
            dbase.OpenConnection();
            string deleteCompletedCmd = "DELETE FROM tasks WHERE id = " + id;
            MySqlCommand deleteRowSql = new MySqlCommand(deleteCompletedCmd, dbase.getConnection());
            deleteRowSql.ExecuteNonQuery();
            rd.Close();
            db.CloseConnection();
            deleteRow(indexRow);
            updateDataGridDetail();
        }

        private void выполненоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridContent.CurrentRow.Index;
            
            string type;
            string header;
            string timeTask;
            string dateTask = "'" + labelViewer.Text + "'";
            string completedTask;
            string id;
            string searchIdSql;

            type = "'" + dataGridContent.Rows[indexRow].Cells["typeTasks"].Value.ToString() + "'";
            header = "'" + dataGridContent.Rows[indexRow].Cells["headTasks"].Value.ToString() + "'";
            timeTask = "'" + dataGridContent.Rows[indexRow].Cells["timeTasks"].Value.ToString() + "'";
            dateTask = "'" + labelViewer.Text + "'";
            completedTask = dataGridContent.Rows[indexRow].Cells["completed"].Value.ToString();
            
            searchIdSql = "SELECT ID FROM `tasks` WHERE type = " + type + "AND " + "headTask = " +
                "" + header + " AND " + " date = " + dateTask + " AND " + " time = " + timeTask;
            

            DataBases db = new DataBases();
            db.OpenConnection();
            MySqlCommand searchIdCmd = new MySqlCommand(searchIdSql, db.getConnection());
            MySqlDataReader rd = searchIdCmd.ExecuteReader();
            rd.Read();
            id = rd["id"].ToString();
            rd.Close();            
            string updateCompletedCmd = "UPDATE `tasks` SET completed = true WHERE id = " + id;
            MySqlCommand updateCompletedSql = new MySqlCommand
                (updateCompletedCmd, db.getConnection());
            updateCompletedSql.ExecuteNonQuery();
            db.CloseConnection();
            updateDataGridDetail();
        }

        private void completedTasks(int indexRow)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new Font(dataGridContent.Font.OriginalFontName, 9, FontStyle.Bold);
            dataGridContent.Rows[indexRow].DefaultCellStyle.ApplyStyle(style);
            dataGridContent.Rows[indexRow].DefaultCellStyle.BackColor = Color.Green;
        }

        private void deleteRow(int indexRow)
        {
            dataGridContent.Rows.RemoveAt(indexRow);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm.EditTask(dataGridContent);
        }
    }
}
