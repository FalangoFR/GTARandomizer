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
        private static List<string> gameList;

        public Form1()
        {
            InitializeComponent();

            // Load the weapon and vehicle lists
            weaponList = new List<string>(File.ReadAllLines("WeaponsList.txt"));
            vehicleList = new List<string>(File.ReadAllLines("VehicleList.txt"));
            gameList = new List<string>(File.ReadAllLines("GameList.txt"));
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
            return RandomNumberGenerator.GetInt32(max);
        }

        private void btnRandomGame_Click(object sender, EventArgs e)
        {
            // Generate a cryptographically secure random number
            int index = GetRandomNumber(gameList.Count);

            // Display the randomly chosen weapon
            txtResult.Text = gameList[index];
        }
    }
}