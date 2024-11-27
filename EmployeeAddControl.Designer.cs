namespace AddressManager
{
    partial class EmployeeAddControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej.NET Designer generated code

        private void InitializeComponent()
        {
            this.empAddTitleTB = new Wisej.Web.TextBox();
            this.empAddFirstNameTB = new Wisej.Web.TextBox();
            this.empAddLastNameTB = new Wisej.Web.TextBox();
            this.empAddPhoneTB = new Wisej.Web.TextBox();
            this.empAddEmailTB = new Wisej.Web.TextBox();
            this.empAddSaveBtn = new Wisej.Web.Button();
            this.empOrgCB = new Wisej.Web.ComboBox();
            this.SuspendLayout();
            // 
            // empAddTitleTB
            // 
            this.empAddTitleTB.LabelText = "Title";
            this.empAddTitleTB.Location = new System.Drawing.Point(44, 80);
            this.empAddTitleTB.Name = "empAddTitleTB";
            this.empAddTitleTB.Size = new System.Drawing.Size(547, 53);
            this.empAddTitleTB.TabIndex = 1;
            // 
            // empAddFirstNameTB
            // 
            this.empAddFirstNameTB.LabelText = "First Name";
            this.empAddFirstNameTB.Location = new System.Drawing.Point(44, 147);
            this.empAddFirstNameTB.Name = "empAddFirstNameTB";
            this.empAddFirstNameTB.Size = new System.Drawing.Size(547, 53);
            this.empAddFirstNameTB.TabIndex = 2;
            // 
            // empAddLastNameTB
            // 
            this.empAddLastNameTB.LabelText = "Last Name";
            this.empAddLastNameTB.Location = new System.Drawing.Point(44, 214);
            this.empAddLastNameTB.Name = "empAddLastNameTB";
            this.empAddLastNameTB.Size = new System.Drawing.Size(547, 53);
            this.empAddLastNameTB.TabIndex = 3;
            // 
            // empAddPhoneTB
            // 
            this.empAddPhoneTB.LabelText = "Phone";
            this.empAddPhoneTB.Location = new System.Drawing.Point(44, 281);
            this.empAddPhoneTB.Name = "empAddPhoneTB";
            this.empAddPhoneTB.Size = new System.Drawing.Size(547, 53);
            this.empAddPhoneTB.TabIndex = 4;
            // 
            // empAddEmailTB
            // 
            this.empAddEmailTB.LabelText = "Email";
            this.empAddEmailTB.Location = new System.Drawing.Point(44, 348);
            this.empAddEmailTB.Name = "empAddEmailTB";
            this.empAddEmailTB.Size = new System.Drawing.Size(547, 53);
            this.empAddEmailTB.TabIndex = 5;
            // 
            // empAddSaveBtn
            // 
            this.empAddSaveBtn.Location = new System.Drawing.Point(273, 425);
            this.empAddSaveBtn.Name = "empAddSaveBtn";
            this.empAddSaveBtn.Size = new System.Drawing.Size(100, 37);
            this.empAddSaveBtn.TabIndex = 6;
            this.empAddSaveBtn.Text = "Save";
            this.empAddSaveBtn.Click += new System.EventHandler(this.empAddSaveBtn_Click);
            // 
            // empOrgCB
            // 
            this.empOrgCB.LabelText = "Organization";
            this.empOrgCB.Location = new System.Drawing.Point(44, 3);
            this.empOrgCB.Name = "empOrgCB";
            this.empOrgCB.Size = new System.Drawing.Size(547, 53);
            this.empOrgCB.TabIndex = 7;
            // 
            // EmployeeAddControl
            // 
            this.Controls.Add(this.empOrgCB);
            this.Controls.Add(this.empAddSaveBtn);
            this.Controls.Add(this.empAddEmailTB);
            this.Controls.Add(this.empAddPhoneTB);
            this.Controls.Add(this.empAddLastNameTB);
            this.Controls.Add(this.empAddFirstNameTB);
            this.Controls.Add(this.empAddTitleTB);
            this.Name = "EmployeeAddControl";
            this.Size = new System.Drawing.Size(655, 488);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Wisej.Web.TextBox empAddTitleTB;
        private Wisej.Web.TextBox empAddFirstNameTB;
        private Wisej.Web.TextBox empAddLastNameTB;
        private Wisej.Web.TextBox empAddPhoneTB;
        private Wisej.Web.TextBox empAddEmailTB;
        private Wisej.Web.Button empAddSaveBtn;
        private Wisej.Web.ComboBox empOrgCB;
    }
}
