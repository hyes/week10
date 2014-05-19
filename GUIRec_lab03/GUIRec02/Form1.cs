using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUIRec02
{
    public partial class Form1 : Form
    {
        private Rectangle[] rectangles = new Rectangle[]
            {
            new Rectangle(10, 10, 100, 100),
            new Rectangle(30, 30, 120, 120)
            };
        
        public Form1()
        {
            InitializeComponent();
        }
    

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                foreach (Rectangle rectangle in rectangles)
                {
                    rectangle.Show(g);

                }
            }
        }


        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Random random = new Random();

            int left = random.Next(1, 100);
            int top = random.Next(1, 100);
            int right = random.Next(200, 300);
            int bottom = random.Next(200, 300);

            Rectangle rectangle = new Rectangle(left, top, right, bottom);

            Rectangle [] newrec = new Rectangle[rectangles.Length+1];

            Array.Copy(rectangles, newrec, 1);
            
            newrec[1] = rectangle;
            
            Array.Copy(rectangles,1, newrec,2, rectangles.Length -1);
            
            rectangles = newrec;
            Form1_Paint(null, null);
        }
    }
}
