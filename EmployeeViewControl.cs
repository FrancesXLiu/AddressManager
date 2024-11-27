using System;
using Wisej.Web;
using AddressManager.Helpers;
using AddressManager.Models;

namespace AddressManager
{
    public partial class EmployeeViewControl : Wisej.Web.UserControl
    {
        private DatabaseHelper databaseHelper = new DatabaseHelper();
        private DataGridViewColumn editButtonColumn;
        private DataGridViewColumn deleteButtonColumn;

        private void LoadEmployees()
        {
            var employees = databaseHelper.GetEmployees();
            DataGridEmployeeView.DataSource = employees;
        }

        public EmployeeViewControl()
        {
            InitializeComponent();
            DataGridEmployeeView.Columns.Add(editButtonColumn);
            DataGridEmployeeView.Columns.Add(deleteButtonColumn);
            LoadEmployees();
        }

        public void RefreshData()
        {
            LoadEmployees();
        }

        private void DataGridEmployeeView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedEmployee = (Employee)DataGridEmployeeView.Rows[e.RowIndex].DataBoundItem;

                if (DataGridEmployeeView.Columns[e.ColumnIndex] == editButtonColumn)
                {
                    EditEmployee(selectedEmployee);
                }
                else if (DataGridEmployeeView.Columns[e.ColumnIndex] == deleteButtonColumn)
                {
                    DeleteEmployee(selectedEmployee);
                }
            }
        }

        private void EditEmployee(Employee employee)
        {
            var editControl = new EmployeeAddControl
            {
                Employee = employee // Pre-fill fields for editing
            };

            editControl.EmployeeAdded += (s, e) =>
            {
                // Update the employee in the database and refresh the data
                databaseHelper.UpdateEmployee(employee);
                RefreshData();
            };

            editControl.ShowPopup(this);
        }

        private void DeleteEmployee(Employee employee)
        {
            if (MessageBox.Show($"Are you sure you want to delete the employee '{employee.FirstName} {employee.LastName}'?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                databaseHelper.DeleteEmployee(employee.Id);
                RefreshData();
            }
        }
    }
}
