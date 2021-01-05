//ID: 1775227
//Name: Marissa Goncalves
//Assignment 6 - World GDP Income Application

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem01
{
    public partial class WorldGDPIncomeForm : Form
    {
        public WorldGDPIncomeForm()
        {
            InitializeComponent();
        }

        private void countryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.worldIncomeDataSet);

        }

        private void WorldGDPIncomeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'worldIncomeDataSet.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.worldIncomeDataSet.Country);
        }

        private void sortByIncomeAscendingButton_Click(object sender, EventArgs e)
        {
            this.countryTableAdapter.FillByIncome(this.worldIncomeDataSet.Country);
        }

        private void sortByIncomeDescendingButton_Click(object sender, EventArgs e)
        {
            this.countryTableAdapter.FillByIncomeDescending(this.worldIncomeDataSet.Country);
        }

        private void sortByNameAscendingButton_Click(object sender, EventArgs e)
        {
            this.countryTableAdapter.FillByName(this.worldIncomeDataSet.Country);
        }

        private void sortByNameDescendingButton_Click(object sender, EventArgs e)
        {
            this.countryTableAdapter.FillByNameDescending(this.worldIncomeDataSet.Country);
        }

        private void totalIncomeButton_Click(object sender, EventArgs e)
        {
            decimal totalCountryIncome;
            totalCountryIncome = (decimal) this.countryTableAdapter.TotalIncome();

            MessageBox.Show("Total income of all countries: " + totalCountryIncome.ToString("c"));
        }

        private void averageIncomeButton_Click(object sender, EventArgs e)
        {
            decimal averageCountryIncome;
            averageCountryIncome = (decimal) this.countryTableAdapter.AverageIncome();

            MessageBox.Show("Average income of all countries: " + averageCountryIncome.ToString("c"));
        }

        private void highestIncomeButton_Click(object sender, EventArgs e)
        {
            decimal highestCountryIncome;
            highestCountryIncome = (decimal)this.countryTableAdapter.HighestIncome();

            MessageBox.Show("Highest income of any country is: " + highestCountryIncome.ToString("c"));
        }

        private void lowestIncomeButton_Click(object sender, EventArgs e)
        {
            decimal lowestCountryIncome;
            lowestCountryIncome = (decimal)this.countryTableAdapter.LowestIncome();

            MessageBox.Show("Lowest income of any country is: " + lowestCountryIncome.ToString("c"));
        }

    }
}
