﻿namespace ReadingaFile_Reyes_BSIT
{
    partial class FrmOpenTextFile
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
            this.lvShowText = new System.Windows.Forms.ListView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lvShowText
            // 
            this.lvShowText.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lvShowText.HideSelection = false;
            this.lvShowText.Location = new System.Drawing.Point(8, 12);
            this.lvShowText.Name = "lvShowText";
            this.lvShowText.Size = new System.Drawing.Size(408, 269);
            this.lvShowText.TabIndex = 0;
            this.lvShowText.TileSize = new System.Drawing.Size(328, 37);
            this.lvShowText.UseCompatibleStateImageBehavior = false;
            this.lvShowText.View = System.Windows.Forms.View.Tile;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Brown;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.btnOpen.Location = new System.Drawing.Point(156, 287);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(115, 32);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmOpenTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(428, 328);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lvShowText);
            this.Name = "FrmOpenTextFile";
            this.Text = "FrmOpenTextFile";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvShowText;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

