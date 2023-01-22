namespace MegaDesk_Waite
{
    partial class AddQuote
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
            this.BackToHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToHome
            // 
            this.BackToHome.Location = new System.Drawing.Point(615, 392);
            this.BackToHome.Name = "BackToHome";
            this.BackToHome.Size = new System.Drawing.Size(173, 46);
            this.BackToHome.TabIndex = 0;
            this.BackToHome.Text = "Back Home";
            this.BackToHome.UseVisualStyleBackColor = true;
            this.BackToHome.Click += new System.EventHandler(this.BackToHome_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToHome);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToHome;
    }
}