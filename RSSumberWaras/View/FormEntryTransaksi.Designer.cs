
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
            this.totalBox = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // tglTransaksiPicker
            // 
            this.tglTransaksiPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tglTransaksiPicker.Location = new System.Drawing.Point(321, 356);
            this.tglTransaksiPicker.Name = "tglTransaksiPicker";
            this.tglTransaksiPicker.Size = new System.Drawing.Size(458, 38);
            this.tglTransaksiPicker.TabIndex = 47;
            // 
            // totalBox
            // 
            this.totalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBox.Location = new System.Drawing.Point(321, 430);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(460, 38);
            this.totalBox.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 45;
            this.label2.Text = "Total";
            // 
            // SelesaiEntryTransBtn
            // 
            this.SelesaiEntryTransBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelesaiEntryTransBtn.Location = new System.Drawing.Point(465, 560);
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
            this.entryTransaksiSimpanBtn.Location = new System.Drawing.Point(270, 560);
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
            this.noHp.Location = new System.Drawing.Point(74, 362);
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
            // FormEntryTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 731);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idObatBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTransaksiBox);
            this.Controls.Add(this.tglTransaksiPicker);
            this.Controls.Add(this.totalBox);
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
        private System.Windows.Forms.TextBox totalBox;
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
    }
}