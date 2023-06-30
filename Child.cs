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
    public partial class Child : Form
    {
        public Parent PARENT { get; set; }
        public Child()
        {
            InitializeComponent();
        }
        public Child(Parent parent)         // конструктор з параметром - батьківська форма
        {
            InitializeComponent();
            this.PARENT = parent;
        }

        private void timer1_Tick(object sender, EventArgs e)        // подія таймера дочірньої форми
        {
            this.textBox1.Text = PARENT.textBox1.Text;              // копіювання тексту з батьківської форми
        }

        private void Child_Activated(object sender, EventArgs e)    // подія - активація дочіньої форми
        {
            this.timer1.Stop();             // таймер дочірньої форми зупиняється
            PARENT.timer1.Start();          // таймер батьківської форми запускається
        }
    }
}
