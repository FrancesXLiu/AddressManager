using System;
using Wisej.Web;
using AddressManager.Helpers;
using AddressManager.Models;

namespace AddressManager
{
    public partial class OrganizationViewControl : Wisej.Web.UserControl
    {
        private DatabaseHelper databaseHelper = new DatabaseHelper();
        private DataGridViewColumn editButtonColumn;
        private DataGridViewColumn deleteButtonColumn;

        private void LoadOrganizations()
        {
            var organizations = databaseHelper.GetOrganizations();
            DataGridOrgView.DataSource = organizations;
        }

        public OrganizationViewControl()
        {
            InitializeComponent();
            DataGridOrgView.Columns.Add(editButtonColumn);
            DataGridOrgView.Columns.Add(deleteButtonColumn);
            LoadOrganizations();
        }

        public void RefreshData()
        {
            LoadOrganizations();
        }

        private void DataGridOrgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedOrganization = (Organization)DataGridOrgView.Rows[e.RowIndex].DataBoundItem;

                if (DataGridOrgView.Columns[e.ColumnIndex] == editButtonColumn)
                {
                    EditOrganization(selectedOrganization);
                }
                else if (DataGridOrgView.Columns[e.ColumnIndex] == deleteButtonColumn)
                {
                    DeleteOrganization(selectedOrganization);
                }
            }
        }

        private void EditOrganization(Organization organization)
        {
            var editControl = new OrganizationAddControl
            {
                Organization = organization // pre-populate the fields
            };

            editControl.OrganizationAdded += (s, e) =>
            {
                // update the organization in the database and refresh the data
                databaseHelper.UpdateOrganization(organization);
                RefreshData();
            };

            editControl.ShowPopup(this);
        }

        private void DeleteOrganization(Organization organization)
        {
            if (MessageBox.Show($"Are you sure you want to delete the organization '{organization.Name}'?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                databaseHelper.DeleteOrganization(organization.Id);
                RefreshData();
            }
        }
    }
}
