using System;
using Wisej.Web;

namespace AddressManager
{
    partial class OrganizationViewControl
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
            this.DataGridOrgView = new Wisej.Web.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOrgView)).BeginInit();
            this.DataGridOrgView.SuspendLayout();
            this.editButtonColumn = new Wisej.Web.DataGridViewColumn();
            this.deleteButtonColumn = new Wisej.Web.DataGridViewColumn();
            this.SuspendLayout();
            // 
            // DataGridOrgView
            // 
            this.DataGridOrgView.AllowUserToDeleteRows = true;
            this.DataGridOrgView.Dock = Wisej.Web.DockStyle.Fill;
            this.DataGridOrgView.Location = new System.Drawing.Point(0, 0);
            this.DataGridOrgView.Name = "DataGridOrgView";
            this.DataGridOrgView.Size = new System.Drawing.Size(820, 489);
            this.DataGridOrgView.TabIndex = 0;
            this.DataGridOrgView.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.DataGridOrgView_CellClick);
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
            // OrganizationViewControl
            // 
            this.Controls.Add(this.DataGridOrgView);
            this.Name = "OrganizationViewControl";
            this.Size = new System.Drawing.Size(820, 489);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridOrgView)).EndInit();
            this.DataGridOrgView.ResumeLayout(false);
            this.DataGridOrgView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.DataGridView DataGridOrgView;
    }
}
