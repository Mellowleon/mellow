using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 浩然计算器__测试用_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.MaximizeBox = false;
            InitializeComponent();
        }
        int d = 0,s=1,g=1,x,w=1,p=1,d2=0,zd=0,gai=0,zdx,l=1;
        double b, b1, ans, r, ans2,k,zd1,r1;
        private void textBox1_TextChanged(object sender, EventArgs e){}
        private void button6_Click(object sender, EventArgs e){}
        
        private void scanf_Click(object sender, EventArgs e)//输入数字
        {
            if (d2 == 1) { textBox1.Text = "0"; d = 0; s = 1; g = 1; ans = 0; x = 0; d2 = 0; p = 1; }

            if (s == 1)
            { 
                if (p == 0) { p = 1; textBox1.Text = "0"; d = 0; s = 1; g = 1;}
                if (g == 0) { g = 1; textBox1.Text = "0"; d = 0;}
                w = 1;
                gai = 0;

                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "";
                        Button but = (Button)sender;
                        textBox1.Text += but.Text;
                    }
                    else
                    {
                        Button but = (Button)sender;
                        textBox1.Text += but.Text;
                    }

                
            }
              
            
            
        }

        private void Num0_Click(object sender, EventArgs e)//输入0
        {
            if (d2 == 1) { textBox1.Text = "0"; d = 0; s = 1; g = 1; ans = 0; x = 0; d2 = 0; p = 1; }
            if (s == 1)
            {
                if (p == 0) { p = 1; textBox1.Text = "0"; d = 0; s = 1; g = 1; }
                if (g == 0) { g = 1; textBox1.Text = "0"; d = 0; }
                w = 1; 
                gai = 0;

                if (textBox1.Text == "0") { }

                else if (d2 == 1)
                    {
                        textBox1.Text = "0"; d = 0; s = 1; g = 1; ans = 0; x = 0; d2 = 0; 

                    }
                else
                {
                    textBox1.Text += "0";
                }
            }
        }

        private void Dot_Click(object sender, EventArgs e)//dot   d
        {
            if (d2 == 1) { textBox1.Text = "0"; d = 0; s = 1; g = 1; ans = 0;  x = 0; d2 = 0; p = 1; }
            if (s == 1)
            {
                w = 1; 
                    if (d == 0)
                    {
                        textBox1.Text += "."; d = 1;
                    }

                    if (d2 == 1)
                    {
                        textBox1.Text = "0."; d = 1; s = 1; g = 1; d2 = 0; p = 1; x = 0;

                    }

                    if (x != 0 && d == 0)
                    {
                        d = 0; s = 1; g = 1; ans = 0; d2 = 0;
                        textBox1.Text = "0."; d = 1; g = 1; p = 1; x = 0; d2 = 0;
                      
                    }

                    if (gai == 1) { textBox1.Text = "0."; d = 1; g = 1; p = 1;  g = 1; d2 = 0; }
                
            gai = 0;
            }

        }

        private void delet_Click(object sender, EventArgs e)//back
        {
            if (s == 1&&g==1)
            {
                if (textBox1.Text == "-0.") { textBox1.Text = "0"; d = 0; d2 = 0; }
                b = Convert.ToDouble(textBox1.Text);

                if (textBox1.Text.Substring(textBox1.Text.Length - 1, 1) == ".")
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    d = 0;
                }

                else if (b == 0) { }

                else if (b > 0)
                {




                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    if (textBox1.Text == "") { textBox1.Text = "0"; }

                }
                else if (b < 0)
                {



                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    if (textBox1.Text == "-") { textBox1.Text = "0"; }
                }
            }
        }





        private void change_Click(object sender, EventArgs e)//相反数
        {
            if (s == 1)
            {
                if (textBox1.Text == "0.") { textBox1.Text = "-0."; }
                else if (textBox1.Text == "-0.") { textBox1.Text = "0."; }
                else if (textBox1.Text != "")
                {
                    b1 = Convert.ToDouble(textBox1.Text);
                    b1 = b1 * (-1);
                    textBox1.Text = Convert.ToString(b1);
                }
            }
        }





        private void sqrt__Click(object sender, EventArgs e)//sqrt   g
        {
            if (s == 1)
            {
                b1 = Convert.ToDouble(textBox1.Text);
                if (b1 >= 0)
                {

                    b1 = Math.Sqrt(b1);
                    textBox1.Text = Convert.ToString(b1); g = 0;
                }
                else { textBox1.Text = "无效输入"; s = 0; d = 0; g = 1; ans = 0; d2 = 0; x = 0; }      // s
              
            }
        }





        private void C_error_Click(object sender, EventArgs e)//c error
        {
            if (textBox1.Text == "除数不能为零" || textBox1.Text == "结果未定义" || textBox1.Text != "无效输入")
            {
                textBox1.Text = "0"; d = 0; s = 1; g = 1; ans = 0; d2 = 0; x = 0;
            }
            else
            {
                textBox1.Text = "0"; d = 0; s = 1; g = 1; d2 = 0;
            }
        }



        private void Clean_Click(object sender, EventArgs e)//clean
        {
            textBox1.Text = "0"; d = 0; s = 1; g = 1; ans = 0; d2 = 0; x = 0; gai = 0; zd = 0; l = 1; zd1 = 0; zdx = 0; zd = 0;w=1;p=1;
        }


        private void work1_Click(object sender, EventArgs e)//                     ↓↓↓↓↓↓↓↓↓***加 减 乘 除***↓↓↓↓↓↓↓↓↓
        {
            d2 = 0;

            if (s == 1)
            {   
                

                if (p != 0&&w==1&&gai==0)
                {     
                    if (x != 0)
                    {
                        if (x == 1)           //        + 
                        {
                            textBox1.Text = Convert.ToString(ans + Convert.ToDouble(textBox1.Text));

                        }
                        else if (x == 2)       //    -
                        {
                            textBox1.Text = Convert.ToString(ans + Convert.ToDouble(textBox1.Text) * (-1));
                        }
                        else if (x== 3)      //        * 
                        {
                            textBox1.Text = Convert.ToString(ans * Convert.ToDouble(textBox1.Text));

                        }
                        else if (x == 4)      //        / 
                        {
                            textBox1.Text = Convert.ToString(ans / Convert.ToDouble(textBox1.Text));

                        }
                    }
                }




            ans = Convert.ToDouble(textBox1.Text); g = 0;
            textBox1.Text = Convert.ToString(ans);
               Button but2 = (Button)sender;
            


            if (but2.Text == "+")
            {
                
               

                     if (w == 1)
                    {
                        x = 1; w = 0; p = 1; gai = 1;     zd = 1;
                    }
                     else if(gai==1)
                     {
                         x = 1; w = 0; p = 1; gai = 1; zd = 1;
                     }
               
                k = 1;
            }

            else if (but2.Text == "-")
            {

                   
                    if (w == 1)
                    {
                        x = 2; w = 0; p = 1; gai = 1;
 zd = 2;
                    }
                    else if (gai == 1)
                    {
                        x = 2; w = 0; p = 1; gai = 1; zd = 2;

                    }
                k = 1;

            }

            else if (but2.Text == "*")
            {

               
                    if (w == 1)
                    {
                        x = 3; w = 0; p = 1; gai = 1; zd = 3;

                    }
                    else if (gai == 1)
                    {
                        x = 3; w = 0; p = 1; gai = 1; zd = 3;

                    }
                k = 1;

            }

            else if (but2.Text == "/")
            {
                
                    if (w == 1)
                    {
                        x = 4; w = 0; p = 1; gai = 1;zd = 4;

                    }
                    else if (gai == 1)
                    {
                        x = 4; w = 0; p = 1; gai = 1; zd = 4;

                    }
               
                k = Convert.ToDouble(textBox1.Text);

            }
            d = 0; 
            }
        }                                                          //       ↑↑↑↑↑↑↑↑↑↑↑***加 减 乘 除***↑↑↑↑↑↑↑↑↑↑↑↑↑






        private void flip_Click(object sender, EventArgs e)//倒数
        {
            if (s == 1)
            {
                if (textBox1.Text != "0")
                {
                    b1 = Convert.ToDouble(textBox1.Text);
                    b1 = 1 / b1;
                    textBox1.Text = Convert.ToString(b1);g = 0;
                }
                else { textBox1.Text = "除数不能为零"; s = 0; d = 0; g = 1; d2 = 0; x = 0; }
                
            }

        }





        private void equal_Click(object sender, EventArgs e)//                    =     ....................复杂的等号
        {

            if (textBox1.Text == "0.") { textBox1.Text = "0"; }
           
            if (x == 0) {  s = 0; }
            if (textBox1.Text != "除数不能为零" && textBox1.Text != "结果未定义" && textBox1.Text != "无效输入")
            {
                r = Convert.ToDouble(textBox1.Text); r1 = r;
            }
             if (s == 1)
            { 
                
                 
                if (x == 4 && r==0 &&k==0)
                {
                    textBox1.Text = "结果未定义"; s = 0; d = 0; g = 1;  d2 = 0; x = 0;
                        }
              //  else if (k == 0 && r != 0) { textBox1.Text = "0"; s = 0; d = 0; g = 1; d2 = 0; x = 0; }

                else if (x == 4 && r == 0)
                {
                    textBox1.Text = "除数不能为零"; s = 0; d = 0; g = 1; d2 = 0; x = 0;
                }
                
                if (s == 1)
                {
                   
             
                    if (zd != 0)
                    {
                        if (textBox1.Text != "除数不能为零" && textBox1.Text != "结果未定义" && textBox1.Text != "无效输入")
                        {
                            zd1 = Convert.ToDouble(textBox1.Text);
                        } zdx = zd; zd = 0;


                        
                    }
                    


                    {



                        if (p == 1) { ans2 = r; }

                        g = 0;

                        if(l==1)
                        {
                        if (x == 0) { g = 0; d = 0; g = 1; }

                        else if (x == 1)
                        {
                            if (p == 1) { r += ans; textBox1.Text = Convert.ToString(r); }
                            else { r += ans2; textBox1.Text = Convert.ToString(r); }  l=0;
                        }
                        else if (x == 2)
                        {
                            if (p == 1) { ans -= r; textBox1.Text = Convert.ToString(ans); }
                            else { r += -ans2; textBox1.Text = Convert.ToString(r); }l=0;
                        }
                        else if (x == 3)
                        {
                            if (p == 1) { r *= ans; textBox1.Text = Convert.ToString(r); }
                            else { r *= ans2; textBox1.Text = Convert.ToString(r); }l=0;

                        }
                        else if (x == 4)
                        {
                            if (p == 1) { ans /= r; textBox1.Text = Convert.ToString(ans); }
                            else { r /= ans2; textBox1.Text = Convert.ToString(r); }l=0;
                        }
                        }


                    }
                    p = 0; w = 1; d2 = 1;
                }
            

             }

             if (x == 0 && s == 0)
             {
                 if (textBox1.Text != "0"&&textBox1.Text != "除数不能为零" && textBox1.Text != "结果未定义" && textBox1.Text != "无效输入")
                 { r = Convert.ToDouble(textBox1.Text); textBox1.Text = Convert.ToString(r); }
                 
                 if (textBox1.Text != "除数不能为零" && textBox1.Text != "结果未定义" && textBox1.Text != "无效输入") { s = 1; p = 0; w = 1; d2 = 1; } }


            if(l==1)
            {
                
             if (zdx == 1)
             {
                
                  { r1 += zd1; textBox1.Text = Convert.ToString(r1); }

                            }
             else if (zdx == 2) {
                 { r1 += -zd1; textBox1.Text = Convert.ToString(r1); }
             }
             else if (zdx == 3) {
                 { r1 *= zd1; textBox1.Text = Convert.ToString(r1); }
             }
             else if (zdx == 4) {
                 { r1 /= zd1; textBox1.Text = Convert.ToString(r1); }
             }
            }
            l = 1;
          //   if (zdx == 1) { textBox1.Text += "***"; }
            // if (r1 == 0) { textBox1.Text = "r1shi0*"; } else { textBox1.Text = "r1bushi0*"; }
        }

        private void label1_Click(object sender, EventArgs e){}
    }
}
