namespace StudentManagementCSharp
{
    partial class Home
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSoftByName = new System.Windows.Forms.Button();
            this.btnSoftByYear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dGView = new System.Windows.Forms.DataGridView();
            this.noColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfBirthCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileCollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student name:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(180, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(282, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(543, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSoftByName
            // 
            this.btnSoftByName.Location = new System.Drawing.Point(26, 73);
            this.btnSoftByName.Name = "btnSoftByName";
            this.btnSoftByName.Size = new System.Drawing.Size(100, 30);
            this.btnSoftByName.TabIndex = 3;
            this.btnSoftByName.Text = "Soft by Name";
            this.btnSoftByName.UseVisualStyleBackColor = true;
            this.btnSoftByName.Click += new System.EventHandler(this.btnSoftByName_Click);
            // 
            // btnSoftByYear
            // 
            this.btnSoftByYear.Location = new System.Drawing.Point(180, 73);
            this.btnSoftByYear.Name = "btnSoftByYear";
            this.btnSoftByYear.Size = new System.Drawing.Size(100, 30);
            this.btnSoftByYear.TabIndex = 4;
            this.btnSoftByYear.Text = "Soft by Year";
            this.btnSoftByYear.UseVisualStyleBackColor = true;
            this.btnSoftByYear.Click += new System.EventHandler(this.btnSoftByYear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(543, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dGView
            // 
            this.dGView.AllowUserToAddRows = false;
            this.dGView.AllowUserToOrderColumns = true;
            this.dGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noColumn,
            this.idColumn,
            this.name,
            this.yearOfBirthCl,
            this.addressCollumn,
            this.MobileCollumn,
            this.editColumn,
            this.deleteColumn});
            this.dGView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dGView.Location = new System.Drawing.Point(12, 140);
            this.dGView.Name = "dGView";
            this.dGView.ReadOnly = true;
            this.dGView.Size = new System.Drawing.Size(752, 312);
            this.dGView.TabIndex = 6;
            this.dGView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGView_CellContentClick);
            // 
            // noColumn
            // 
            this.noColumn.HeaderText = "No";
            this.noColumn.Name = "noColumn";
            this.noColumn.ReadOnly = true;
            this.noColumn.Width = 46;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            this.idColumn.Width = 40;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 60;
            // 
            // yearOfBirthCl
            // 
            this.yearOfBirthCl.HeaderText = "Year Of Birth";
            this.yearOfBirthCl.Name = "yearOfBirthCl";
            this.yearOfBirthCl.ReadOnly = true;
            this.yearOfBirthCl.Width = 92;
            // 
            // addressCollumn
            // 
            this.addressCollumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.addressCollumn.HeaderText = "Address";
            this.addressCollumn.Name = "addressCollumn";
            this.addressCollumn.ReadOnly = true;
            this.addressCollumn.Width = 70;
            // 
            // MobileCollumn
            // 
            this.MobileCollumn.HeaderText = "Mobie Phone";
            this.MobileCollumn.Name = "MobileCollumn";
            this.MobileCollumn.ReadOnly = true;
            this.MobileCollumn.Width = 95;
            // 
            // editColumn
            // 
            this.editColumn.HeaderText = "Edit";
            this.editColumn.Name = "editColumn";
            this.editColumn.ReadOnly = true;
            this.editColumn.Width = 50;
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "Delete";
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Width = 63;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(767, 455);
            this.Controls.Add(this.dGView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSoftByYear);
            this.Controls.Add(this.btnSoftByName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Student Management";
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSoftByName;
        private System.Windows.Forms.Button btnSoftByYear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dGView;
        private System.Windows.Forms.DataGridViewTextBoxColumn noColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfBirthCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressCollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileCollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteColumn;
    }
}

