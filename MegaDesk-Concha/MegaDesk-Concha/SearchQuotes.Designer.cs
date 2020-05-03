namespace MegaDesk_Concha
{
    partial class SearchQuotes
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
            this.searchQuotesBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchQuotesBackButton
            // 
            this.searchQuotesBackButton.Location = new System.Drawing.Point(12, 12);
            this.searchQuotesBackButton.Name = "searchQuotesBackButton";
            this.searchQuotesBackButton.Size = new System.Drawing.Size(100, 50);
            this.searchQuotesBackButton.TabIndex = 0;
            this.searchQuotesBackButton.Text = "Main Menu";
            this.searchQuotesBackButton.UseVisualStyleBackColor = true;
            this.searchQuotesBackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchQuotesBackButton);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchQuotesBackButton;
    }
}