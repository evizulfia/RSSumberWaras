
namespace RSSumberWaras.View
{
    partial class FormTransaksi
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
            this.selesaiTransaksiBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tmbhTransaksiBtn = new System.Windows.Forms.Button();
            this.listViewTransaksi = new System.Windows.Forms.ListView();
            this.cariTransaksiBtn = new System.Windows.Forms.Button();
            this.cariRekamMedisBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selesaiTransaksiBtn
            // 
            this.selesaiTransaksiBtn.Location = new System.Drawing.Point(1670, 948);
            this.selesaiTransaksiBtn.Name = "selesaiTransaksiBtn";
            this.selesaiTransaksiBtn.Size = new System.Drawing.Size(161, 34);
            this.selesaiTransaksiBtn.TabIndex = 39;
            this.selesaiTransaksiBtn.Text = "Selesai";
            this.selesaiTransaksiBtn.UseVisualStyleBackColor = true;
            this.selesaiTransaksiBtn.Click += new System.EventHandler(this.selesaiTransaksiBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Daftar TransaksiPasien RS Sumber Waras";
            // 
            // tmbhTransaksiBtn
            // 
            this.tmbhTransaksiBtn.Location = new System.Drawing.Point(1740, 114);
            this.tmbhTransaksiBtn.Name = "tmbhTransaksiBtn";
            this.tmbhTransaksiBtn.Size = new System.Drawing.Size(91, 34);
            this.tmbhTransaksiBtn.TabIndex = 35;
            this.tmbhTransaksiBtn.Text = "Tambah";
            this.tmbhTransaksiBtn.UseVisualStyleBackColor = true;
            this.tmbhTransaksiBtn.Click += new System.EventHandler(this.tmbhTransaksiBtn_Click);
            // 
            // listViewTransaksi
            // 
            this.listViewTransaksi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listViewTransaksi.HideSelection = false;
            this.listViewTransaksi.Location = new System.Drawing.Point(140, 163);
            this.listViewTransaksi.Name = "listViewTransaksi";
            this.listViewTransaksi.Size = new System.Drawing.Size(1691, 744);
            this.listViewTransaksi.TabIndex = 32;
            this.listViewTransaksi.UseCompatibleStateImageBehavior = false;
            // 
            // cariTransaksiBtn
            // 
            this.cariTransaksiBtn.Location = new System.Drawing.Point(1618, 114);
            this.cariTransaksiBtn.Name = "cariTransaksiBtn";
            this.cariTransaksiBtn.Size = new System.Drawing.Size(91, 34);
            this.cariTransaksiBtn.TabIndex = 34;
            this.cariTransaksiBtn.Text = "Cari";
            this.cariTransaksiBtn.UseVisualStyleBackColor = true;
            // 
            // cariRekamMedisBox
            // 
            this.cariRekamMedisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariRekamMedisBox.Location = new System.Drawing.Point(140, 114);
            this.cariRekamMedisBox.Name = "cariRekamMedisBox";
            this.cariRekamMedisBox.Size = new System.Drawing.Size(1428, 34);
            this.cariRekamMedisBox.TabIndex = 33;
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.selesaiTransaksiBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tmbhTransaksiBtn);
            this.Controls.Add(this.cariTransaksiBtn);
            this.Controls.Add(this.cariRekamMedisBox);
            this.Controls.Add(this.listViewTransaksi);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.maximise);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selesaiTransaksiBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tmbhTransaksiBtn;
        private System.Windows.Forms.ListView listViewTransaksi;
        private System.Windows.Forms.Button cariTransaksiBtn;
        private System.Windows.Forms.TextBox cariRekamMedisBox;
    }
}