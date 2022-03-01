namespace TPMOD2_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama, output;

            nama = Convert.ToString (inputNama.Text);

            output = "Halo " + nama;

            outputNama.Text = output;
        }
    }
}