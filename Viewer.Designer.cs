
namespace Notebook_.NET_Framework_v._1._0
{
    partial class Viewer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelViewerBorderLeft = new System.Windows.Forms.Panel();
            this.panelViewerBorderRight = new System.Windows.Forms.Panel();
            this.panelViewerBorderTop = new System.Windows.Forms.Panel();
            this.panelViewerBorderBottom = new System.Windows.Forms.Panel();
            this.CmdClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDayOfWeek = new System.Windows.Forms.Label();
            this.labelViewer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridContent = new System.Windows.Forms.DataGridView();
            this.contextMenuViewer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполненоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelViewerBorderBottom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContent)).BeginInit();
            this.contextMenuViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelViewerBorderLeft
            // 
            this.panelViewerBorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelViewerBorderLeft.Location = new System.Drawing.Point(0, 0);
            this.panelViewerBorderLeft.Name = "panelViewerBorderLeft";
            this.panelViewerBorderLeft.Size = new System.Drawing.Size(10, 450);
            this.panelViewerBorderLeft.TabIndex = 0;
            // 
            // panelViewerBorderRight
            // 
            this.panelViewerBorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelViewerBorderRight.Location = new System.Drawing.Point(1024, 0);
            this.panelViewerBorderRight.Name = "panelViewerBorderRight";
            this.panelViewerBorderRight.Size = new System.Drawing.Size(10, 450);
            this.panelViewerBorderRight.TabIndex = 1;
            // 
            // panelViewerBorderTop
            // 
            this.panelViewerBorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelViewerBorderTop.Location = new System.Drawing.Point(10, 0);
            this.panelViewerBorderTop.Name = "panelViewerBorderTop";
            this.panelViewerBorderTop.Size = new System.Drawing.Size(1014, 10);
            this.panelViewerBorderTop.TabIndex = 2;
            // 
            // panelViewerBorderBottom
            // 
            this.panelViewerBorderBottom.Controls.Add(this.CmdClose);
            this.panelViewerBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelViewerBorderBottom.Location = new System.Drawing.Point(10, 418);
            this.panelViewerBorderBottom.Name = "panelViewerBorderBottom";
            this.panelViewerBorderBottom.Size = new System.Drawing.Size(1014, 32);
            this.panelViewerBorderBottom.TabIndex = 3;
            // 
            // CmdClose
            // 
            this.CmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.CmdClose.Location = new System.Drawing.Point(905, 0);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(109, 32);
            this.CmdClose.TabIndex = 1;
            this.CmdClose.Text = "Закрыть(Esc)";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelDayOfWeek);
            this.panel2.Controls.Add(this.labelViewer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 79);
            this.panel2.TabIndex = 0;
            // 
            // labelDayOfWeek
            // 
            this.labelDayOfWeek.AutoSize = true;
            this.labelDayOfWeek.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDayOfWeek.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelDayOfWeek.Location = new System.Drawing.Point(276, 30);
            this.labelDayOfWeek.Name = "labelDayOfWeek";
            this.labelDayOfWeek.Size = new System.Drawing.Size(87, 36);
            this.labelDayOfWeek.TabIndex = 1;
            this.labelDayOfWeek.Text = "label1";
            // 
            // labelViewer
            // 
            this.labelViewer.AutoSize = true;
            this.labelViewer.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelViewer.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelViewer.Location = new System.Drawing.Point(46, 30);
            this.labelViewer.Name = "labelViewer";
            this.labelViewer.Size = new System.Drawing.Size(87, 36);
            this.labelViewer.TabIndex = 0;
            this.labelViewer.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 408);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dataGridContent);
            this.panel3.Location = new System.Drawing.Point(0, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 331);
            this.panel3.TabIndex = 1;
            // 
            // dataGridContent
            // 
            this.dataGridContent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContent.ContextMenuStrip = this.contextMenuViewer;
            this.dataGridContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridContent.Location = new System.Drawing.Point(0, 0);
            this.dataGridContent.Name = "dataGridContent";
            this.dataGridContent.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridContent.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridContent.Size = new System.Drawing.Size(1014, 331);
            this.dataGridContent.TabIndex = 0;
            this.dataGridContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridContent_MouseDown);
            // 
            // contextMenuViewer
            // 
            this.contextMenuViewer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.выполненоToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuViewer.Name = "contextMenuViewer";
            this.contextMenuViewer.Size = new System.Drawing.Size(155, 92);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // выполненоToolStripMenuItem
            // 
            this.выполненоToolStripMenuItem.Name = "выполненоToolStripMenuItem";
            this.выполненоToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.выполненоToolStripMenuItem.Text = "Выполнено";
            this.выполненоToolStripMenuItem.Click += new System.EventHandler(this.выполненоToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CmdClose;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelViewerBorderBottom);
            this.Controls.Add(this.panelViewerBorderTop);
            this.Controls.Add(this.panelViewerBorderRight);
            this.Controls.Add(this.panelViewerBorderLeft);
            this.Name = "Viewer";
            this.Text = "Детали дня";
            this.panelViewerBorderBottom.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContent)).EndInit();
            this.contextMenuViewer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelViewerBorderLeft;
        private System.Windows.Forms.Panel panelViewerBorderRight;
        private System.Windows.Forms.Panel panelViewerBorderTop;
        private System.Windows.Forms.Panel panelViewerBorderBottom;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label labelViewer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dataGridContent;
        private System.Windows.Forms.ContextMenuStrip contextMenuViewer;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполненоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        public System.Windows.Forms.Label labelDayOfWeek;
    }
}