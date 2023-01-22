
namespace RSSumberWaras.View
{
    partial class FormPenjualanObat
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
            this.CheckoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hapusPenjualanBtn = new System.Windows.Forms.Button();
            this.tmbhPenjualanBtn = new System.Windows.Forms.Button();
            this.listViewPenjualan = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasienPenjualancomboBox = new System.Windows.Forms.ComboBox();
            this.ObatPenjualancomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.Location = new System.Drawing.Point(923, 637);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckoutBtn.Size = new System.Drawing.Size(161, 34);
            this.CheckoutBtn.TabIndex = 15;
            this.CheckoutBtn.Text = "Checkout";
            this.CheckoutBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Penjualan Obat RS Sumber Waras";
            // 
            // hapusPenjualanBtn
            // 
            this.hapusPenjualanBtn.Location = new System.Drawing.Point(993, 163);
            this.hapusPenjualanBtn.Name = "hapusPenjualanBtn";
            this.hapusPenjualanBtn.Size = new System.Drawing.Size(91, 34);
            this.hapusPenjualanBtn.TabIndex = 13;
            this.hapusPenjualanBtn.Text = "Hapus";
            this.hapusPenjualanBtn.UseVisualStyleBackColor = true;
            // 
            // tmbhPenjualanBtn
            // 
            this.tmbhPenjualanBtn.Location = new System.Drawing.Point(867, 163);
            this.tmbhPenjualanBtn.Name = "tmbhPenjualanBtn";
            this.tmbhPenjualanBtn.Size = new System.Drawing.Size(91, 34);
            this.tmbhPenjualanBtn.TabIndex = 11;
            this.tmbhPenjualanBtn.Text = "Tambah";
            this.tmbhPenjualanBtn.UseVisualStyleBackColor = true;
            // 
            // listViewPenjualan
            // 
            this.listViewPenjualan.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listViewPenjualan.HideSelection = false;
            this.listViewPenjualan.Location = new System.Drawing.Point(98, 218);
            this.listViewPenjualan.Name = "listViewPenjualan";
            this.listViewPenjualan.Size = new System.Drawing.Size(986, 388);
            this.listViewPenjualan.TabIndex = 8;
            this.listViewPenjualan.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nama Pasien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nama Obat";
            // 
            // PasienPenjualancomboBox
            // 
            this.PasienPenjualancomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.PasienPenjualancomboBox.FormattingEnabled = true;
            this.PasienPenjualancomboBox.Location = new System.Drawing.Point(264, 124);
            this.PasienPenjualancomboBox.Name = "PasienPenjualancomboBox";
            this.PasienPenjualancomboBox.Size = new System.Drawing.Size(375, 39);
            this.PasienPenjualancomboBox.TabIndex = 18;
            this.PasienPenjualancomboBox.SelectedIndexChanged += new System.EventHandler(this.PasienPenjualancomboBox_SelectedIndexChanged);
            // 
            // ObatPenjualancomboBox
            // 
            this.ObatPenjualancomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.ObatPenjualancomboBox.FormattingEnabled = true;
            this.ObatPenjualancomboBox.Location = new System.Drawing.Point(264, 169);
            this.ObatPenjualancomboBox.Name = "ObatPenjualancomboBox";
            this.ObatPenjualancomboBox.Size = new System.Drawing.Size(375, 39);
            this.ObatPenjualancomboBox.TabIndex = 19;
            // 
            // FormPenjualanObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 735);
            this.Controls.Add(this.ObatPenjualancomboBox);
            this.Controls.Add(this.PasienPenjualancomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckoutBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hapusPenjualanBtn);
            this.Controls.Add(this.tmbhPenjualanBtn);
            this.Controls.Add(this.listViewPenjualan);
            this.Name = "FormPenjualanObat";
            this.Text = "FormPenjualanObat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hapusPenjualanBtn;
        private System.Windows.Forms.Button tmbhPenjualanBtn;
        private System.Windows.Forms.ListView listViewPenjualan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PasienPenjualancomboBox;
        private System.Windows.Forms.ComboBox ObatPenjualancomboBox;
    }
}