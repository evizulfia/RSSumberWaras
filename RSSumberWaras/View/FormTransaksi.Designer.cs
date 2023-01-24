
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
            this.CheckoutBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hapusPenjualanBtn = new System.Windows.Forms.Button();
            this.tmbhPenjualanBtn = new System.Windows.Forms.Button();
            this.selesaiPenjualanBtn = new System.Windows.Forms.Button();
            this.listViewTransaksi = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.Location = new System.Drawing.Point(1020, 758);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckoutBtn.Size = new System.Drawing.Size(161, 34);
            this.CheckoutBtn.TabIndex = 15;
            this.CheckoutBtn.Text = "SimpanBtn";
            this.CheckoutBtn.UseVisualStyleBackColor = true;
            this.CheckoutBtn.Click += new System.EventHandler(this.CheckoutBtn_Click);
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
            this.hapusPenjualanBtn.Location = new System.Drawing.Point(1163, 98);
            this.hapusPenjualanBtn.Name = "hapusPenjualanBtn";
            this.hapusPenjualanBtn.Size = new System.Drawing.Size(91, 34);
            this.hapusPenjualanBtn.TabIndex = 13;
            this.hapusPenjualanBtn.Text = "Hapus";
            this.hapusPenjualanBtn.UseVisualStyleBackColor = true;
            this.hapusPenjualanBtn.Click += new System.EventHandler(this.hapusPenjualanBtn_Click);
            // 
            // tmbhPenjualanBtn
            // 
            this.tmbhPenjualanBtn.Location = new System.Drawing.Point(1034, 98);
            this.tmbhPenjualanBtn.Name = "tmbhPenjualanBtn";
            this.tmbhPenjualanBtn.Size = new System.Drawing.Size(91, 34);
            this.tmbhPenjualanBtn.TabIndex = 11;
            this.tmbhPenjualanBtn.Text = "Tambah";
            this.tmbhPenjualanBtn.UseVisualStyleBackColor = true;
            this.tmbhPenjualanBtn.Click += new System.EventHandler(this.tmbhPenjualanBtn_Click);
            // 
            // selesaiPenjualanBtn
            // 
            this.selesaiPenjualanBtn.Location = new System.Drawing.Point(796, 758);
            this.selesaiPenjualanBtn.Name = "selesaiPenjualanBtn";
            this.selesaiPenjualanBtn.Size = new System.Drawing.Size(161, 34);
            this.selesaiPenjualanBtn.TabIndex = 20;
            this.selesaiPenjualanBtn.Text = "Selesai";
            this.selesaiPenjualanBtn.UseVisualStyleBackColor = true;
            this.selesaiPenjualanBtn.Click += new System.EventHandler(this.selesaiPenjualanBtn_Click);
            // 
            // listViewTransaksi
            // 
            this.listViewTransaksi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listViewTransaksi.HideSelection = false;
            this.listViewTransaksi.Location = new System.Drawing.Point(75, 152);
            this.listViewTransaksi.Name = "listViewTransaksi";
            this.listViewTransaksi.Size = new System.Drawing.Size(1179, 558);
            this.listViewTransaksi.TabIndex = 21;
            this.listViewTransaksi.UseCompatibleStateImageBehavior = false;
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 816);
            this.Controls.Add(this.listViewTransaksi);
            this.Controls.Add(this.selesaiPenjualanBtn);
            this.Controls.Add(this.CheckoutBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hapusPenjualanBtn);
            this.Controls.Add(this.tmbhPenjualanBtn);
            this.Name = "FormTransaksi";
            this.Text = "FormPenjualanObat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hapusPenjualanBtn;
        private System.Windows.Forms.Button tmbhPenjualanBtn;
        private System.Windows.Forms.Button selesaiPenjualanBtn;
        private System.Windows.Forms.ListView listViewTransaksi;
    }
}