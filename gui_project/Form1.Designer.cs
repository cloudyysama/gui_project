using System.Drawing;
using System.Windows.Forms;

namespace gui_project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 432);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            Panel panel1 = new Panel();
            GroupBox week1 = new GroupBox();
            GroupBox week2 = new GroupBox();
            GroupBox week3 = new GroupBox();
            GroupBox week4 = new GroupBox();
            CheckBox cb1 = new CheckBox();
            this.Size = new Size(1000, 600);

            this.Controls.Add(panel1);
            panel1.Size = new Size(900, 500);
            panel1.Location = new Point(40, 30);
            panel1.ForeColor = Color.WhiteSmoke;
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.Fixed3D;

            panel1.Controls.Add(week1);
            week1.Size = new Size(190, 400);
            week1.Location = new Point(40, 50);
            week1.Text = "Week 1";
            week1.Font = new Font("Constantia", 12);
            week1.ForeColor = Color.WhiteSmoke;

            panel1.Controls.Add(week2);
            week2.Size = new Size(190, 400);
            week2.Location = new Point(250, 50);
            week2.Text = "Week 2";
            week2.Font = new Font("Constantia", 12);
            week2.ForeColor = Color.WhiteSmoke;

            panel1.Controls.Add(week3);
            week3.Size = new Size(190, 400);
            week3.Location = new Point(460, 50);
            week3.Text = "Week 3";
            week3.Font = new Font("Constantia", 12);
            week3.ForeColor = Color.WhiteSmoke;

            panel1.Controls.Add(week4);
            week4.Size = new Size(190, 400);
            week4.Location = new Point(670, 50);
            week4.Text = "Week 4";
            week4.Font = new Font("Constantia", 12);
            week4.ForeColor = Color.WhiteSmoke;

        }

        #endregion
    }
}

