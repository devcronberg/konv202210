namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hund h = new Hund();
            h.Navn = "a";
            h.AntalBen = 4;
            propertyGrid1.SelectedObject = h;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hund h = (Hund)propertyGrid1.SelectedObject;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}