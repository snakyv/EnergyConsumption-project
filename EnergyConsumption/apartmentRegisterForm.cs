using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnergyConsumption
{
    public partial class apartmentRegisterForm : Form
    {
        private SqlConnection cnn;
        String[] s = {"Rooms", "Area", "Residents", "Electricity", "ElectricityCost",
                          "Water", "WaterCost", "Gas", "GasCost", "Heating",
                          "HeatingCost","HeatingSystemType"};
        Boolean editText = false;

        public apartmentRegisterForm()
        {
            InitializeComponent();
        }

        private void apartmentRegisterForm_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection();
            cnn.ConnectionString = "Data Source=(local); Initial Catalog = EnergyConsumption; Integrated Security=True";
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control == WaterCost || control == GasCost || control == ElectricityCost || control == Heating || control == HeatingCost)
                    {
                        ((TextBox)control).KeyPress += TextBox_KeyPress;
                    }
                    else
                    {
                        ((TextBox)control).KeyPress += TextBox_KeyPressValidation;
                    }
                }
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("takeFlatID", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Flat", SqlDbType.VarChar).Value = textBox1.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listBox1.DataSource = dt;
            listBox1.DisplayMember = dt.Columns[0].ColumnName;
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("searchFlat", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataRowView dr = (DataRowView)listBox1.SelectedItem;
            cmd.Parameters.Add("@search_Flat", SqlDbType.VarChar).Value =
                dr.Row.ItemArray[0].ToString();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da1.Fill(dt);
            FlatText.Text = "Flat " + dr.Row.ItemArray[0].ToString();
            fillComboBox();
            comboBoxHouseID.Text = dt.Rows[0].ItemArray[1].ToString().Trim();
            comboBoxFloor.Text = dt.Rows[0].ItemArray[2].ToString().Trim();

            for (int i = 3; i < 15; i++)
            {
                TextBox textBox = this.Controls.Find(s[i - 3], true).FirstOrDefault() as TextBox;
                textBox.Text = dt.Rows[0].ItemArray[i].ToString();
            }
            editButton.Enabled = true;
        }

        private void updateData()
        {
            SqlCommand cmd = new SqlCommand("takeFlatID", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Flat", SqlDbType.VarChar).Value = textBox1.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listBox1.DataSource = dt;
            listBox1.DisplayMember = dt.Columns[0].ColumnName;

            SqlCommand cmd1 = new SqlCommand("searchFlat", cnn);
            cmd1.CommandType = CommandType.StoredProcedure;
            DataRowView dr = (DataRowView)listBox1.SelectedItem;
            cmd1.Parameters.Add("@search_Flat", SqlDbType.VarChar).Value =
                dr.Row.ItemArray[0].ToString();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            FlatText.Text = "Flat " + dr.Row.ItemArray[0].ToString();
            fillComboBox();
            comboBoxHouseID.Text = dt1.Rows[0].ItemArray[1].ToString().Trim();
            comboBoxFloor.Text = dt1.Rows[0].ItemArray[2].ToString().Trim();

            for (int i = 3; i < 15; i++)
            {
                TextBox textBox = this.Controls.Find(s[i - 3], true).FirstOrDefault() as TextBox;
                textBox.Text = dt.Rows[0].ItemArray[i].ToString();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            buttonsEdit(true);
            editButton.Hide();
            changeDataButton.Show();
            newDataButton.Show();
            deleteDataButton.Show();
            editText = true;
        }

        private void buttonsEdit(bool condition)
        {
            comboBoxHouseID.Enabled = condition;
            comboBoxFloor.Enabled = condition;
            for (int i = 3; i < 14; i++)
            {
                TextBox textBox = this.Controls.Find(s[i - 3], true).FirstOrDefault() as TextBox;
                textBox.Enabled = condition;
            }
        }

        private void fillComboBox()
        {
            SqlCommand cmdHouseID = new SqlCommand("SELECT DISTINCT HouseID FROM BuildingRegistry", cnn);
            SqlDataAdapter daHouseID = new SqlDataAdapter(cmdHouseID);
            DataTable dtHouseID = new DataTable();
            daHouseID.Fill(dtHouseID);
            foreach (DataRow row in dtHouseID.Rows)
            {
                row["HouseID"] = row["HouseID"].ToString().Trim();
            }

            comboBoxHouseID.DataSource = dtHouseID;
            comboBoxHouseID.DisplayMember = "HouseID";
        }

        private void comboBoxHouseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedHouseID = comboBoxHouseID.SelectedItem?.ToString();
            string type;
            using (SqlConnection connection = new SqlConnection("Data Source=(local); Initial Catalog = EnergyConsumption; Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand selectHeatingType = new SqlCommand("select Type from HeatingEquipment where HeatingEquipment.HeatingSystemID = (select HeatingSystemID from BuildingRegistry Where HouseID=@HouseID)", connection))
                {
                    selectHeatingType.Parameters.AddWithValue("@HouseID", comboBoxHouseID.Text);
                    type = Convert.ToString(selectHeatingType.ExecuteScalar());
                }
            }
            HeatingSystemType.Text = type;
            if (type.Trim() == "Печі та каміни")
            {
                Heating.Text = "0";
                HeatingCost.Text = "0";
            }
            else if (type.Trim() == "Сонячні системи опалення")
            {
                Gas.Text = "0";
                GasCost.Text = "0";
            }
        }

        private void newDataButton_Click(object sender, EventArgs e)
        {
            newDataButton.Hide();
            deleteDataButton.Hide();
            changeDataButton.Hide();
            confirmDataButton.Show();
            textBox1.Enabled = false;
            listBox1.Enabled = false;
            FlatText.Text = "New Flat";
            comboBoxHouseID.Text = "";
            comboBoxFloor.Text = "";
            for (int i = 3; i < 14; i++)
            {
                TextBox textBox = this.Controls.Find(s[i - 3], true).FirstOrDefault() as TextBox;
                textBox.Text = "";
            }
        }

        private void confirmDataButton_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int flatId;
                using (SqlConnection connection = new SqlConnection("Data Source=(local); Initial Catalog = EnergyConsumption; Integrated Security=True"))
                {
                    connection.Open();

                    using (SqlCommand insertIntoFlats = new SqlCommand("INSERT INTO FlatRegistry ( HouseID, Floor, Rooms, Area, Residents) OUTPUT INSERTED.FlatID VALUES (@HouseID, @Floor, @Rooms, @Area, @Residents);", connection))
                    {
                        insertIntoFlats.Parameters.AddWithValue("@HouseID", comboBoxHouseID.Text.Trim());
                        insertIntoFlats.Parameters.AddWithValue("@Floor", Convert.ToInt32(comboBoxFloor.Text));
                        insertIntoFlats.Parameters.AddWithValue("@Rooms", Convert.ToInt32(Rooms.Text));
                        insertIntoFlats.Parameters.AddWithValue("@Area", Convert.ToInt32(Area.Text));
                        insertIntoFlats.Parameters.AddWithValue("@Residents", Convert.ToInt32(Residents.Text));
                        flatId = Convert.ToInt32(insertIntoFlats.ExecuteScalar());
                    }

                    int electricityUsageId;
                    using (SqlCommand insertIntoElectricityUsage = new SqlCommand("INSERT INTO ElectricityConsumption (Electricity, ElectricityCost) OUTPUT INSERTED.UsageID VALUES (@Electricity, @ElectricityCost);", connection))
                    {
                        insertIntoElectricityUsage.Parameters.AddWithValue("@Electricity", Convert.ToInt32(Electricity.Text));
                        insertIntoElectricityUsage.Parameters.AddWithValue("@ElectricityCost", Convert.ToDouble(ElectricityCost.Text));
                        electricityUsageId = Convert.ToInt32(insertIntoElectricityUsage.ExecuteScalar());
                    }

                    int waterUsageid;
                    using (SqlCommand insertIntoWaterUsage = new SqlCommand("INSERT INTO WaterConsumption (Water, WaterCost) OUTPUT INSERTED.UsageID VALUES (@Water, @WaterCost);", connection))
                    {
                        insertIntoWaterUsage.Parameters.AddWithValue("@Water", Convert.ToInt32(Water.Text));
                        insertIntoWaterUsage.Parameters.AddWithValue("@WaterCost", Convert.ToDouble(WaterCost.Text));
                        waterUsageid = Convert.ToInt32(insertIntoWaterUsage.ExecuteScalar());
                    }

                    int heatingUsageid;
                    using (SqlCommand insertIntoHeatingUsage = new SqlCommand("INSERT INTO HeatingConsumption (Heating, HeatingCost) OUTPUT INSERTED.UsageID VALUES (@Heating, @HeatingCost);", connection))
                    {
                        insertIntoHeatingUsage.Parameters.AddWithValue("@Heating", Convert.ToDouble(Heating.Text));
                        insertIntoHeatingUsage.Parameters.AddWithValue("@HeatingCost", Convert.ToDouble(HeatingCost.Text));
                        heatingUsageid = Convert.ToInt32(insertIntoHeatingUsage.ExecuteScalar());
                    }

                    int gasUsageid;
                    using (SqlCommand insertIntoGasUsage = new SqlCommand("INSERT INTO GasConsumption (Gas, GasCost) OUTPUT INSERTED.UsageID VALUES (@Gas, @GasCost);", connection))
                    {
                        insertIntoGasUsage.Parameters.AddWithValue("@Gas", Convert.ToInt32(Gas.Text));
                        insertIntoGasUsage.Parameters.AddWithValue("@GasCost", Convert.ToDouble(GasCost.Text));
                        gasUsageid = Convert.ToInt32(insertIntoGasUsage.ExecuteScalar());
                    }

                    using (SqlCommand insertIntoResourceUsage = new SqlCommand("INSERT INTO ResourceExpenses (FlatID, ElectricityUsageID, WaterUsageID, HeatingUsageID, GasUsageID, LastUpdate) VALUES (@FlatID, @ElectricityUsageID, @WaterUsageID, @HeatingUsageID, @GasUsageID, GETDATE());", connection))
                    {
                        insertIntoResourceUsage.Parameters.AddWithValue("@FlatID", flatId);
                        insertIntoResourceUsage.Parameters.AddWithValue("@ElectricityUsageID", electricityUsageId);
                        insertIntoResourceUsage.Parameters.AddWithValue("@WaterUsageID", waterUsageid);
                        insertIntoResourceUsage.Parameters.AddWithValue("@HeatingUsageID", heatingUsageid);
                        insertIntoResourceUsage.Parameters.AddWithValue("@GasUsageID", gasUsageid);
                        insertIntoResourceUsage.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("A new flat has been created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FlatText.Text = "Flat " + flatId;
                textBox1.Text = Convert.ToString(flatId);
                textBox1.Enabled = true;
                listBox1.Enabled = true;
                newDataButton.Show();
                deleteDataButton.Show();
                changeDataButton.Show();
                confirmDataButton.Hide();
            }
        }

        private bool isEmpty()
        {
            return (string.IsNullOrWhiteSpace(comboBoxHouseID.Text) ||
                string.IsNullOrWhiteSpace(comboBoxFloor.Text) ||
                string.IsNullOrWhiteSpace(Rooms.Text) ||
                string.IsNullOrWhiteSpace(Area.Text) ||
                string.IsNullOrWhiteSpace(Electricity.Text) ||
                string.IsNullOrWhiteSpace(ElectricityCost.Text) ||
                string.IsNullOrWhiteSpace(Water.Text) ||
                string.IsNullOrWhiteSpace(WaterCost.Text) ||
                string.IsNullOrWhiteSpace(Heating.Text) ||
                string.IsNullOrWhiteSpace(HeatingCost.Text) ||
                string.IsNullOrWhiteSpace(Gas.Text) ||
                string.IsNullOrWhiteSpace(GasCost.Text));
        }

        private void changeDataButton_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataRowView dr = (DataRowView)listBox1.SelectedItem;
                int flatID = Convert.ToInt32(dr.Row.ItemArray[0]);

                // Проверяем и конвертируем значения из полей
                if (!int.TryParse(comboBoxFloor.Text, out int floor))
                {
                    MessageBox.Show("Please enter a valid number for the floor.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(Rooms.Text, out int rooms))
                {
                    MessageBox.Show("Please enter a valid number for rooms.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(Area.Text, out int area))
                {
                    MessageBox.Show("Please enter a valid number for area.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(Residents.Text, out int residents))
                {
                    MessageBox.Show("Please enter a valid number for residents.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(Water.Text, out int water))
                {
                    MessageBox.Show("Please enter a valid number for water usage.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(WaterCost.Text, out double waterCost))
                {
                    MessageBox.Show("Please enter a valid number for water cost.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(Gas.Text, out int gas))
                {
                    MessageBox.Show("Please enter a valid number for gas usage.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(GasCost.Text, out double gasCost))
                {
                    MessageBox.Show("Please enter a valid number for gas cost.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(Heating.Text, out double heating))
                {
                    MessageBox.Show("Please enter a valid number for heating usage.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(HeatingCost.Text, out double heatingCost))
                {
                    MessageBox.Show("Please enter a valid number for heating cost.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(Electricity.Text, out int electricity))
                {
                    MessageBox.Show("Please enter a valid number for electricity usage.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(ElectricityCost.Text, out double electricityCost))
                {
                    MessageBox.Show("Please enter a valid number for electricity cost.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = new SqlConnection("Data Source=(local); Initial Catalog = EnergyConsumption; Integrated Security=True"))
                {
                    connection.Open();


                    using (SqlCommand updateFlatsCmd = new SqlCommand("UPDATE FlatRegistry SET HouseID = @HouseID, Floor = @Floor, Rooms = @Rooms, Area = @Area, Residents = @Residents WHERE FlatID = @FlatID", connection))
                    {
                        updateFlatsCmd.Parameters.AddWithValue("@FlatID", flatID);
                        updateFlatsCmd.Parameters.AddWithValue("@HouseID", comboBoxHouseID.Text.Trim());
                        updateFlatsCmd.Parameters.AddWithValue("@Floor", floor);
                        updateFlatsCmd.Parameters.AddWithValue("@Rooms", rooms);
                        updateFlatsCmd.Parameters.AddWithValue("@Area", area);
                        updateFlatsCmd.Parameters.AddWithValue("@Residents", residents);

                        updateFlatsCmd.ExecuteNonQuery();
                    }


                    using (SqlCommand updateWaterUsageCmd = new SqlCommand("UPDATE WaterConsumption SET Water = @Water, WaterCost = @WaterCost WHERE UsageID = (SELECT WaterUsageID FROM ResourceExpenses WHERE FlatID = @FlatID)", connection))
                    {
                        updateWaterUsageCmd.Parameters.AddWithValue("@FlatID", flatID);
                        updateWaterUsageCmd.Parameters.AddWithValue("@Water", water);
                        updateWaterUsageCmd.Parameters.AddWithValue("@WaterCost", waterCost);

                        updateWaterUsageCmd.ExecuteNonQuery();
                    }



                    using (SqlCommand updateGasUsageCmd = new SqlCommand("UPDATE GasConsumption SET Gas = @Gas, GasCost = @GasCost WHERE UsageID = (SELECT GasUsageID FROM ResourceExpenses WHERE FlatID = @FlatID)", connection))
                    {
                        updateGasUsageCmd.Parameters.AddWithValue("@FlatID", flatID);
                        updateGasUsageCmd.Parameters.AddWithValue("@Gas", gas);
                        updateGasUsageCmd.Parameters.AddWithValue("@GasCost", gasCost);

                        updateGasUsageCmd.ExecuteNonQuery();
                    }


                    using (SqlCommand updateHeatingUsageCmd = new SqlCommand("UPDATE HeatingConsumption SET Heating = @Heating, HeatingCost = @HeatingCost WHERE UsageID = (SELECT HeatingUsageID FROM ResourceExpenses WHERE FlatID = @FlatID)", connection))
                    {
                        updateHeatingUsageCmd.Parameters.AddWithValue("@FlatID", flatID);
                        updateHeatingUsageCmd.Parameters.AddWithValue("@Heating", heating);
                        updateHeatingUsageCmd.Parameters.AddWithValue("@HeatingCost", heatingCost);

                        updateHeatingUsageCmd.ExecuteNonQuery();
                    }


                    using (SqlCommand updateElectricityUsageCmd = new SqlCommand("UPDATE ElectricityConsumption SET Electricity = @Electricity, ElectricityCost = @ElectricityCost WHERE UsageID = (SELECT ElectricityUsageID FROM ResourceExpenses WHERE FlatID = @FlatID)", connection))
                    {
                        updateElectricityUsageCmd.Parameters.AddWithValue("@FlatID", flatID);
                        updateElectricityUsageCmd.Parameters.AddWithValue("@Electricity", electricity);
                        updateElectricityUsageCmd.Parameters.AddWithValue("@ElectricityCost", electricityCost);

                        updateElectricityUsageCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data changed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void deleteDataButton_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Fill in all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Do you want to delete " + FlatText.Text + "?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataRowView dr = (DataRowView)listBox1.SelectedItem;
                    int flatID = Convert.ToInt32(dr.Row.ItemArray[0]);

                    using (SqlConnection connection = new SqlConnection("Data Source=(local); Initial Catalog = EnergyConsumption; Integrated Security=True"))
                    {
                        connection.Open();


                        int expensesid;
                        using (SqlCommand SelectExpensesCmd = new SqlCommand("SELECT ExpenseID FROM ResourceExpenses WHERE FlatID = @FlatID", connection))
                        {
                            SelectExpensesCmd.Parameters.AddWithValue("@FlatID", flatID);
                            expensesid = Convert.ToInt32(SelectExpensesCmd.ExecuteScalar());
                        }


                        using (SqlCommand deleteExpensesCmd = new SqlCommand("DELETE FROM ResourceExpenses WHERE FlatID = @FlatID", connection))
                        {
                            deleteExpensesCmd.Parameters.AddWithValue("@FlatID", flatID);
                            deleteExpensesCmd.ExecuteNonQuery();
                        }


                        using (SqlCommand deleteFlatsCmd = new SqlCommand("DELETE FROM FlatRegistry WHERE FlatID = @FlatID", connection))
                        {
                            deleteFlatsCmd.Parameters.AddWithValue("@FlatID", flatID);
                            deleteFlatsCmd.ExecuteNonQuery();
                        }


                        using (SqlCommand deleteElectricityUsageCmd = new SqlCommand("DELETE FROM ElectricityConsumption WHERE UsageID = @ExpenseID", connection))
                        {
                            deleteElectricityUsageCmd.Parameters.AddWithValue("@ExpenseID", expensesid);
                            deleteElectricityUsageCmd.ExecuteNonQuery();
                        }

                        using (SqlCommand deleteWaterUsageCmd = new SqlCommand("DELETE FROM WaterConsumption WHERE UsageID = @ExpenseID", connection))
                        {
                            deleteWaterUsageCmd.Parameters.AddWithValue("@ExpenseID", expensesid);
                            deleteWaterUsageCmd.ExecuteNonQuery();
                        }

                        using (SqlCommand deleteGasUsageCmd = new SqlCommand("DELETE FROM GasConsumption WHERE UsageID = @ExpenseID", connection))
                        {
                            deleteGasUsageCmd.Parameters.AddWithValue("@ExpenseID", expensesid);
                            deleteGasUsageCmd.ExecuteNonQuery();
                        }

                        using (SqlCommand deleteHeatingUsageCmd = new SqlCommand("DELETE FROM HeatingConsumption WHERE UsageID = @ExpenseID", connection))
                        {
                            deleteHeatingUsageCmd.Parameters.AddWithValue("@ExpenseID", expensesid);
                            deleteHeatingUsageCmd.ExecuteNonQuery();
                        }



                        using (SqlCommand deleteHeatingEquipmentCmd = new SqlCommand("DELETE FROM HeatingEquipment WHERE HeatingSystemID = (SELECT HeatingSystemID FROM BuildingRegistry WHERE HouseID = (SELECT HouseID FROM FlatRegistry WHERE FlatID = @FlatID))", connection))
                        {
                            deleteHeatingEquipmentCmd.Parameters.AddWithValue("@FlatID", flatID);
                            deleteHeatingEquipmentCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Flat deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = "1";
                        updateData();
                    }
                }
            }
        }


        private void comboBoxHouseID_TextChanged(object sender, EventArgs e)
        {

            int numberOfFloor = 0;
            using (SqlConnection connection = new SqlConnection("Data Source=(local); Initial Catalog = EnergyConsumption; Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand cmdHouseID = new SqlCommand("SELECT Floors FROM BuildingRegistry WHERE HouseID = @HouseID", connection))
                {
                    cmdHouseID.Parameters.AddWithValue("@HouseID", comboBoxHouseID.Text);
                    numberOfFloor = Convert.ToInt32(cmdHouseID.ExecuteScalar());

                }
            }
            comboBoxFloor.Items.Clear();
            for (int i = 1; i <= numberOfFloor; i++)
            {
                comboBoxFloor.Items.Add(i);

            }
        }

        private void Electricity_TextChanged(object sender, EventArgs e)
        {
            if (editText)
            {
                double Rate = 2.64;
                if (double.TryParse(Electricity.Text, out double electricityValue))
                {
                    double result = electricityValue * Rate;
                    ElectricityCost.Text = result.ToString();
                }
            }
        }

        private void Water_TextChanged(object sender, EventArgs e)
        {
            if (editText)
            {
                double Rate = 41.136;
                if (double.TryParse(Water.Text, out double waterValue))
                {
                    double result = waterValue * Rate;
                    WaterCost.Text = result.ToString();
                }
            }
        }

        private void Gas_TextChanged(object sender, EventArgs e)
        {
            if (editText)
            {
                double Rate = 7.99;
                if (double.TryParse(Gas.Text, out double gasValue))
                {
                    double result = gasValue * Rate;
                    GasCost.Text = result.ToString();
                }
            }
        }

        private void Heating_TextChanged(object sender, EventArgs e)
        {
            if (editText)
            {
                double Rate = 1813.94;
                if (double.TryParse(Heating.Text, out double heatingValue))
                {
                    double result = heatingValue * Rate;
                    HeatingCost.Text = result.ToString();
                }
            }
        }


        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && (((TextBox)sender).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
        private void TextBox_KeyPressValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}