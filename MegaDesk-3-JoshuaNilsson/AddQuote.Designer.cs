namespace MegaDesk_3_JoshuaNilsson
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
            this.addQuoteWidthLabel = new System.Windows.Forms.Label();
            this.addQuoteDepthLabel = new System.Windows.Forms.Label();
            this.addQuoteWidthInput = new System.Windows.Forms.TextBox();
            this.addQuoteDepthInput = new System.Windows.Forms.TextBox();
            this.CancelAddQuoteButton = new System.Windows.Forms.Button();
            this.addQuoteCustomerLabel = new System.Windows.Forms.Label();
            this.addQuoteCustomerInput = new System.Windows.Forms.TextBox();
            this.addQuoteDaysLabel = new System.Windows.Forms.Label();
            this.addQuoteDrawerCountInput = new System.Windows.Forms.TextBox();
            this.addQuoteDrawerCountLabel = new System.Windows.Forms.Label();
            this.AddQuoteButton = new System.Windows.Forms.Button();
            this.AddQuoteMaterialType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddQuoteDays = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addQuoteWidthLabel
            // 
            this.addQuoteWidthLabel.Font = new System.Drawing.Font("Oswald", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteWidthLabel.Location = new System.Drawing.Point(26, 39);
            this.addQuoteWidthLabel.Name = "addQuoteWidthLabel";
            this.addQuoteWidthLabel.Size = new System.Drawing.Size(45, 25);
            this.addQuoteWidthLabel.TabIndex = 9;
            this.addQuoteWidthLabel.Text = "Width";
            // 
            // addQuoteDepthLabel
            // 
            this.addQuoteDepthLabel.Font = new System.Drawing.Font("Oswald", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteDepthLabel.Location = new System.Drawing.Point(26, 64);
            this.addQuoteDepthLabel.Name = "addQuoteDepthLabel";
            this.addQuoteDepthLabel.Size = new System.Drawing.Size(49, 25);
            this.addQuoteDepthLabel.TabIndex = 10;
            this.addQuoteDepthLabel.Text = "Depth";
            // 
            // addQuoteWidthInput
            // 
            this.addQuoteWidthInput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteWidthInput.Location = new System.Drawing.Point(84, 38);
            this.addQuoteWidthInput.Name = "addQuoteWidthInput";
            this.addQuoteWidthInput.Size = new System.Drawing.Size(100, 20);
            this.addQuoteWidthInput.TabIndex = 1;
            this.addQuoteWidthInput.Validating += new System.ComponentModel.CancelEventHandler(this.WidthValidating);
            // 
            // addQuoteDepthInput
            // 
            this.addQuoteDepthInput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteDepthInput.Location = new System.Drawing.Point(84, 64);
            this.addQuoteDepthInput.Name = "addQuoteDepthInput";
            this.addQuoteDepthInput.Size = new System.Drawing.Size(100, 20);
            this.addQuoteDepthInput.TabIndex = 2;
            this.addQuoteDepthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Depth_KeyPress);
            this.addQuoteDepthInput.Validating += new System.ComponentModel.CancelEventHandler(this.DepthValidating);
            // 
            // CancelAddQuoteButton
            // 
            this.CancelAddQuoteButton.Font = new System.Drawing.Font("Oswald", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelAddQuoteButton.Location = new System.Drawing.Point(149, 201);
            this.CancelAddQuoteButton.Name = "CancelAddQuoteButton";
            this.CancelAddQuoteButton.Size = new System.Drawing.Size(123, 48);
            this.CancelAddQuoteButton.TabIndex = 7;
            this.CancelAddQuoteButton.Text = "Cancel";
            this.CancelAddQuoteButton.UseVisualStyleBackColor = true;
            this.CancelAddQuoteButton.Click += new System.EventHandler(this.cancelAddQuoteButton_Click);
            // 
            // addQuoteCustomerLabel
            // 
            this.addQuoteCustomerLabel.Font = new System.Drawing.Font("Oswald", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteCustomerLabel.Location = new System.Drawing.Point(8, 9);
            this.addQuoteCustomerLabel.Name = "addQuoteCustomerLabel";
            this.addQuoteCustomerLabel.Size = new System.Drawing.Size(70, 25);
            this.addQuoteCustomerLabel.TabIndex = 8;
            this.addQuoteCustomerLabel.Text = "Customer";
            // 
            // addQuoteCustomerInput
            // 
            this.addQuoteCustomerInput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteCustomerInput.Location = new System.Drawing.Point(84, 12);
            this.addQuoteCustomerInput.Name = "addQuoteCustomerInput";
            this.addQuoteCustomerInput.Size = new System.Drawing.Size(188, 20);
            this.addQuoteCustomerInput.TabIndex = 0;
            // 
            // addQuoteDaysLabel
            // 
            this.addQuoteDaysLabel.Font = new System.Drawing.Font("Oswald", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteDaysLabel.Location = new System.Drawing.Point(34, 145);
            this.addQuoteDaysLabel.Name = "addQuoteDaysLabel";
            this.addQuoteDaysLabel.Size = new System.Drawing.Size(37, 25);
            this.addQuoteDaysLabel.TabIndex = 13;
            this.addQuoteDaysLabel.Text = "Days";
            // 
            // addQuoteDrawerCountInput
            // 
            this.addQuoteDrawerCountInput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteDrawerCountInput.Location = new System.Drawing.Point(84, 92);
            this.addQuoteDrawerCountInput.Name = "addQuoteDrawerCountInput";
            this.addQuoteDrawerCountInput.Size = new System.Drawing.Size(100, 20);
            this.addQuoteDrawerCountInput.TabIndex = 3;
            this.addQuoteDrawerCountInput.TextChanged += new System.EventHandler(this.AddQuoteDrawerCountInput_TextChanged);
            // 
            // addQuoteDrawerCountLabel
            // 
            this.addQuoteDrawerCountLabel.Font = new System.Drawing.Font("Oswald", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteDrawerCountLabel.Location = new System.Drawing.Point(15, 88);
            this.addQuoteDrawerCountLabel.Name = "addQuoteDrawerCountLabel";
            this.addQuoteDrawerCountLabel.Size = new System.Drawing.Size(60, 25);
            this.addQuoteDrawerCountLabel.TabIndex = 11;
            this.addQuoteDrawerCountLabel.Text = "Drawers";
            // 
            // AddQuoteButton
            // 
            this.AddQuoteButton.Font = new System.Drawing.Font("Oswald", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuoteButton.Location = new System.Drawing.Point(12, 201);
            this.AddQuoteButton.Name = "AddQuoteButton";
            this.AddQuoteButton.Size = new System.Drawing.Size(127, 48);
            this.AddQuoteButton.TabIndex = 6;
            this.AddQuoteButton.Text = "Add";
            this.AddQuoteButton.UseVisualStyleBackColor = true;
            this.AddQuoteButton.Click += new System.EventHandler(this.AddQuoteButton_Click);
            // 
            // AddQuoteMaterialType
            // 
            this.AddQuoteMaterialType.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuoteMaterialType.FormattingEnabled = true;
            this.AddQuoteMaterialType.Location = new System.Drawing.Point(84, 120);
            this.AddQuoteMaterialType.Name = "AddQuoteMaterialType";
            this.AddQuoteMaterialType.Size = new System.Drawing.Size(100, 22);
            this.AddQuoteMaterialType.TabIndex = 4;
            this.AddQuoteMaterialType.SelectedIndexChanged += new System.EventHandler(this.AddQuoteMaterialType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Oswald", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Material";
            // 
            // AddQuoteDays
            // 
            this.AddQuoteDays.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuoteDays.FormattingEnabled = true;
            this.AddQuoteDays.Location = new System.Drawing.Point(84, 149);
            this.AddQuoteDays.Name = "AddQuoteDays";
            this.AddQuoteDays.Size = new System.Drawing.Size(100, 22);
            this.AddQuoteDays.TabIndex = 5;
            this.AddQuoteDays.SelectedIndexChanged += new System.EventHandler(this.AddQuoteDays_SelectedIndexChanged);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AddQuoteDays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddQuoteMaterialType);
            this.Controls.Add(this.AddQuoteButton);
            this.Controls.Add(this.addQuoteDrawerCountLabel);
            this.Controls.Add(this.addQuoteDrawerCountInput);
            this.Controls.Add(this.addQuoteDaysLabel);
            this.Controls.Add(this.addQuoteCustomerInput);
            this.Controls.Add(this.addQuoteCustomerLabel);
            this.Controls.Add(this.CancelAddQuoteButton);
            this.Controls.Add(this.addQuoteDepthInput);
            this.Controls.Add(this.addQuoteWidthInput);
            this.Controls.Add(this.addQuoteDepthLabel);
            this.Controls.Add(this.addQuoteWidthLabel);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label addQuoteWidthLabel;
        private System.Windows.Forms.Label addQuoteDepthLabel;
        private System.Windows.Forms.TextBox addQuoteWidthInput;
        private System.Windows.Forms.TextBox addQuoteDepthInput;
        private System.Windows.Forms.Button CancelAddQuoteButton;
        private System.Windows.Forms.Label addQuoteCustomerLabel;
        private System.Windows.Forms.TextBox addQuoteCustomerInput;
        private System.Windows.Forms.Label addQuoteDaysLabel;
        private System.Windows.Forms.TextBox addQuoteDrawerCountInput;
        private System.Windows.Forms.Label addQuoteDrawerCountLabel;
        private System.Windows.Forms.Button AddQuoteButton;
        private System.Windows.Forms.ComboBox AddQuoteMaterialType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AddQuoteDays;
    }
}