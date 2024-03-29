﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class FinalizeHouse : Form
    {
        private ManageComboxLists comboxLists = new ManageComboxLists();
        private ValidationType validation = new ValidationType();
        private House house;
        public FinalizeHouse(House homes)
        {
            house = homes;
            InitializeComponent();
        }

        private void FinalizeHouse_Load(object sender, EventArgs e)
        {
            if (house.Keys != null)
            {
                SetInputs();
               
            }
            FillCombobox();
            LoadPets();
        }
       
            
        
        private void FillCombobox()
        {
            List<String> petTypes = comboxLists.GetPetTypes();
            AddListToBox(drpPetType, petTypes);
            
        }
        private void AddListToBox(ComboBox combobox, List<String> items)
        {

            combobox.Items.Add("None");
            foreach (String item in items)
            {
                combobox.Items.Add(item);

            }
        }
        private void LoadPets()
        {
            foreach (Pet pet in house.LeadTenant.Pets)
            {
                AddPetToTable(pet);
            }
        }
        private void AddPetToTable(Pet pet)
        {
            dataPets.Rows.Add(pet.petType, pet.petBreed, pet.petFee, pet.petFeePaid,pet.petRent, "EDIT", "Delete");
            var count = dataPets.RowCount - 1;
            dataPets.Rows[count].ReadOnly = true;
        }
        private void SetupHouse()
        {
            var dateval = validation.getValidationDateTime();
           if(house.Keys == null)
            {
                house.Keys = new Keys(0);
            }
            house.Keys.KeyNumberCurrent1 = txtCurrentKey.Text;
            house.Keys.KeyNumberCurrentDate1 = dateval.ConvertDatePickerDefault(dateCurrentKey);

            house.Keys.KeyNumberPrevious1 = textPrevKey.Text;
            house.Keys.KeyNumberPrevDate1 = dateval.ConvertDatePickerDefault(datePrevKey);
            house.Miscellaneous1 = textMiscellaneous.Text;
        }
        private void SetInputs()
        {
            var dateval = validation.getValidationDateTime();
            txtCurrentKey.Text = house.Keys.KeyNumberCurrent1;
            if (dateval.fieldHasValue(house.Keys.KeyNumberCurrentDate1) == false)
            {
                dateCurrentKey.Value = house.Keys.KeyNumberCurrentDate1;
            }

            textPrevKey.Text = house.Keys.KeyNumberPrevious1;
            if (dateval.fieldHasValue(house.Keys.KeyNumberPrevDate1) == false)
            {
                datePrevKey.Value = house.Keys.KeyNumberPrevDate1;
            }
        }
        private void clearPetInputs()
        {
            drpPetType.SelectedIndex = -1;
            textPetBread.Text = "";
            textPetRent.Text = "";
            textPetFee.Text = "";
            checkPetFee.Checked = false;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            SetupHouse();
            TenantInfo tenantInfo = new TenantInfo(house);
            Hide();
            tenantInfo.ShowDialog();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            SetupHouse();
            if (house.HouseID1 == 0)
            {
               
                CreateHouse createHouse = new CreateHouse();
                createHouse.CreateNewHouse(house);
                
            }
            else
            {
                UpdateHouse updateHouse = new UpdateHouse();
                updateHouse.generatUpdatedHouse(house);
            }
            Hide();
           Menu mainMenu = new Menu();
           mainMenu.ShowDialog();
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            var intval = validation.getValidationInt();
            house.LeadTenant.Pets.Add(new Pet(0, drpPetType.SelectedIndex, drpPetType.SelectedItem.ToString(), textPetBread.Text,
                intval.convertStringToDecimal(textPetFee.Text),
                intval.convertStringToDecimal(textPetRent.Text),  checkPetFee.Checked
                ));
            var entry = house.LeadTenant.Pets.Count-1;
            AddPetToTable(house.LeadTenant.Pets[entry]);
            clearPetInputs();
        }

        private void dataPets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = e.ColumnIndex;
            var row = e.RowIndex;
            var cell = dataPets.CurrentCell.Value;
            if (column == 6)
            {
                if (cell.ToString() == "Edit")
                {
                    Console.WriteLine(row);
                    dataPets.CurrentCell.Value = "Done";
                    dataPets.Rows[row].ReadOnly = false;
                }
                else if (cell.ToString() == "Done")
                {
                    dataPets.CurrentCell.Value = "Edit";
                    dataPets.Rows[row].ReadOnly = true;
                }
            }
            else if (column == 7)
            {
                dataPets.Rows.RemoveAt(row);

            }
        }
        private void numericKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // inputs are strip to prevent the database from being circumnaviated
            }
        }

        private void letterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;// inputs are strip to prevent the database from being circumnaviated
            }
        }

        private void txtCurrentKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // inputs are strip to prevent the database from being circumnaviated
            }
        }

        private void textMiscellaneous_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar)&& (e.KeyChar != '.') && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;// inputs are strip to prevent the database from being circumnaviated
            }
        }
    }
}
