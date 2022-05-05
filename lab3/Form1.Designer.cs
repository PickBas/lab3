
namespace lab3
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
            this.openFileBtn = new System.Windows.Forms.Button();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.deleteItemBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.filterBtn = new System.Windows.Forms.Button();
            this.entityChoice = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(422, 329);
            this.openFileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(82, 27);
            this.openFileBtn.TabIndex = 0;
            this.openFileBtn.Text = "Open file";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Location = new System.Drawing.Point(508, 329);
            this.saveFileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(82, 27);
            this.saveFileBtn.TabIndex = 1;
            this.saveFileBtn.Text = "Save as";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFileBtn_Click);
            // 
            // filePathLabel
            // 
            this.filePathLabel.Location = new System.Drawing.Point(17, 340);
            this.filePathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(400, 16);
            this.filePathLabel.TabIndex = 2;
            this.filePathLabel.Text = "No file was opened";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(560, 231);
            this.dataGridView1.TabIndex = 3;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(82, 39);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(106, 25);
            this.addItemBtn.TabIndex = 4;
            this.addItemBtn.Text = "Add";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.Location = new System.Drawing.Point(195, 39);
            this.deleteItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(106, 25);
            this.deleteItemBtn.TabIndex = 6;
            this.deleteItemBtn.Text = "Delete";
            this.deleteItemBtn.UseVisualStyleBackColor = true;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(308, 39);
            this.sortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(106, 25);
            this.sortBtn.TabIndex = 7;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(422, 39);
            this.filterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(106, 25);
            this.filterBtn.TabIndex = 8;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            // 
            // entityChoice
            // 
            this.entityChoice.FormattingEnabled = true;
            this.entityChoice.Items.AddRange(new object[] {"City", "Megapolis", "Place", "Region"});
            this.entityChoice.Location = new System.Drawing.Point(82, 15);
            this.entityChoice.Margin = new System.Windows.Forms.Padding(2);
            this.entityChoice.Name = "entityChoice";
            this.entityChoice.Size = new System.Drawing.Size(447, 21);
            this.entityChoice.TabIndex = 9;
            this.entityChoice.Text = "City";
            this.entityChoice.SelectedIndexChanged += new System.EventHandler(this.entityChoice_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.entityChoice);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.deleteItemBtn);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.saveFileBtn);
            this.Controls.Add(this.openFileBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.Button deleteItemBtn;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.ComboBox entityChoice;

        private System.Windows.Forms.Button addItemBtn;

        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Button saveFileBtn;

        #endregion
    }
}

