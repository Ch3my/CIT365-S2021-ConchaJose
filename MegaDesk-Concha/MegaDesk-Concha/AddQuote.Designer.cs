namespace MegaDesk_Concha
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
            this.components = new System.ComponentModel.Container();
            this.addQuoteBackButton = new System.Windows.Forms.Button();
            this.addQuoteCsName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.consumerFullNameTextbox = new System.Windows.Forms.TextBox();
            this.deskWidthTextbox = new System.Windows.Forms.TextBox();
            this.deskDepthTextbox = new System.Windows.Forms.TextBox();
            this.nDrawersCombobox = new System.Windows.Forms.ComboBox();
            this.surfaceCombobox = new System.Windows.Forms.ComboBox();
            this.buildTimeCombobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProviderDeskWidth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDeskDepth = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeskDepth)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuoteBackButton
            // 
            this.addQuoteBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteBackButton.Location = new System.Drawing.Point(12, 12);
            this.addQuoteBackButton.Name = "addQuoteBackButton";
            this.addQuoteBackButton.Size = new System.Drawing.Size(100, 50);
            this.addQuoteBackButton.TabIndex = 0;
            this.addQuoteBackButton.Text = "Main Menu";
            this.addQuoteBackButton.UseVisualStyleBackColor = true;
            this.addQuoteBackButton.Click += new System.EventHandler(this.addQuoteBackButton_Click);
            // 
            // addQuoteCsName
            // 
            this.addQuoteCsName.AutoSize = true;
            this.addQuoteCsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteCsName.Location = new System.Drawing.Point(12, 96);
            this.addQuoteCsName.Name = "addQuoteCsName";
            this.addQuoteCsName.Size = new System.Drawing.Size(146, 20);
            this.addQuoteCsName.TabIndex = 1;
            this.addQuoteCsName.Text = "Customer full name";
            this.addQuoteCsName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Desk width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desk depth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Drawers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Desktop surface material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Build Time";
            // 
            // consumerFullNameTextbox
            // 
            this.consumerFullNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consumerFullNameTextbox.Location = new System.Drawing.Point(182, 90);
            this.consumerFullNameTextbox.Name = "consumerFullNameTextbox";
            this.consumerFullNameTextbox.Size = new System.Drawing.Size(133, 26);
            this.consumerFullNameTextbox.TabIndex = 7;
            // 
            // deskWidthTextbox
            // 
            this.deskWidthTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidthTextbox.Location = new System.Drawing.Point(182, 139);
            this.deskWidthTextbox.Name = "deskWidthTextbox";
            this.deskWidthTextbox.Size = new System.Drawing.Size(100, 26);
            this.deskWidthTextbox.TabIndex = 8;
            this.deskWidthTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.addQuoteDeskWidthValidating);
            // 
            // deskDepthTextbox
            // 
            this.deskDepthTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepthTextbox.Location = new System.Drawing.Point(182, 190);
            this.deskDepthTextbox.Name = "deskDepthTextbox";
            this.deskDepthTextbox.Size = new System.Drawing.Size(100, 26);
            this.deskDepthTextbox.TabIndex = 9;
            this.deskDepthTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addQuoteDeskDepthKeyPressValidating);
            this.deskDepthTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.addQuoteDeskDeptValidating);
            // 
            // nDrawersCombobox
            // 
            this.nDrawersCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nDrawersCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nDrawersCombobox.FormattingEnabled = true;
            this.nDrawersCombobox.Location = new System.Drawing.Point(567, 86);
            this.nDrawersCombobox.Name = "nDrawersCombobox";
            this.nDrawersCombobox.Size = new System.Drawing.Size(121, 28);
            this.nDrawersCombobox.TabIndex = 13;
            this.nDrawersCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // surfaceCombobox
            // 
            this.surfaceCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surfaceCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceCombobox.FormattingEnabled = true;
            this.surfaceCombobox.Location = new System.Drawing.Point(567, 137);
            this.surfaceCombobox.Name = "surfaceCombobox";
            this.surfaceCombobox.Size = new System.Drawing.Size(121, 28);
            this.surfaceCombobox.TabIndex = 14;
            this.surfaceCombobox.SelectedIndexChanged += new System.EventHandler(this.surfaceCombobox_SelectedIndexChanged);
            // 
            // buildTimeCombobox
            // 
            this.buildTimeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buildTimeCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buildTimeCombobox.FormattingEnabled = true;
            this.buildTimeCombobox.Location = new System.Drawing.Point(567, 188);
            this.buildTimeCombobox.Name = "buildTimeCombobox";
            this.buildTimeCombobox.Size = new System.Drawing.Size(121, 28);
            this.buildTimeCombobox.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(118, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProviderDeskWidth
            // 
            this.errorProviderDeskWidth.ContainerControl = this;
            // 
            // errorProviderDeskDepth
            // 
            this.errorProviderDeskDepth.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buildTimeCombobox);
            this.Controls.Add(this.surfaceCombobox);
            this.Controls.Add(this.nDrawersCombobox);
            this.Controls.Add(this.deskDepthTextbox);
            this.Controls.Add(this.deskWidthTextbox);
            this.Controls.Add(this.consumerFullNameTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addQuoteCsName);
            this.Controls.Add(this.addQuoteBackButton);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeskDepth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addQuoteBackButton;
        private System.Windows.Forms.Label addQuoteCsName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox consumerFullNameTextbox;
        private System.Windows.Forms.TextBox deskWidthTextbox;
        private System.Windows.Forms.TextBox deskDepthTextbox;
        private System.Windows.Forms.ComboBox nDrawersCombobox;
        private System.Windows.Forms.ComboBox surfaceCombobox;
        private System.Windows.Forms.ComboBox buildTimeCombobox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProviderDeskWidth;
        private System.Windows.Forms.ErrorProvider errorProviderDeskDepth;
    }
}