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
            this.lViewStudent = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameStudent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YoB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fLPanelButton = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 31);
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
            this.btnSearch.Size = new System.Drawing.Size(93, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSoftByName
            // 
            this.btnSoftByName.Location = new System.Drawing.Point(26, 73);
            this.btnSoftByName.Name = "btnSoftByName";
            this.btnSoftByName.Size = new System.Drawing.Size(128, 32);
            this.btnSoftByName.TabIndex = 3;
            this.btnSoftByName.Text = "Soft by Name";
            this.btnSoftByName.UseVisualStyleBackColor = true;
            this.btnSoftByName.Click += new System.EventHandler(this.btnSoftByName_Click);
            // 
            // btnSoftByYear
            // 
            this.btnSoftByYear.Location = new System.Drawing.Point(194, 73);
            this.btnSoftByYear.Name = "btnSoftByYear";
            this.btnSoftByYear.Size = new System.Drawing.Size(128, 32);
            this.btnSoftByYear.TabIndex = 4;
            this.btnSoftByYear.Text = "Soft by Year";
            this.btnSoftByYear.UseVisualStyleBackColor = true;
            this.btnSoftByYear.Click += new System.EventHandler(this.btnSoftByYear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(645, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 32);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lViewStudent
            // 
            this.lViewStudent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.nameStudent,
            this.YoB,
            this.Address,
            this.phone});
            this.lViewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lViewStudent.HideSelection = false;
            this.lViewStudent.Location = new System.Drawing.Point(23, 140);
            this.lViewStudent.Name = "lViewStudent";
            this.lViewStudent.Size = new System.Drawing.Size(566, 293);
            this.lViewStudent.TabIndex = 6;
            this.lViewStudent.UseCompatibleStateImageBehavior = false;
            this.lViewStudent.View = System.Windows.Forms.View.Details;
            this.lViewStudent.SelectedIndexChanged += new System.EventHandler(this.lViewStudent_SelectedIndexChanged);
            // 
            // No
            // 
            this.No.Text = "No";
            this.No.Width = 33;
            // 
            // nameStudent
            // 
            this.nameStudent.Text = "Name";
            this.nameStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameStudent.Width = 86;
            // 
            // YoB
            // 
            this.YoB.Text = "Year of Birth";
            this.YoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.YoB.Width = 73;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Address.Width = 276;
            // 
            // phone
            // 
            this.phone.Text = "Mobile phone";
            this.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phone.Width = 94;
            // 
            // fLPanelButton
            // 
            this.fLPanelButton.Location = new System.Drawing.Point(623, 140);
            this.fLPanelButton.Name = "fLPanelButton";
            this.fLPanelButton.Size = new System.Drawing.Size(174, 292);
            this.fLPanelButton.TabIndex = 7;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fLPanelButton);
            this.Controls.Add(this.lViewStudent);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSoftByYear);
            this.Controls.Add(this.btnSoftByName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Student Management";
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
        private System.Windows.Forms.ListView lViewStudent;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader nameStudent;
        private System.Windows.Forms.ColumnHeader YoB;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.FlowLayoutPanel fLPanelButton;
    }
}

