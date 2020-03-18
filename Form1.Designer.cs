using System;

namespace Currency
{
    partial class Form1
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
            System.Windows.Forms.TextBox startingCurrency;
            this.endingCurrency = new System.Windows.Forms.TextBox();
            this.GBP = new System.Windows.Forms.Label();
            this.allCurrencies = new System.Windows.Forms.ComboBox();
            this.process = new System.Windows.Forms.Button();
            this.startingCurrency = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startingCurrency
            // 
            this.startingCurrency.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.startingCurrency.BackColor = System.Drawing.SystemColors.Window;
            this.startingCurrency.Location = new System.Drawing.Point(117, 66);
            this.startingCurrency.MaxLength = 10;
            this.startingCurrency.Name = "startingCurrency";
            this.startingCurrency.Size = new System.Drawing.Size(137, 20);
            this.startingCurrency.TabIndex = 0;
            // 
            // endingCurrency
            // 
            this.endingCurrency.ForeColor = System.Drawing.SystemColors.WindowText;
            this.endingCurrency.Location = new System.Drawing.Point(506, 66);
            this.endingCurrency.MaxLength = 10;
            this.endingCurrency.Name = "endingCurrency";
            this.endingCurrency.ReadOnly = true;
            this.endingCurrency.Size = new System.Drawing.Size(178, 20);
            this.endingCurrency.TabIndex = 1;
            // 
            // GBP
            // 
            this.GBP.AutoSize = true;
            this.GBP.Location = new System.Drawing.Point(82, 69);
            this.GBP.Name = "GBP";
            this.GBP.Size = new System.Drawing.Size(29, 13);
            this.GBP.TabIndex = 2;
            this.GBP.Text = "GBP";
            // 
            // allCurrencies
            // 
            this.allCurrencies.FormattingEnabled = true;
            this.allCurrencies.Items.AddRange(new object[] {
            "USD",
            "AUD",
            "EUR"});
            this.allCurrencies.Location = new System.Drawing.Point(289, 66);
            this.allCurrencies.Name = "allCurrencies";
            this.allCurrencies.Size = new System.Drawing.Size(178, 21);
            this.allCurrencies.TabIndex = 3;
            this.allCurrencies.Text = "Selected Currency to Convert to";
            // 
            // process
            // 
            this.process.BackColor = System.Drawing.Color.Lime;
            this.process.Location = new System.Drawing.Point(307, 124);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(129, 67);
            this.process.TabIndex = 4;
            this.process.Text = "Convert";
            this.process.UseVisualStyleBackColor = false;
            this.process.Click += new System.EventHandler(this.processClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 240);
            this.Controls.Add(this.process);
            this.Controls.Add(this.allCurrencies);
            this.Controls.Add(this.GBP);
            this.Controls.Add(this.endingCurrency);
            this.Controls.Add(this.startingCurrency);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox endingCurrency;
        private System.Windows.Forms.TextBox startingCurrency;
        private System.Windows.Forms.Label GBP;
        private System.Windows.Forms.ComboBox allCurrencies;
        private System.Windows.Forms.Button process;
    }
}

