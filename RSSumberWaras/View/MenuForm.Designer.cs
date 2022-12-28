
namespace RSSumberWaras.View
{
    partial class MenuForm
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
            this.logoutMenuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutMenuBtn
            // 
            this.logoutMenuBtn.Location = new System.Drawing.Point(701, 68);
            this.logoutMenuBtn.Name = "logoutMenuBtn";
            this.logoutMenuBtn.Size = new System.Drawing.Size(213, 63);
            this.logoutMenuBtn.TabIndex = 0;
            this.logoutMenuBtn.Text = "Logout";
            this.logoutMenuBtn.UseVisualStyleBackColor = true;
            this.logoutMenuBtn.Click += new System.EventHandler(this.logoutMenuBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 604);
            this.Controls.Add(this.logoutMenuBtn);
            this.Name = "MenuForm";
            this.Text = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutMenuBtn;
    }
}