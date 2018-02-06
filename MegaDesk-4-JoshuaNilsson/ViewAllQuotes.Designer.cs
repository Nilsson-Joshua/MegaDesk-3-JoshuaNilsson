namespace MegaDesk_3_JoshuaNilsson
{
    partial class ViewAllQuotes
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
            this.viewAllQuotesLabel = new System.Windows.Forms.Label();
            this.viewAllQuotesList = new System.Windows.Forms.ListBox();
            this.cancelViewAllQuotesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewAllQuotesLabel
            // 
            this.viewAllQuotesLabel.AutoSize = true;
            this.viewAllQuotesLabel.Font = new System.Drawing.Font("Oswald", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllQuotesLabel.Location = new System.Drawing.Point(12, 9);
            this.viewAllQuotesLabel.Name = "viewAllQuotesLabel";
            this.viewAllQuotesLabel.Size = new System.Drawing.Size(109, 22);
            this.viewAllQuotesLabel.TabIndex = 2;
            this.viewAllQuotesLabel.Text = "List of All Quotes";
            // 
            // viewAllQuotesList
            // 
            this.viewAllQuotesList.FormattingEnabled = true;
            this.viewAllQuotesList.Location = new System.Drawing.Point(16, 43);
            this.viewAllQuotesList.Name = "viewAllQuotesList";
            this.viewAllQuotesList.Size = new System.Drawing.Size(247, 121);
            this.viewAllQuotesList.TabIndex = 0;
            // 
            // cancelViewAllQuotesButton
            // 
            this.cancelViewAllQuotesButton.Font = new System.Drawing.Font("Oswald", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelViewAllQuotesButton.Location = new System.Drawing.Point(16, 184);
            this.cancelViewAllQuotesButton.Name = "cancelViewAllQuotesButton";
            this.cancelViewAllQuotesButton.Size = new System.Drawing.Size(154, 48);
            this.cancelViewAllQuotesButton.TabIndex = 1;
            this.cancelViewAllQuotesButton.Text = "Finish";
            this.cancelViewAllQuotesButton.UseVisualStyleBackColor = true;
            this.cancelViewAllQuotesButton.Click += new System.EventHandler(this.cancelViewAllQuotesButton_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancelViewAllQuotesButton);
            this.Controls.Add(this.viewAllQuotesList);
            this.Controls.Add(this.viewAllQuotesLabel);
            this.Name = "ViewAllQuotes";
            this.Text = "View All Quotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewAllQuotesLabel;
        private System.Windows.Forms.ListBox viewAllQuotesList;
        private System.Windows.Forms.Button cancelViewAllQuotesButton;
    }
}