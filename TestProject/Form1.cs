using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); //เรียกหน้าฟอร์มใหม่ กำหนดให้ฟอร์มใหม่นั้นชื่อว่า form2
            form2.Show(); //กำหนดเมื่อคลิกปุ่มนี้ให้เปิดหน้า form2 ขึ้น
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); //เรียกหน้าฟอร์มใหม่ กำหนดให้ฟอร์มใหม่นั้นชื่อว่า form3
            form3.Show(); //กำหนดเมื่อคลิกปุ่มนี้ให้เปิดหน้า form3 ขึ้น
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            Form4 form4 = new Form4(); //เรียกหน้าฟอร์มใหม่ กำหนดให้ฟอร์มใหม่นั้นชื่อว่า form4
            form4.Show(); //กำหนดเมื่อคลิกปุ่มนี้ให้เปิดหน้า form4 ขึ้น
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(); //เรียกหน้าฟอร์มใหม่ กำหนดให้ฟอร์มใหม่นั้นชื่อว่า form5
            form5.Show(); //กำหนดเมื่อคลิกปุ่มนี้ให้เปิดหน้า form5 ขึ้น
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(); //เรียกหน้าฟอร์มใหม่ กำหนดให้ฟอร์มใหม่นั้นชื่อว่า form6
            form6.Show(); //กำหนดเมื่อคลิกปุ่มนี้ให้เปิดหน้า form6 ขึ้น
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(); //เรียกหน้าฟอร์มใหม่ กำหนดให้ฟอร์มใหม่นั้นชื่อว่า form7
            form7.Show(); //กำหนดเมื่อคลิกปุ่มนี้ให้เปิดหน้า form7 ขึ้น
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(); //เรียกหน้าฟอร์มใหม่ กำหนดให้ฟอร์มใหม่นั้นชื่อว่า form8
            form8.Show(); //กำหนดเมื่อคลิกปุ่มนี้ให้เปิดหน้า form8 ขึ้น
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(); //เรียกหน้าฟอร์มใหม่ กำหนดให้ฟอร์มใหม่นั้นชื่อว่า form9
            form9.Show(); //กำหนดเมื่อคลิกปุ่มนี้ให้เปิดหน้า form9 ขึ้น
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10(); //เรียกหน้าฟอร์มใหม่ กำหนดให้ฟอร์มใหม่นั้นชื่อว่า form10
            form10.Show(); //กำหนดเมื่อคลิกปุ่มนี้ให้เปิดหน้า form10 ขึ้น
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11(); //เรียกหน้าฟอร์มใหม่ กำหนดให้ฟอร์มใหม่นั้นชื่อว่า form11
            form11.Show(); //กำหนดเมื่อคลิกปุ่มนี้ให้เปิดหน้า form11 ขึ้น
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
