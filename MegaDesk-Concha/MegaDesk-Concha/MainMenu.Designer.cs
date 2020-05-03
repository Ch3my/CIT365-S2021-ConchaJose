namespace MegaDesk_Concha
{
    partial class MegaDesk
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.addQuoteButton = new System.Windows.Forms.Button();
            this.viewQuotesButton = new System.Windows.Forms.Button();
            this.searchQuotesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addQuoteButton
            // 
            this.addQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteButton.Location = new System.Drawing.Point(29, 12);
            this.addQuoteButton.Name = "addQuoteButton";
            this.addQuoteButton.Size = new System.Drawing.Size(138, 62);
            this.addQuoteButton.TabIndex = 0;
            this.addQuoteButton.Text = "&Add New Quote";
            this.addQuoteButton.UseVisualStyleBackColor = true;
            this.addQuoteButton.Click += new System.EventHandler(this.addQuoteButton_Click);
            // 
            // viewQuotesButton
            // 
            this.viewQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuotesButton.Location = new System.Drawing.Point(29, 80);
            this.viewQuotesButton.Name = "viewQuotesButton";
            this.viewQuotesButton.Size = new System.Drawing.Size(138, 62);
            this.viewQuotesButton.TabIndex = 1;
            this.viewQuotesButton.Text = "&View Quotes";
            this.viewQuotesButton.UseVisualStyleBackColor = true;
            this.viewQuotesButton.Click += new System.EventHandler(this.viewQuotesButton_Click);
            // 
            // searchQuotesButton
            // 
            this.searchQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotesButton.Location = new System.Drawing.Point(29, 148);
            this.searchQuotesButton.Name = "searchQuotesButton";
            this.searchQuotesButton.Size = new System.Drawing.Size(138, 62);
            this.searchQuotesButton.TabIndex = 2;
            this.searchQuotesButton.Text = "&Search Quotes";
            this.searchQuotesButton.UseVisualStyleBackColor = true;
            this.searchQuotesButton.Click += new System.EventHandler(this.searchQuotesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(29, 216);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(138, 62);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MegaDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 292);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchQuotesButton);
            this.Controls.Add(this.viewQuotesButton);
            this.Controls.Add(this.addQuoteButton);
            this.Name = "MegaDesk";
            this.Text = "MegaDesk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuoteButton;
        private System.Windows.Forms.Button viewQuotesButton;
        private System.Windows.Forms.Button searchQuotesButton;
        private System.Windows.Forms.Button exitButton;
    }
}

