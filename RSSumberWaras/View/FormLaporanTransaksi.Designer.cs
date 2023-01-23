
namespace RSSumberWaras.View
{
    partial class FormLaporanTransaksi
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
            this.selesaiLaporanBtn = new System.Windows.Forms.Button();
            this.cariLaporanBtn = new System.Windows.Forms.Button();
            this.laporanBox = new System.Windows.Forms.TextBox();
            this.listViewLaporan = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selesaiLaporanBtn
            // 
            this.selesaiLaporanBtn.Location = new System.Drawing.Point(959, 632);
            this.selesaiLaporanBtn.Name = "selesaiLaporanBtn";
            this.selesaiLaporanBtn.Size = new System.Drawing.Size(135, 48);
            this.selesaiLaporanBtn.TabIndex = 10;
            this.selesaiLaporanBtn.Text = "Selesai";
            this.selesaiLaporanBtn.UseVisualStyleBackColor = true;
            this.selesaiLaporanBtn.Click += new System.EventHandler(this.selesaiLaporanBtn_Click);
            // 
            // cariLaporanBtn
            // 
            this.cariLaporanBtn.Location = new System.Drawing.Point(974, 75);
            this.cariLaporanBtn.Name = "cariLaporanBtn";
            this.cariLaporanBtn.Size = new System.Drawing.Size(91, 34);
            this.cariLaporanBtn.TabIndex = 9;
            this.cariLaporanBtn.Text = "Cari";
            this.cariLaporanBtn.UseVisualStyleBackColor = true;
            // 
            // laporanBox
            // 
            this.laporanBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laporanBox.Location = new System.Drawing.Point(49, 75);
            this.laporanBox.Name = "laporanBox";
            this.laporanBox.Size = new System.Drawing.Size(919, 34);
            this.laporanBox.TabIndex = 8;
            // 
            // listViewLaporan
            // 
            this.listViewLaporan.HideSelection = false;
            this.listViewLaporan.Location = new System.Drawing.Point(49, 116);
            this.listViewLaporan.Name = "listViewLaporan";
            this.listViewLaporan.Size = new System.Drawing.Size(1045, 498);
            this.listViewLaporan.TabIndex = 7;
            this.listViewLaporan.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Laporan Penjualan Obat Ruah Sakit Sumber Waras";
            // 
            // FormLaporanTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 710);
            this.Controls.Add(this.selesaiLaporanBtn);
            this.Controls.Add(this.cariLaporanBtn);
            this.Controls.Add(this.laporanBox);
            this.Controls.Add(this.listViewLaporan);
            this.Controls.Add(this.label1);
            this.Name = "FormLaporanTransaksi";
            this.Text = "FormLaporanTransaksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selesaiLaporanBtn;
        private System.Windows.Forms.Button cariLaporanBtn;
        private System.Windows.Forms.TextBox laporanBox;
        private System.Windows.Forms.ListView listViewLaporan;
        private System.Windows.Forms.Label label1;
    }
}