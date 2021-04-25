﻿
namespace FaCup
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
            this.components = new System.ComponentModel.Container();
            this.btnDraw = new System.Windows.Forms.Button();
            this.rtbTeams = new System.Windows.Forms.RichTextBox();
            this.teamModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.teamModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(459, 230);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(122, 23);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Fourth Round Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // rtbTeams
            // 
            this.rtbTeams.Location = new System.Drawing.Point(12, 12);
            this.rtbTeams.Name = "rtbTeams";
            this.rtbTeams.Size = new System.Drawing.Size(428, 327);
            this.rtbTeams.TabIndex = 2;
            this.rtbTeams.Text = "";
            // 
            // teamModelBindingSource
            // 
            this.teamModelBindingSource.DataSource = typeof(FaCup.TeamModel);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1664, 1011);
            this.Controls.Add(this.rtbTeams);
            this.Controls.Add(this.btnDraw);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FA Cup Draw";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.RichTextBox rtbTeams;
        private System.Windows.Forms.BindingSource teamModelBindingSource;
    }
}

