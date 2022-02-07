using System;
using System.Collections.Generic;
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
        public MainForm()
        {
            Timer timer = new Timer()
            {
                Interval = 1000,
                Enabled = true
            };
            timer.Tick += new EventHandler(Timer_tick);
            InitializeComponent();

            DataGridViewCellStyle style = dataGridCurrent.ColumnHeadersDefaultCellStyle;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewTextBoxColumn TypeTasks;
            TypeTasks = new DataGridViewTextBoxColumn();
            TypeTasks.Name = "TypeTasks";
            TypeTasks.HeaderText = "Тип задачи";
            TypeTasks.Width = 150;
            DataGridViewTextBoxColumn TimeTasks;
            TimeTasks = new DataGridViewTextBoxColumn();
            TimeTasks.Name = "TimeTasks";
            TimeTasks.HeaderText = "Время";
            TimeTasks.Width = 150;
            DataGridViewTextBoxColumn HeadTasks;
            HeadTasks = new DataGridViewTextBoxColumn();
            HeadTasks.Name = "HeadTasks";
            HeadTasks.HeaderText = "Краткое содержание";            
            HeadTasks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            dataGridCurrent.Columns.AddRange(new DataGridViewColumn[] { TypeTasks, TimeTasks, HeadTasks });
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTask dlg = new AddTask();
            dlg.ShowDialog();
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
            string a = monthCalendar1.SelectionRange.Start.ToLongDateString();
            viewer.labelViewer.Text = a;
        }
    }
}
