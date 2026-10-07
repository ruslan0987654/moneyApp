
namespace moneyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXirdala_Click(object sender, EventArgs e)
        {
            

            if (maskedTextBox1.Text == "")
            {
                errorProvider1.SetError(maskedTextBox1, "Məbləğ daxil edin");
                return;
            }

            double mebleg = Convert.ToDouble(maskedTextBox1.Text);

            if (mebleg <= 0)
            {
                MessageBox.Show(
                    "Mənfi və ya sıfır məbləğ xırdalanmaz",
                    "Diqqət",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";

            double say;

            say = Math.Floor(mebleg / 500);

            if (say > 0)
            {
                label8.Text = say.ToString();
                mebleg = mebleg - say * 500;
            }

            say = Math.Floor(mebleg / 200);

            if (say > 0)
            {
                label7.Text = say.ToString();
                mebleg = mebleg - say * 200;
            }

            say = Math.Floor(mebleg / 100);

            if (say > 0)
            {
                label6.Text = say.ToString();
                mebleg = mebleg - say * 100;
            }

            say = Math.Floor(mebleg / 50);

            if (say > 0)
            {
                label5.Text = say.ToString();
                mebleg = mebleg - say * 50;
            }

            say = Math.Floor(mebleg / 20);

            if (say > 0)
            {
                label4.Text = say.ToString();
                mebleg = mebleg - say * 20;
            }

            say = Math.Floor(mebleg / 10);

            if (say > 0)
            {
                label3.Text = say.ToString();
                mebleg = mebleg - say * 10;
            }

            say = Math.Floor(mebleg / 5);

            if (say > 0)
            {
                label2.Text = say.ToString();
                mebleg = mebleg - say * 5;
            }

            say = Math.Floor(mebleg / 1);

            if (say > 0)
            {
                label1.Text = say.ToString();
                mebleg = mebleg - say * 1;
            }
        }
    }
}

