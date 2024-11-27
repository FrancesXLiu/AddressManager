namespace AddressManager
{
    partial class OrganizationAddControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej.NET Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.orgAddNameTB = new Wisej.Web.TextBox();
            this.contextMenu1 = new Wisej.Web.ContextMenu(this.components);
            this.orgAddStreetTB = new Wisej.Web.TextBox();
            this.contextMenu2 = new Wisej.Web.ContextMenu(this.components);
            this.contextMenu3 = new Wisej.Web.ContextMenu(this.components);
            this.orgAddZipTB = new Wisej.Web.TextBox();
            this.contextMenu4 = new Wisej.Web.ContextMenu(this.components);
            this.contextMenu5 = new Wisej.Web.ContextMenu(this.components);
            this.orgAddCityTB = new Wisej.Web.TextBox();
            this.contextMenu6 = new Wisej.Web.ContextMenu(this.components);
            this.orgAddCountryTB = new Wisej.Web.TextBox();
            this.contextMenu7 = new Wisej.Web.ContextMenu(this.components);
            this.orgAddSaveBtn = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // orgAddNameTB
            // 
            this.orgAddNameTB.LabelText = "Name";
            this.orgAddNameTB.Location = new System.Drawing.Point(44, 13);
            this.orgAddNameTB.Name = "orgAddNameTB";
            this.orgAddNameTB.Size = new System.Drawing.Size(547, 53);
            this.orgAddNameTB.TabIndex = 0;
            // 
            // contextMenu1
            // 
            this.contextMenu1.Name = "contextMenu1";
            // 
            // orgAddStreetTB
            // 
            this.orgAddStreetTB.LabelText = "Street";
            this.orgAddStreetTB.Location = new System.Drawing.Point(44, 93);
            this.orgAddStreetTB.Name = "orgAddStreetTB";
            this.orgAddStreetTB.Size = new System.Drawing.Size(381, 53);
            this.orgAddStreetTB.TabIndex = 1;
            // 
            // contextMenu2
            // 
            this.contextMenu2.Name = "contextMenu2";
            // 
            // contextMenu3
            // 
            this.contextMenu3.Name = "contextMenu3";
            // 
            // orgAddZipTB
            // 
            this.orgAddZipTB.LabelText = "Zip Code";
            this.orgAddZipTB.Location = new System.Drawing.Point(467, 93);
            this.orgAddZipTB.Name = "orgAddZipTB";
            this.orgAddZipTB.Size = new System.Drawing.Size(124, 53);
            this.orgAddZipTB.TabIndex = 2;
            // 
            // contextMenu4
            // 
            this.contextMenu4.Name = "contextMenu4";
            // 
            // contextMenu5
            // 
            this.contextMenu5.Name = "contextMenu5";
            // 
            // orgAddCityTB
            // 
            this.orgAddCityTB.LabelText = "City";
            this.orgAddCityTB.Location = new System.Drawing.Point(44, 195);
            this.orgAddCityTB.Name = "orgAddCityTB";
            this.orgAddCityTB.Size = new System.Drawing.Size(312, 53);
            this.orgAddCityTB.TabIndex = 3;
            // 
            // contextMenu6
            // 
            this.contextMenu6.Name = "contextMenu6";
            // 
            // orgAddCountryTB
            // 
            this.orgAddCountryTB.LabelText = "Country";
            this.orgAddCountryTB.Location = new System.Drawing.Point(398, 195);
            this.orgAddCountryTB.Name = "orgAddCountryTB";
            this.orgAddCountryTB.Size = new System.Drawing.Size(193, 53);
            this.orgAddCountryTB.TabIndex = 4;
            // 
            // contextMenu7
            // 
            this.contextMenu7.Name = "contextMenu7";
            // 
            // orgAddSaveBtn
            // 
            this.orgAddSaveBtn.Location = new System.Drawing.Point(273, 300);
            this.orgAddSaveBtn.Name = "orgAddSaveBtn";
            this.orgAddSaveBtn.Size = new System.Drawing.Size(100, 37);
            this.orgAddSaveBtn.TabIndex = 5;
            this.orgAddSaveBtn.Text = "Save";
            this.orgAddSaveBtn.Click += new System.EventHandler(this.orgAddSaveBtn_Click);
            // 
            // OrganizationAddControl
            // 
            this.Controls.Add(this.orgAddSaveBtn);
            this.Controls.Add(this.orgAddCountryTB);
            this.Controls.Add(this.orgAddCityTB);
            this.Controls.Add(this.orgAddZipTB);
            this.Controls.Add(this.orgAddStreetTB);
            this.Controls.Add(this.orgAddNameTB);
            this.Name = "OrganizationAddControl";
            this.Size = new System.Drawing.Size(655, 388);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.TextBox orgAddNameTB;
        private Wisej.Web.ContextMenu contextMenu1;
        private Wisej.Web.TextBox orgAddStreetTB;
        private Wisej.Web.ContextMenu contextMenu2;
        private Wisej.Web.ContextMenu contextMenu3;
        private Wisej.Web.TextBox orgAddZipTB;
        private Wisej.Web.ContextMenu contextMenu4;
        private Wisej.Web.ContextMenu contextMenu5;
        private Wisej.Web.TextBox orgAddCityTB;
        private Wisej.Web.ContextMenu contextMenu6;
        private Wisej.Web.TextBox orgAddCountryTB;
        private Wisej.Web.ContextMenu contextMenu7;
        private Wisej.Web.Button orgAddSaveBtn;
    }
}
