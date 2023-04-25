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
            groupInfor = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridSV).BeginInit();
            groupInfor.SuspendLayout();
            SuspendLayout();
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(26, 40);
            labelId.Name = "labelId";
            labelId.Size = new Size(21, 15);
            labelId.TabIndex = 1;
            labelId.Text = "ID:";
            // 
            // labelFullname
            // 
            labelFullname.AutoSize = true;
            labelFullname.Location = new Point(26, 83);
            labelFullname.Name = "labelFullname";
            labelFullname.Size = new Size(59, 15);
            labelFullname.TabIndex = 2;
            labelFullname.Text = "Fullname:";
            // 
            // labelBirth
            // 
            labelBirth.AutoSize = true;
            labelBirth.Location = new Point(25, 128);
            labelBirth.Name = "labelBirth";
            labelBirth.Size = new Size(76, 15);
            labelBirth.TabIndex = 3;
            labelBirth.Text = "Date of Birth:";
            // 
            // txtId
            // 
            txtId.Location = new Point(107, 41);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(237, 23);
            txtId.TabIndex = 4;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(107, 83);
            txtFullname.Name = "txtFullname";
            txtFullname.ReadOnly = true;
            txtFullname.Size = new Size(237, 23);
            txtFullname.TabIndex = 5;
            // 
            // txtBirth
            // 
            txtBirth.Location = new Point(107, 125);
            txtBirth.Name = "txtBirth";
            txtBirth.ReadOnly = true;
            txtBirth.Size = new Size(237, 23);
            txtBirth.TabIndex = 6;
            // 
            // labelHomeTown
            // 
            labelHomeTown.AutoSize = true;
            labelHomeTown.Location = new Point(414, 42);
            labelHomeTown.Name = "labelHomeTown";
            labelHomeTown.Size = new Size(73, 15);
            labelHomeTown.TabIndex = 7;
            labelHomeTown.Text = "Home town:";
            // 
            // labelPoint
            // 
            labelPoint.AutoSize = true;
            labelPoint.Location = new Point(413, 83);
            labelPoint.Name = "labelPoint";
            labelPoint.Size = new Size(38, 15);
            labelPoint.TabIndex = 8;
            labelPoint.Text = "Point:";
            // 
            // txtHomeTown
            // 
            txtHomeTown.Location = new Point(515, 41);
            txtHomeTown.Name = "txtHomeTown";
            txtHomeTown.ReadOnly = true;
            txtHomeTown.Size = new Size(207, 23);
            txtHomeTown.TabIndex = 9;
            // 
            // txtPoint
            // 
            txtPoint.Location = new Point(515, 80);
            txtPoint.Name = "txtPoint";
            txtPoint.ReadOnly = true;
            txtPoint.Size = new Size(207, 23);
            txtPoint.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(31, 434);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 49);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpated
            // 
            btnUpated.Location = new Point(153, 433);
            btnUpated.Name = "btnUpated";
            btnUpated.Size = new Size(93, 50);
            btnUpated.TabIndex = 13;
            btnUpated.Text = "Sửa";
            btnUpated.UseVisualStyleBackColor = true;
            btnUpated.Click += btnUpated_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(290, 433);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 50);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(430, 433);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 51);
            btnSave.TabIndex = 15;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(561, 433);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(91, 51);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(688, 433);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(88, 51);
            btnExit.TabIndex = 17;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dataGridSV
            // 
            dataGridSV.BackgroundColor = SystemColors.ControlLightLight;
            dataGridSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSV.Location = new Point(31, 223);
            dataGridSV.Name = "dataGridSV";
            dataGridSV.RowTemplate.Height = 25;
            dataGridSV.Size = new Size(745, 190);
            dataGridSV.TabIndex = 11;
            dataGridSV.CellMouseClick += dataGridSV_CellMouseClick;
            // 
            // groupInfor
            // 
            groupInfor.Controls.Add(txtId);
            groupInfor.Controls.Add(labelId);
            groupInfor.Controls.Add(labelFullname);
            groupInfor.Controls.Add(labelBirth);
            groupInfor.Controls.Add(txtFullname);
            groupInfor.Controls.Add(txtBirth);
            groupInfor.Controls.Add(labelHomeTown);
            groupInfor.Controls.Add(labelPoint);
            groupInfor.Controls.Add(txtPoint);
            groupInfor.Controls.Add(txtHomeTown);
            groupInfor.Location = new Point(31, 25);
            groupInfor.Name = "groupInfor";
            groupInfor.Size = new Size(745, 178);
            groupInfor.TabIndex = 18;
            groupInfor.TabStop = false;
            groupInfor.Text = "Thông tin sinh viên";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 498);
            Controls.Add(groupInfor);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnUpated);
            Controls.Add(btnAdd);
            Controls.Add(dataGridSV);
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TVS update";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSV).EndInit();
            groupInfor.ResumeLayout(false);
            groupInfor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private GroupBox groupInfor;
    }
}