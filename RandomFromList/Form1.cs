using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RandomFromList
{
    public partial class Form1 : Form
    {
        private static List<string> weaponList;
        private static List<string> vehicleList;

        public Form1()
        {
            InitializeComponent();

            // Load the weapon and vehicle lists
            weaponList = new List<string>(File.ReadAllLines("WeaponsList.txt"));
            vehicleList = new List<string>(File.ReadAllLines("VehicleList.txt"));
        }

        private void btnRandomWeapon_Click(object sender, EventArgs e)
        {
            // Generate a cryptographically secure random number
            int index = GetRandomNumber(weaponList.Count);

            // Display the randomly chosen weapon
            txtResult.Text = weaponList[index];
        }

        private void btnRandomCar_Click(object sender, EventArgs e)
        {
            // Generate a cryptographically secure random number
            int index = GetRandomNumber(vehicleList.Count);

            // Display the randomly chosen vehicle
            txtResult.Text = vehicleList[index];
        }

        private int GetRandomNumber(int max)
        {
            // Create a buffer to hold the random bytes
            byte[] randomNumber = new byte[4];

            // Create a new instance of the RNGCryptoServiceProvider
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                // Generate a random number using the RNGCryptoServiceProvider
                rng.GetBytes(randomNumber);

                // Convert the random bytes to an integer
                int value = BitConverter.ToInt32(randomNumber, 0);

                // Ensure that the random number is within the range [0, max)
                return Math.Abs(value % max);
            }
        }
    }
}