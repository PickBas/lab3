﻿
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
            this.openFileBtn.Location = new System.Drawing.Point(562, 405);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(110, 33);
            this.openFileBtn.TabIndex = 0;
            this.openFileBtn.Text = "Open file";
            this.openFileBtn.UseVisualStyleBackColor = true;
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Location = new System.Drawing.Point(678, 405);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(110, 33);
            this.saveFileBtn.TabIndex = 1;
            this.saveFileBtn.Text = "Save as";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            // 
            // filePathLabel
            // 
            this.filePathLabel.Location = new System.Drawing.Point(359, 418);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(197, 20);
            this.filePathLabel.TabIndex = 2;
            this.filePathLabel.Text = "No file was opened";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(747, 284);
            this.dataGridView1.TabIndex = 3;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(109, 48);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(142, 31);
            this.addItemBtn.TabIndex = 4;
            this.addItemBtn.Text = "Add";
            this.addItemBtn.UseVisualStyleBackColor = true;
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.Location = new System.Drawing.Point(260, 48);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(142, 31);
            this.deleteItemBtn.TabIndex = 6;
            this.deleteItemBtn.Text = "Delete";
            this.deleteItemBtn.UseVisualStyleBackColor = true;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(411, 48);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(142, 31);
            this.sortBtn.TabIndex = 7;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(562, 48);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(142, 31);
            this.filterBtn.TabIndex = 8;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            // 
            // entityChoice
            // 
            this.entityChoice.FormattingEnabled = true;
            this.entityChoice.Items.AddRange(new object[] {"City", "Megapolis", "Place", "Region"});
            this.entityChoice.Location = new System.Drawing.Point(109, 18);
            this.entityChoice.Name = "entityChoice";
            this.entityChoice.Size = new System.Drawing.Size(595, 24);
            this.entityChoice.TabIndex = 9;
            this.entityChoice.Text = "City";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.entityChoice);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.deleteItemBtn);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.filePathLabel);
            this.Controls.Add(this.saveFileBtn);
            this.Controls.Add(this.openFileBtn);
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

