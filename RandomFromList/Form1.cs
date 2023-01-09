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
            var weaponFile = File.ReadAllLines("WeaponsList.txt");
            var weaponList = new List<string>(weaponFile);
            var random = new Random();
            int index = random.Next(weaponList.Count);
            txtResult.Text = weaponList[index];
        }

        private void btnRandomCar_Click(object sender, EventArgs e)
        {
            var vehicleFile = File.ReadAllLines("VehicleList.txt");
            var vehicleList = new List<string>(vehicleFile);
            var random = new Random();
            int index = random.Next(vehicleList.Count);
            txtResult.Text = vehicleList[index];
        }
    }
}