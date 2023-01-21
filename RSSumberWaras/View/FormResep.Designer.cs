
namespace RSSumberWaras.View
{
    partial class FormResep
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
            this.selesaiResepBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hapusResepBtn = new System.Windows.Forms.Button();
            this.editResepBtn = new System.Windows.Forms.Button();
            this.tmbhResepBtn = new System.Windows.Forms.Button();
            this.cariResepBtn = new System.Windows.Forms.Button();
            this.cariResepBox = new System.Windows.Forms.TextBox();
            this.listViewResep = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // selesaiResepBtn
            // 
            this.selesaiResepBtn.Location = new System.Drawing.Point(646, 499);
            this.selesaiResepBtn.Margin = new System.Windows.Forms.Padding(2);
            this.selesaiResepBtn.Name = "selesaiResepBtn";
            this.selesaiResepBtn.Size = new System.Drawing.Size(121, 28);
            this.selesaiResepBtn.TabIndex = 15;
            this.selesaiResepBtn.Text = "Selesai";
            this.selesaiResepBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Resep Obat RS Sumber Waras";
            // 
            // hapusResepBtn
            // 
            this.hapusResepBtn.Location = new System.Drawing.Point(699, 61);
            this.hapusResepBtn.Margin = new System.Windows.Forms.Padding(2);
            this.hapusResepBtn.Name = "hapusResepBtn";
            this.hapusResepBtn.Size = new System.Drawing.Size(68, 28);
            this.hapusResepBtn.TabIndex = 13;
            this.hapusResepBtn.Text = "Hapus";
            this.hapusResepBtn.UseVisualStyleBackColor = true;
            // 
            // editResepBtn
            // 
            this.editResepBtn.Location = new System.Drawing.Point(614, 61);
            this.editResepBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editResepBtn.Name = "editResepBtn";
            this.editResepBtn.Size = new System.Drawing.Size(68, 28);
            this.editResepBtn.TabIndex = 12;
            this.editResepBtn.Text = "Edit";
            this.editResepBtn.UseVisualStyleBackColor = true;
            // 
            // tmbhResepBtn
            // 
            this.tmbhResepBtn.Location = new System.Drawing.Point(529, 61);
            this.tmbhResepBtn.Margin = new System.Windows.Forms.Padding(2);
            this.tmbhResepBtn.Name = "tmbhResepBtn";
            this.tmbhResepBtn.Size = new System.Drawing.Size(68, 28);
            this.tmbhResepBtn.TabIndex = 11;
            this.tmbhResepBtn.Text = "Tambah";
            this.tmbhResepBtn.UseVisualStyleBackColor = true;
            // 
            // cariResepBtn
            // 
            this.cariResepBtn.Location = new System.Drawing.Point(446, 61);
            this.cariResepBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cariResepBtn.Name = "cariResepBtn";
            this.cariResepBtn.Size = new System.Drawing.Size(68, 28);
            this.cariResepBtn.TabIndex = 10;
            this.cariResepBtn.Text = "Cari";
            this.cariResepBtn.UseVisualStyleBackColor = true;
            // 
            // cariResepBox
            // 
            this.cariResepBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariResepBox.Location = new System.Drawing.Point(27, 61);
            this.cariResepBox.Margin = new System.Windows.Forms.Padding(2);
            this.cariResepBox.Name = "cariResepBox";
            this.cariResepBox.Size = new System.Drawing.Size(408, 28);
            this.cariResepBox.TabIndex = 9;
            // 
            // listViewResep
            // 
            this.listViewResep.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listViewResep.HideSelection = false;
            this.listViewResep.Location = new System.Drawing.Point(27, 101);
            this.listViewResep.Margin = new System.Windows.Forms.Padding(2);
            this.listViewResep.Name = "listViewResep";
            this.listViewResep.Size = new System.Drawing.Size(740, 374);
            this.listViewResep.TabIndex = 8;
            this.listViewResep.UseCompatibleStateImageBehavior = false;
            // 
            // FormResep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 553);
            this.Controls.Add(this.selesaiResepBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hapusResepBtn);
            this.Controls.Add(this.editResepBtn);
            this.Controls.Add(this.tmbhResepBtn);
            this.Controls.Add(this.cariResepBtn);
            this.Controls.Add(this.cariResepBox);
            this.Controls.Add(this.listViewResep);
            this.Name = "FormResep";
            this.Text = "FormResep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selesaiResepBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hapusResepBtn;
        private System.Windows.Forms.Button editResepBtn;
        private System.Windows.Forms.Button tmbhResepBtn;
        private System.Windows.Forms.Button cariResepBtn;
        private System.Windows.Forms.TextBox cariResepBox;
        private System.Windows.Forms.ListView listViewResep;
    }
}