
namespace RSSumberWaras.View
{
    partial class FormEntryTransaksi
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
            this.tglTransaksiPicker = new System.Windows.Forms.DateTimePicker();
            this.qtyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelesaiEntryTransBtn = new System.Windows.Forms.Button();
            this.entryTransaksiSimpanBtn = new System.Windows.Forms.Button();
            this.noHp = new System.Windows.Forms.Label();
            this.namaDokter = new System.Windows.Forms.Label();
            this.idPasienBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idTransaksiBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idObatBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusPembayaranDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tglTransaksiPicker
            // 
            this.tglTransaksiPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tglTransaksiPicker.Location = new System.Drawing.Point(321, 333);
            this.tglTransaksiPicker.Name = "tglTransaksiPicker";
            this.tglTransaksiPicker.Size = new System.Drawing.Size(458, 38);
            this.tglTransaksiPicker.TabIndex = 47;
            // 
            // qtyBox
            // 
            this.qtyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyBox.Location = new System.Drawing.Point(321, 407);
            this.qtyBox.Name = "qtyBox";
            this.qtyBox.Size = new System.Drawing.Size(460, 38);
            this.qtyBox.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "Jumlah";
            // 
            // SelesaiEntryTransBtn
            // 
            this.SelesaiEntryTransBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelesaiEntryTransBtn.Location = new System.Drawing.Point(611, 636);
            this.SelesaiEntryTransBtn.Name = "SelesaiEntryTransBtn";
            this.SelesaiEntryTransBtn.Size = new System.Drawing.Size(157, 53);
            this.SelesaiEntryTransBtn.TabIndex = 42;
            this.SelesaiEntryTransBtn.Text = "Selesai";
            this.SelesaiEntryTransBtn.UseVisualStyleBackColor = true;
            this.SelesaiEntryTransBtn.Click += new System.EventHandler(this.SelesaiEntryTransBtn_Click);
            // 
            // entryTransaksiSimpanBtn
            // 
            this.entryTransaksiSimpanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryTransaksiSimpanBtn.Location = new System.Drawing.Point(416, 636);
            this.entryTransaksiSimpanBtn.Name = "entryTransaksiSimpanBtn";
            this.entryTransaksiSimpanBtn.Size = new System.Drawing.Size(156, 53);
            this.entryTransaksiSimpanBtn.TabIndex = 41;
            this.entryTransaksiSimpanBtn.Text = "Simpan";
            this.entryTransaksiSimpanBtn.UseVisualStyleBackColor = true;
            this.entryTransaksiSimpanBtn.Click += new System.EventHandler(this.entryTransaksiSimpanBtn_Click);
            // 
            // noHp
            // 
            this.noHp.AutoSize = true;
            this.noHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noHp.Location = new System.Drawing.Point(74, 339);
            this.noHp.Name = "noHp";
            this.noHp.Size = new System.Drawing.Size(213, 29);
            this.noHp.TabIndex = 38;
            this.noHp.Text = "Tanggal Transaksi";
            // 
            // namaDokter
            // 
            this.namaDokter.AutoSize = true;
            this.namaDokter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaDokter.Location = new System.Drawing.Point(75, 187);
            this.namaDokter.Name = "namaDokter";
            this.namaDokter.Size = new System.Drawing.Size(116, 29);
            this.namaDokter.TabIndex = 35;
            this.namaDokter.Text = "ID Pasien";
            // 
            // idPasienBox
            // 
            this.idPasienBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPasienBox.Location = new System.Drawing.Point(321, 181);
            this.idPasienBox.Name = "idPasienBox";
            this.idPasienBox.Size = new System.Drawing.Size(460, 38);
            this.idPasienBox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 49;
            this.label1.Text = "ID Transaksi";
            // 
            // idTransaksiBox
            // 
            this.idTransaksiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTransaksiBox.Location = new System.Drawing.Point(321, 113);
            this.idTransaksiBox.Name = "idTransaksiBox";
            this.idTransaksiBox.Size = new System.Drawing.Size(460, 38);
            this.idTransaksiBox.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 51;
            this.label3.Text = "ID Obat";
            // 
            // idObatBox
            // 
            this.idObatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idObatBox.Location = new System.Drawing.Point(321, 260);
            this.idObatBox.Name = "idObatBox";
            this.idObatBox.Size = new System.Drawing.Size(460, 38);
            this.idObatBox.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 52;
            this.label4.Text = "Status";
            // 
            // statusPembayaranDropDown
            // 
            this.statusPembayaranDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.statusPembayaranDropDown.FormattingEnabled = true;
            this.statusPembayaranDropDown.Items.AddRange(new object[] {
            "Lunas",
            "Belum Lunas"});
            this.statusPembayaranDropDown.Location = new System.Drawing.Point(321, 475);
            this.statusPembayaranDropDown.Name = "statusPembayaranDropDown";
            this.statusPembayaranDropDown.Size = new System.Drawing.Size(458, 40);
            this.statusPembayaranDropDown.TabIndex = 53;
            // 
            // FormEntryTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 731);
            this.Controls.Add(this.statusPembayaranDropDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idObatBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTransaksiBox);
            this.Controls.Add(this.tglTransaksiPicker);
            this.Controls.Add(this.qtyBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelesaiEntryTransBtn);
            this.Controls.Add(this.entryTransaksiSimpanBtn);
            this.Controls.Add(this.noHp);
            this.Controls.Add(this.namaDokter);
            this.Controls.Add(this.idPasienBox);
            this.Name = "FormEntryTransaksi";
            this.Text = "FormEntryTransaksi";
            this.Load += new System.EventHandler(this.FormEntryTransaksi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker tglTransaksiPicker;
        private System.Windows.Forms.TextBox qtyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SelesaiEntryTransBtn;
        private System.Windows.Forms.Button entryTransaksiSimpanBtn;
        private System.Windows.Forms.Label noHp;
        private System.Windows.Forms.Label namaDokter;
        private System.Windows.Forms.TextBox idPasienBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTransaksiBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idObatBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox statusPembayaranDropDown;
    }
}