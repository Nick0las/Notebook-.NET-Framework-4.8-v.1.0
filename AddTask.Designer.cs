
namespace Notebook_.NET_Framework_v._1._0
{
    partial class AddTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAddBorderLeft = new System.Windows.Forms.Panel();
            this.panelAddBorderRight = new System.Windows.Forms.Panel();
            this.panelAddBorderTop = new System.Windows.Forms.Panel();
            this.panelAddBorderBottom = new System.Windows.Forms.Panel();
            this.labelType = new System.Windows.Forms.Label();
            this.labelHeadTask = new System.Windows.Forms.Label();
            this.labelContentTask = new System.Windows.Forms.Label();
            this.labelDateTask = new System.Windows.Forms.Label();
            this.labelTimeTask = new System.Windows.Forms.Label();
            this.dateAddTask = new System.Windows.Forms.DateTimePicker();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.comboBoxEnum = new System.Windows.Forms.ComboBox();
            this.headTask = new System.Windows.Forms.TextBox();
            this.detailTask = new System.Windows.Forms.TextBox();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdOk = new System.Windows.Forms.Button();
            this.addTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // panelAddBorderLeft
            // 
            this.panelAddBorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAddBorderLeft.Location = new System.Drawing.Point(0, 0);
            this.panelAddBorderLeft.Name = "panelAddBorderLeft";
            this.panelAddBorderLeft.Size = new System.Drawing.Size(10, 413);
            this.panelAddBorderLeft.TabIndex = 0;
            // 
            // panelAddBorderRight
            // 
            this.panelAddBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAddBorderRight.Location = new System.Drawing.Point(790, 0);
            this.panelAddBorderRight.Name = "panelAddBorderRight";
            this.panelAddBorderRight.Size = new System.Drawing.Size(10, 413);
            this.panelAddBorderRight.TabIndex = 1;
            // 
            // panelAddBorderTop
            // 
            this.panelAddBorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddBorderTop.Location = new System.Drawing.Point(10, 0);
            this.panelAddBorderTop.Name = "panelAddBorderTop";
            this.panelAddBorderTop.Size = new System.Drawing.Size(780, 10);
            this.panelAddBorderTop.TabIndex = 2;
            // 
            // panelAddBorderBottom
            // 
            this.panelAddBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAddBorderBottom.Location = new System.Drawing.Point(10, 403);
            this.panelAddBorderBottom.Name = "panelAddBorderBottom";
            this.panelAddBorderBottom.Size = new System.Drawing.Size(780, 10);
            this.panelAddBorderBottom.TabIndex = 3;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(33, 37);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(64, 13);
            this.labelType.TabIndex = 4;
            this.labelType.Text = "Тип задачи";
            // 
            // labelHeadTask
            // 
            this.labelHeadTask.AutoSize = true;
            this.labelHeadTask.Location = new System.Drawing.Point(33, 77);
            this.labelHeadTask.Name = "labelHeadTask";
            this.labelHeadTask.Size = new System.Drawing.Size(61, 13);
            this.labelHeadTask.TabIndex = 5;
            this.labelHeadTask.Text = "Заголовок";
            // 
            // labelContentTask
            // 
            this.labelContentTask.AutoSize = true;
            this.labelContentTask.Location = new System.Drawing.Point(33, 136);
            this.labelContentTask.Name = "labelContentTask";
            this.labelContentTask.Size = new System.Drawing.Size(128, 13);
            this.labelContentTask.TabIndex = 6;
            this.labelContentTask.Text = "Подробное содержание";
            // 
            // labelDateTask
            // 
            this.labelDateTask.AutoSize = true;
            this.labelDateTask.Location = new System.Drawing.Point(33, 285);
            this.labelDateTask.Name = "labelDateTask";
            this.labelDateTask.Size = new System.Drawing.Size(33, 13);
            this.labelDateTask.TabIndex = 7;
            this.labelDateTask.Text = "Дата";
            // 
            // labelTimeTask
            // 
            this.labelTimeTask.AutoSize = true;
            this.labelTimeTask.Location = new System.Drawing.Point(53, 323);
            this.labelTimeTask.Name = "labelTimeTask";
            this.labelTimeTask.Size = new System.Drawing.Size(40, 13);
            this.labelTimeTask.TabIndex = 8;
            this.labelTimeTask.Text = "Время";
            // 
            // dateAddTask
            // 
            this.dateAddTask.Location = new System.Drawing.Point(180, 279);
            this.dateAddTask.Name = "dateAddTask";
            this.dateAddTask.Size = new System.Drawing.Size(200, 20);
            this.dateAddTask.TabIndex = 9;
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.Location = new System.Drawing.Point(36, 323);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTime.TabIndex = 10;
            this.checkBoxTime.UseVisualStyleBackColor = true;
            this.checkBoxTime.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBoxEnum
            // 
            this.comboBoxEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnum.FormattingEnabled = true;
            this.comboBoxEnum.Location = new System.Drawing.Point(180, 29);
            this.comboBoxEnum.Name = "comboBoxEnum";
            this.comboBoxEnum.Size = new System.Drawing.Size(259, 21);
            this.comboBoxEnum.TabIndex = 11;
            // 
            // headTask
            // 
            this.headTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headTask.Location = new System.Drawing.Point(180, 69);
            this.headTask.Multiline = true;
            this.headTask.Name = "headTask";
            this.headTask.Size = new System.Drawing.Size(604, 53);
            this.headTask.TabIndex = 12;
            // 
            // detailTask
            // 
            this.detailTask.Location = new System.Drawing.Point(180, 128);
            this.detailTask.Multiline = true;
            this.detailTask.Name = "detailTask";
            this.detailTask.Size = new System.Drawing.Size(604, 133);
            this.detailTask.TabIndex = 13;
            // 
            // CmdCancel
            // 
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancel.Location = new System.Drawing.Point(709, 375);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(75, 23);
            this.CmdCancel.TabIndex = 16;
            this.CmdCancel.Text = "Отмена";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // CmdOk
            // 
            this.CmdOk.Location = new System.Drawing.Point(17, 374);
            this.CmdOk.Name = "CmdOk";
            this.CmdOk.Size = new System.Drawing.Size(75, 23);
            this.CmdOk.TabIndex = 17;
            this.CmdOk.Text = "Добавить";
            this.CmdOk.UseVisualStyleBackColor = true;
            this.CmdOk.Click += new System.EventHandler(this.CmdOk_Click);
            // 
            // addTime
            // 
            this.addTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.addTime.Location = new System.Drawing.Point(180, 323);
            this.addTime.Name = "addTime";
            this.addTime.Size = new System.Drawing.Size(200, 20);
            this.addTime.TabIndex = 18;
            // 
            // AddTask
            // 
            this.AcceptButton = this.CmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CmdCancel;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.addTime);
            this.Controls.Add(this.CmdOk);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.detailTask);
            this.Controls.Add(this.headTask);
            this.Controls.Add(this.comboBoxEnum);
            this.Controls.Add(this.checkBoxTime);
            this.Controls.Add(this.dateAddTask);
            this.Controls.Add(this.labelTimeTask);
            this.Controls.Add(this.labelDateTask);
            this.Controls.Add(this.labelContentTask);
            this.Controls.Add(this.labelHeadTask);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.panelAddBorderBottom);
            this.Controls.Add(this.panelAddBorderTop);
            this.Controls.Add(this.panelAddBorderRight);
            this.Controls.Add(this.panelAddBorderLeft);
            this.MaximumSize = new System.Drawing.Size(816, 452);
            this.MinimumSize = new System.Drawing.Size(816, 452);
            this.Name = "AddTask";
            this.Text = "Новая задача";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAddBorderLeft;
        private System.Windows.Forms.Panel panelAddBorderRight;
        private System.Windows.Forms.Panel panelAddBorderTop;
        private System.Windows.Forms.Panel panelAddBorderBottom;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelHeadTask;
        private System.Windows.Forms.Label labelContentTask;
        private System.Windows.Forms.Label labelDateTask;
        private System.Windows.Forms.Label labelTimeTask;
        private System.Windows.Forms.Button CmdCancel;
        private System.Windows.Forms.Button CmdOk;
        public System.Windows.Forms.TextBox headTask;
        public System.Windows.Forms.DateTimePicker dateAddTask;
        public System.Windows.Forms.CheckBox checkBoxTime;
        public System.Windows.Forms.ComboBox comboBoxEnum;
        public System.Windows.Forms.TextBox detailTask;
        public System.Windows.Forms.DateTimePicker addTime;
    }
}