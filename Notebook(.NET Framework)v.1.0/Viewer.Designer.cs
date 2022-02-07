
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
            this.panelViewerBorderLeft = new System.Windows.Forms.Panel();
            this.panelViewerBorderRight = new System.Windows.Forms.Panel();
            this.panelViewerBorderTop = new System.Windows.Forms.Panel();
            this.panelViewerBorderBottom = new System.Windows.Forms.Panel();
            this.CmdClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelViewer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridContent = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelViewerBorderBottom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContent)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.panelViewerBorderRight.Location = new System.Drawing.Point(790, 0);
            this.panelViewerBorderRight.Name = "panelViewerBorderRight";
            this.panelViewerBorderRight.Size = new System.Drawing.Size(10, 450);
            this.panelViewerBorderRight.TabIndex = 1;
            // 
            // panelViewerBorderTop
            // 
            this.panelViewerBorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelViewerBorderTop.Location = new System.Drawing.Point(10, 0);
            this.panelViewerBorderTop.Name = "panelViewerBorderTop";
            this.panelViewerBorderTop.Size = new System.Drawing.Size(780, 10);
            this.panelViewerBorderTop.TabIndex = 2;
            // 
            // panelViewerBorderBottom
            // 
            this.panelViewerBorderBottom.Controls.Add(this.CmdClose);
            this.panelViewerBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelViewerBorderBottom.Location = new System.Drawing.Point(10, 418);
            this.panelViewerBorderBottom.Name = "panelViewerBorderBottom";
            this.panelViewerBorderBottom.Size = new System.Drawing.Size(780, 32);
            this.panelViewerBorderBottom.TabIndex = 3;
            // 
            // CmdClose
            // 
            this.CmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CmdClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.CmdClose.Location = new System.Drawing.Point(671, 0);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(109, 32);
            this.CmdClose.TabIndex = 1;
            this.CmdClose.Text = "Закрыть(Esc)";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelViewer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 79);
            this.panel2.TabIndex = 0;
            // 
            // labelViewer
            // 
            this.labelViewer.AutoSize = true;
            this.labelViewer.Location = new System.Drawing.Point(46, 30);
            this.labelViewer.Name = "labelViewer";
            this.labelViewer.Size = new System.Drawing.Size(35, 13);
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
            this.panel1.Size = new System.Drawing.Size(780, 408);
            this.panel1.TabIndex = 4;
            // 
            // dataGridContent
            // 
            this.dataGridContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridContent.Location = new System.Drawing.Point(0, 0);
            this.dataGridContent.Name = "dataGridContent";
            this.dataGridContent.Size = new System.Drawing.Size(780, 331);
            this.dataGridContent.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dataGridContent);
            this.panel3.Location = new System.Drawing.Point(0, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(780, 331);
            this.panel3.TabIndex = 1;
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CmdClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelViewerBorderBottom);
            this.Controls.Add(this.panelViewerBorderTop);
            this.Controls.Add(this.panelViewerBorderRight);
            this.Controls.Add(this.panelViewerBorderLeft);
            this.Name = "Viewer";
            this.Text = "Viewer";
            this.panelViewerBorderBottom.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContent)).EndInit();
            this.panel3.ResumeLayout(false);
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
    }
}