
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
            this.laporanCariBox = new System.Windows.Forms.TextBox();
            this.listViewLaporan = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.filterDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // selesaiLaporanBtn
            // 
            this.selesaiLaporanBtn.Location = new System.Drawing.Point(1695, 956);
            this.selesaiLaporanBtn.Name = "selesaiLaporanBtn";
            this.selesaiLaporanBtn.Size = new System.Drawing.Size(135, 48);
            this.selesaiLaporanBtn.TabIndex = 10;
            this.selesaiLaporanBtn.Text = "Selesai";
            this.selesaiLaporanBtn.UseVisualStyleBackColor = true;
            this.selesaiLaporanBtn.Click += new System.EventHandler(this.selesaiLaporanBtn_Click);
            // 
            // cariLaporanBtn
            // 
            this.cariLaporanBtn.Location = new System.Drawing.Point(1661, 157);
            this.cariLaporanBtn.Name = "cariLaporanBtn";
            this.cariLaporanBtn.Size = new System.Drawing.Size(169, 53);
            this.cariLaporanBtn.TabIndex = 9;
            this.cariLaporanBtn.Text = "Tampilkan Data";
            this.cariLaporanBtn.UseVisualStyleBackColor = true;
            this.cariLaporanBtn.Click += new System.EventHandler(this.cariLaporanBtn_Click);
            // 
            // laporanCariBox
            // 
            this.laporanCariBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.laporanCariBox.Location = new System.Drawing.Point(445, 159);
            this.laporanCariBox.Name = "laporanCariBox";
            this.laporanCariBox.Size = new System.Drawing.Size(1187, 39);
            this.laporanCariBox.TabIndex = 8;
            // 
            // listViewLaporan
            // 
            this.listViewLaporan.HideSelection = false;
            this.listViewLaporan.Location = new System.Drawing.Point(49, 233);
            this.listViewLaporan.Name = "listViewLaporan";
            this.listViewLaporan.Size = new System.Drawing.Size(1781, 717);
            this.listViewLaporan.TabIndex = 7;
            this.listViewLaporan.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Laporan Transaksi Rumah Sakit Sumber Waras";
            // 
            // filterDropdown
            // 
            this.filterDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.filterDropdown.FormattingEnabled = true;
            this.filterDropdown.Items.AddRange(new object[] {
            "Semua",
            "ID Transaksi",
            "Nama pasien"});
            this.filterDropdown.Location = new System.Drawing.Point(49, 159);
            this.filterDropdown.Name = "filterDropdown";
            this.filterDropdown.Size = new System.Drawing.Size(344, 40);
            this.filterDropdown.TabIndex = 11;
            // 
            // FormLaporanTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.filterDropdown);
            this.Controls.Add(this.selesaiLaporanBtn);
            this.Controls.Add(this.cariLaporanBtn);
            this.Controls.Add(this.laporanCariBox);
            this.Controls.Add(this.listViewLaporan);
            this.Controls.Add(this.label1);
            this.Name = "FormLaporanTransaksi";
            this.Text = "FormLaporanTransaksi";
            this.Load += new System.EventHandler(this.maximise);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selesaiLaporanBtn;
        private System.Windows.Forms.Button cariLaporanBtn;
        private System.Windows.Forms.TextBox laporanCariBox;
        private System.Windows.Forms.ListView listViewLaporan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filterDropdown;
    }
}