namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            txtDisplay.ReadOnly = true;
            txtDisplay.TabStop = false;
        }

        double firstNum;
        double secondNum;
        string sign;
        double result;
        string equation = "";
        bool resultDisplayed = false;
        bool includesDot = false;


        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.Enabled = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearCalculator();
        }

        private void ClearCalculator()
        {
            txtDisplay.Clear();
            equation = "";
            result = 0;
            firstNum = 0;
            secondNum = 0;
            txtDisplay.Enabled = true;
            resultDisplayed = false;
            includesDot = false;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (resultDisplayed)
            {
                ClearCalculator();
            }

            txtDisplay.Text = txtDisplay.Text + buttonZero.Text;
            equation += buttonZero.Text;
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (resultDisplayed)
            {
                ClearCalculator();
            }

            txtDisplay.Text = txtDisplay.Text + buttonOne.Text;
            equation += buttonOne.Text;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (resultDisplayed)
            {
                ClearCalculator();
            }

            txtDisplay.Text = txtDisplay.Text + buttonTwo.Text;
            equation += buttonTwo.Text;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (resultDisplayed)
            {
                ClearCalculator();
            }

            txtDisplay.Text = txtDisplay.Text + buttonThree.Text;
            equation += buttonThree.Text;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (resultDisplayed)
            {
                ClearCalculator();
            }

            txtDisplay.Text = txtDisplay.Text + buttonFour.Text;
            equation += buttonFour.Text;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (resultDisplayed)
            {
                ClearCalculator();
            }

            txtDisplay.Text = txtDisplay.Text + buttonFive.Text;
            equation += buttonFive.Text;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (resultDisplayed)
            {
                ClearCalculator();
            }

            txtDisplay.Text = txtDisplay.Text + buttonSix.Text;
            equation += buttonSix.Text;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (resultDisplayed)
            {
                ClearCalculator();
            }

            txtDisplay.Text = txtDisplay.Text + buttonSeven.Text;
            equation += buttonSeven.Text;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (resultDisplayed)
            {
                ClearCalculator();
            }

            txtDisplay.Text = txtDisplay.Text + buttonEight.Text;
            equation += buttonEight.Text;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (resultDisplayed)
            {
                ClearCalculator();
            }

            txtDisplay.Text = txtDisplay.Text + buttonNine.Text;
            equation += buttonNine.Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplay.Text))
            {
                return;
            }

            if(!double.TryParse(txtDisplay.Text, out double parsedValue))
            {
                return;
            }

            if (!resultDisplayed)
            {
                if (txtDisplay.Text.EndsWith("."))
                {
                    return;
                }

                sign = "+";
                firstNum = double.Parse(txtDisplay.Text);
                txtDisplay.Text += "+";
                equation += " + ";
                txtDisplay.Clear();
                resultDisplayed = false;
                includesDot = false;
            }

            //if (!string.IsNullOrEmpty(txtDisplay.Text) && !resultDisplayed)
            // This condition doesn't check for the input where user clicks on the operator
            // twice.
            //{
            //    if (txtDisplay.Text.EndsWith("."))
            //    {
            //        return;
            //    }

            //    sign = "+";
            //    firstNum = double.Parse(txtDisplay.Text);
            //    txtDisplay.Text += "+";
            //    equation += " + ";
            //    txtDisplay.Clear();
            //    resultDisplayed = false;
            //    includesDot = false;
            //}
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplay.Text))
            {
                return;
            }

            if (!double.TryParse(txtDisplay.Text, out double parsedValue))
            {
                return;
            }

            if (!resultDisplayed)
            {
                if (txtDisplay.Text.EndsWith("."))
                {
                    return;
                }

                sign = "x";
                firstNum = double.Parse(txtDisplay.Text);
                txtDisplay.Text += "x";
                equation += " x ";
                resultDisplayed = false;
                includesDot = false;
                txtDisplay.Clear();
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplay.Text))
            {
                return;
            }

            if(!double.TryParse(txtDisplay.Text, out double parsedValue))
            {
                return;
            }

            if (!resultDisplayed)
            {
                if (txtDisplay.Text.EndsWith("."))
                {
                    return;
                }

                sign = "/";
                firstNum = double.Parse(txtDisplay.Text);
                txtDisplay.Text += "/";
                equation += " / ";
                txtDisplay.Clear();
                resultDisplayed = false;
                includesDot = false;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplay.Text))
            {
                return;
            }

            if(!double.TryParse(txtDisplay.Text, out double parsedValue))
            {
                return;
            }

            if (!resultDisplayed)
            {
                if (txtDisplay.Text.EndsWith("."))
                {
                    return;
                }
                sign = "-";
                
                firstNum = double.Parse(txtDisplay.Text);
                txtDisplay.Text += "-";
                equation += sign;
                txtDisplay.Clear();
                resultDisplayed = false;
                includesDot = false;
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (resultDisplayed)
            {
                ClearCalculator();
            }

            if (!includesDot)
            {
                txtDisplay.Text += ".";
                equation += ".";
                includesDot = true;
            }
            else
            {
                return;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (resultDisplayed)
            {
                return;
            }

            if (!string.IsNullOrEmpty(txtDisplay.Text) && !string.IsNullOrEmpty(sign))
            {
                //secondNum = double.Parse(txtDisplay.Text);
                if (double.TryParse(txtDisplay.Text, out secondNum))
                {
                    equation += " = ";

                    switch (sign)
                    {
                        case "+":
                            result = firstNum + secondNum;
                            break;
                        case "-":
                            result = firstNum - secondNum;
                            break;
                        case "x":
                            result = firstNum * secondNum;
                            break;
                        case "/":
                            if (secondNum == 0)
                            {
                                txtDisplay.Text = " Can't Divide by 0";
                                return;
                            }
                            else
                            {
                                result = firstNum / secondNum;
                            }
                            break;

                    }
                    equation += result.ToString("F2");
                    txtDisplay.Text = equation;
                    resultDisplayed = true;
                }
            }
        }
    }
}
