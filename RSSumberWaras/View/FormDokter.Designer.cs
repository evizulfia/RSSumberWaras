
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewDokter
            // 
            this.listViewDokter.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listViewDokter.HideSelection = false;
            this.listViewDokter.Location = new System.Drawing.Point(116, 159);
            this.listViewDokter.Name = "listViewDokter";
            this.listViewDokter.Size = new System.Drawing.Size(1774, 783);
            this.listViewDokter.TabIndex = 0;
            this.listViewDokter.UseCompatibleStateImageBehavior = false;
            this.listViewDokter.SelectedIndexChanged += new System.EventHandler(this.listViewDokter_SelectedIndexChanged);
            // 
            // cariDokterBox
            // 
            this.cariDokterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariDokterBox.Location = new System.Drawing.Point(213, 110);
            this.cariDokterBox.Name = "cariDokterBox";
            this.cariDokterBox.Size = new System.Drawing.Size(1228, 34);
            this.cariDokterBox.TabIndex = 1;
            // 
            // cariDokterBtn
            // 
            this.cariDokterBtn.Location = new System.Drawing.Point(1462, 110);
            this.cariDokterBtn.Name = "cariDokterBtn";
            this.cariDokterBtn.Size = new System.Drawing.Size(91, 34);
            this.cariDokterBtn.TabIndex = 2;
            this.cariDokterBtn.Text = "Cari";
            this.cariDokterBtn.UseVisualStyleBackColor = true;
            this.cariDokterBtn.Click += new System.EventHandler(this.cariDokterBtn_Click);
            // 
            // tmbhDokterBtn
            // 
            this.tmbhDokterBtn.Location = new System.Drawing.Point(1573, 110);
            this.tmbhDokterBtn.Name = "tmbhDokterBtn";
            this.tmbhDokterBtn.Size = new System.Drawing.Size(91, 34);
            this.tmbhDokterBtn.TabIndex = 3;
            this.tmbhDokterBtn.Text = "Tambah";
            this.tmbhDokterBtn.UseVisualStyleBackColor = true;
            this.tmbhDokterBtn.Click += new System.EventHandler(this.tmbhDokterBtn_Click);
            // 
            // editDokterBtn
            // 
            this.editDokterBtn.Location = new System.Drawing.Point(1686, 110);
            this.editDokterBtn.Name = "editDokterBtn";
            this.editDokterBtn.Size = new System.Drawing.Size(91, 34);
            this.editDokterBtn.TabIndex = 4;
            this.editDokterBtn.Text = "Edit";
            this.editDokterBtn.UseVisualStyleBackColor = true;
            this.editDokterBtn.Click += new System.EventHandler(this.editDokterBtn_Click);
            // 
            // hapusDokterBtn
            // 
            this.hapusDokterBtn.Location = new System.Drawing.Point(1799, 110);
            this.hapusDokterBtn.Name = "hapusDokterBtn";
            this.hapusDokterBtn.Size = new System.Drawing.Size(91, 34);
            this.hapusDokterBtn.TabIndex = 5;
            this.hapusDokterBtn.Text = "Hapus";
            this.hapusDokterBtn.UseVisualStyleBackColor = true;
            this.hapusDokterBtn.Click += new System.EventHandler(this.hapusDokterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Daftar Dokter RS Sumber Waras";
            // 
            // selesaiDokterBtn
            // 
            this.selesaiDokterBtn.Location = new System.Drawing.Point(1666, 970);
            this.selesaiDokterBtn.Name = "selesaiDokterBtn";
            this.selesaiDokterBtn.Size = new System.Drawing.Size(161, 34);
            this.selesaiDokterBtn.TabIndex = 7;
            this.selesaiDokterBtn.Text = "Selesai";
            this.selesaiDokterBtn.UseVisualStyleBackColor = true;
            this.selesaiDokterBtn.Click += new System.EventHandler(this.selesaiDokterBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Keyword";
            // 
            // FormDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
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
            this.Load += new System.EventHandler(this.maximise);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}