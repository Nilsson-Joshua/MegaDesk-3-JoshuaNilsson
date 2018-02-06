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
            this.cancelSearchQuoteButton = new System.Windows.Forms.Button();
            this.searchQuoteListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // searchQuoteMaterial
            // 
            this.searchQuoteMaterial.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuoteMaterial.FormattingEnabled = true;
            this.searchQuoteMaterial.Location = new System.Drawing.Point(79, 9);
            this.searchQuoteMaterial.Name = "searchQuoteMaterial";
            this.searchQuoteMaterial.Size = new System.Drawing.Size(121, 22);
            this.searchQuoteMaterial.TabIndex = 0;
            // 
            // searchQuoteMaterialLabel
            // 
            this.searchQuoteMaterialLabel.Font = new System.Drawing.Font("Oswald", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuoteMaterialLabel.Location = new System.Drawing.Point(12, 9);
            this.searchQuoteMaterialLabel.Name = "searchQuoteMaterialLabel";
            this.searchQuoteMaterialLabel.Size = new System.Drawing.Size(61, 25);
            this.searchQuoteMaterialLabel.TabIndex = 3;
            this.searchQuoteMaterialLabel.Text = "Material";
            // 
            // cancelSearchQuoteButton
            // 
            this.cancelSearchQuoteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelSearchQuoteButton.Font = new System.Drawing.Font("Oswald", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelSearchQuoteButton.Location = new System.Drawing.Point(12, 329);
            this.cancelSearchQuoteButton.Name = "cancelSearchQuoteButton";
            this.cancelSearchQuoteButton.Size = new System.Drawing.Size(154, 48);
            this.cancelSearchQuoteButton.TabIndex = 2;
            this.cancelSearchQuoteButton.Text = "Finish";
            this.cancelSearchQuoteButton.UseVisualStyleBackColor = false;
            this.cancelSearchQuoteButton.Click += new System.EventHandler(this.cancelSearchQuoteButton_Click);
            // 
            // searchQuoteListBox
            // 
            this.searchQuoteListBox.FormattingEnabled = true;
            this.searchQuoteListBox.Location = new System.Drawing.Point(16, 37);
            this.searchQuoteListBox.Name = "searchQuoteListBox";
            this.searchQuoteListBox.Size = new System.Drawing.Size(344, 277);
            this.searchQuoteListBox.TabIndex = 4;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(380, 389);
            this.Controls.Add(this.searchQuoteListBox);
            this.Controls.Add(this.cancelSearchQuoteButton);
            this.Controls.Add(this.searchQuoteMaterialLabel);
            this.Controls.Add(this.searchQuoteMaterial);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox searchQuoteMaterial;
        private System.Windows.Forms.Label searchQuoteMaterialLabel;
        private System.Windows.Forms.Button cancelSearchQuoteButton;
        private System.Windows.Forms.ListBox searchQuoteListBox;
    }
}