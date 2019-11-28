using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsForm_Hello_Word
{
    public partial class Form1 : Form
    {


        public int Adadeavval=0;

        public int AdadeDovvom = -222222222;

        public int AdadeHasel = 0;

        public string flag="" ;

        public bool is_Adadeavval = false;

        List<Calculator_Struct> Mohamad = new List<Calculator_Struct>();
        



        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            if (is_Adadeavval == true)
            {
                if( string.IsNullOrEmpty(flag) )
                {
                    MessageBox.Show("عملگر را انتحاب کنید");
                }else
                {
                    AdadeDovvom = 1;
                    Lbl_Result.Text = Adadeavval.ToString() + flag + AdadeDovvom.ToString();

                }
            }
            else
            {
                Adadeavval = 1;
                Lbl_Result.Text = Adadeavval.ToString();
                is_Adadeavval = true; 
                

            }
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            if (is_Adadeavval == true)
            {
                if (string.IsNullOrEmpty(flag))
                {
                    MessageBox.Show("عملگر را انتحاب کنید");
                }
                else
                {
                    AdadeDovvom = 2;
                    Lbl_Result.Text = Adadeavval.ToString() + flag + AdadeDovvom.ToString();

                }
            }
            else
            {
                Adadeavval = 2;
                Lbl_Result.Text = Adadeavval.ToString();
                is_Adadeavval = true;


            }
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            if (is_Adadeavval == true)
            {
                if (string.IsNullOrEmpty(flag))
                {
                    MessageBox.Show("عملگر را انتحاب کنید");
                }
                else
                {
                    AdadeDovvom = 3;
                    Lbl_Result.Text = Adadeavval.ToString() + flag + AdadeDovvom.ToString();

                }
            }
            else
            {
                Adadeavval = 3;
                Lbl_Result.Text = Adadeavval.ToString();
                is_Adadeavval = true;


            }
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            if (is_Adadeavval == true)
            {
                if (string.IsNullOrEmpty(flag))
                {
                    MessageBox.Show("عملگر را انتحاب کنید");
                }
                else
                {
                    AdadeDovvom = 4;
                    Lbl_Result.Text = Adadeavval.ToString() + flag + AdadeDovvom.ToString();

                }
            }
            else
            {
                Adadeavval = 4;
                Lbl_Result.Text = Adadeavval.ToString();
                is_Adadeavval = true;


            }
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            if (is_Adadeavval == true)
            {
                if (string.IsNullOrEmpty(flag))
                {
                    MessageBox.Show("عملگر را انتحاب کنید");
                }
                else
                {
                    AdadeDovvom = 5;
                    Lbl_Result.Text = Adadeavval.ToString() + flag + AdadeDovvom.ToString();

                }
            }
            else
            {
                Adadeavval = 5;
                Lbl_Result.Text = Adadeavval.ToString();
                is_Adadeavval = true;


            }
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            if (is_Adadeavval == true)
            {
                if (string.IsNullOrEmpty(flag))
                {
                    MessageBox.Show("عملگر را انتحاب کنید");
                }
                else
                {
                    AdadeDovvom = 6;
                    Lbl_Result.Text = Adadeavval.ToString() + flag + AdadeDovvom.ToString();

                }
            }
            else
            {
                Adadeavval = 6;
                Lbl_Result.Text = Adadeavval.ToString();
                is_Adadeavval = true;


            }
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            if (is_Adadeavval == true)
            {
                if (string.IsNullOrEmpty(flag))
                {
                    MessageBox.Show("عملگر را انتحاب کنید");
                }
                else
                {
                    AdadeDovvom = 7;
                    Lbl_Result.Text = Adadeavval.ToString() + flag + AdadeDovvom.ToString();

                }
            }
            else
            {
                Adadeavval = 7;
                Lbl_Result.Text = Adadeavval.ToString();
                is_Adadeavval = true;


            }
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            if (is_Adadeavval == true)
            {
                if (string.IsNullOrEmpty(flag))
                {
                    MessageBox.Show("عملگر را انتحاب کنید");
                }
                else
                {
                    AdadeDovvom = 8;
                    Lbl_Result.Text = Adadeavval.ToString() + flag + AdadeDovvom.ToString();

                }
            }
            else
            {
                Adadeavval = 8;
                Lbl_Result.Text = Adadeavval.ToString();
                is_Adadeavval = true;


            }
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            if (is_Adadeavval == true)
            {
                if (string.IsNullOrEmpty(flag))
                {
                    MessageBox.Show("عملگر را انتحاب کنید");
                }
                else
                {
                    AdadeDovvom = 9;
                    Lbl_Result.Text = Adadeavval.ToString() + flag + AdadeDovvom.ToString();

                }
            }
            else
            {
                Adadeavval = 9;
                Lbl_Result.Text = Adadeavval.ToString();
                is_Adadeavval = true;


            }
        }

        private void Btn_Taghsim_Click(object sender, EventArgs e)
        {
            if (is_Adadeavval == true)
            {
                flag = "/";
                Lbl_Result.Text = Adadeavval.ToString() + flag;

            }else
            {
                MessageBox.Show("ابتدا عدد اول را وارد نمایید");


            }
          

           
        }

        private void Btn_Zarb_Click(object sender, EventArgs e)
        {
            if (is_Adadeavval == true)
            {
                flag = "*";
                Lbl_Result.Text = Adadeavval.ToString() + flag;

            }
            else
            {
                MessageBox.Show("ابتدا عدد اول را وارد نمایید");


            }
        }

        private void Btn_Jam_Click(object sender, EventArgs e)
        {
            if (is_Adadeavval == true)
            {
                flag = "+";
                Lbl_Result.Text = Adadeavval.ToString() + flag;

            }
            else
            {
                MessageBox.Show("ابتدا عدد اول را وارد نمایید");


            }
        }

        private void Btn_Tafrigh_Click(object sender, EventArgs e)
        {
            if (is_Adadeavval == true)
            {
                flag = "-";
                Lbl_Result.Text = Adadeavval.ToString() + flag;

            }
            else
            {
                MessageBox.Show("ابتدا عدد اول را وارد نمایید");


            }

        }

        private void Btn_Zero_Click(object sender, EventArgs e)
        {
            if (is_Adadeavval == true)
            {
                if (string.IsNullOrEmpty(flag))
                {
                    MessageBox.Show("عملگر را انتحاب کنید");
                }
                else
                {
                    AdadeDovvom = 0;
                    Lbl_Result.Text = Adadeavval.ToString() + flag + AdadeDovvom.ToString();

                }
            }
            else
            {
                Adadeavval = 0;
                Lbl_Result.Text = Adadeavval.ToString();
                is_Adadeavval = true;


            }
        }

        private void Btn_Mosavi_Click(object sender, EventArgs e)
        {
            if(is_Adadeavval)
            {
                if (AdadeDovvom!= -222222222)
                {
                    if (flag == "+")
                    {
                        AdadeHasel = Adadeavval + AdadeDovvom;
                        Calculator_Struct calculator_Struct = new Calculator_Struct();
                        calculator_Struct.Adadeavval = Adadeavval;
                        calculator_Struct.AdadeDovvom = AdadeDovvom;
                        calculator_Struct.AdadeHasel = AdadeHasel;
                        calculator_Struct.flag = flag;
                        calculator_Struct.is_Adadeavval = is_Adadeavval;

                        Mohamad.Add(calculator_Struct);


        
                        Lbl_Result.Text = Adadeavval.ToString() + flag + AdadeDovvom.ToString() + "=" + AdadeHasel.ToString();
                        Adadeavval = 0;

                        AdadeDovvom = -222222222;

                        AdadeHasel = 0;

                        flag = "";

                        is_Adadeavval = false;
                    }
                    else   if (flag == "*")
                    {
                        AdadeHasel = Adadeavval * AdadeDovvom;
                        Calculator_Struct calculator_Struct = new Calculator_Struct();
                        calculator_Struct.Adadeavval = Adadeavval;
                        calculator_Struct.AdadeDovvom = AdadeDovvom;
                        calculator_Struct.AdadeHasel = AdadeHasel;
                        calculator_Struct.flag = flag;
                        calculator_Struct.is_Adadeavval = is_Adadeavval;

                        Mohamad.Add(calculator_Struct);

                       
                        Lbl_Result.Text = Adadeavval.ToString() + flag + AdadeDovvom.ToString() + "=" + AdadeHasel.ToString();

                        Adadeavval = 0;

                        AdadeDovvom = -222222222;

                        AdadeHasel = 0;

                        flag = "";

                        is_Adadeavval = false;
                    }
                 else   if (flag == "/")
                    {
                        AdadeHasel = Adadeavval / AdadeDovvom;
                        Calculator_Struct calculator_Struct = new Calculator_Struct();
                        calculator_Struct.Adadeavval = Adadeavval;
                        calculator_Struct.AdadeDovvom = AdadeDovvom;
                        calculator_Struct.AdadeHasel = AdadeHasel;
                        calculator_Struct.flag = flag;
                        calculator_Struct.is_Adadeavval = is_Adadeavval;

                        Mohamad.Add(calculator_Struct);
                       
                        Lbl_Result.Text = Adadeavval.ToString() + flag + AdadeDovvom.ToString() + "=" + AdadeHasel.ToString();


                        Adadeavval = 0;

                        AdadeDovvom = -222222222;

                        AdadeHasel = 0;

                        flag = "";

                        is_Adadeavval = false;
                    }
                    else  if (flag == "-")
                    {
                        AdadeHasel = Adadeavval - AdadeDovvom;
                        Calculator_Struct calculator_Struct = new Calculator_Struct();
                        calculator_Struct.Adadeavval = Adadeavval;
                        calculator_Struct.AdadeDovvom = AdadeDovvom;
                        calculator_Struct.AdadeHasel = AdadeHasel;
                        calculator_Struct.flag = flag;
                        calculator_Struct.is_Adadeavval = is_Adadeavval;

                        Mohamad.Add(calculator_Struct);
                        Lbl_Result.Text = Adadeavval.ToString() + flag + AdadeDovvom.ToString() + "=" + AdadeHasel.ToString();



                        Adadeavval = 0;

                        AdadeDovvom = -222222222;

                        AdadeHasel = 0;

                        flag = "";

                        is_Adadeavval = false;
                    }
                    else
                    {
                        MessageBox.Show("عملگر را وارد نمایید");
                    }
                }else
                {
                    MessageBox.Show("عدد دوم را وارد نمایید");

                }
            }
            else
            {
                MessageBox.Show("عدد اول را وارد نمایید");
            }


        }

        private void FrmClosed(object sender, FormClosedEventArgs e)
        {
            ClassCach name = new ClassCach("cash.json", "Name");

            string jsone = JsonConvert.SerializeObject(Mohamad);
            name.Write_ToFile(jsone);
        }
        //----
        private void Form1_Load(object sender, EventArgs e)
        {
            ClassCach name = new ClassCach("cash.json", "Name");

            string jsone = name.TextFromFile();


            if (string.IsNullOrEmpty(jsone))
            {
                Mohamad = new List<Calculator_Struct>();
            }
            else
            {
                Mohamad = JsonConvert.DeserializeObject<List<Calculator_Struct>>(jsone);
            }
        }

        private void Btn_UP_Click(object sender, EventArgs e)
        {
            if (Count < Mohamad.Count)
            {
                Lbl_Result.Text = Mohamad[Count].Adadeavval.ToString() + Mohamad[Count].flag + Mohamad[Count].AdadeDovvom.ToString() + "=" + Mohamad[Count].AdadeHasel.ToString();
                Count++;
            } else
            {
                Count = Mohamad.Count - 1;

            }
        }
        public int Count = 0;

        

        private void Btn_Down_Click(object sender, EventArgs e)
        {
            if (Count > -1)
            {
              

                Lbl_Result.Text = Mohamad[Count].Adadeavval.ToString() + Mohamad[Count].flag + Mohamad[Count].AdadeDovvom.ToString() + "=" + Mohamad[Count].AdadeHasel.ToString();
            Count--;

            }else
            {
                Count = 0;
            }

            if (Count == -1)
            {
                Count = 0;
            }
        }

    }
}
