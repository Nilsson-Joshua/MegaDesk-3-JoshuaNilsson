namespace MegaDesk_3_JoshuaNilsson
{
    partial class MainMenu
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
            this.exitButton = new System.Windows.Forms.Button();
            this.openSearchQuoteButton = new System.Windows.Forms.Button();
            this.openViewQuoteButton = new System.Windows.Forms.Button();
            this.openAddQuoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(90, 177);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 44);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openSearchQuoteButton
            // 
            this.openSearchQuoteButton.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSearchQuoteButton.Location = new System.Drawing.Point(90, 127);
            this.openSearchQuoteButton.Name = "openSearchQuoteButton";
            this.openSearchQuoteButton.Size = new System.Drawing.Size(102, 44);
            this.openSearchQuoteButton.TabIndex = 2;
            this.openSearchQuoteButton.Text = "Search Quotes";
            this.openSearchQuoteButton.UseVisualStyleBackColor = true;
            this.openSearchQuoteButton.Click += new System.EventHandler(this.openSearchQuoteButton_Click);
            // 
            // openViewQuoteButton
            // 
            this.openViewQuoteButton.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openViewQuoteButton.Location = new System.Drawing.Point(90, 77);
            this.openViewQuoteButton.Name = "openViewQuoteButton";
            this.openViewQuoteButton.Size = new System.Drawing.Size(102, 44);
            this.openViewQuoteButton.TabIndex = 1;
            this.openViewQuoteButton.Text = "View Quotes";
            this.openViewQuoteButton.UseVisualStyleBackColor = true;
            this.openViewQuoteButton.Click += new System.EventHandler(this.openViewQuoteButton_Click);
            // 
            // openAddQuoteButton
            // 
            this.openAddQuoteButton.Font = new System.Drawing.Font("Oswald", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAddQuoteButton.Location = new System.Drawing.Point(90, 27);
            this.openAddQuoteButton.Name = "openAddQuoteButton";
            this.openAddQuoteButton.Size = new System.Drawing.Size(102, 44);
            this.openAddQuoteButton.TabIndex = 0;
            this.openAddQuoteButton.Text = "Add New Quote";
            this.openAddQuoteButton.UseVisualStyleBackColor = true;
            this.openAddQuoteButton.Click += new System.EventHandler(this.openAddQuoteButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.openViewQuoteButton);
            this.Controls.Add(this.openSearchQuoteButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.openAddQuoteButton);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button openSearchQuoteButton;
        private System.Windows.Forms.Button openViewQuoteButton;
        private System.Windows.Forms.Button openAddQuoteButton;
    }
}

