using System;
using Wisej.Web;
using AddressManager.Helpers;
using AddressManager.Models;

namespace AddressManager
{
    public partial class EmployeeAddControl : Wisej.Web.UserPopup
    {
        private Employee _employee;
        public Employee Employee
        {
            get => _employee;
            set
            {
                _employee = value;
                if (_employee != null)
                {
                    PopulateFields(_employee);
                }
            }
        }

        public EmployeeAddControl()
        {
            InitializeComponent();
            this.Alignment = Placement.TopCenter;
            LoadOrganizations();
        }
        private void LoadOrganizations()
        {
            var dbHelper = new DatabaseHelper();
            var organizations = dbHelper.GetOrganizations();

            empOrgCB.DataSource = organizations;
            empOrgCB.DisplayMember = "Name";
            empOrgCB.ValueMember = "Id";
        }

        public event EventHandler EmployeeAdded;

        private void PopulateFields(Employee employee)
        {
            empOrgCB.SelectedValue = employee.OrganizationId;
            empAddTitleTB.Text = employee.Title;
            empAddFirstNameTB.Text = employee.FirstName;
            empAddLastNameTB.Text = employee.LastName;
            empAddPhoneTB.Text = employee.Phone;
            empAddEmailTB.Text = employee.Email;
        }

        private void empAddSaveBtn_Click(object sender, EventArgs e)
        {
            if (_employee == null)
            {
                _employee = new Employee();
            }

            var selectedOrgId = (int)empOrgCB.SelectedValue;


            // Populate employee data
            _employee.OrganizationId = selectedOrgId;
            _employee.Title = empAddTitleTB.Text;
            _employee.FirstName = empAddFirstNameTB.Text;
            _employee.LastName = empAddLastNameTB.Text;
            _employee.Phone = empAddPhoneTB.Text;
            _employee.Email = empAddEmailTB.Text;

            var dbHelper = new DatabaseHelper();

            if (_employee.Id == 0)
            {
                // Add a new employee
                dbHelper.AddEmployee(_employee);
                MessageBox.Show("Employee added.");
            }
            else
            {
                // Update an existing employee
                dbHelper.UpdateEmployee(_employee);
                MessageBox.Show("Employee updated.");
            }

            // Trigger event to notify the parent control
            EmployeeAdded?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
