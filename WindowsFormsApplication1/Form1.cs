using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Select();
            //在下面调用 start录音功能的function， 开始录音

            ////////////////////////////////////////////////////////
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //在下面调用 停止录音功能的function , 并且用语音识别出来的string替换“hello”

            ////////////////////////////////////////////////////////
            radioButton2.Select();
            string order = "hello"; //在这里 用语音识别出来的string替换“hello”
            checkedListBox1.Items.Add(order);
            int i = checkedListBox1.Items.Count;
            checkedListBox1.SetItemCheckState(i - 1, CheckState.Checked);           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string item in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(item.ToString());
            }
            for (int i = 0; i < checkedListBox1.Items.Count; i++) {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }


    }
}
