namespace AddressManager
{
    partial class EmployeeViewControl
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
            this.DataGridEmployeeView = new Wisej.Web.DataGridView();
            this.editButtonColumn = new Wisej.Web.DataGridViewColumn();
            this.deleteButtonColumn = new Wisej.Web.DataGridViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmployeeView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridEmployeeView
            // 
            this.DataGridEmployeeView.AllowUserToDeleteRows = true;
            this.DataGridEmployeeView.Dock = Wisej.Web.DockStyle.Fill;
            this.DataGridEmployeeView.Location = new System.Drawing.Point(0, 0);
            this.DataGridEmployeeView.Name = "DataGridEmployeeView";
            this.DataGridEmployeeView.Size = new System.Drawing.Size(1044, 673);
            this.DataGridEmployeeView.TabIndex = 0;
            this.DataGridEmployeeView.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.DataGridEmployeeView_CellClick);
            // 
            // editButtonColumn
            // 
            this.editButtonColumn.HeaderText = "Edit";
            this.editButtonColumn.Name = "editButtonColumn";
            this.editButtonColumn.ReadOnly = true;
            this.editButtonColumn.CellTemplate = new Wisej.Web.DataGridViewButtonCell();
            // 
            // deleteButtonColumn
            // 
            this.deleteButtonColumn.HeaderText = "Delete";
            this.deleteButtonColumn.Name = "deleteButtonColumn";
            this.deleteButtonColumn.ReadOnly = true;
            this.deleteButtonColumn.CellTemplate = new Wisej.Web.DataGridViewButtonCell();
            // 
            // EmployeeViewControl
            // 
            this.Controls.Add(this.DataGridEmployeeView);
            this.Name = "EmployeeViewControl";
            this.Size = new System.Drawing.Size(1044, 673);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmployeeView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.DataGridView DataGridEmployeeView;
    }
}
