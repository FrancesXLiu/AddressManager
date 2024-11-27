using System;
using System.Xml.Linq;
using Wisej.Web;
using AddressManager.Helpers;
using AddressManager.Models;

namespace AddressManager
{
    public partial class OrganizationAddControl : Wisej.Web.UserPopup
    {
        public Organization _organization { get; set; }

        public Organization Organization
        {
            get => _organization;
            set
            {
                _organization = value;
                if (_organization != null)
                {
                    PopulateFields(_organization);
                }
            }
        }
        private void PopulateFields(Organization organization)
        {
            orgAddNameTB.Text = organization.Name;
            orgAddStreetTB.Text = organization.Street;
            orgAddZipTB.Text = organization.Zip;
            orgAddCityTB.Text = organization.City;
            orgAddCountryTB.Text = organization.Country;
        }


        public OrganizationAddControl()
        {
            InitializeComponent();
            this.Alignment = Placement.TopCenter;
        }

        public event EventHandler OrganizationAdded;

        private void orgAddSaveBtn_Click(object sender, EventArgs e)
        {
            if (_organization == null)
            {
                _organization = new Organization();
            }

            _organization.Name = orgAddNameTB.Text;
            _organization.Street = orgAddStreetTB.Text;
            _organization.Zip = orgAddZipTB.Text;
            _organization.City = orgAddCityTB.Text;
            _organization.Country = orgAddCountryTB.Text;

            var dbHelper = new DatabaseHelper();

            if (_organization.Id == 0)
            {
                // add a new organization
                dbHelper.AddOrganization(_organization);
                MessageBox.Show("Organization added.");
            }
            else
            {
                // update an existing organization
                dbHelper.UpdateOrganization(_organization);
                MessageBox.Show("Organization updated.");
            }

            // trigger the event to notify the parent control
            OrganizationAdded?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
