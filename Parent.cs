using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_49_WF4_24._06._2023
{
    public partial class Parent : Form
    {
        private Child child = null;
        public Parent()
        {
            InitializeComponent();
            child = new Child(this);
            child.Show();
            //this.Location = new Point(50, 50);
            //this.child.Location = new Point(50, 250);
            //timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)        // подія таймера батьківської форми
        {
            this.textBox1.Text = child.textBox1.Text;              // копіювання тексту з дочірньої форми
        }

        private void Parent_Activated(object sender, EventArgs e)    // подія - активація батьківської форми
        {
            this.timer1.Stop();             // таймер батьківської форми зупиняється
            child.timer1.Start();           // таймер дочірньої форми запускається

        }
    }
}
