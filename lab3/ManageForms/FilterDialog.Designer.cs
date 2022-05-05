using System.ComponentModel;

namespace lab3.ManageForms
{
    partial class FilterDialog
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
            this.populationInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.squareInput = new System.Windows.Forms.TextBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // populationInput
            // 
            this.populationInput.Location = new System.Drawing.Point(169, 19);
            this.populationInput.Name = "populationInput";
            this.populationInput.Size = new System.Drawing.Size(290, 20);
            this.populationInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Population more than:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(34, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Square more than:";
            // 
            // squareInput
            // 
            this.squareInput.Location = new System.Drawing.Point(169, 45);
            this.squareInput.Name = "squareInput";
            this.squareInput.Size = new System.Drawing.Size(290, 20);
            this.squareInput.TabIndex = 2;
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(433, 89);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(72, 27);
            this.filterBtn.TabIndex = 4;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // FilterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 128);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.squareInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.populationInput);
            this.Name = "FilterDialog";
            this.Text = "FilterDialog";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox populationInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox squareInput;
        private System.Windows.Forms.Button filterBtn;

        #endregion
    }
}