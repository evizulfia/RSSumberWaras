
namespace RSSumberWaras.View
{
    partial class FormDokter
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
            this.listViewDokter = new System.Windows.Forms.ListView();
            this.cariDokterBox = new System.Windows.Forms.TextBox();
            this.cariDokterBtn = new System.Windows.Forms.Button();
            this.tmbhDokterBtn = new System.Windows.Forms.Button();
            this.editDokterBtn = new System.Windows.Forms.Button();
            this.hapusDokterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selesaiDokterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewDokter
            // 
            this.listViewDokter.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listViewDokter.HideSelection = false;
            this.listViewDokter.Location = new System.Drawing.Point(30, 128);
            this.listViewDokter.Name = "listViewDokter";
            this.listViewDokter.Size = new System.Drawing.Size(986, 459);
            this.listViewDokter.TabIndex = 0;
            this.listViewDokter.UseCompatibleStateImageBehavior = false;
            // 
            // cariDokterBox
            // 
            this.cariDokterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariDokterBox.Location = new System.Drawing.Point(30, 79);
            this.cariDokterBox.Name = "cariDokterBox";
            this.cariDokterBox.Size = new System.Drawing.Size(542, 34);
            this.cariDokterBox.TabIndex = 1;
            // 
            // cariDokterBtn
            // 
            this.cariDokterBtn.Location = new System.Drawing.Point(588, 79);
            this.cariDokterBtn.Name = "cariDokterBtn";
            this.cariDokterBtn.Size = new System.Drawing.Size(91, 34);
            this.cariDokterBtn.TabIndex = 2;
            this.cariDokterBtn.Text = "Cari";
            this.cariDokterBtn.UseVisualStyleBackColor = true;
            // 
            // tmbhDokterBtn
            // 
            this.tmbhDokterBtn.Location = new System.Drawing.Point(699, 79);
            this.tmbhDokterBtn.Name = "tmbhDokterBtn";
            this.tmbhDokterBtn.Size = new System.Drawing.Size(91, 34);
            this.tmbhDokterBtn.TabIndex = 3;
            this.tmbhDokterBtn.Text = "Tambah";
            this.tmbhDokterBtn.UseVisualStyleBackColor = true;
            this.tmbhDokterBtn.Click += new System.EventHandler(this.tmbhDokterBtn_Click);
            // 
            // editDokterBtn
            // 
            this.editDokterBtn.Location = new System.Drawing.Point(812, 79);
            this.editDokterBtn.Name = "editDokterBtn";
            this.editDokterBtn.Size = new System.Drawing.Size(91, 34);
            this.editDokterBtn.TabIndex = 4;
            this.editDokterBtn.Text = "Edit";
            this.editDokterBtn.UseVisualStyleBackColor = true;
            // 
            // hapusDokterBtn
            // 
            this.hapusDokterBtn.Location = new System.Drawing.Point(925, 79);
            this.hapusDokterBtn.Name = "hapusDokterBtn";
            this.hapusDokterBtn.Size = new System.Drawing.Size(91, 34);
            this.hapusDokterBtn.TabIndex = 5;
            this.hapusDokterBtn.Text = "Hapus";
            this.hapusDokterBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Daftar Dokter RS Sumber Waras";
            // 
            // selesaiDokterBtn
            // 
            this.selesaiDokterBtn.Location = new System.Drawing.Point(855, 618);
            this.selesaiDokterBtn.Name = "selesaiDokterBtn";
            this.selesaiDokterBtn.Size = new System.Drawing.Size(161, 34);
            this.selesaiDokterBtn.TabIndex = 7;
            this.selesaiDokterBtn.Text = "Selesai";
            this.selesaiDokterBtn.UseVisualStyleBackColor = true;
            this.selesaiDokterBtn.Click += new System.EventHandler(this.selesaiDokterBtn_Click);
            // 
            // FormDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 681);
            this.Controls.Add(this.selesaiDokterBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hapusDokterBtn);
            this.Controls.Add(this.editDokterBtn);
            this.Controls.Add(this.tmbhDokterBtn);
            this.Controls.Add(this.cariDokterBtn);
            this.Controls.Add(this.cariDokterBox);
            this.Controls.Add(this.listViewDokter);
            this.Name = "FormDokter";
            this.Text = "FormDokter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDokter;
        private System.Windows.Forms.TextBox cariDokterBox;
        private System.Windows.Forms.Button cariDokterBtn;
        private System.Windows.Forms.Button tmbhDokterBtn;
        private System.Windows.Forms.Button editDokterBtn;
        private System.Windows.Forms.Button hapusDokterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selesaiDokterBtn;
    }
}