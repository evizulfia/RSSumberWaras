
namespace RSSumberWaras.View
{
    partial class FormPasien
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
            this.selesaiPasienBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hapusPasienBtn = new System.Windows.Forms.Button();
            this.editPasienBtn = new System.Windows.Forms.Button();
            this.tmbhPasienBtn = new System.Windows.Forms.Button();
            this.cariPasienBtn = new System.Windows.Forms.Button();
            this.cariPasienBox = new System.Windows.Forms.TextBox();
            this.listViewPasien = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // selesaiPasienBtn
            // 
            this.selesaiPasienBtn.Location = new System.Drawing.Point(1654, 923);
            this.selesaiPasienBtn.Name = "selesaiPasienBtn";
            this.selesaiPasienBtn.Size = new System.Drawing.Size(161, 34);
            this.selesaiPasienBtn.TabIndex = 23;
            this.selesaiPasienBtn.Text = "Selesai";
            this.selesaiPasienBtn.UseVisualStyleBackColor = true;
            this.selesaiPasienBtn.Click += new System.EventHandler(this.selesaiPasienBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Daftar Pasien RS Sumber Waras";
            // 
            // hapusPasienBtn
            // 
            this.hapusPasienBtn.Location = new System.Drawing.Point(1724, 116);
            this.hapusPasienBtn.Name = "hapusPasienBtn";
            this.hapusPasienBtn.Size = new System.Drawing.Size(91, 34);
            this.hapusPasienBtn.TabIndex = 21;
            this.hapusPasienBtn.Text = "Hapus";
            this.hapusPasienBtn.UseVisualStyleBackColor = true;
            this.hapusPasienBtn.Click += new System.EventHandler(this.hapusPasienBtn_Click);
            // 
            // editPasienBtn
            // 
            this.editPasienBtn.Location = new System.Drawing.Point(1611, 116);
            this.editPasienBtn.Name = "editPasienBtn";
            this.editPasienBtn.Size = new System.Drawing.Size(91, 34);
            this.editPasienBtn.TabIndex = 20;
            this.editPasienBtn.Text = "Edit";
            this.editPasienBtn.UseVisualStyleBackColor = true;
            this.editPasienBtn.Click += new System.EventHandler(this.editPasienBtn_Click);
            // 
            // tmbhPasienBtn
            // 
            this.tmbhPasienBtn.Location = new System.Drawing.Point(1498, 116);
            this.tmbhPasienBtn.Name = "tmbhPasienBtn";
            this.tmbhPasienBtn.Size = new System.Drawing.Size(91, 34);
            this.tmbhPasienBtn.TabIndex = 19;
            this.tmbhPasienBtn.Text = "Tambah";
            this.tmbhPasienBtn.UseVisualStyleBackColor = true;
            this.tmbhPasienBtn.Click += new System.EventHandler(this.tmbhPasienBtn_Click);
            // 
            // cariPasienBtn
            // 
            this.cariPasienBtn.Location = new System.Drawing.Point(1387, 116);
            this.cariPasienBtn.Name = "cariPasienBtn";
            this.cariPasienBtn.Size = new System.Drawing.Size(91, 34);
            this.cariPasienBtn.TabIndex = 18;
            this.cariPasienBtn.Text = "Cari";
            this.cariPasienBtn.UseVisualStyleBackColor = true;
            this.cariPasienBtn.Click += new System.EventHandler(this.cariPasienBtn_Click);
            // 
            // cariPasienBox
            // 
            this.cariPasienBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariPasienBox.Location = new System.Drawing.Point(106, 116);
            this.cariPasienBox.Name = "cariPasienBox";
            this.cariPasienBox.Size = new System.Drawing.Size(1263, 34);
            this.cariPasienBox.TabIndex = 17;
            // 
            // listViewPasien
            // 
            this.listViewPasien.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listViewPasien.HideSelection = false;
            this.listViewPasien.Location = new System.Drawing.Point(106, 165);
            this.listViewPasien.Name = "listViewPasien";
            this.listViewPasien.Size = new System.Drawing.Size(1709, 725);
            this.listViewPasien.TabIndex = 16;
            this.listViewPasien.UseCompatibleStateImageBehavior = false;
            // 
            // FormPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.selesaiPasienBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hapusPasienBtn);
            this.Controls.Add(this.editPasienBtn);
            this.Controls.Add(this.tmbhPasienBtn);
            this.Controls.Add(this.cariPasienBtn);
            this.Controls.Add(this.cariPasienBox);
            this.Controls.Add(this.listViewPasien);
            this.Name = "FormPasien";
            this.Text = "FormPasien";
            this.Load += new System.EventHandler(this.maximise);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selesaiPasienBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hapusPasienBtn;
        private System.Windows.Forms.Button editPasienBtn;
        private System.Windows.Forms.Button tmbhPasienBtn;
        private System.Windows.Forms.Button cariPasienBtn;
        private System.Windows.Forms.TextBox cariPasienBox;
        private System.Windows.Forms.ListView listViewPasien;
    }
}