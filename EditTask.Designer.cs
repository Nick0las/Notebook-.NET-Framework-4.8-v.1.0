
namespace Notebook_.NET_Framework_v._1._0
{
    partial class EditTask
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
            this.addTime = new System.Windows.Forms.DateTimePicker();
            this.CmdOk = new System.Windows.Forms.Button();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.detailTask = new System.Windows.Forms.TextBox();
            this.headTask = new System.Windows.Forms.TextBox();
            this.comboBoxEnum = new System.Windows.Forms.ComboBox();
            this.checkBoxTime = new System.Windows.Forms.CheckBox();
            this.dateAddTask = new System.Windows.Forms.DateTimePicker();
            this.labelTimeTask = new System.Windows.Forms.Label();
            this.labelDateTask = new System.Windows.Forms.Label();
            this.labelContentTask = new System.Windows.Forms.Label();
            this.labelHeadTask = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.panelAddBorderBottom = new System.Windows.Forms.Panel();
            this.panelAddBorderTop = new System.Windows.Forms.Panel();
            this.panelAddBorderRight = new System.Windows.Forms.Panel();
            this.panelAddBorderLeft = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addTime
            // 
            this.addTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.addTime.Location = new System.Drawing.Point(180, 323);
            this.addTime.Name = "addTime";
            this.addTime.Size = new System.Drawing.Size(200, 20);
            this.addTime.TabIndex = 35;
            // 
            // CmdOk
            // 
            this.CmdOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CmdOk.Location = new System.Drawing.Point(17, 374);
            this.CmdOk.Name = "CmdOk";
            this.CmdOk.Size = new System.Drawing.Size(75, 23);
            this.CmdOk.TabIndex = 34;
            this.CmdOk.Text = "Добавить";
            this.CmdOk.UseVisualStyleBackColor = true;
            this.CmdOk.Click += new System.EventHandler(this.CmdOk_Click);
            // 
            // CmdCancel
            // 
            this.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdCancel.Location = new System.Drawing.Point(709, 375);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(75, 23);
            this.CmdCancel.TabIndex = 33;
            this.CmdCancel.Text = "Отмена";
            this.CmdCancel.UseVisualStyleBackColor = true;
            this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // detailTask
            // 
            this.detailTask.Location = new System.Drawing.Point(180, 128);
            this.detailTask.Multiline = true;
            this.detailTask.Name = "detailTask";
            this.detailTask.Size = new System.Drawing.Size(604, 133);
            this.detailTask.TabIndex = 32;
            // 
            // headTask
            // 
            this.headTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headTask.Location = new System.Drawing.Point(180, 69);
            this.headTask.Multiline = true;
            this.headTask.Name = "headTask";
            this.headTask.Size = new System.Drawing.Size(604, 53);
            this.headTask.TabIndex = 31;
            // 
            // comboBoxEnum
            // 
            this.comboBoxEnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnum.FormattingEnabled = true;
            this.comboBoxEnum.Location = new System.Drawing.Point(180, 29);
            this.comboBoxEnum.Name = "comboBoxEnum";
            this.comboBoxEnum.Size = new System.Drawing.Size(259, 21);
            this.comboBoxEnum.TabIndex = 30;
            // 
            // checkBoxTime
            // 
            this.checkBoxTime.AutoSize = true;
            this.checkBoxTime.Location = new System.Drawing.Point(36, 323);
            this.checkBoxTime.Name = "checkBoxTime";
            this.checkBoxTime.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTime.TabIndex = 29;
            this.checkBoxTime.UseVisualStyleBackColor = true;
            this.checkBoxTime.CheckedChanged += new System.EventHandler(this.checkBoxTime_CheckedChanged);
            // 
            // dateAddTask
            // 
            this.dateAddTask.Location = new System.Drawing.Point(180, 279);
            this.dateAddTask.Name = "dateAddTask";
            this.dateAddTask.Size = new System.Drawing.Size(200, 20);
            this.dateAddTask.TabIndex = 28;
            // 
            // labelTimeTask
            // 
            this.labelTimeTask.AutoSize = true;
            this.labelTimeTask.Location = new System.Drawing.Point(53, 323);
            this.labelTimeTask.Name = "labelTimeTask";
            this.labelTimeTask.Size = new System.Drawing.Size(40, 13);
            this.labelTimeTask.TabIndex = 27;
            this.labelTimeTask.Text = "Время";
            // 
            // labelDateTask
            // 
            this.labelDateTask.AutoSize = true;
            this.labelDateTask.Location = new System.Drawing.Point(33, 285);
            this.labelDateTask.Name = "labelDateTask";
            this.labelDateTask.Size = new System.Drawing.Size(33, 13);
            this.labelDateTask.TabIndex = 26;
            this.labelDateTask.Text = "Дата";
            // 
            // labelContentTask
            // 
            this.labelContentTask.AutoSize = true;
            this.labelContentTask.Location = new System.Drawing.Point(33, 136);
            this.labelContentTask.Name = "labelContentTask";
            this.labelContentTask.Size = new System.Drawing.Size(128, 13);
            this.labelContentTask.TabIndex = 25;
            this.labelContentTask.Text = "Подробное содержание";
            // 
            // labelHeadTask
            // 
            this.labelHeadTask.AutoSize = true;
            this.labelHeadTask.Location = new System.Drawing.Point(33, 77);
            this.labelHeadTask.Name = "labelHeadTask";
            this.labelHeadTask.Size = new System.Drawing.Size(61, 13);
            this.labelHeadTask.TabIndex = 24;
            this.labelHeadTask.Text = "Заголовок";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(33, 37);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(64, 13);
            this.labelType.TabIndex = 23;
            this.labelType.Text = "Тип задачи";
            // 
            // panelAddBorderBottom
            // 
            this.panelAddBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAddBorderBottom.Location = new System.Drawing.Point(10, 403);
            this.panelAddBorderBottom.Name = "panelAddBorderBottom";
            this.panelAddBorderBottom.Size = new System.Drawing.Size(780, 10);
            this.panelAddBorderBottom.TabIndex = 22;
            // 
            // panelAddBorderTop
            // 
            this.panelAddBorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddBorderTop.Location = new System.Drawing.Point(10, 0);
            this.panelAddBorderTop.Name = "panelAddBorderTop";
            this.panelAddBorderTop.Size = new System.Drawing.Size(780, 10);
            this.panelAddBorderTop.TabIndex = 21;
            // 
            // panelAddBorderRight
            // 
            this.panelAddBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAddBorderRight.Location = new System.Drawing.Point(790, 0);
            this.panelAddBorderRight.Name = "panelAddBorderRight";
            this.panelAddBorderRight.Size = new System.Drawing.Size(10, 413);
            this.panelAddBorderRight.TabIndex = 20;
            // 
            // panelAddBorderLeft
            // 
            this.panelAddBorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAddBorderLeft.Location = new System.Drawing.Point(0, 0);
            this.panelAddBorderLeft.Name = "panelAddBorderLeft";
            this.panelAddBorderLeft.Size = new System.Drawing.Size(10, 413);
            this.panelAddBorderLeft.TabIndex = 19;
            // 
            // EditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "EditTask";
            this.Text = "Редактирование задачи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker addTime;
        private System.Windows.Forms.Button CmdOk;
        private System.Windows.Forms.Button CmdCancel;
        public System.Windows.Forms.TextBox detailTask;
        public System.Windows.Forms.TextBox headTask;
        public System.Windows.Forms.ComboBox comboBoxEnum;
        public System.Windows.Forms.CheckBox checkBoxTime;
        public System.Windows.Forms.DateTimePicker dateAddTask;
        private System.Windows.Forms.Label labelTimeTask;
        private System.Windows.Forms.Label labelDateTask;
        private System.Windows.Forms.Label labelContentTask;
        private System.Windows.Forms.Label labelHeadTask;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Panel panelAddBorderBottom;
        private System.Windows.Forms.Panel panelAddBorderTop;
        private System.Windows.Forms.Panel panelAddBorderRight;
        private System.Windows.Forms.Panel panelAddBorderLeft;
    }
}