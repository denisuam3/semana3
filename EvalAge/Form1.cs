using Usoif.models;

namespace EvalAge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LblAdware_Click(object sender, EventArgs e)
        {
            int age = Convert.ToUInt16(tbAge.Text);
            Evaluate evaluate = new Evaluate();
            lbLAnswer.Text = evaluate.EvalAge(age);

        }
    }
}
