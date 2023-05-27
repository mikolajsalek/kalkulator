using System.Diagnostics;
using org.mariuszgromada.math.mxparser;

namespace kalkulator
{


    public partial class Form1 : Form
    {
        double firstvalue, secondvalue;
        string op;
        bool isRadians;
        string previousResult;
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (display.Text == "0")
                display.Text = "";

            {
                if (num.Text == ".")
                {
                    if (!display.Text.Contains("."))
                        display.Text = display.Text + num.Text;
                }
                else
                {
                    display.Text = display.Text + num.Text;
                }

            }


        }

        private void numop(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            firstvalue = Convert.ToDouble(display.Text);
            op = num.Text;
            display.Text = "";

        }
        private void rowna_Click(object sender, EventArgs e)
        {
            secondvalue = Convert.ToDouble(display.Text);

            switch (op)
            {
                case "+":
                    display.Text = (secondvalue + firstvalue).ToString();
                    break;

                case "-":
                    display.Text = (secondvalue - firstvalue).ToString();
                    break;

                case "X":
                    display.Text = (secondvalue * firstvalue).ToString();
                    break;

                case "/":
                    display.Text = (secondvalue / firstvalue).ToString();
                    break;
                case "Exp":
                    double i = Convert.ToDouble(display.Text);
                    double j;

                    j = secondvalue;
                    display.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                    break;

                case "xdoy":

                    string expression = firstvalue.ToString() + "^" + secondvalue.ToString();
                    Expression p = new Expression(expression);
                    double result = p.calculate();

                    display.Text = result.ToString();


                    break;



                default:
                    break;

            }
            previousResult = display.Text;
        }

        private void ac_Click(object sender, EventArgs e)
        {
            display.Text = "0";

            string a, b;

            a = Convert.ToString(firstvalue);
            b = Convert.ToString(secondvalue);

            a = "";
            b = "";
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 450;
            display.Width = 400;
        }


        private void prosty_Click(object sender, EventArgs e)
        {

        }

        private void deg_Click(object sender, EventArgs e)
        {
            isRadians = false;
            rad.Enabled = true;
            deg.Enabled = false;
        }


        private void procent_Click(object sender, EventArgs e)
        {
            double a;

            a = Convert.ToDouble(display.Text) / Convert.ToDouble(100);

            display.Text = Convert.ToString(a);
        }

        private void ans_Click(object sender, EventArgs e)
        {
            display.Text = previousResult;

        }

        private void pnawias_Click(object sender, EventArgs e)
        {
        }

        private void lnawias_Click(object sender, EventArgs e)
        {
        }

        private void root_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(display.Text);
            sq = Math.Sqrt(sq);
            display.Text = Convert.ToString(sq);

        }

        private void log_Click(object sender, EventArgs e)
        {
            double logg = Convert.ToDouble(display.Text);
            logg = Math.Log10(logg);
            display.Text = Convert.ToString(logg);

        }

        private void ln_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(display.Text);
            lnx = Math.Log(lnx);
            display.Text = Convert.ToString(lnx);
        }

        private void silnia_Click(object sender, EventArgs e)
        {
            string expression = display.Text + "!";
            Expression p = new Expression(expression);
            double result = p.calculate();
            display.Text = result.ToString();

        }

        private void tan_Click(object sender, EventArgs e)
        {
            double angle = Convert.ToDouble(display.Text);
            if (!isRadians)
                angle = DegreesToRadians(angle);

            double result = Math.Tan(angle);
            display.Text = result.ToString();
        }

        private void e_Click(object sender, EventArgs e)
        {
            display.Text = "2.71828182846";
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            double angle = Convert.ToDouble(display.Text);
            if (!isRadians)
                angle = DegreesToRadians(angle);

            double result = Math.Cos(angle);
            display.Text = result.ToString();
        }

        private void pi_Click(object sender, EventArgs e)
        {
            display.Text = "3.141592653589976323";

        }

        private void sin_Click(object sender, EventArgs e)
        {
            double angle = Convert.ToDouble(display.Text);
            if (!isRadians)
                angle = DegreesToRadians(angle);

            double result = Math.Sin(angle);
            display.Text = result.ToString();
        }

        private void inv_Click(object sender, EventArgs e)
        {
            string expression = "1/" + display.Text;
            Expression p = new Expression(expression);
            double result = p.calculate();
            display.Text = result.ToString();
        }

        private void rad_Click(object sender, EventArgs e)
        {
            isRadians = true;
            rad.Enabled = false;
            deg.Enabled = true;
        }

        private void naukowy_Click(object sender, EventArgs e)
        {
        }

        private void display_TextChanged(object sender, EventArgs e)
        {
        }

        private double DegreesToRadians(double degrees)
        {
            return degrees * (Math.PI / 180.0);
        }

        private double RadiansToDegrees(double radians)
        {
            return radians * (180.0 / Math.PI);
        }

        private void prostyKalkulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 450;
            display.Width = 400;
        }

        private void naukowyKalkulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 780;
            display.Width = 700;
        }
    }
}