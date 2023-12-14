using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_project
{
    public partial class Form1 : Form
    {
        Panel panel1 = new Panel();
        GroupBox week1 = new GroupBox();
        GroupBox week2 = new GroupBox();
        GroupBox week3 = new GroupBox();
        GroupBox week4 = new GroupBox();
        CheckBox cb1 = new CheckBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 600);

            this.Controls.Add(panel1);
            panel1.Size = new Size(900, 500);
            panel1.Location = new Point(40,30);
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
    }
}
