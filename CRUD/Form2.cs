using ClassLibrary;
using Newtonsoft.Json;
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
    public partial class Form2 : Form
    {
        public Barbershop editedBarbershop;
        private bool dataModified = false;

        public Form2(Barbershop barbershop)
        {
            InitializeComponent();
            editedBarbershop = barbershop;

            IDTextBox.Text = editedBarbershop.BarbershopNumber.ToString();
            dateTimePicker.Value = editedBarbershop.CurrentDate;

            foreach (Hairdo hairdo in editedBarbershop.CompletedHairstyles)
            {
                HairdosListBox.Items.Add(hairdo.ToString());
            }
        }

        public Form2()
        {
            InitializeComponent();
            editedBarbershop = new Barbershop(9999, DateTime.Now);

            IDTextBox.Text = "";
            dateTimePicker.Value = editedBarbershop.CurrentDate;

            foreach (Hairdo hairdo in editedBarbershop.CompletedHairstyles)
            {
                HairdosListBox.Items.Add(hairdo.ToString());
            }
        }

        private void AddElem_Button_Click(object sender, EventArgs e)
        {
            Form3 addHairdoForm = new Form3();

            if (addHairdoForm.ShowDialog() == DialogResult.OK)
            {
                Hairdo newHairdo = new Hairdo(
                addHairdoForm.HairdoDescription,
                addHairdoForm.ClientType,
                new Hairdresser(addHairdoForm.HairdresserFirstName, addHairdoForm.HairdresserLastName),
                addHairdoForm.CostOfServices,
                addHairdoForm.IsNeedAdditionalServices
                );

                editedBarbershop.CompletedHairstyles.Add(newHairdo);
                HairdosListBox.Items.Add(newHairdo.ToString());
                dataModified = true;
            }
        }

        private void ShowHairdos()
        {
            HairdosListBox.Items.Clear();

            foreach (Hairdo hairdo in editedBarbershop.CompletedHairstyles)
            {
                HairdosListBox.Items.Add(hairdo.ToString());
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (HairdosListBox.SelectedIndex >= 0)
            {
                int selectedIndex = HairdosListBox.SelectedIndex;
                editedBarbershop.CompletedHairstyles.RemoveAt(selectedIndex);
                ShowHairdos();
                dataModified = true;
            }
            else
            {
                MessageBox.Show("No hairdo selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            if (HairdosListBox.SelectedItems.Count == 1)
            {
                int selectedIndex = HairdosListBox.SelectedIndex;
                Hairdo selectedHairdo = editedBarbershop.CompletedHairstyles[selectedIndex];

                Form3 editHairdoForm = new Form3(selectedHairdo);

                if (editHairdoForm.ShowDialog() == DialogResult.OK)
                {
                    selectedHairdo.Hairdresser.FirstName = editHairdoForm.HairdresserFirstName;
                    selectedHairdo.Hairdresser.LastName = editHairdoForm.HairdresserLastName;
                    selectedHairdo.Description = editHairdoForm.HairdoDescription;
                    selectedHairdo.CostOfServices = editHairdoForm.CostOfServices;
                    selectedHairdo.IsNeedAdditionalServices = editHairdoForm.IsNeedAdditionalServices;
                    selectedHairdo.ClientType = editHairdoForm.ClientType;
                    ShowHairdos();
                    dataModified = true;
                }
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataModified)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes before exiting?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:
                        Save();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void Save()
        {
            try
            {
                editedBarbershop.BarbershopNumber = Convert.ToInt32(IDTextBox.Text.Trim());
                editedBarbershop.CurrentDate = dateTimePicker.Value;
                dataModified = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
