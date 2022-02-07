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
            dataGridContent.Columns.AddRange(new DataGridViewColumn[] { TypeTasks, TimeTasks, HeadTasks });
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
