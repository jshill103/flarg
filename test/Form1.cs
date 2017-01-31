using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        bool isActive;
        String path;
        int pricePerUnit,stackSize, seconds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isActive = false;
            path = "path/to/image";
            seconds = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isActive = true;
            pricePerUnit = int.Parse(textBox1.Text);
            stackSize = int.Parse(textBox2.Text);
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            isActive = false;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            seconds = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                seconds++;
                if(seconds >= 60)
                {
                    runBot();
                }
            }
        }

        private void runBot()
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

    }

}
