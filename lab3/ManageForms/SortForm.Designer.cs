using System.ComponentModel;

namespace lab3.ManageForms
{
    partial class SortForm <T>
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.populationBtn = new System.Windows.Forms.Button();
            this.squareBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // populationBtn
            // 
            this.populationBtn.Location = new System.Drawing.Point(12, 96);
            this.populationBtn.Name = "populationBtn";
            this.populationBtn.Size = new System.Drawing.Size(138, 43);
            this.populationBtn.TabIndex = 0;
            this.populationBtn.Text = "Population";
            this.populationBtn.UseVisualStyleBackColor = true;
            this.populationBtn.Click += new System.EventHandler(this.populationBtn_Click);
            // 
            // squareBtn
            // 
            this.squareBtn.Location = new System.Drawing.Point(195, 96);
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(138, 43);
            this.squareBtn.TabIndex = 1;
            this.squareBtn.Text = "Square";
            this.squareBtn.UseVisualStyleBackColor = true;
            this.squareBtn.Click += new System.EventHandler(this.squareBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(54, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sort by population or by square?";
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 168);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.squareBtn);
            this.Controls.Add(this.populationBtn);
            this.Name = "SortForm";
            this.Text = "SortForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button populationBtn;
        private System.Windows.Forms.Button squareBtn;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}