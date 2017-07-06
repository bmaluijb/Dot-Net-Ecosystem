using System;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsSpecific
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawSomething();            
        }

        private void DrawSomething()
        {
            using(var blueBrush = new SolidBrush(Color.Blue))
            {
                using(var graphics = CreateGraphics())
                {                
                    graphics.FillRectangle(blueBrush, new Rectangle(10, 10, 100, 100));
                    graphics.DrawString(SharedClassLibrary.SharedClass.GetCurrentAssemblyLocation(),
                        this.Font, blueBrush, new Point(125, 125));
                }
            }
        }
    }
}
