namespace RandomFromList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            var carFile = File.ReadAllLines("WeaponsList.txt");
            var carList = new List<string>(carFile);
            var random = new Random();
            int index = random.Next(carList.Count);
            txtResult.Text = carList[index];
        }
    }
}