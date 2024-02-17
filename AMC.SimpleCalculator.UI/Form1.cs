namespace AMC.SimpleCalculator.UI
{
    public partial class Form1 : Form
    {
        Calculator calculator = new Calculator();
        bool textchanged = true;
        bool willdelete = true;
        public Form1()
        {
            InitializeComponent();

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textchanged)
            {
             txtMain.Text += (sender as Button).Text;
            }
            else
            {
                txtMain.Text ="";
                txtMain.Text += (sender as Button).Text;
            }
           

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMain.Text = string.Empty;
            calculator.assigned1 = false;
            calculator.assigned2 = false;
            textchanged = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            if (txtMain.Text.Length != 0)
            {
                txtMain.Text = txtMain.Text.Remove(txtMain.Text.Length - 1);
            }

        }

        private void btn_NegOrPos(object sender, EventArgs e)
        {
         if(textchanged)
            {
            if (txtMain.Text.StartsWith("-"))
            {
                txtMain.Text = txtMain.Text.Replace("-", "");
            }
            else
            {
                txtMain.Text = "-" + txtMain.Text;
            }
            }
            else
            {
                txtMain.Text ="";
                if (txtMain.Text.StartsWith("-"))
                {
                    txtMain.Text = txtMain.Text.Replace("-", "");
                }
                else
                {
                    txtMain.Text = "-" + txtMain.Text;
                }
            }
            
        }

        private void btnDecimalClick(object sender, EventArgs e)
        {
            if (textchanged)
            {
            if (!txtMain.Text.Contains("."))
            {
                if(txtMain.Text.StartsWith("."))
                {
                    txtMain.Text = "0";
                }
                txtMain.Text += ".";
            }
            }
            else
            {
                txtMain.Text = "";
                if (!txtMain.Text.Contains("."))
                {
                    if (txtMain.Text.StartsWith("."))
                    {
                        txtMain.Text = "0";
                    }
                    txtMain.Text += ".";
                }
            }
           
            
        }



        private void btnDivide_click(object sender, EventArgs e)
        {
            if (textchanged == true)
            {
                calculator.Assignnumber(double.Parse(txtMain.Text));
                calculator.storefunction((sender as Button).Text);
                textchanged = false;
            }
        }

        private void btnMultiply_click(object sender, EventArgs e)
        {
            if (textchanged == true)
            {
                calculator.Assignnumber(double.Parse(txtMain.Text));
                calculator.storefunction((sender as Button).Text);
                textchanged = false;
            }
        }

        private void btnSubtract_click(object sender, EventArgs e)
        {
            if (textchanged == true)
            {
                calculator.Assignnumber(double.Parse(txtMain.Text));
                calculator.storefunction((sender as Button).Text);
                textchanged = false;
            }

        }

        private void btnPlus_click(object sender, EventArgs e)
        {
            if (textchanged == true)
            {
                calculator.Assignnumber(double.Parse(txtMain.Text));
                calculator.storefunction((sender as Button).Text);
                textchanged = false;
            }
        }

        private void btnSqrt_click(object sender, EventArgs e)
        {
            calculator.storefunction((sender as Button).Text);
            textchanged = false;
        }

        private void btnReciprical_click(object sender, EventArgs e)
        {

            calculator.storefunction((sender as Button).Text);
            textchanged = false;
        }


        private void btnEquals_click(object sender, EventArgs e)
        {
            willdelete = true;
            textchanged = false;
            calculator.Assignnumber(double.Parse(txtMain.Text));
            txtMain.Text = calculator.executefunction().ToString();
        }


    }
}
