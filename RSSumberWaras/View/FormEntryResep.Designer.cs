
namespace RSSumberWaras.View
{
    partial class FormEntryResep
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
            this.enresSimpanBtn = new System.Windows.Forms.Button();
            this.jumlahBox = new System.Windows.Forms.TextBox();
            this.jumlah = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enresSimpanBtn
            // 
            this.enresSimpanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enresSimpanBtn.Location = new System.Drawing.Point(473, 86);
            this.enresSimpanBtn.Margin = new System.Windows.Forms.Padding(2);
            this.enresSimpanBtn.Name = "enresSimpanBtn";
            this.enresSimpanBtn.Size = new System.Drawing.Size(146, 43);
            this.enresSimpanBtn.TabIndex = 17;
            this.enresSimpanBtn.Text = "Simpan";
            this.enresSimpanBtn.UseVisualStyleBackColor = true;
            // 
            // jumlahBox
            // 
            this.jumlahBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlahBox.Location = new System.Drawing.Point(215, 39);
            this.jumlahBox.Margin = new System.Windows.Forms.Padding(2);
            this.jumlahBox.Name = "jumlahBox";
            this.jumlahBox.Size = new System.Drawing.Size(404, 32);
            this.jumlahBox.TabIndex = 14;
            // 
            // jumlah
            // 
            this.jumlah.AutoSize = true;
            this.jumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlah.Location = new System.Drawing.Point(31, 44);
            this.jumlah.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jumlah.Name = "jumlah";
            this.jumlah.Size = new System.Drawing.Size(71, 24);
            this.jumlah.TabIndex = 11;
            this.jumlah.Text = "Jumlah";
            // 
            // FormEntryResep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 148);
            this.Controls.Add(this.enresSimpanBtn);
            this.Controls.Add(this.jumlahBox);
            this.Controls.Add(this.jumlah);
            this.Name = "FormEntryResep";
            this.Text = "FormEntryResep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enresSimpanBtn;
        private System.Windows.Forms.TextBox jumlahBox;
        private System.Windows.Forms.Label jumlah;
    }
}