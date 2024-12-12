using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EnergyConsumption
{
    public partial class apartmentSearchForm : Form
    {
        private SqlConnection cnn = new SqlConnection();
        private DataTable dt2 = new DataTable();
        private BindingSource bs = new BindingSource();

        public apartmentSearchForm()
        {
            InitializeComponent();
        }

        private void apartmentSearchForm_Load(object sender, EventArgs e)
        {
            try
            {
                cnn.ConnectionString = "Data Source = (local); Initial Catalog = EnergyConsumption; Integrated Security = true";
                cnn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT FlatRegistry.FlatID, HeatingEquipment.Type " +
                    "FROM FlatRegistry " +
                    "INNER JOIN BuildingRegistry ON BuildingRegistry.HouseID = FlatRegistry.HouseID " +
                    "INNER JOIN HeatingEquipment ON HeatingEquipment.HeatingSystemID = BuildingRegistry.HeatingSystemID " +
                    "ORDER BY FlatRegistry.FlatID", cnn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                int rowCount = da.Fill(dt2);

                
                if (rowCount > 0)
                {
                    bs.DataSource = dt2;
                    selectlistBox.DataSource = bs;
                    selectlistBox.DisplayMember = dt2.Columns[0].ColumnName; 
                    selectlistBox.ValueMember = dt2.Columns[1].ColumnName;   
                }
                else
                {
                    MessageBox.Show("Данные не найдены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close(); 
            }
        }

        
        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                
                if (selectlistBox.SelectedItem == null)
                {
                    MessageBox.Show("Выберите квартиру из списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SqlCommand cmd = new SqlCommand("searchFlat", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                
                DataRowView dr = (DataRowView)selectlistBox.SelectedItem;
                cmd.Parameters.Add("@search_Flat", SqlDbType.NVarChar).Value = dr.Row.ItemArray[0].ToString();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

            
                if (dt.Rows.Count > 0)
                {
                    
                    string heatingType = dt.Rows[0]["HeatingSystemType"].ToString().Trim(); 
                    string flatId = dr.Row.ItemArray[0].ToString();

                    label4.Text = $"HeatingType: {heatingType}  FlatID: {flatId}";
                    GridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Данные для выбранной квартиры не найдены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}



