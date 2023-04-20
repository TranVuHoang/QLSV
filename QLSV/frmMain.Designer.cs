namespace QLSV
{
    partial class frmMain
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
            labelTitle = new Label();
            labelId = new Label();
            labelFullname = new Label();
            labelBirth = new Label();
            txtId = new TextBox();
            txtFullname = new TextBox();
            txtBirth = new TextBox();
            labelHomeTown = new Label();
            labelPoint = new Label();
            txtHomeTown = new TextBox();
            txtPoint = new TextBox();
            btnAdd = new Button();
            btnUpated = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            dataGridSV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridSV).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(383, 26);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(80, 30);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Update";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(73, 86);
            labelId.Name = "labelId";
            labelId.Size = new Size(21, 15);
            labelId.TabIndex = 1;
            labelId.Text = "ID:";
            // 
            // labelFullname
            // 
            labelFullname.AutoSize = true;
            labelFullname.Location = new Point(73, 129);
            labelFullname.Name = "labelFullname";
            labelFullname.Size = new Size(59, 15);
            labelFullname.TabIndex = 2;
            labelFullname.Text = "Fullname:";
            // 
            // labelBirth
            // 
            labelBirth.AutoSize = true;
            labelBirth.Location = new Point(72, 174);
            labelBirth.Name = "labelBirth";
            labelBirth.Size = new Size(76, 15);
            labelBirth.TabIndex = 3;
            labelBirth.Text = "Date of Birth:";
            // 
            // txtId
            // 
            txtId.Location = new Point(154, 87);
            txtId.Name = "txtId";
            txtId.Size = new Size(237, 23);
            txtId.TabIndex = 4;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(154, 130);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(237, 23);
            txtFullname.TabIndex = 5;
            // 
            // txtBirth
            // 
            txtBirth.Location = new Point(154, 171);
            txtBirth.Name = "txtBirth";
            txtBirth.Size = new Size(237, 23);
            txtBirth.TabIndex = 6;
            // 
            // labelHomeTown
            // 
            labelHomeTown.AutoSize = true;
            labelHomeTown.Location = new Point(450, 92);
            labelHomeTown.Name = "labelHomeTown";
            labelHomeTown.Size = new Size(73, 15);
            labelHomeTown.TabIndex = 7;
            labelHomeTown.Text = "Home town:";
            // 
            // labelPoint
            // 
            labelPoint.AutoSize = true;
            labelPoint.Location = new Point(449, 133);
            labelPoint.Name = "labelPoint";
            labelPoint.Size = new Size(38, 15);
            labelPoint.TabIndex = 8;
            labelPoint.Text = "Point:";
            // 
            // txtHomeTown
            // 
            txtHomeTown.Location = new Point(551, 91);
            txtHomeTown.Name = "txtHomeTown";
            txtHomeTown.Size = new Size(207, 23);
            txtHomeTown.TabIndex = 9;
            // 
            // txtPoint
            // 
            txtPoint.Location = new Point(551, 130);
            txtPoint.Name = "txtPoint";
            txtPoint.Size = new Size(207, 23);
            txtPoint.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(73, 440);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 49);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpated
            // 
            btnUpated.Location = new Point(192, 440);
            btnUpated.Name = "btnUpated";
            btnUpated.Size = new Size(93, 50);
            btnUpated.TabIndex = 13;
            btnUpated.Text = "Update";
            btnUpated.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(314, 440);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 50);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(432, 440);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 51);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(551, 440);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(91, 51);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(670, 440);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(88, 49);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dataGridSV
            // 
            dataGridSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSV.Location = new Point(73, 220);
            dataGridSV.Name = "dataGridSV";
            dataGridSV.RowTemplate.Height = 25;
            dataGridSV.Size = new Size(685, 199);
            dataGridSV.TabIndex = 11;
            dataGridSV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 574);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnUpated);
            Controls.Add(btnAdd);
            Controls.Add(dataGridSV);
            Controls.Add(txtPoint);
            Controls.Add(txtHomeTown);
            Controls.Add(labelPoint);
            Controls.Add(labelHomeTown);
            Controls.Add(txtBirth);
            Controls.Add(txtFullname);
            Controls.Add(txtId);
            Controls.Add(labelBirth);
            Controls.Add(labelFullname);
            Controls.Add(labelId);
            Controls.Add(labelTitle);
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TVS upate";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelId;
        private Label labelFullname;
        private Label labelBirth;
        private TextBox txtId;
        private TextBox txtFullname;
        private TextBox txtBirth;
        private Label labelHomeTown;
        private Label labelPoint;
        private TextBox txtHomeTown;
        private TextBox txtPoint;
        private Button btnAdd;
        private Button btnUpated;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
        private Button btnExit;
        private DataGridView dataGridView1;
        private DataGridView dataGridSV;
    }
}