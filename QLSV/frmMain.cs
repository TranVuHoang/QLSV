using abo_lib;
using adao_lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public bool s;

        // Phương thức LoadData - khi form Main được mở thì sẽ load lên
        public void LoadData()
        {
            StudentUpdate student = new StudentUpdate();
            DataTable dt = student.getAllStudent();
            this.dataGridSV.DataSource = dt;
        }

        // Phương thức để fillData từ dataGridView (đổ dữ liệu từ dataGridView lên form)
        public void FillData()
        {
            if (this.dataGridSV.Rows.Count > 0)
            {
                this.txtId.Text = this.dataGridSV.CurrentRow.Cells[0].Value.ToString();
                this.txtFullname.Text = this.dataGridSV.CurrentRow.Cells[1].Value.ToString();
                this.txtBirth.Text = this.dataGridSV.CurrentRow.Cells[2].Value.ToString();
                this.txtHomeTown.Text = this.dataGridSV.CurrentRow.Cells[3].Value.ToString();
                this.txtPoint.Text = this.dataGridSV.CurrentRow.Cells[4].Value.ToString();
            }
        }

        // Phương thức setStatus để ẩn hiện các nút
        public void SetStatus()
        {
            this.txtId.ReadOnly = true;
            this.txtFullname.ReadOnly = true;
            this.txtBirth.ReadOnly = true;
            this.txtHomeTown.ReadOnly = true;
            this.txtPoint.ReadOnly = true;

            this.btnAdd.Enabled = true;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;

            if (this.dataGridSV.Rows.Count > 0)
            {
                this.btnUpated.Enabled = true;
                this.btnDelete.Enabled = true;
            }
            else
            {
                this.btnUpated.Enabled = false;
                this.btnDelete.Enabled = false;
            }

        }

        //check regular
        public bool CheckData()
        {
            // id trống
            if (this.txtId.Text.Trim().Length == 0)
            {
                DialogResult result = new DialogResult();
                result = MessageBox.Show("Id không được để trống.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
               
                return false;
            }
            // id trùng
            StudentUpdate u = new StudentUpdate();
            DataTable dt = u.getStudent(this.txtId.Text.Trim());          
          
            if (dt.Rows.Count > 0)
            {
                DialogResult result = new DialogResult();
                result = MessageBox.Show("Id da ton tai.", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.txtId.Focus();

                return false;
            }
            
            // check điểm có định dạng số hay không
            if(!float.TryParse(this.txtPoint.Text.Trim(), out float dtPoint))
            {
                DialogResult result = new DialogResult();
                result = MessageBox.Show("Điểm chưa đúng định dạng số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPoint.Focus();

                return false;
            }
            
            // check ngày sinh có đúng định dạng datetime
            if(!DateTime.TryParse(this.txtBirth.Text.Trim(), out DateTime dateTime))
            {
                DialogResult result = new DialogResult();
                result = MessageBox.Show("Ngày sinh chưa đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            return true;

        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadData();
            FillData();
            SetStatus();
        }

        // Phương thức để bắt sự kiện người dùng click vào 1 thông tin bất kỳ trong dataGridView thì đổ thông tin đó lên form
        private void dataGridSV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillData();
        }

        /**
         * 
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "";
            this.txtId.Focus();
            this.txtFullname.Text = "";
            this.txtBirth.Text = "";
            this.txtHomeTown.Text = "";
            this.txtPoint.Text = "";

            this.txtId.ReadOnly = false;
            this.txtFullname.ReadOnly = false;
            this.txtBirth.ReadOnly = false;
            this.txtHomeTown.ReadOnly = false;
            this.txtPoint.ReadOnly = false;

            this.btnAdd.Enabled = false;
            this.btnUpated.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;

            s = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FillData();
            SetStatus();
        }

        private void btnUpated_Click(object sender, EventArgs e)
        {
            s = false;

            this.txtId.ReadOnly = true;
            this.txtFullname.ReadOnly = false;
            this.txtBirth.ReadOnly = false;
            this.txtHomeTown.ReadOnly = false;
            this.txtPoint.ReadOnly = false;

            this.btnAdd.Enabled = false;
            this.btnUpated.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnCancel.Enabled = true;
            this.btnSave.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (s)
            {
                if (CheckData())
                {
                    Student ru = new Student();
                    ru.id = this.txtId.Text.Trim();
                    ru.hoten = this.txtFullname.Text.Trim();
                    ru.ngaysinh = DateTime.Parse(this.txtBirth.Text.Trim().Split()[0]);
                    ru.que = this.txtHomeTown.Text.Trim();
                    if(txtPoint.Text.Trim() != "")
                    {
                        ru.diem = float.Parse(this.txtPoint.Text.Trim());
                    }
                    else
                    {
                        ru.diem = 0;
                    }
                    

                    StudentUpdate student = new StudentUpdate();
                    student.Insert(ru);
                    LoadData();
                    FillData();
                    SetStatus();
                }
 
            }
            else
            {
                Student ru = new Student();
                ru.id = this.txtId.Text.Trim();
                ru.hoten = this.txtFullname.Text.Trim();
                ru.ngaysinh = DateTime.Parse(this.txtBirth.Text.Trim().Split()[0]);
                ru.que = this.txtHomeTown.Text.Trim();
                if (txtPoint.Text.Trim() != "")
                {
                    ru.diem = float.Parse(this.txtPoint.Text.Trim());
                }
                else
                {
                    ru.diem = 0;
                }
                StudentUpdate student = new StudentUpdate();
                student.Update(ru);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
