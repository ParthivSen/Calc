using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        double num1, num2;
        string expression;
        string[] expressionList = { };
        string[] resultList = { };
        string option = "";
        float currentSize;
        double res;
        bool historyBarExpand;
        bool sidebarExpand;


        private void CheckTxtRcnt(string num)
        {
            if (TxtRcnt.Text.Length != 0)
            {
                if (num1 + "" == TxtMain.Text || TxtMain.Text == "0")
                {
                    TxtMain.Text = num;
                }
                else if (TxtRcnt.Text[TxtRcnt.Text.Length - 1] == '=')
                {
                    TxtMain.Text = num;
                    TxtRcnt.Text = "";
                }
                else
                {
                    TxtMain.Text += num;
                }
            }

            else if (TxtMain.Text == "0")
            {
                TxtMain.Text = num;
            }
            else if (TxtMain.Text == "Cannot Divide By Zero" || TxtMain.Text == "Invalid Input")
            {
                currentSize = 32.25F;
                TxtMain.Font = new Font(TxtMain.Font.Name, currentSize,
                TxtMain.Font.Style, TxtMain.Font.Unit);
                TxtMain.Text = num;
                EnableBtns();
            }

            else
            {
                TxtMain.Text += num;
            }


        }

        private void DisableBtns()
        {
            BtnPercent.Enabled = false;
            BtnFrac.Enabled = false;
            BtnSqre.Enabled = false;
            BtnSqrt.Enabled = false;
            BtnDivide.Enabled = false;
            BtnDecimal.Enabled = false;
            BtnMultiply.Enabled = false;
            BtnMinus.Enabled = false;
            BtnPlus.Enabled = false;
            BtnNegate.Enabled = false;

        }
        private void EnableBtns()
        {
            BtnPercent.Enabled = true;
            BtnFrac.Enabled = true;
            BtnSqre.Enabled = true;
            BtnSqrt.Enabled = true;
            BtnDivide.Enabled = true;
            BtnDecimal.Enabled = true;
            BtnMultiply.Enabled = true;
            BtnMinus.Enabled = true;
            BtnPlus.Enabled = true;
            BtnNegate.Enabled = true;
        }

        private void BtnNum1_Click(object sender, EventArgs e)
        {
            //CheckTxtMain("1");
            CheckTxtRcnt("1");
        }

        private void BtnNum2_Click(object sender, EventArgs e)
        {
            //CheckTxtMain("2");
            CheckTxtRcnt("2");
        }

        private void BtnNum3_Click(object sender, EventArgs e)
        {
            //CheckTxtMain("3");
            CheckTxtRcnt("3");
        }

        private void BtnNum4_Click(object sender, EventArgs e)
        {
            //CheckTxtMain("4");
            CheckTxtRcnt("4");
        }

        private void BtnNum5_Click(object sender, EventArgs e)
        {
            //CheckTxtMain("5");
            CheckTxtRcnt("5");
        }

        private void BtnNum6_Click(object sender, EventArgs e)
        {
            //CheckTxtMain("6");
            CheckTxtRcnt("6");
        }

        private void BtnNum7_Click(object sender, EventArgs e)
        {
            //CheckTxtMain("7");
            CheckTxtRcnt("7");
        }

        private void BtnNum8_Click(object sender, EventArgs e)
        {
            //CheckTxtMain("8");
            CheckTxtRcnt("8");
        }

        private void BtnNum9_Click(object sender, EventArgs e)
        {
            //CheckTxtMain("9");
            CheckTxtRcnt("9");
        }

        private void BtnNum0_Click(object sender, EventArgs e)
        {
            CheckTxtRcnt("0");
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(TxtMain.Text);
            expression = num1 + " +";
            TxtRcnt.Text = expression;
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(TxtMain.Text);
            expression = num1 + " -";
            TxtRcnt.Text = expression;
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(TxtMain.Text);
            expression = num1 + " \u00d7";
            TxtRcnt.Text = expression;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(TxtMain.Text);
            expression = num1 + " \u00f7";
            TxtRcnt.Text = expression;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            if (TxtMain.Text == "Cannot Divide By Zero" || TxtMain.Text == "Invalid Input")
            {
                EnableBtns();
                TxtMain.Text = "0";
                TxtRcnt.Text = "";
            }
            else
            {
                num2 = double.Parse(TxtMain.Text);
                TxtRcnt.Text += " " + num2 + " =";

                if (option == "+")
                {
                    res = num1 + num2;
                    TxtMain.Text = res + "";
                }

                if (option == "-")
                {
                    res = num1 - num2;
                    TxtMain.Text = res + "";
                }

                if (option == "*")
                {
                    res = num1 * num2;
                    TxtMain.Text = res + "";
                }

                if (option == "/")
                {
                    res = num1 / num2;
                    TxtMain.Text = res + "";
                }

                expression += num2;
                expressionList.Append(expression);
                resultList.Append(res + "");

                if (res.ToString() == "\u221e") //infinty icon
                {
                    TxtMain.Text = "Cannot Divide By Zero";

                    currentSize = 20.0F;
                    TxtMain.Font = new Font(TxtMain.Font.Name, currentSize,
                    TxtMain.Font.Style, TxtMain.Font.Unit);
                    DisableBtns();
                }

                res = 0;
            }


        }

        private void BtnNegate_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(TxtMain.Text);
            TxtMain.Text = num1 * -1 + "";
            TxtRcnt.Text = "negate(" + num1 + ")";
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            if (TxtMain.Text.Contains("."))
            {
                TxtMain.Text += "";
            }
            else
            {
                TxtMain.Text += ".";
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if ((TxtMain.Text == "Cannot Divide By Zero" || TxtMain.Text == "Invalid Input"))
            {
                EnableBtns();
                currentSize = 32.25F;
                TxtMain.Font = new Font(TxtMain.Font.Name, currentSize,
                TxtMain.Font.Style, TxtMain.Font.Unit);
                TxtMain.Text = "0";
            }
            else
            {
                if (!String.IsNullOrEmpty(TxtMain.Text))
                {
                    TxtMain.Text = TxtMain.Text.Substring(0, TxtMain.Text.Length - 1);
                }
                if (String.IsNullOrEmpty(TxtMain.Text))
                {
                    TxtMain.Text = "0";
                }
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            if (TxtMain.Text == "Cannot Divide By Zero" || TxtMain.Text == "Invalid Input")
            {
                EnableBtns();
                currentSize = 32.25F;
                TxtMain.Font = new Font(TxtMain.Font.Name, currentSize,
                TxtMain.Font.Style, TxtMain.Font.Unit);
                TxtMain.Text = "0";
                TxtRcnt.Clear();
                
            }
            else
            {
                TxtRcnt.Clear();
                TxtMain.Text = "0";
            }
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {

            if (TxtMain.Text == "Cannot Divide By Zero" || TxtMain.Text == "Invalid Input")
            {
                EnableBtns();
                currentSize = 32.25F;
                TxtMain.Font = new Font(TxtMain.Font.Name, currentSize,
                TxtMain.Font.Style, TxtMain.Font.Unit);
                TxtMain.Text = "0";
                TxtRcnt.Clear();
            }
            else
            {
                TxtMain.Text = "0";
            }
        }

        private void BtnFrac_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(TxtMain.Text);
            if (num1 == 0)
            {
                TxtMain.Text = "Cannot Divide By Zero";

                currentSize = 20.0F;
                TxtMain.Font = new Font(TxtMain.Font.Name, currentSize,
                TxtMain.Font.Style, TxtMain.Font.Unit);
                DisableBtns();
            }
            else
            {
                res = 1 / num1;
                TxtMain.Text = res + "";
                TxtRcnt.Text = "1/(" + num1 + ")=";
            }

        }

        private void BtnSqre_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(TxtMain.Text);
            res = Math.Pow(num1, 2);
            TxtMain.Text = res + "";
            TxtRcnt.Text = "sqr(" + num1 + ")=";
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(TxtMain.Text);
            if (num1 < 0)
            {
                TxtMain.Text = "Invalid Input";
                DisableBtns();
            }
            else
            {
                res = Math.Sqrt(num1);
                TxtMain.Text = res + "";
                TxtRcnt.Text = "\u221a(" + num1 + ")=";
            }
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            if (TxtRcnt.Text.Length == 0)
            {
                TxtMain.Text = "0";
                TxtRcnt.Text = "0";
            }
            else
            {
                double percent = double.Parse(TxtMain.Text);
                if (TxtRcnt.Text == "0")
                {
                    TxtRcnt.Text = "0";
                    TxtMain.Text = "0";
                }
                else if(option == "*")
                {
                    num2 = percent / 100;
                    TxtMain.Text = num2 + "";
                }
                else if(TxtRcnt.Text.Substring(TxtRcnt.Text.Length-1, 1) == "=")
                {
                    res *= res / 100; 
                }
                else
                {
                    num1 = double.Parse(TxtRcnt.Text.Substring(0, TxtRcnt.Text.Length - 1));
                    //double percent = double.Parse(TxtMain.Text);

                    num2 = percent * num1 / 100;

                    TxtMain.Text = num2 + "";
                }
            }
        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                RcntHistBtn.Enabled = true;
                BtnBack.Enabled = true;
                BtnDivide.Enabled = true;
                BtnMinus.Enabled = true;
                BtnMultiply.Enabled = true;
                BtnPlus.Enabled = true;
                BtnEqual.Enabled = true;
                SideBar.Width -= 100;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SiderBarTimer.Stop();
                }
            }
            else
            {
                RcntHistBtn.Enabled = false;
                BtnBack.Enabled = false;
                BtnDivide.Enabled = false;
                BtnMinus.Enabled = false;
                BtnMultiply.Enabled = false;
                BtnPlus.Enabled = false;
                BtnEqual.Enabled = false;
                SideBar.Width += 100;
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SiderBarTimer.Stop();
                }
            }
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            SiderBarTimer.Start();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            //SideBar.Visible = true;
            SiderBarTimer.Start();
        }

        private void HistoryBarTimer_Tick(object sender, EventArgs e)
        {
            if (historyBarExpand)
            {
                MainMenuBtn.Enabled = true;
                HistoryBar.Height -= 100;
                if (HistoryBar.Height == HistoryBar.MinimumSize.Height)
                {
                    historyBarExpand = false;
                    HistoryBarTimer.Stop();
                }
            }
            else
            {
                MainMenuBtn.Enabled = false;
                HistoryBar.Height += 100;
                if (HistoryBar.Height == HistoryBar.MaximumSize.Height)
                {
                    historyBarExpand = true;
                    HistoryBarTimer.Stop();
                }
            }
        }

        private void RcntHistBtn_Click(object sender, EventArgs e)
        {
            HistoryBarTimer.Start();
        }

        
    }
}
