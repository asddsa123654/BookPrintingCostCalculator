namespace BookPrintingCostCalculator
{
    partial class MainForm
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
            this.numericNumberOfCopies = new System.Windows.Forms.NumericUpDown();
            this.chkUrgent = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.numericNumberOfPages = new System.Windows.Forms.NumericUpDown();
            this.numericPricePerPage = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPricePerPage)).BeginInit();
            this.SuspendLayout();
            // 
            // numericNumberOfCopies
            // 
            this.numericNumberOfCopies.Location = new System.Drawing.Point(537, 183);
            this.numericNumberOfCopies.Name = "numericNumberOfCopies";
            this.numericNumberOfCopies.Size = new System.Drawing.Size(120, 22);
            this.numericNumberOfCopies.TabIndex = 0;
            // 
            // chkUrgent
            // 
            this.chkUrgent.AutoSize = true;
            this.chkUrgent.Location = new System.Drawing.Point(558, 86);
            this.chkUrgent.Name = "chkUrgent";
            this.chkUrgent.Size = new System.Drawing.Size(96, 20);
            this.chkUrgent.TabIndex = 1;
            this.chkUrgent.Text = "терміново";
            this.chkUrgent.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(558, 211);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "обчислення вартості";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(573, 281);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(44, 16);
            this.lblTotalCost.TabIndex = 3;
            this.lblTotalCost.Text = "label1";
            // 
            // numericNumberOfPages
            // 
            this.numericNumberOfPages.Location = new System.Drawing.Point(537, 155);
            this.numericNumberOfPages.Name = "numericNumberOfPages";
            this.numericNumberOfPages.Size = new System.Drawing.Size(120, 22);
            this.numericNumberOfPages.TabIndex = 4;
            // 
            // numericPricePerPage
            // 
            this.numericPricePerPage.Location = new System.Drawing.Point(537, 127);
            this.numericPricePerPage.Name = "numericPricePerPage";
            this.numericPricePerPage.Size = new System.Drawing.Size(120, 22);
            this.numericPricePerPage.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(558, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "очищення";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.numericPricePerPage);
            this.Controls.Add(this.numericNumberOfPages);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkUrgent);
            this.Controls.Add(this.numericNumberOfCopies);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumberOfPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPricePerPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericNumberOfCopies;
        private System.Windows.Forms.CheckBox chkUrgent;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.NumericUpDown numericNumberOfPages;
        private System.Windows.Forms.NumericUpDown numericPricePerPage;
        private System.Windows.Forms.Button btnClear;
    }
}

