using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnergyConsumption
{
    public partial class MainForm : Form
    {
        private bool childFormOpen = false; 

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void apartmentRegisterButton_Click(object sender, EventArgs e)
        {
            
            if (childFormOpen)
            {
                MessageBox.Show("Дочерняя форма уже открыта.");
                return;
            }

            apartmentRegisterForm myApartmentRegisterForm = new apartmentRegisterForm();
            myApartmentRegisterForm.FormClosed += ChildForm_FormClosed;
            myApartmentRegisterForm.Show();
            this.Enabled = false;
            childFormOpen = true; 
        }

        private void apartmentSearchButton_Click(object sender, EventArgs e)
        {
            
            if (childFormOpen)
            {
                MessageBox.Show("Дочерняя форма уже открыта.");
                return;
            }

            apartmentSearchForm myApartmentSearchForm = new apartmentSearchForm();
            myApartmentSearchForm.FormClosed += ChildForm_FormClosed;
            myApartmentSearchForm.Show();
            this.Enabled = false;
            childFormOpen = true; 
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            
            if (childFormOpen)
            {
                MessageBox.Show("Дочерняя форма уже открыта.");
                return;
            }

            exportForm myExportForm = new exportForm();
            myExportForm.FormClosed += ChildForm_FormClosed;
            myExportForm.Show();
            this.Enabled = false;
            childFormOpen = true; 
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            this.Enabled = true;
            childFormOpen = false;
        }
    }
}

