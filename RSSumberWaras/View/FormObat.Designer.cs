
namespace RSSumberWaras.View
{
    partial class FormObat
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
            this.selesaiObatBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hapusObatBtn = new System.Windows.Forms.Button();
            this.editObatBtn = new System.Windows.Forms.Button();
            this.tmbhObatBtn = new System.Windows.Forms.Button();
            this.cariObatBtn = new System.Windows.Forms.Button();
            this.cariObatBox = new System.Windows.Forms.TextBox();
            this.listViewObat = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // selesaiObatBtn
            // 
            this.selesaiObatBtn.Location = new System.Drawing.Point(646, 499);
            this.selesaiObatBtn.Margin = new System.Windows.Forms.Padding(2);
            this.selesaiObatBtn.Name = "selesaiObatBtn";
            this.selesaiObatBtn.Size = new System.Drawing.Size(121, 28);
            this.selesaiObatBtn.TabIndex = 15;
            this.selesaiObatBtn.Text = "Selesai";
            this.selesaiObatBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data Obat RS Sumber Waras";
            // 
            // hapusObatBtn
            // 
            this.hapusObatBtn.Location = new System.Drawing.Point(699, 61);
            this.hapusObatBtn.Margin = new System.Windows.Forms.Padding(2);
            this.hapusObatBtn.Name = "hapusObatBtn";
            this.hapusObatBtn.Size = new System.Drawing.Size(68, 28);
            this.hapusObatBtn.TabIndex = 13;
            this.hapusObatBtn.Text = "Hapus";
            this.hapusObatBtn.UseVisualStyleBackColor = true;
            // 
            // editObatBtn
            // 
            this.editObatBtn.Location = new System.Drawing.Point(614, 61);
            this.editObatBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editObatBtn.Name = "editObatBtn";
            this.editObatBtn.Size = new System.Drawing.Size(68, 28);
            this.editObatBtn.TabIndex = 12;
            this.editObatBtn.Text = "Edit";
            this.editObatBtn.UseVisualStyleBackColor = true;
            // 
            // tmbhObatBtn
            // 
            this.tmbhObatBtn.Location = new System.Drawing.Point(529, 61);
            this.tmbhObatBtn.Margin = new System.Windows.Forms.Padding(2);
            this.tmbhObatBtn.Name = "tmbhObatBtn";
            this.tmbhObatBtn.Size = new System.Drawing.Size(68, 28);
            this.tmbhObatBtn.TabIndex = 11;
            this.tmbhObatBtn.Text = "Tambah";
            this.tmbhObatBtn.UseVisualStyleBackColor = true;
            // 
            // cariObatBtn
            // 
            this.cariObatBtn.Location = new System.Drawing.Point(446, 61);
            this.cariObatBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cariObatBtn.Name = "cariObatBtn";
            this.cariObatBtn.Size = new System.Drawing.Size(68, 28);
            this.cariObatBtn.TabIndex = 10;
            this.cariObatBtn.Text = "Cari";
            this.cariObatBtn.UseVisualStyleBackColor = true;
            // 
            // cariObatBox
            // 
            this.cariObatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariObatBox.Location = new System.Drawing.Point(27, 61);
            this.cariObatBox.Margin = new System.Windows.Forms.Padding(2);
            this.cariObatBox.Name = "cariObatBox";
            this.cariObatBox.Size = new System.Drawing.Size(408, 28);
            this.cariObatBox.TabIndex = 9;
            // 
            // listViewObat
            // 
            this.listViewObat.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listViewObat.HideSelection = false;
            this.listViewObat.Location = new System.Drawing.Point(27, 101);
            this.listViewObat.Margin = new System.Windows.Forms.Padding(2);
            this.listViewObat.Name = "listViewObat";
            this.listViewObat.Size = new System.Drawing.Size(740, 374);
            this.listViewObat.TabIndex = 8;
            this.listViewObat.UseCompatibleStateImageBehavior = false;
            // 
            // FormObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 553);
            this.Controls.Add(this.selesaiObatBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hapusObatBtn);
            this.Controls.Add(this.editObatBtn);
            this.Controls.Add(this.tmbhObatBtn);
            this.Controls.Add(this.cariObatBtn);
            this.Controls.Add(this.cariObatBox);
            this.Controls.Add(this.listViewObat);
            this.Name = "FormObat";
            this.Text = "FormObat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selesaiObatBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hapusObatBtn;
        private System.Windows.Forms.Button editObatBtn;
        private System.Windows.Forms.Button tmbhObatBtn;
        private System.Windows.Forms.Button cariObatBtn;
        private System.Windows.Forms.TextBox cariObatBox;
        private System.Windows.Forms.ListView listViewObat;
    }
}