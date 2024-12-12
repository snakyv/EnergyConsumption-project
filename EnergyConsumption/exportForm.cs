using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;

namespace EnergyConsumption
{
    public partial class exportForm : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        System.Data.DataTable dt = new System.Data.DataTable();

        public exportForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }
        private void InitializeDatabaseConnection()
        {
            cnn.ConnectionString = "Data Source=(local);Initial Catalog=EnergyConsumption;Integrated Security=True";
            cmd.Connection = cnn;
            da.SelectCommand = cmd;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Вправа 3 Завдання 1");
            comboBox1.Items.Add("Вправа 3 Завдання 2");
            comboBox1.Items.Add("Вправа 3 Завдання 3");
            comboBox1.Items.Add("Вправа 4 Завдання 1");
            comboBox1.Items.Add("Вправа 4 Завдання 2");
            comboBox1.Items.Add("Вправа 4 Завдання 3");
            comboBox1.Items.Add("Вправа 5 Завдання 1");
            comboBox1.Items.Add("Вправа 5 Завдання 2");
            comboBox1.Items.Add("Вправа 5 Завдання 3");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            dt.Columns.Clear();
            switch (comboBox1.Text)
            {
                case "Вправа 3 Завдання 1":
                    textBox1.Text = "Виведення адрес даних про будинки, що знаходяться в Малиновському районі.";
                    cmd.CommandText = "SELECT * FROM LocationAddresses WHERE District LIKE '%Малиновський%';";
                    break;
                case "Вправа 3 Завдання 2":
                    textBox1.Text = "Виведення усіх даних про будинки, збудовані після 2000 року.";
                    cmd.CommandText = "SELECT * FROM BuildingRegistry WHERE Year > 2000;";
                    break;
                case "Вправа 3 Завдання 3":
                    textBox1.Text = "Отримати дані про будинки в яких є ліфт.";
                    cmd.CommandText = "SELECT HouseID, Year, Material, EnergyRating FROM BuildingRegistry WHERE Elevator=1;";
                    break;
                case "Вправа 4 Завдання 1":
                    textBox1.Text = "Показати кількість даних квартир на кожному поверсі будинку.";
                    cmd.CommandText = "SELECT HouseID, Floor, COUNT(FlatID) AS NumberOfFlats FROM FlatRegistry GROUP BY HouseID, Floor ORDER BY HouseID;";
                    break;
                case "Вправа 4 Завдання 2":
                    textBox1.Text = "Вивести інформацію про кількість квартир за кількістю мешканців, які в ній проживають.";
                    cmd.CommandText = "SELECT Residents, COUNT(FlatID) AS NumberOfFlats FROM FlatRegistry WHERE Residents IS NOT NULL GROUP BY Residents ORDER BY Residents;";
                    break;
                case "Вправа 4 Завдання 3":
                    textBox1.Text = "Підрахувати загальні витрати на енергоресурси для кожної квартири.";
                    cmd.CommandText = "SELECT FlatID, Rooms, Area, Residents, TotalCost FROM FlatsTotalCostView;";
                    break;
                case "Вправа 5 Завдання 1":
                    textBox1.Text = "Додати до завдання 4.3 інформацію про тип системи опалення для кожної квартири.";
                    cmd.CommandText = "SELECT FlatID, Rooms, Area, Residents, TotalCost, HeatingSystemType FROM FlatsTotalCostView;";
                    break;
                case "Вправа 5 Завдання 2":
                    textBox1.Text = "Отримати список всіх будинків разом з даними про адресу та про систему отоплення.";
                    cmd.CommandText = "SELECT BuildingRegistry.HouseID, LocationAddresses.Address, LocationAddresses.District, HeatingEquipment.Type AS HeatingSystemType, BuildingRegistry.EnergyRating, BuildingRegistry.Year, BuildingRegistry.Material FROM BuildingRegistry INNER JOIN LocationAddresses ON BuildingRegistry.HouseID = LocationAddresses.HouseID INNER JOIN HeatingEquipment ON BuildingRegistry.HeatingSystemID = HeatingEquipment.HeatingSystemID;";
                    break;
                case "Вправа 5 Завдання 3":
                    textBox1.Text = "Вивести інформацію про квартири, де використовують центральну систему опалення.";
                    cmd.CommandText = "SELECT FlatID, Rooms, Area, Residents, HouseID, HeatingSystemType FROM CentralHeatingFlatsView;";
                    break;
                default:
                    break;
            }
            try
            {
                cnn.Open();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Вправа 5 Завдання 2")
            {
                MessageBox.Show("Оберіть <Вправу 5 Завдання 2>");
                return;
            }
            else
            {
                PrintToWord();
            }

        }
        private void PrintToWord()
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document doc = null;
            string pathToExe = Application.StartupPath;
            doc = app.Documents.Open(pathToExe + "\\sampleTask5_2.docx");
            doc.Activate();

            Microsoft.Office.Interop.Word.Words wrds = doc.Words;
            Microsoft.Office.Interop.Word.Range wRange;
            wRange = wrds[11];
            wRange.InsertAfter(DateTime.Today.Date.ToString("d"));
            Microsoft.Office.Interop.Word.Bookmarks wBookmarks = doc.Bookmarks;
            Microsoft.Office.Interop.Word.Bookmark mark;
            mark = wBookmarks["kod_House"];
            wRange = mark.Range;
            wRange.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            mark = wBookmarks["address_House"];
            wRange = mark.Range;
            wRange.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            mark = wBookmarks["kod1_House"];
            wRange = mark.Range;
            wRange.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            mark = wBookmarks["fillTable"];
            wRange = mark.Range;
            wRange.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            Microsoft.Office.Interop.Word.Table tab1 = doc.Tables[1];
            for (int i = 2; i < 6; ++i)
            {
                wRange = tab1.Cell(2, i).Range;
                wRange.Text = dataGridView1.CurrentRow.Cells[i + 1].Value.ToString();
            }

            app.Visible = true;
        }
    }
}

