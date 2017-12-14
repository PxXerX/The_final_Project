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
    public partial class Form9 : Form
    {
        int clickCount = 6; //กำหนดให้ clickCount เป็นตัวแปรประเภทตัวเลข และกำหนดค่าให้เท่ากับ 6

        public Form9()
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
                MessageBox.Show("You lose .. Let's try again ^^.", "The Hangman Game Level 8 !!"); //ให้ MessageBox แสดงข้อความ
                this.Close(); //ให้ปิดหน้า form9 นี้
                Form9 form9 = new Form9(); //เรียกหน้าฟอร์มใหม่ กำหนดให้ฟอร์มใหม่นั้นชื่อว่า form9
                form9.Show(); //กำหนดเมื่อคลิกปุ่มนี้ให้เปิดหน้า form9 ขึ้น
            }
        }
        public void right(Button bt)
        {
            bt.Visible = false; //ให้ปิดปุ่มนี้เมื่อได้ทำการกดแล้ว
            if (textBox1.Text == "D" && textBox2.Text == "E" && textBox3.Text == "P" && textBox4.Text == "A" && textBox5.Text == "R" && textBox6.Text == "T" && textBox7.Text == "U" && textBox8.Text == "R" && textBox9.Text == "E")
            //กำหนดเงื่อนไขเมื่อตัวอักษร D แสดงใน textBox1 ,E แสดงใน textBox2 ,P แสดงใน textBox3 ,A แสดงใน textBox4 ,R แสดงใน textBox5 ,T แสดงใน textBox6 ,U แสดงใน textBox7 ,R ใน textBox8 และ E ใน textBox9
            {
                MessageBox.Show("\r\nDeparture (n.) = การออกเดินทาง \r\n\r\n คลิก OK เพื่อไปเลเวลต่อไป", "The Hangman Game Level 8 !!"); //เมื่อเข้าเงื่อนไข ให้ MessageBox แสดงข้อความ
                this.Close(); //ให้ปิดหน้า form9 นี้
                Form10 form10 = new Form10(); //เรียกหน้าฟอร์มใหม่ กำหนดให้ฟอร์มใหม่นั้นชื่อว่า form10
                form10.Show(); //กำหนดเมื่อคลิกปุ่มนี้ให้เปิดหน้า form10 ขึ้น
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "D"; //ให้ตัวอักษร D แสดงบน textBox1
            right(button20); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "E"; textBox9.Text = "E"; //ให้ตัวอักษร E แสดงบน textBox2 และ textBox9
            right(button3); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text = "P"; //ให้ตัวอักษร P แสดงบน textBox3
            right(button11); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox4.Text = "A"; //ให้ตัวอักษร A แสดงบน textBox4
            right(button12); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Text = "T"; //ให้ตัวอักษร E แสดงบน textBox6
            right(button5); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox7.Text = "U"; //ให้ตัวอักษร U แสดงบน textBox7
            right(button8); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Text = "R"; textBox8.Text = "R"; //ให้ตัวอักษร R แสดงบน textBox5 และ textBox8
            right(button4); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox10.Text += button1.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button1); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox10.Text += button15.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button15); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox10.Text += button23.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button23); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
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

        private void button26_Click(object sender, EventArgs e)
        {
            textBox10.Text += button26.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button26); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox10.Text += button27.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button27); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
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

        private void button22_Click(object sender, EventArgs e)
        {
            textBox10.Text += button22.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button22); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
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

        private void button19_Click(object sender, EventArgs e)
        {
            textBox10.Text += button19.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button19); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox10.Text += button21.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button21); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox10.Text += button10.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button10); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox10.Text += button9.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button9); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox10.Text += button6.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button6); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox10.Text += button2.Text + ",  "; //ให้ข้อความในปุ่มไปเพิ่มที่กล่องข้อความ
            check(button2); //สร้าง Method แบบ public โดยไม่สนค่ากลับ เพื่อนำตรวจสอบในเงื่อนไข
        }
    }
}
