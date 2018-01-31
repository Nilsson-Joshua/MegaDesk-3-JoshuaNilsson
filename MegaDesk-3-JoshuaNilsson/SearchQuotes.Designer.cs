namespace MegaDesk_3_JoshuaNilsson
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
            this.searchQuoteMaterial = new System.Windows.Forms.ComboBox();
            this.searchQuoteMaterialLabel = new System.Windows.Forms.Label();
            this.searchQuoteCostLabel = new System.Windows.Forms.Label();
            this.searchQuoteCost = new System.Windows.Forms.Label();
            this.cancelSearchQuoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchQuoteMaterial
            // 
            this.searchQuoteMaterial.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuoteMaterial.FormattingEnabled = true;
            this.searchQuoteMaterial.Location = new System.Drawing.Point(16, 105);
            this.searchQuoteMaterial.Name = "searchQuoteMaterial";
            this.searchQuoteMaterial.Size = new System.Drawing.Size(121, 22);
            this.searchQuoteMaterial.TabIndex = 0;
            // 
            // searchQuoteMaterialLabel
            // 
            this.searchQuoteMaterialLabel.Font = new System.Drawing.Font("Oswald", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuoteMaterialLabel.Location = new System.Drawing.Point(12, 77);
            this.searchQuoteMaterialLabel.Name = "searchQuoteMaterialLabel";
            this.searchQuoteMaterialLabel.Size = new System.Drawing.Size(81, 25);
            this.searchQuoteMaterialLabel.TabIndex = 3;
            this.searchQuoteMaterialLabel.Text = "Material";
            // 
            // searchQuoteCostLabel
            // 
            this.searchQuoteCostLabel.Font = new System.Drawing.Font("Oswald", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuoteCostLabel.Location = new System.Drawing.Point(139, 77);
            this.searchQuoteCostLabel.Name = "searchQuoteCostLabel";
            this.searchQuoteCostLabel.Size = new System.Drawing.Size(81, 25);
            this.searchQuoteCostLabel.TabIndex = 4;
            this.searchQuoteCostLabel.Text = "Cost";
            // 
            // searchQuoteCost
            // 
            this.searchQuoteCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchQuoteCost.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuoteCost.Location = new System.Drawing.Point(143, 105);
            this.searchQuoteCost.Name = "searchQuoteCost";
            this.searchQuoteCost.Size = new System.Drawing.Size(129, 21);
            this.searchQuoteCost.TabIndex = 1;
            // 
            // cancelSearchQuoteButton
            // 
            this.cancelSearchQuoteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelSearchQuoteButton.Font = new System.Drawing.Font("Oswald", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSearchQuoteButton.Location = new System.Drawing.Point(66, 145);
            this.cancelSearchQuoteButton.Name = "cancelSearchQuoteButton";
            this.cancelSearchQuoteButton.Size = new System.Drawing.Size(154, 48);
            this.cancelSearchQuoteButton.TabIndex = 2;
            this.cancelSearchQuoteButton.Text = "Finish";
            this.cancelSearchQuoteButton.UseVisualStyleBackColor = false;
            this.cancelSearchQuoteButton.Click += new System.EventHandler(this.cancelSearchQuoteButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancelSearchQuoteButton);
            this.Controls.Add(this.searchQuoteCost);
            this.Controls.Add(this.searchQuoteCostLabel);
            this.Controls.Add(this.searchQuoteMaterialLabel);
            this.Controls.Add(this.searchQuoteMaterial);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox searchQuoteMaterial;
        private System.Windows.Forms.Label searchQuoteMaterialLabel;
        private System.Windows.Forms.Label searchQuoteCostLabel;
        private System.Windows.Forms.Label searchQuoteCost;
        private System.Windows.Forms.Button cancelSearchQuoteButton;
    }
}