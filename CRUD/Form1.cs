using ClassLibrary;
using Newtonsoft.Json;

namespace CRUD
{
    public partial class Form1 : Form
    {
        private List<Barbershop> barbershops;
        private const string jsonFilePath = "barbershops.json";
        private bool dataModified = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddElem_Button_Click(object sender, EventArgs e)
        {
            Form2 editForm = new Form2();
            editForm.ShowDialog();

            Barbershop modified = editForm.editedBarbershop;
            barbershops.Add(modified);
            ShowBarbershops();
            dataModified = true;
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (BarbershopsListBox.SelectedIndex >= 0)
            {
                int selectedIndex = BarbershopsListBox.SelectedIndex;
                barbershops.RemoveAt(selectedIndex);
                ShowBarbershops();
                dataModified = true;
            }
            else
            {
                MessageBox.Show("No barbershop selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            if (BarbershopsListBox.SelectedIndex >= 0)
            {
                int selectedIndex = BarbershopsListBox.SelectedIndex;
                Barbershop selectedOrder = barbershops[selectedIndex];

                Form2 editForm = new Form2(selectedOrder);
                editForm.ShowDialog();

                barbershops[selectedIndex] = editForm.editedBarbershop;
                ShowBarbershops();
                dataModified = true;

            }
            else
            {
                MessageBox.Show("No barbershop selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void Import_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    string json = File.ReadAllText(filePath).Trim();
                    if (json.Length == 0 || json == "[]")
                    {
                        MessageBox.Show("Error: The file is empty or contains only [].", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    List<Barbershop> importedBarbershops = JsonConvert.DeserializeObject<List<Barbershop>>(json);

                    if (importedBarbershops != null)
                    {
                        barbershops = importedBarbershops;

                        ShowBarbershops();
                        dataModified = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Data imported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataModified)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes before exiting?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:
                        SaveToFile();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void SaveToFile()
        {
            try
            {
                string json = JsonConvert.SerializeObject(barbershops, Formatting.Indented);
                File.WriteAllText(jsonFilePath, json);
                dataModified = false;
                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not write file to disk: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFromJson();
            ShowBarbershops();
        }

        private void LoadFromJson()
        {
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                barbershops = JsonConvert.DeserializeObject<List<Barbershop>>(json);
            }
            else
            {
                barbershops = new List<Barbershop>();
            }
        }

        private void ShowBarbershops()
        {
            BarbershopsListBox.Items.Clear();

            foreach (Barbershop barbershop in barbershops)
            {
                BarbershopsListBox.Items.Add(barbershop.ToShortString());
            }
        }
    }
}
