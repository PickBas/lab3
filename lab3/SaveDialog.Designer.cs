using System.ComponentModel;

namespace lab3
{
    partial class SaveDialog <T>
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
            this.jsonSave = new System.Windows.Forms.Button();
            this.xmlSave = new System.Windows.Forms.Button();
            this.csvSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jsonSave
            // 
            this.jsonSave.Location = new System.Drawing.Point(50, 70);
            this.jsonSave.Margin = new System.Windows.Forms.Padding(2);
            this.jsonSave.Name = "jsonSave";
            this.jsonSave.Size = new System.Drawing.Size(100, 71);
            this.jsonSave.TabIndex = 0;
            this.jsonSave.Text = "JSON";
            this.jsonSave.UseVisualStyleBackColor = true;
            this.jsonSave.Click += new System.EventHandler(this.jsonSave_Click);
            // 
            // xmlSave
            // 
            this.xmlSave.Location = new System.Drawing.Point(154, 70);
            this.xmlSave.Margin = new System.Windows.Forms.Padding(2);
            this.xmlSave.Name = "xmlSave";
            this.xmlSave.Size = new System.Drawing.Size(100, 71);
            this.xmlSave.TabIndex = 1;
            this.xmlSave.Text = "XML";
            this.xmlSave.UseVisualStyleBackColor = true;
            this.xmlSave.Click += new System.EventHandler(this.xmlSave_Click);
            // 
            // csvSave
            // 
            this.csvSave.Location = new System.Drawing.Point(259, 70);
            this.csvSave.Margin = new System.Windows.Forms.Padding(2);
            this.csvSave.Name = "csvSave";
            this.csvSave.Size = new System.Drawing.Size(100, 71);
            this.csvSave.TabIndex = 2;
            this.csvSave.Text = "CSV";
            this.csvSave.UseVisualStyleBackColor = true;
            this.csvSave.Click += new System.EventHandler(this.csvSave_Click);
            // 
            // SaveDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 204);
            this.Controls.Add(this.csvSave);
            this.Controls.Add(this.xmlSave);
            this.Controls.Add(this.jsonSave);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SaveDialog";
            this.Text = "SaveDialog";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button jsonSave;
        private System.Windows.Forms.Button xmlSave;
        private System.Windows.Forms.Button csvSave;

        #endregion
    }
}