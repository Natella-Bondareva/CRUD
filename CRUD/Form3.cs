using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form3 : Form
    {
        public string HairdresserFirstName { get; private set; }
        public string HairdresserLastName { get; private set; }
        public string HairdoDescription { get; private set; }
        public int CostOfServices { get; private set; }
        public bool IsNeedAdditionalServices { get; private set; }
        public ClientType ClientType { get; private set; }
        private bool isSaved = false;

        public Form3()
        {
            InitializeComponent();
            FillComboBox();
        }

        public Form3(Hairdo hairdo)
        {
            InitializeComponent();
            FillComboBox();

            FirstNameTextBox.Text = hairdo.Hairdresser.FirstName;
            LastNameTextBox.Text = hairdo.Hairdresser.LastName;
            ClientTypeComboBox.SelectedItem = hairdo.ClientType;
            CostOfServicesTextBox.Text = hairdo.CostOfServices.ToString();
            DescriptionTextBox.Text = hairdo.Description;

            AdditionalServicesComboBox.SelectedIndex = hairdo.IsNeedAdditionalServices ? 0 : 1;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            string hairdresserFirstName = FirstNameTextBox.Text;
            string hairdresserLastName = LastNameTextBox.Text;
            string hairdoDescription = DescriptionTextBox.Text;
            string costOfServicesText = CostOfServicesTextBox.Text;
            bool isNeedAdditionalServices = AdditionalServicesComboBox.SelectedIndex == 0 ? true : false;

            if (string.IsNullOrWhiteSpace(hairdresserFirstName) || string.IsNullOrWhiteSpace(hairdresserLastName) ||
                string.IsNullOrWhiteSpace(hairdoDescription) || string.IsNullOrWhiteSpace(costOfServicesText))
            {
                MessageBox.Show("Please fill all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(costOfServicesText, out int costOfServices) || costOfServices <= 0)
            {
                MessageBox.Show("Invalid cost of services. Please enter a valid non-negative number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            HairdresserFirstName = hairdresserFirstName;
            HairdresserLastName = hairdresserLastName;
            HairdoDescription = hairdoDescription;
            CostOfServices = costOfServices;
            IsNeedAdditionalServices = isNeedAdditionalServices;
            ClientType = (ClientType)ClientTypeComboBox.SelectedItem;

            isSaved = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FillComboBox()
        {
            ClientTypeComboBox.DataSource = Enum.GetValues(typeof(ClientType));
            AdditionalServicesComboBox.DataSource = new string[] { "Yes", "No" };
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                MessageBox.Show("Changes will not be saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

