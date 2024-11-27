
using System;
using Wisej.Web;

namespace AddressManager
{
    public partial class MainWindow : Form
    {
        OrganizationViewControl orgViewControl;
        OrganizationAddControl orgAddPopup;
        EmployeeViewControl empViewControl;
        EmployeeAddControl empAddPopup;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuOrganizationView_Click(object sender, EventArgs e)
        {
            // open the organization view control
            orgViewControl = new OrganizationViewControl();
            LoadControlIntoPanel(orgViewControl);
        }

        private void MenuOrganizationAdd_Click(object sender, EventArgs e)
        {
            // open the organization add control
            orgAddPopup = new OrganizationAddControl();
            orgAddPopup.OrganizationAdded += OrganizationAddControl_OrganizationAdded; // subscribe to the org added event and refresh the data grid
            LoadPopup(orgAddPopup);
        }

        private void OrganizationAddControl_OrganizationAdded(object sender, EventArgs e)
        {
            orgViewControl?.RefreshData();
        }

        private void MenuEmployeeView_Click(object sender, EventArgs e)
        {
            empViewControl = new EmployeeViewControl();
            LoadControlIntoPanel(empViewControl);
        }
        private void MenuEmployeeAdd_Click(object sender, EventArgs e)
        {
            empAddPopup = new EmployeeAddControl();
            empAddPopup.EmployeeAdded += EmployeeAddControl_EmployeeAdded; 
            LoadPopup(empAddPopup);
        }
        private void EmployeeAddControl_EmployeeAdded(object sender, EventArgs e)
        {
            empViewControl?.RefreshData(); 
        }

        private void LoadControlIntoPanel(UserControl control)
        {
            // clear the main panel
            panelMain.Controls.Clear();
            // put in the new UserControl
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }

        private void LoadPopup(UserControl control)
        {
            if (control is OrganizationAddControl)
                orgAddPopup.ShowPopup(panelMain);
            else if (control is EmployeeAddControl)
                empAddPopup.ShowPopup(panelMain);
        }
    }
}
