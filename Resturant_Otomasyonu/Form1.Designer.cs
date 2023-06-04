
namespace Resturant_Otomasyonu
{
    partial class pageUrunler
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
            this.masa = new System.Windows.Forms.Panel();
            this.flowmasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowurunler = new System.Windows.Forms.FlowLayoutPanel();
            this.urun = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masa.SuspendLayout();
            this.urun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // masa
            // 
            this.masa.Controls.Add(this.flowurunler);
            this.masa.Controls.Add(this.label1);
            this.masa.Controls.Add(this.flowmasalar);
            this.masa.Dock = System.Windows.Forms.DockStyle.Right;
            this.masa.ForeColor = System.Drawing.Color.DarkRed;
            this.masa.Location = new System.Drawing.Point(1164, 0);
            this.masa.Name = "masa";
            this.masa.Size = new System.Drawing.Size(209, 643);
            this.masa.TabIndex = 1;
            // 
            // flowmasalar
            // 
            this.flowmasalar.Location = new System.Drawing.Point(0, 29);
            this.flowmasalar.Name = "flowmasalar";
            this.flowmasalar.Size = new System.Drawing.Size(209, 672);
            this.flowmasalar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "MASALAR";
            // 
            // flowurunler
            // 
            this.flowurunler.Location = new System.Drawing.Point(209, 33);
            this.flowurunler.Name = "flowurunler";
            this.flowurunler.Size = new System.Drawing.Size(196, 607);
            this.flowurunler.TabIndex = 1;
            // 
            // urun
            // 
            this.urun.Controls.Add(this.flowLayoutPanel1);
            this.urun.Controls.Add(this.label2);
            this.urun.Dock = System.Windows.Forms.DockStyle.Right;
            this.urun.Location = new System.Drawing.Point(964, 0);
            this.urun.Name = "urun";
            this.urun.Size = new System.Drawing.Size(200, 643);
            this.urun.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 614);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(64, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "URUNLER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(718, 493);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // pageUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 643);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.urun);
            this.Controls.Add(this.masa);
            this.Name = "pageUrunler";
            this.Text = "Form1";
            this.masa.ResumeLayout(false);
            this.masa.PerformLayout();
            this.urun.ResumeLayout(false);
            this.urun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel masa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowmasalar;
        private System.Windows.Forms.FlowLayoutPanel flowurunler;
        private System.Windows.Forms.Panel urun;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

