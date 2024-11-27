namespace AddressManager
{
    partial class MainWindow
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
            this.menuBar1 = new Wisej.Web.MenuBar();
            this.menuOrganization = new Wisej.Web.MenuItem();
            this.menuOrganizationView = new Wisej.Web.MenuItem();
            this.menuOrganizationAdd = new Wisej.Web.MenuItem();
            this.menuEmployee = new Wisej.Web.MenuItem();
            this.menuEmployeeView = new Wisej.Web.MenuItem();
            this.menuEmployeeAdd = new Wisej.Web.MenuItem();
            this.contextMenu1 = new Wisej.Web.ContextMenu(this.components);
            this.panelMain = new Wisej.Web.Panel();
            this.SuspendLayout();
            // 
            // menuBar1
            // 
            this.menuBar1.Dock = Wisej.Web.DockStyle.Top;
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuOrganization,
            this.menuEmployee});
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(821, 40);
            this.menuBar1.TabIndex = 0;
            this.menuBar1.TabStop = false;
            // 
            // menuOrganization
            // 
            this.menuOrganization.Index = 0;
            this.menuOrganization.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuOrganizationView,
            this.menuOrganizationAdd});
            this.menuOrganization.Name = "menuOrganization";
            this.menuOrganization.Text = "Oroganization";
            // 
            // menuOrganizationView
            // 
            this.menuOrganizationView.Index = 0;
            this.menuOrganizationView.Name = "menuOrganizationView";
            this.menuOrganizationView.Text = "View";
            this.menuOrganizationView.Click += new System.EventHandler(this.MenuOrganizationView_Click);
            // 
            // menuOrganizationAdd
            // 
            this.menuOrganizationAdd.Index = 1;
            this.menuOrganizationAdd.Name = "menuOrganizationAdd";
            this.menuOrganizationAdd.Text = "Add";
            this.menuOrganizationAdd.Click += new System.EventHandler(this.MenuOrganizationAdd_Click);
            // 
            // menuEmployee
            // 
            this.menuEmployee.Index = 1;
            this.menuEmployee.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuEmployeeView,
            this.menuEmployeeAdd});
            this.menuEmployee.Name = "menuEmployee";
            this.menuEmployee.Text = "Employee";
            // 
            // menuEmployeeView
            // 
            this.menuEmployeeView.Index = 0;
            this.menuEmployeeView.Name = "menuEmployeeView";
            this.menuEmployeeView.Text = "View";
            this.menuEmployeeView.Click += new System.EventHandler(this.MenuEmployeeView_Click);
            // 
            // menuEmployeeAdd
            // 
            this.menuEmployeeAdd.Index = 1;
            this.menuEmployeeAdd.Name = "menuEmployeeAdd";
            this.menuEmployeeAdd.Text = "Add";
            this.menuEmployeeAdd.Click += new System.EventHandler(this.MenuEmployeeAdd_Click);
            // 
            // contextMenu1
            // 
            this.contextMenu1.Name = "contextMenu1";
            // 
            // panelMain
            // 
            this.panelMain.Dock = Wisej.Web.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(821, 523);
            this.panelMain.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 563);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.menuBar1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.MenuBar menuBar1;
        private Wisej.Web.ContextMenu contextMenu1;
        private Wisej.Web.MenuItem menuOrganization;
        private Wisej.Web.MenuItem menuOrganizationView;
        private Wisej.Web.MenuItem menuOrganizationAdd;
        private Wisej.Web.MenuItem menuEmployee;
        private Wisej.Web.MenuItem menuEmployeeView;
        private Wisej.Web.MenuItem menuEmployeeAdd;
        private Wisej.Web.Panel panelMain;
    }
}

