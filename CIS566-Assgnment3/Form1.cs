namespace CIS566_Assgnment3
{
    public partial class Form1 : Form
    {
        MileHandler mileHandler;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double input;

            try{
                input = Convert.ToDouble(inputBox.Text);
                mileHandler = new MileHandler(conversionBox.Text, input);
                resultBox.Text = mileHandler.getResult().ToString();
            }
            catch(Exception ex)
            {

            }
        }
    }
}