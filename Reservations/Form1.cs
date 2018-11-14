using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservations
{
    public partial class frmReservation : Form
    {
        DateTime currentDate = DateTime.Today;
        int numDefaultDaysFromStart = 3;
        int numDefaultYearsFromStart = 5;
        int pricePerNight = 115;

        public frmReservation()
        {
            InitializeComponent();
            txtArrival.Text = DateTime.Today.ToShortDateString();
            txtDeparture.Text = DateTime.Today.AddDays(numDefaultDaysFromStart).ToShortDateString();
        }

        private void lblArrival_Click(object sender, EventArgs e)
        {

        }

        private int calcNumDays(DateTime dateStart, DateTime dateEnd, int maxYears)
        {
            int yearStart = dateStart.Year;
            int yearEnd = dateEnd.Year;

            int dayStart = dateStart.Day;
            int dayEnd = dateEnd.Day;

            int numDays = 0;

            int years = yearEnd - yearStart;

            numDays = dayEnd - dayStart;
            numDays += years * 365;

            if (dayEnd <= dayStart)
            {
                years--;
            }

            if (years < maxYears)
            {
                return numDays;
            }

            return -1;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime dateArrival = formatDate(txtArrival.Text, 0);
            DateTime dateDeparture = formatDate(txtDeparture.Text, numDefaultDaysFromStart);

            txtArrival.Text = dateArrival.ToShortDateString();
            txtDeparture.Text = dateDeparture.ToShortDateString();

            int numDays = calcNumDays(dateArrival, dateDeparture, numDefaultYearsFromStart);
            if (numDays == -1)
            {
                MessageBox.Show("Departure date must be within 5 years of arrival date", "Change arrival date");
                txtDeparture.Text = DateTime.Today.AddDays(numDefaultDaysFromStart).ToShortDateString();
            }

            txtNumNights.Text = numDays.ToString();

            txtPricePerNight.Text = "$" + pricePerNight.ToString();

            txtTotal.Text = (numDays * pricePerNight).ToString();

        }

        private DateTime formatDate(string date, int days)
        {
            DateTime dateTime;
            DateTime defaultDate = DateTime.Today.AddDays(days);

            if (DateTime.TryParse(date, out dateTime))
            {
                if (dateTime < DateTime.Today)
                {
                    MessageBox.Show("Date must be the same or later than today", "Date before today");
                    return defaultDate;
                }
                return dateTime;
            }
            else
            {
                MessageBox.Show("Please format the date as given", "Format Error");
                return defaultDate;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
