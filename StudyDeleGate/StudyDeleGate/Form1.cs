using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyDeleGate
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //声明一个委托
        public delegate void MyDeleGate();
        //实例一个委托
        public MyDeleGate myDel;
        //声明一个事件
        public event MyDeleGate EventMydel;
        //事件触发机制
        public void DoEventMydel()
        {
            EventMydel();
        }
        Test ts = new Test();
        private void Form1_Load(object sender, EventArgs e)
        {
             
            myDel += ts.Fun_A;
            myDel += ts.Fun_B;

            EventMydel += ts.Fun_A;
            EventMydel += ts.Fun_B;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            myDel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myDel = null;
            myDel += ts.Fun_C;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoEventMydel();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EventMydel = null;
            EventMydel += ts.Fun_C;
        }

     
    }
    public class Test
    {
        public void Fun_A()
        {
            MessageBox.Show("A方法触发了");
        }
        public void Fun_B()
        {
            MessageBox.Show("B 方法触发了");
        }
        public void Fun_C()
        {
            MessageBox.Show("C 方法触发了");
        }

    }
}
