using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;


namespace Notebook_.NET_Framework_v._1._0
{
    public partial class MainForm : Form
    {
        public static ArrayList ArrView = new ArrayList(); // список данных для просмотра из БД
        public MainForm()
        {
            /*--------------получение текущей даты-----------------*/
            DateTime thisDay = DateTime.Today;
            string dataStrNow = thisDay.ToLongDateString();
            /*--------------получение текущей даты-----------------*/

            Timer timer = new Timer()
            {
                Interval = 1000,
                Enabled = true
            };
            timer.Tick += new EventHandler(Timer_tick);
            InitializeComponent();
            boldDateCalendar();

            DataGridViewCellStyle style = dataGridCurrent.ColumnHeadersDefaultCellStyle;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridCurrent.AllowUserToAddRows = false;



            DataGridViewTextBoxColumn DateTask;
            DateTask = new DataGridViewTextBoxColumn();
            DateTask.Name = "dateTasks";
            DateTask.HeaderText = "Дата";
            DateTask.Width = 150;

            DataGridViewTextBoxColumn Completed;
            Completed = new DataGridViewTextBoxColumn();
            Completed.Name = "completed";
            Completed.HeaderText = "Выполнено";
            Completed.Width = 150;

            DataGridViewTextBoxColumn TypeTasks;
            TypeTasks = new DataGridViewTextBoxColumn();
            TypeTasks.Name = "typeTasks";
            TypeTasks.HeaderText = "Тип задачи";
            TypeTasks.Width = 150;

            DataGridViewTextBoxColumn TimeTasks;
            TimeTasks = new DataGridViewTextBoxColumn();
            TimeTasks.Name = "timeTasks";
            TimeTasks.HeaderText = "Время";
            TimeTasks.Width = 150;

            DataGridViewTextBoxColumn HeadTasks;
            HeadTasks = new DataGridViewTextBoxColumn();
            HeadTasks.Name = "headTasks";
            HeadTasks.HeaderText = "Краткое содержание";
            
            HeadTasks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;            
            dataGridCurrent.Columns.AddRange(new DataGridViewColumn[] { Completed, DateTask, TimeTasks, TypeTasks,  HeadTasks });
            DataBases db = new DataBases();
            db.OpenConnection();
            updateDateGrid();
            //dataGridCurrent.Columns["Completed"].Visible = false;
            //dataGridCurrent.Columns["DateTask"].Visible = false;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTask dlg = new AddTask();
            dlg.ShowDialog();
            updateDateGrid();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Timer_tick(object sender, EventArgs e)
        {
            label_Time.Text = DateTime.Now.ToLongTimeString();
            //label_Data.Text = DateTime.Now.ToLongDateString();
            //label_CurrentTasks.Text = "Текущие задачи";            
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About dlgAbout = new About();
            dlgAbout.Show();
        }

        private void перейтиКДатеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viewer viewer = new Viewer();
            viewer.Show();
            string dataStrLabel = monthCalendar1.SelectionRange.Start.ToLongDateString();
            viewer.labelDayOfWeek.Text = monthCalendar1.SelectionStart.DayOfWeek.ToString().ToUpper();
            string dataStr = monthCalendar1.SelectionRange.Start.ToLongDateString(); // используется в Sql запросе
            viewer.labelViewer.Text = dataStrLabel;

            /*выборка и показ данных в dataGrid*/

            DataBases dataBasesView = new DataBases();
            dataBasesView.OpenConnection();
            string sqlComand = "SELECT completed, date, time, type, headTask, detailTask FROM `tasks` WHERE date = " + "'" + dataStr + "'" + "ORDER BY ABS (time)"; 
            MySqlCommand cmddataView = new MySqlCommand(sqlComand, dataBasesView.getConnection());
            MySqlDataReader rd = cmddataView.ExecuteReader();
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
                viewer.dataGridContent.Rows.Add(str);
            }
            rd.Close();

            /*выборка и показ данных в dataGrid*/
        }

        private void monthCalendar1_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            MonthCalendar.HitTestInfo calendar = monthCalendar1.HitTest(p);
            monthCalendar1.SetDate(calendar.Time);
        }

        private void обновитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateDateGrid();            
        }

        public void updateDateGrid()
        {
            /*--------------получение текущей даты-----------------*/
            DateTime thisDay = DateTime.Today;
            string dataStrNow = thisDay.ToLongDateString();
            /*--------------получение текущей даты-----------------*/
            dataGridCurrent.Rows.Clear();

            /*выборка и показ данных в dataGrid*/
            DataBases dataBasesView = new DataBases();
            dataBasesView.OpenConnection();
            string sqlComand = "SELECT  completed, date, time, type, headTask, completed FROM `tasks` WHERE date = " + "'" + dataStrNow + "'" + "ORDER BY ABS (time)";
            MySqlCommand cmddataView = new MySqlCommand(sqlComand, dataBasesView.getConnection());
            MySqlDataReader rd = cmddataView.ExecuteReader();
            List<string[]> listStr = new List<string[]>();
            while (rd.Read())
            {
                listStr.Add(new string[5]);
                listStr[listStr.Count - 1][0] = rd[0].ToString();
                listStr[listStr.Count - 1][1] = rd[1].ToString();
                listStr[listStr.Count - 1][2] = rd[2].ToString();
                listStr[listStr.Count - 1][3] = rd[3].ToString();
                listStr[listStr.Count - 1][4] = rd[4].ToString();
            }

            foreach (string[] str in listStr)
            {
                dataGridCurrent.Rows.Add(str);                
            }
            rd.Close();
            dataBasesView.CloseConnection();
            /*выборка и показ данных в dataGrid*/

            for (int i = 0; i < dataGridCurrent.Rows.Count; i++)
            {
                if(dataGridCurrent.Rows[i].Cells[0].Value.ToString() == "True")
                {                    
                    completedTasks(i);
                }
            }
            boldDateCalendar();
        }        

        private void выполненоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int indexRow = dataGridCurrent.CurrentRow.Index;
            

            DateTime thisDay = DateTime.Today;
            string type;
            string header;
            string timeTask;
            string dateTask = "'" + thisDay.ToLongDateString() + "'";
            string id;
            string searchIdSql;

            type = "'" + dataGridCurrent.Rows[indexRow].Cells["typeTasks"].Value.ToString() + "'";
            timeTask = "'" + dataGridCurrent.Rows[indexRow].Cells["timeTasks"].Value.ToString() + "'";
            header = "'" + dataGridCurrent.Rows[indexRow].Cells["headTasks"].Value.ToString() + "'";
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
            string updateCompletedCmd = "UPDATE `tasks` SET completed = true WHERE id = " + id;            
            MySqlCommand updateCompletedSql = new MySqlCommand(updateCompletedCmd, dbase.getConnection());
            updateCompletedSql.ExecuteNonQuery();
            db.CloseConnection();
            completedTasks(indexRow);
        }

        private void completedTasks(int indexRow)
        {
            //DataGridViewCellStyle style = new DataGridViewCellStyle();
            //style.Font = new Font(dataGridCurrent.Font.OriginalFontName, 9, FontStyle.Strikeout);
            dataGridCurrent.Rows[indexRow].Cells["dateTasks"].Style.Font = new Font (dataGridCurrent.Font.OriginalFontName, 9, FontStyle.Strikeout);
            dataGridCurrent.Rows[indexRow].Cells["timeTasks"].Style.Font = new Font(dataGridCurrent.Font.OriginalFontName, 9, FontStyle.Strikeout);
            dataGridCurrent.Rows[indexRow].Cells["typeTasks"].Style.Font = new Font(dataGridCurrent.Font.OriginalFontName, 9, FontStyle.Strikeout);
            dataGridCurrent.Rows[indexRow].Cells["headTasks"].Style.Font = new Font(dataGridCurrent.Font.OriginalFontName, 9, FontStyle.Strikeout);
        }

        private void deleteRow(int indexRow)
        {
            dataGridCurrent.Rows.RemoveAt(indexRow);
        }

        private void dataGridCurrent_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestNode = dataGridCurrent.HitTest(e.X, e.Y);

                if (hitTestNode.RowIndex != -1)
                {
                    dataGridCurrent.ClearSelection();
                    dataGridCurrent.Rows[hitTestNode.RowIndex].Selected = true;
                    dataGridCurrent.CurrentCell = dataGridCurrent.Rows[hitTestNode.RowIndex].Cells[0];
                }
            }
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string type;
            string header;            
            string dateTask;
            string id;
            string searchIdSql;

            int indexRow = dataGridCurrent.CurrentRow.Index;

            type = "'" + dataGridCurrent.Rows[indexRow].Cells["typeTasks"].Value.ToString() + "'";
            header = "'" + dataGridCurrent.Rows[indexRow].Cells["headTasks"].Value.ToString() + "'";
            dateTask = "'" + dataGridCurrent.Rows[indexRow].Cells["dateTasks"].Value.ToString() + "'";

            searchIdSql = "SELECT id FROM tasks WHERE type =" + type + " AND " + "	headTask = " + header + " AND " + "date = " + dateTask;

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
            updateDateGrid();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string type;
            string header;
            string timeTask;
            string dateTask;
            string id;
            string searchIdSql;

            int indexRow = dataGridCurrent.CurrentRow.Index;


            type = "'" + dataGridCurrent.Rows[indexRow].Cells["typeTasks"].Value.ToString() + "'";
            timeTask = "'" + dataGridCurrent.Rows[indexRow].Cells["timeTasks"].Value.ToString() + "'";
            header = "'" + dataGridCurrent.Rows[indexRow].Cells["headTasks"].Value.ToString() + "'";
            dateTask = "'" + dataGridCurrent.Rows[indexRow].Cells["dateTasks"].Value.ToString() + "'";

            searchIdSql = "SELECT id FROM tasks WHERE type = " + type + " AND " + "	headTask = " + header + " AND " + "date = " + dateTask + " AND time = " + timeTask;

            DataBases db = new DataBases();
            db.OpenConnection();
            MySqlCommand searchIdCmd = new MySqlCommand(searchIdSql, db.getConnection());
            MySqlDataReader rd = searchIdCmd.ExecuteReader();
            rd.Read();
            id = rd["id"].ToString();
            rd.Close();
            db.CloseConnection();

            DataBases dbase = new DataBases();
            dbase.OpenConnection();
            string deleteCompletedCmd = "DELETE FROM tasks WHERE id = " + id;
            MySqlCommand deleteRowSql = new MySqlCommand(deleteCompletedCmd, dbase.getConnection());
            deleteRowSql.ExecuteNonQuery();
            dbase.CloseConnection();
            deleteRow(indexRow);
            updateDateGrid();
        }

        private void обновитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            updateDateGrid();
        }

        public static void EditTask(DataGridView grid)
        {
            int indexRow = grid.CurrentRow.Index;
            string completed;
            string dateTask;
            string timeTask;
            string typeTask;
            string headTask;
            string detailTask = "";
            string id;

            completed = grid.Rows[indexRow].Cells["completed"].Value.ToString();
            if(completed == "True")
            {
                MessageBox.Show
                    (
                    "Завершенная задача не может быть отредактирована!",
                    "Внимание!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information                    
                    );
            }
             else
            {
                dateTask = "'" + grid.Rows[indexRow].Cells["dateTasks"].Value.ToString() + "'";
                timeTask = "'" + grid.Rows[indexRow].Cells["timeTasks"].Value.ToString() + "'";
                typeTask = "'" + grid.Rows[indexRow].Cells["typeTasks"].Value.ToString() + "'";
                headTask = "'" + grid.Rows[indexRow].Cells["headTasks"].Value.ToString() + "'";

                string searchRowInBd = "SELECT type, headTask, detailTask, date, time FROM tasks WHERE date = " + dateTask + " AND time = " + timeTask + " AND type = " + typeTask
                                        + " AND headTask = " + headTask + " ORDER BY ABS (time)";
                string searchIdSql = "SELECT ID FROM `tasks` WHERE type = " + typeTask + " AND " + "headTask = " + headTask + " AND " + " date = " + dateTask + " AND " + " time = " + timeTask;

                DataBases searchRowDb = new DataBases();
                searchRowDb.OpenConnection();
                MySqlCommand cmdSearchRow = new MySqlCommand(searchRowInBd, searchRowDb.getConnection());
                MySqlDataReader rd = cmdSearchRow.ExecuteReader();
                List<string[]> listStr = new List<string[]>();
                while (rd.Read())
                {
                    listStr.Add(new string[5]);
                    listStr[listStr.Count - 1][0] = rd[0].ToString();
                    listStr[listStr.Count - 1][1] = rd[1].ToString();
                    listStr[listStr.Count - 1][2] = rd[2].ToString();
                    listStr[listStr.Count - 1][3] = rd[3].ToString();
                    listStr[listStr.Count - 1][4] = rd[4].ToString();                    
                }
                foreach (string[] str in listStr)
                {
                    typeTask = listStr[listStr.Count - 1][0];
                    headTask = listStr[listStr.Count - 1][1];
                    detailTask = listStr[listStr.Count - 1][2];
                    dateTask = listStr[listStr.Count - 1][3];
                    timeTask = listStr[listStr.Count - 1][4];
                }
                rd.Close();
                MySqlCommand cmdSearchId = new MySqlCommand(searchIdSql, searchRowDb.getConnection());
                MySqlDataReader readId = cmdSearchId.ExecuteReader();
                readId.Read();
                id = readId["id"].ToString();
                readId.Close();
                searchRowDb.CloseConnection();
                EditTask editTaskDlg = new EditTask();
                editTaskDlg.checkBoxTime.Checked = true;
                editTaskDlg.headTask.Text = headTask;
                editTaskDlg.detailTask.Text = detailTask;
                editTaskDlg.comboBoxEnum.Text = typeTask;
                editTaskDlg.dateAddTask.Text = dateTask;
                if(timeTask == "-")
                {
                    timeTask = "00:00";
                    editTaskDlg.checkBoxTime.Checked = false;
                }
                editTaskDlg.addTime.Text = timeTask;
                editTaskDlg.ShowDialog();

                /*изменение данных в базе*/
                DateTime date = new DateTime(editTaskDlg.dateAddTask.Value.Ticks);
                DateTime s = new DateTime(editTaskDlg.addTime.Value.Ticks);                
                string s2 = s.ToShortTimeString();
                string editRowSql;

                typeTask = "'"+ editTaskDlg.comboBoxEnum.Text + "'";
                headTask = "'" + editTaskDlg.headTask.Text + "'";
                detailTask = "'" + editTaskDlg.detailTask.Text + "'";
                dateTask = "'" + editTaskDlg.dateAddTask.Text + "'";
                if (!editTaskDlg.checkBoxTime.Checked)
                {
                    timeTask =  "'-'";
                }
                else
                {
                    timeTask = "'" + s2 + "'";
                }
                
                editRowSql = "UPDATE tasks SET type = " + typeTask + ", headTask = " + headTask + ", detailTask = " + detailTask + ", date = " + dateTask + ", time = " + timeTask + " WHERE id = " + id;
                searchRowDb.OpenConnection();
                /*ПРОВЕРКА НА СУЩЕСТВУЮЩИЕ ЗАПИСИ В ЗАДАВАЕМОЕ ВРЕМЯ*/
                if (editTaskDlg.checkBoxTime.Checked)
                {
                    string checkSQLRowws = "SELECT  count(*) FROM tasks WHERE date = " + dateTask + " AND time = " + timeTask;
                    MySqlCommand cmdCheck = new MySqlCommand(checkSQLRowws, searchRowDb.getConnection());
                    
                    int totalRows = AddTask.GetRowsCount(cmdCheck);
                    if (totalRows > 0)
                    {
                        MessageBox.Show(
                            "Измените дату или время. Ячейка занята.",
                            "Внимание",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        return;
                    }
                }
                /*ПРОВЕРКА НА СУЩЕСТВУЮЩИЕ ЗАПИСИ В ЗАДАВАЕМОЕ ВРЕМЯ*/
                MySqlCommand editRow = new MySqlCommand(editRowSql, searchRowDb.getConnection());
                editRow.ExecuteNonQuery();
                searchRowDb.CloseConnection();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTask(dataGridCurrent);
            updateDateGrid();
        }

        public void boldDateCalendar()
        {
            // запрос на выборку всех дат из базы данных
            string sqlSearchDate = "SELECT date FROM `tasks`"; 
            List<string> listStr = new List<string>(); // хранение всех дат в базе данных
            /*Подключение к базе данных*/
            DataBases db = new DataBases();
            db.OpenConnection();
            MySqlCommand cmdUpdateDetail = new MySqlCommand
                (sqlSearchDate, db.getConnection());
            MySqlDataReader rd = cmdUpdateDetail.ExecuteReader();
            
            while (rd.Read())
            {
                listStr.Add(rd.GetString(0));
            }
            for (int i = 0; i < listStr.Count; i++)
            {
                var parsedDate = DateTime.Parse(listStr[i]);
                monthCalendar1.AddBoldedDate(parsedDate);
                monthCalendar1.ShowTodayCircle = true;                
            }
            monthCalendar1.UpdateBoldedDates();
        }
    }
}
