
namespace RSSumberWaras.View
{
    partial class FormEntryRekamMedis
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
            this.EntryFormObatSelesaiBtn = new System.Windows.Forms.Button();
            this.rekamMedisSimpanBtn = new System.Windows.Forms.Button();
            this.idDokterBox = new System.Windows.Forms.TextBox();
            this.idRekamMedisBox = new System.Windows.Forms.TextBox();
            this.noHp = new System.Windows.Forms.Label();
            this.spesialisasi = new System.Windows.Forms.Label();
            this.idDokter = new System.Windows.Forms.Label();
            this.namaDokter = new System.Windows.Forms.Label();
            this.idPasienBox = new System.Windows.Forms.TextBox();
            this.diagnosaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tindakanBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tglPeriksaRekamMedisPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // EntryFormObatSelesaiBtn
            // 
            this.EntryFormObatSelesaiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFormObatSelesaiBtn.Location = new System.Drawing.Point(805, 555);
            this.EntryFormObatSelesaiBtn.Name = "EntryFormObatSelesaiBtn";
            this.EntryFormObatSelesaiBtn.Size = new System.Drawing.Size(195, 53);
            this.EntryFormObatSelesaiBtn.TabIndex = 28;
            this.EntryFormObatSelesaiBtn.Text = "Selesai";
            this.EntryFormObatSelesaiBtn.UseVisualStyleBackColor = true;
            this.EntryFormObatSelesaiBtn.Click += new System.EventHandler(this.EntryFormObatSelesaiBtn_Click);
            // 
            // rekamMedisSimpanBtn
            // 
            this.rekamMedisSimpanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rekamMedisSimpanBtn.Location = new System.Drawing.Point(556, 555);
            this.rekamMedisSimpanBtn.Name = "rekamMedisSimpanBtn";
            this.rekamMedisSimpanBtn.Size = new System.Drawing.Size(195, 53);
            this.rekamMedisSimpanBtn.TabIndex = 27;
            this.rekamMedisSimpanBtn.Text = "Simpan";
            this.rekamMedisSimpanBtn.UseVisualStyleBackColor = true;
            this.rekamMedisSimpanBtn.Click += new System.EventHandler(this.rekamMedisSimpanBtn_Click);
            // 
            // idDokterBox
            // 
            this.idDokterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDokterBox.Location = new System.Drawing.Point(462, 231);
            this.idDokterBox.Name = "idDokterBox";
            this.idDokterBox.Size = new System.Drawing.Size(538, 38);
            this.idDokterBox.TabIndex = 25;
            // 
            // idRekamMedisBox
            // 
            this.idRekamMedisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idRekamMedisBox.Location = new System.Drawing.Point(462, 116);
            this.idRekamMedisBox.Name = "idRekamMedisBox";
            this.idRekamMedisBox.Size = new System.Drawing.Size(538, 38);
            this.idRekamMedisBox.TabIndex = 24;
            // 
            // noHp
            // 
            this.noHp.AutoSize = true;
            this.noHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noHp.Location = new System.Drawing.Point(216, 295);
            this.noHp.Name = "noHp";
            this.noHp.Size = new System.Drawing.Size(189, 29);
            this.noHp.TabIndex = 23;
            this.noHp.Text = "Tanggal Periksa";
            // 
            // spesialisasi
            // 
            this.spesialisasi.AutoSize = true;
            this.spesialisasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spesialisasi.Location = new System.Drawing.Point(216, 231);
            this.spesialisasi.Name = "spesialisasi";
            this.spesialisasi.Size = new System.Drawing.Size(113, 29);
            this.spesialisasi.TabIndex = 22;
            this.spesialisasi.Text = "ID Dokter";
            // 
            // idDokter
            // 
            this.idDokter.AutoSize = true;
            this.idDokter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDokter.Location = new System.Drawing.Point(216, 122);
            this.idDokter.Name = "idDokter";
            this.idDokter.Size = new System.Drawing.Size(190, 29);
            this.idDokter.TabIndex = 21;
            this.idDokter.Text = "ID Rekam Medis";
            // 
            // namaDokter
            // 
            this.namaDokter.AutoSize = true;
            this.namaDokter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaDokter.Location = new System.Drawing.Point(216, 178);
            this.namaDokter.Name = "namaDokter";
            this.namaDokter.Size = new System.Drawing.Size(116, 29);
            this.namaDokter.TabIndex = 20;
            this.namaDokter.Text = "ID Pasien";
            // 
            // idPasienBox
            // 
            this.idPasienBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPasienBox.Location = new System.Drawing.Point(462, 169);
            this.idPasienBox.Name = "idPasienBox";
            this.idPasienBox.Size = new System.Drawing.Size(538, 38);
            this.idPasienBox.TabIndex = 19;
            // 
            // diagnosaBox
            // 
            this.diagnosaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosaBox.Location = new System.Drawing.Point(462, 344);
            this.diagnosaBox.Name = "diagnosaBox";
            this.diagnosaBox.Size = new System.Drawing.Size(538, 38);
            this.diagnosaBox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Diagnosa";
            // 
            // tindakanBox
            // 
            this.tindakanBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tindakanBox.Location = new System.Drawing.Point(462, 408);
            this.tindakanBox.Name = "tindakanBox";
            this.tindakanBox.Size = new System.Drawing.Size(538, 38);
            this.tindakanBox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tindakan";
            // 
            // tglPeriksaRekamMedisPicker
            // 
            this.tglPeriksaRekamMedisPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tglPeriksaRekamMedisPicker.Location = new System.Drawing.Point(463, 289);
            this.tglPeriksaRekamMedisPicker.Name = "tglPeriksaRekamMedisPicker";
            this.tglPeriksaRekamMedisPicker.Size = new System.Drawing.Size(536, 38);
            this.tglPeriksaRekamMedisPicker.TabIndex = 33;
            // 
            // FormEntryRekamMedis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 777);
            this.Controls.Add(this.tglPeriksaRekamMedisPicker);
            this.Controls.Add(this.tindakanBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diagnosaBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EntryFormObatSelesaiBtn);
            this.Controls.Add(this.rekamMedisSimpanBtn);
            this.Controls.Add(this.idDokterBox);
            this.Controls.Add(this.idRekamMedisBox);
            this.Controls.Add(this.noHp);
            this.Controls.Add(this.spesialisasi);
            this.Controls.Add(this.idDokter);
            this.Controls.Add(this.namaDokter);
            this.Controls.Add(this.idPasienBox);
            this.Name = "FormEntryRekamMedis";
            this.Text = "FormEntryRekamMedis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EntryFormObatSelesaiBtn;
        private System.Windows.Forms.Button rekamMedisSimpanBtn;
        private System.Windows.Forms.TextBox idDokterBox;
        private System.Windows.Forms.TextBox idRekamMedisBox;
        private System.Windows.Forms.Label noHp;
        private System.Windows.Forms.Label spesialisasi;
        private System.Windows.Forms.Label idDokter;
        private System.Windows.Forms.Label namaDokter;
        private System.Windows.Forms.TextBox idPasienBox;
        private System.Windows.Forms.TextBox diagnosaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tindakanBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tglPeriksaRekamMedisPicker;
    }
}