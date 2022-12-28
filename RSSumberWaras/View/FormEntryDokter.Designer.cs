
namespace RSSumberWaras.View
{
    partial class FormEntryDokter
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
            this.namaDokterBox = new System.Windows.Forms.TextBox();
            this.namaDokter = new System.Windows.Forms.Label();
            this.idDokter = new System.Windows.Forms.Label();
            this.spesialisasi = new System.Windows.Forms.Label();
            this.noHp = new System.Windows.Forms.Label();
            this.idDokterBox = new System.Windows.Forms.TextBox();
            this.spesialisasiBox = new System.Windows.Forms.TextBox();
            this.noHpDokBox = new System.Windows.Forms.TextBox();
            this.doktSimpanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namaDokterBox
            // 
            this.namaDokterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaDokterBox.Location = new System.Drawing.Point(280, 111);
            this.namaDokterBox.Name = "namaDokterBox";
            this.namaDokterBox.Size = new System.Drawing.Size(538, 38);
            this.namaDokterBox.TabIndex = 0;
            // 
            // namaDokter
            // 
            this.namaDokter.AutoSize = true;
            this.namaDokter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaDokter.Location = new System.Drawing.Point(34, 120);
            this.namaDokter.Name = "namaDokter";
            this.namaDokter.Size = new System.Drawing.Size(154, 29);
            this.namaDokter.TabIndex = 1;
            this.namaDokter.Text = "Nama Dokter";
            // 
            // idDokter
            // 
            this.idDokter.AutoSize = true;
            this.idDokter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDokter.Location = new System.Drawing.Point(34, 64);
            this.idDokter.Name = "idDokter";
            this.idDokter.Size = new System.Drawing.Size(113, 29);
            this.idDokter.TabIndex = 2;
            this.idDokter.Text = "ID Dokter";
            // 
            // spesialisasi
            // 
            this.spesialisasi.AutoSize = true;
            this.spesialisasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spesialisasi.Location = new System.Drawing.Point(34, 173);
            this.spesialisasi.Name = "spesialisasi";
            this.spesialisasi.Size = new System.Drawing.Size(143, 29);
            this.spesialisasi.TabIndex = 3;
            this.spesialisasi.Text = "Spesialisasi";
            // 
            // noHp
            // 
            this.noHp.AutoSize = true;
            this.noHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noHp.Location = new System.Drawing.Point(34, 231);
            this.noHp.Name = "noHp";
            this.noHp.Size = new System.Drawing.Size(218, 29);
            this.noHp.TabIndex = 4;
            this.noHp.Text = "Nomor Handphone";
            // 
            // idDokterBox
            // 
            this.idDokterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDokterBox.Location = new System.Drawing.Point(280, 58);
            this.idDokterBox.Name = "idDokterBox";
            this.idDokterBox.Size = new System.Drawing.Size(538, 38);
            this.idDokterBox.TabIndex = 5;
            // 
            // spesialisasiBox
            // 
            this.spesialisasiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spesialisasiBox.Location = new System.Drawing.Point(280, 173);
            this.spesialisasiBox.Name = "spesialisasiBox";
            this.spesialisasiBox.Size = new System.Drawing.Size(538, 38);
            this.spesialisasiBox.TabIndex = 6;
            // 
            // noHpDokBox
            // 
            this.noHpDokBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noHpDokBox.Location = new System.Drawing.Point(280, 231);
            this.noHpDokBox.Name = "noHpDokBox";
            this.noHpDokBox.Size = new System.Drawing.Size(538, 38);
            this.noHpDokBox.TabIndex = 7;
            // 
            // doktSimpanBtn
            // 
            this.doktSimpanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doktSimpanBtn.Location = new System.Drawing.Point(623, 330);
            this.doktSimpanBtn.Name = "doktSimpanBtn";
            this.doktSimpanBtn.Size = new System.Drawing.Size(195, 53);
            this.doktSimpanBtn.TabIndex = 8;
            this.doktSimpanBtn.Text = "Simpan";
            this.doktSimpanBtn.UseVisualStyleBackColor = true;
            // 
            // FormEntryDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 421);
            this.Controls.Add(this.doktSimpanBtn);
            this.Controls.Add(this.noHpDokBox);
            this.Controls.Add(this.spesialisasiBox);
            this.Controls.Add(this.idDokterBox);
            this.Controls.Add(this.noHp);
            this.Controls.Add(this.spesialisasi);
            this.Controls.Add(this.idDokter);
            this.Controls.Add(this.namaDokter);
            this.Controls.Add(this.namaDokterBox);
            this.Name = "FormEntryDokter";
            this.Text = "FormEntryDokter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namaDokterBox;
        private System.Windows.Forms.Label namaDokter;
        private System.Windows.Forms.Label idDokter;
        private System.Windows.Forms.Label spesialisasi;
        private System.Windows.Forms.Label noHp;
        private System.Windows.Forms.TextBox idDokterBox;
        private System.Windows.Forms.TextBox spesialisasiBox;
        private System.Windows.Forms.TextBox noHpDokBox;
        private System.Windows.Forms.Button doktSimpanBtn;
    }
}