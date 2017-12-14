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
    public partial class Form10 : Form
    {
        int clickCount = 6; //กำหนดให้ clickCount เป็นตัวแปรประเภทตัวเลข และกำหนดค่าให้เท่ากับ 6

        public Form10()
        {
            InitializeComponent();
        }
        public void check(Button btn)
        {
            clickCount -= 1; //ให้ clickCount -1 ไปเรื่อยๆ ทุกครั้งที่กดปุ่ม
            btn.Visible = false; //ให้ปิดปุ่มนี้เมื่อได้ทำการกดแล้ว
            label3.Text = clickCount.ToString(); //ให้ label3 แสดงค่า clickCount เป็นข้อมูลตัวอักษร
            if (clickCount == 5) //สร้างเงื่อนไขเมื่อ clickCount มีค่าเท่ากับ 5 
            {
                pictureBox1.ImageLocation = Application.StartupPath + @"\image\2.png"; //ให้ pictureBox1 แสดงรูปภาพ
            }
            else if (clickCount == 4) //สร้างเงื่อนไขเมื่อ clickCount มีค่าเท่ากับ 4
            {
                pictureBox1.ImageLocation = Application.StartupPath + @"\image\3.png"; //ให้ pictureBox1 แสดงรูปภาพ
            }
            else if (clickCount == 3) //สร้างเงื่อนไขเมื่อ clickCount มีค่าเท่ากับ 3
            {
                pictureBox1.ImageLocation = Application.StartupPath + @"\image\4.png"; //ให้ pictureBox1 แสดงรูปภาพ
            }
            else if (clickCount == 2) //สร้างเงื่อนไขเมื่อ clickCount มีค่าเท่ากับ 2
            {
                pictureBox1.ImageLocation = Application.StartupPath + @"\image\5.png"; //ให้ pictureBox1 แสดงรูปภาพ
            }
            else if (clickCount == 1) //สร้างเงื่อนไขเมื่อ clickCount มีค่าเท่ากับ 1
            {
                pictureBox1.ImageLocation = Application.StartupPath + @"\image\6.png"; //ให้ pictureBox1 แสดงรูปภาพ
            }
            else if (clickCount == 0) //สร้างเงื่อนไขเมื่อ clickCount มีค่าเท่ากับ 0
            {
                pictureBox1.ImageLocation = Application.StartupPath + @"\image\7.png"; //ให้ pictureBox1 แสดงรูปภาพ
                MessageBox.Show("You lose .. Let's try again ^^.", "The Hangman Game Level 9 !!"); //ให้ MessageBox แสดงข้อความ
                this.Close(); //ให้ปิดหน้า form10 นี้
                Form10 form10 = new Form10(); //เรียกหน้าฟอร์มใหม่ กำหนดให้ฟอร์มใหม่นั้นชื่อว่า form10
                form10.Show(); //กำหนดเมื่อคลิกปุ่มนี้ให้เปิดหน้า form10 ขึ้น
            }
        }
        public void right(Button bt)
        {
            bt.Visible = false; //ให้ปิดปุ่มนี้เมื่อได้ทำการกดแล้ว
            if (textBox1.Text == "E" && textBox2.Text == "F" && textBox3.Text == "F" && textBox4.Text == "I" && textBox5.Text == "C" && textBox6.Text == "I" && textBox7.Text == "E" && textBox8.Text == "N" && textBox9.Text == "T")
            //กำหนดเงื่อนไขเมื่อตัวอักษร E แสดงใน textBox1 ,F แสดงใน textBox2 ,F แสดงใน textBox3 ,I แสดงใน textBox4 ,C แสดงใน textBox5 ,I แสดงใน textBox6 ,E แสดงใน textBox7 ,N ใน textBox8 และ T ใน textBox9
            {
                MessageBox.Show("\r\nEfficient (adj.) = ที่มีประสิทธิภาพ \r\n\r\n คลิก OK เพื่อไปเลเวลต่อไป", "The Hangman Game Level 9 !!"); //เมื่อเข้าเงื่อนไข ให้ MessageBox แสดงข้อความ
                this.Close(); //ให้ปิดหน้า form10 นี้
                Form11 form11 = new Form11(); //เรียกหน้าฟอร์มใหม่ กำหนดให้ฟอร์มใหม่นั้นชื่อว่า form11
                form11.Show(); //กำหนดเมื่อคลิกปุ่มนี้ให้เปิดหน้า form11 ขึ้น
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "E"; textBox7.Text = "E"; //ให้ตัวอักษร E แสดงบน textBox1 และ textBox7
            right(button3); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Text = "F"; textBox3.Text = "F"; //ให้ตัวอักษร F แสดงบน textBox2 และ textBox3
            right(button19); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox4.Text = "I"; textBox6.Text = "I"; //ให้ตัวอักษร I แสดงบน textBox4 และ textBox6
            right(button9); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox5.Text = "C"; //ให้ตัวอักษร C แสดงบน textBox5
            right(button26); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox8.Text = "N"; //ให้ตัวอักษร N แสดงบน textBox8
            right(button23); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox9.Text = "T"; //ให้ตัวอักษร T แสดงบน textBox9
            right(button5); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox10.Text += button1.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button1); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox10.Text += button8.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button8); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox10.Text += button24.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button24); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox10.Text += button25.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button25); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox10.Text += button27.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button27); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox10.Text += button12.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button12); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button_M_Click(object sender, EventArgs e)
        {
            textBox10.Text += button_M.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button_M); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox10.Text += button14.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button14); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox10.Text += button15.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button15); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox10.Text += button16.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button16); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox10.Text += button17.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button17); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox10.Text += button18.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button18); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox10.Text += button20.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button20); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox10.Text += button21.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button21); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox10.Text += button11.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button11); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox10.Text += button10.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button10); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox10.Text += button22.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button22); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox10.Text += button6.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button6); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox10.Text += button4.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button4); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox10.Text += button2.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button2); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }
    }
}
