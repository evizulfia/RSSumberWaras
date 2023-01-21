
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
            this.selesaiPasienBtn.Location = new System.Drawing.Point(646, 499);
            this.selesaiPasienBtn.Margin = new System.Windows.Forms.Padding(2);
            this.selesaiPasienBtn.Name = "selesaiPasienBtn";
            this.selesaiPasienBtn.Size = new System.Drawing.Size(121, 28);
            this.selesaiPasienBtn.TabIndex = 23;
            this.selesaiPasienBtn.Text = "Selesai";
            this.selesaiPasienBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Data Pasien RS Sumber Waras";
            // 
            // hapusPasienBtn
            // 
            this.hapusPasienBtn.Location = new System.Drawing.Point(699, 61);
            this.hapusPasienBtn.Margin = new System.Windows.Forms.Padding(2);
            this.hapusPasienBtn.Name = "hapusPasienBtn";
            this.hapusPasienBtn.Size = new System.Drawing.Size(68, 28);
            this.hapusPasienBtn.TabIndex = 21;
            this.hapusPasienBtn.Text = "Hapus";
            this.hapusPasienBtn.UseVisualStyleBackColor = true;
            // 
            // editPasienBtn
            // 
            this.editPasienBtn.Location = new System.Drawing.Point(614, 61);
            this.editPasienBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editPasienBtn.Name = "editPasienBtn";
            this.editPasienBtn.Size = new System.Drawing.Size(68, 28);
            this.editPasienBtn.TabIndex = 20;
            this.editPasienBtn.Text = "Edit";
            this.editPasienBtn.UseVisualStyleBackColor = true;
            // 
            // tmbhPasienBtn
            // 
            this.tmbhPasienBtn.Location = new System.Drawing.Point(529, 61);
            this.tmbhPasienBtn.Margin = new System.Windows.Forms.Padding(2);
            this.tmbhPasienBtn.Name = "tmbhPasienBtn";
            this.tmbhPasienBtn.Size = new System.Drawing.Size(68, 28);
            this.tmbhPasienBtn.TabIndex = 19;
            this.tmbhPasienBtn.Text = "Tambah";
            this.tmbhPasienBtn.UseVisualStyleBackColor = true;
            // 
            // cariPasienBtn
            // 
            this.cariPasienBtn.Location = new System.Drawing.Point(446, 61);
            this.cariPasienBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cariPasienBtn.Name = "cariPasienBtn";
            this.cariPasienBtn.Size = new System.Drawing.Size(68, 28);
            this.cariPasienBtn.TabIndex = 18;
            this.cariPasienBtn.Text = "Cari";
            this.cariPasienBtn.UseVisualStyleBackColor = true;
            // 
            // cariPasienBox
            // 
            this.cariPasienBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariPasienBox.Location = new System.Drawing.Point(27, 61);
            this.cariPasienBox.Margin = new System.Windows.Forms.Padding(2);
            this.cariPasienBox.Name = "cariPasienBox";
            this.cariPasienBox.Size = new System.Drawing.Size(408, 28);
            this.cariPasienBox.TabIndex = 17;
            // 
            // listViewPasien
            // 
            this.listViewPasien.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listViewPasien.HideSelection = false;
            this.listViewPasien.Location = new System.Drawing.Point(27, 101);
            this.listViewPasien.Margin = new System.Windows.Forms.Padding(2);
            this.listViewPasien.Name = "listViewPasien";
            this.listViewPasien.Size = new System.Drawing.Size(740, 374);
            this.listViewPasien.TabIndex = 16;
            this.listViewPasien.UseCompatibleStateImageBehavior = false;
            // 
            // FormPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 553);
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