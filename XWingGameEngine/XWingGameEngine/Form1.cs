using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XWingGameEngine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Random rnd = new Random();

            Rectangle Rec_1 = new Rectangle
            {
                Size = new Size(40, 40),
                Location = new Point(rnd.Next(0, 60), rnd.Next(0, 60)),
            };
            Rectangle Rec_2 = new Rectangle
            {
                Size = new Size(40, 40),
                Location = new Point(rnd.Next(0, 60), rnd.Next(0, 60))
            };

            Overlap(Rec_1, Rec_2);

            Panel Red_Panel = new Panel
            {
                Size = Rec_1.Size,
                Location = Rec_1.Location,
                BackColor = Color.Red
            };
            Controls.Add(Red_Panel);
            Panel Blue_Panel = new Panel
            {
                Size = Rec_2.Size,
                Location = Rec_2.Location,
                BackColor = Color.Blue
            };
            Controls.Add(Blue_Panel);

        }

        private void Overlap(Rectangle Rec_1, Rectangle Rec_2)
        {
            if (!(Rectangle.Intersect(Rec_1, Rec_2)).IsEmpty)
            {
                MessageBox.Show("Intersect");
            }
            else
            {
                MessageBox.Show("Do not intersect");
            }
        }
    }
}
