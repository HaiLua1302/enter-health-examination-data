using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace khamsk
{
    public partial class KSKTT14 : Form
    {
        public KSKTT14()
        {
            InitializeComponent();
        }

        //load form
        private void KSKTT14_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            setDataCB();
            formatDate();
            getDSBN();
            formatDtg();
            disBtn();
            autoCompleteData_Lydo();
            autoCompleteData_NguoiKL();
        }
        //disable button
        private void disBtn()
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        //set data mac dinh
        private void setDataCB()
        {
            cbGioitinh.Items.Add("Nam");
            cbGioitinh.Items.Add("Nữ");
            cbGioitinh.SelectedIndex = 0;

            cbPLTL.Items.Add("1");
            cbPLTL.Items.Add("2");
            cbPLTL.Items.Add("3");
            cbPLTL.Items.Add("4");
            cbPLTL.Items.Add("5");
            cbPLTL.SelectedIndex = 0;

            cbPLSK.Items.Add("1");
            cbPLSK.Items.Add("2");
            cbPLSK.Items.Add("3");
            cbPLSK.Items.Add("4");
            cbPLSK.Items.Add("5");
            cbPLSK.SelectedIndex = 0;
        }

        //format ngay thang
        private void formatDate()
        {
            dtpNgaycap.Format = DateTimePickerFormat.Custom;
            dtpNgaycap.CustomFormat = "dd-MM-yyyy";
           
        }


        //format datagridview
        private void formatDtg()
        {
            dtgDS_TT14.BackgroundColor = Color.White;
            dtgDS_TT14.RowHeadersVisible = false;
        }

        //get ds tt14
        private void getDSBN()
        {
            DataTable _dskq = BUS.BUS_TT14.getDS_TT14();
            dtgDS_TT14.DataSource = _dskq;
        }
        //refresh ds
        private void btnLayDS_Click(object sender, EventArgs e)
        {
            getDSBN();
        }

        //auto completedata
        private void autoCompleteData_Lydo()
        {
            SqlConnection con = new SqlConnection(DB.getDB._connectionString);
            SqlCommand com = new SqlCommand("Select lydo from thongtinBN", con);
            con.Open();
            SqlDataReader rdr = com.ExecuteReader();
            //AutoCompleteStringCollection Contains a collection of strings to use for the auto-complete feature on certain Windows Forms controls.
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            while (rdr.Read())
            {
                autoCompleteCollection.Add(rdr.GetString(0));
            }
            //Set AutoCompleteSource property of txt_StateName as CustomSource
            txtLydokham.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //Set AutoCompleteMode property of txt_StateName as SuggestAppend. SuggestAppend Applies both Suggest and Append
            txtLydokham.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtLydokham.AutoCompleteCustomSource = autoCompleteCollection;
            con.Close();
        }
        private void autoCompleteData_NguoiKL()
        {
            SqlConnection con = new SqlConnection(DB.getDB._connectionString);
            SqlCommand com = new SqlCommand("Select nguoiKL from thongtinkham", con);
            con.Open();
            SqlDataReader rdr = com.ExecuteReader();
            //AutoCompleteStringCollection Contains a collection of strings to use for the auto-complete feature on certain Windows Forms controls.
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            while (rdr.Read())
            {
                autoCompleteCollection.Add(rdr.GetString(0));
            }
            //Set AutoCompleteSource property of txt_StateName as CustomSource
            txtNguoiKL.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //Set AutoCompleteMode property of txt_StateName as SuggestAppend. SuggestAppend Applies both Suggest and Append
            txtNguoiKL.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNguoiKL.AutoCompleteCustomSource = autoCompleteCollection;
            con.Close();
        }


        //them benh nhan
        private void themBN()
        {
            if (txtHoten.Text == string.Empty)
            {
                errorProvider1.SetError(txtHoten, "Nhập họ tên!!!");
            }
            else if (txtNamsinh.Text != string.Empty)
            {
                if (txtNamsinh.Text.Length != 4)
                {
                    errorProvider1.SetError(txtNamsinh, "Năm sinh không hợp lệ!!!");
                }
                else
                {
                    string timenow = DateTime.Now.ToString("dd-MM-yyyy");
                    CLASS.thongtinBN bn = new CLASS.thongtinBN();
                    CLASS.thongtinSK sk = new CLASS.thongtinSK();
                    bn.hoten = txtHoten.Text;
                    bn.gioitinh = cbGioitinh.Text;
                    if (txtNamsinh.Text == string.Empty)
                    {
                        bn.namsinh = 0;
                    }
                    else { bn.namsinh = int.Parse(txtNamsinh.Text); }
                    bn.cmnd = txtCMND.Text;
                    bn.ngaycap = dtpNgaycap.Text;
                    bn.diachi = txtDiachi.Text;
                    bn.lydo = txtLydokham.Text;
                    if (txtChieucao.Text == string.Empty || txtChieucao.Text.Length > 3)
                    {
                        errorProvider1.SetError(txtChieucao, "Chiều cao không hợp lệ!!!");
                        sk.chieucao = 0;
                    }
                    else { sk.chieucao = int.Parse(txtChieucao.Text); }
                    if (txtCannang.Text == string.Empty)
                    {
                        sk.cannang = 0;
                    }
                    else { sk.cannang = int.Parse(txtCannang.Text); }
                    if (sk.cannang == 0 || sk.chieucao == 0)
                    {
                        sk.bmi = 0;
                    }
                    else
                    {
                        double FirstNumber = Convert.ToDouble(sk.chieucao);
                        double second = Convert.ToDouble(sk.cannang);
                        double BMI = second / ((FirstNumber / 100) * (FirstNumber / 100));
                        int bmi = (int)BMI;
                        sk.bmi = bmi;
                    }

                    if (txtMach.Text == string.Empty)
                    {
                        sk.mach = 0;
                    }
                    else { sk.mach = int.Parse(txtMach.Text); }

                    sk.huyetap = txtHuyetap.Text;
                    sk.pltl = cbPLTL.Text;
                    sk.plsk = cbPLSK.Text;
                    sk.benhkhac = txtBenhkhac.Text;
                    sk.nguoiKL = txtNguoiKL.Text;
                    sk.ngaykham = timenow;
                    bool kq = BUS.BUS_TT14.ThemBN(bn, sk);
                    if (kq == true)
                    {
                        MessageBox.Show("Thêm thành công!!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getDSBN();
                    }
                    else
                    {
                        MessageBox.Show("Thêm dữ liệu thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }

            }
            
        }

        //hiệu ứng dòng datagridview
        private void dtgDS_TT14_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dtgDS_TT14.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dtgDS_TT14.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }
        //hiệu ứng dòng datagridview
        private void dtgDS_TT14_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dtgDS_TT14.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 193);
                dtgDS_TT14.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        //lấy dữ liệu datagridview
        private void dtgDS_TT14_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string hoten = dtgDS_TT14.CurrentRow.Cells[1].Value.ToString();
            string gioitinh = dtgDS_TT14.CurrentRow.Cells[2].Value.ToString();
            string namsinh = dtgDS_TT14.CurrentRow.Cells[3].Value.ToString();
            string cmnd = dtgDS_TT14.CurrentRow.Cells[4].Value.ToString();
            string ngaycap = dtgDS_TT14.CurrentRow.Cells[5].Value.ToString();
            string diachi = dtgDS_TT14.CurrentRow.Cells[6].Value.ToString();
            string lydo = dtgDS_TT14.CurrentRow.Cells[7].Value.ToString();
            string chieucao = dtgDS_TT14.CurrentRow.Cells[8].Value.ToString();
            string cannang = dtgDS_TT14.CurrentRow.Cells[9].Value.ToString();
            string bmi = dtgDS_TT14.CurrentRow.Cells[10].Value.ToString();
            string mach = dtgDS_TT14.CurrentRow.Cells[11].Value.ToString();
            string huyetap = dtgDS_TT14.CurrentRow.Cells[12].Value.ToString();
            string pltl = dtgDS_TT14.CurrentRow.Cells[13].Value.ToString();
            string plsk = dtgDS_TT14.CurrentRow.Cells[14].Value.ToString();
            string benhkhac = dtgDS_TT14.CurrentRow.Cells[15].Value.ToString();
            string nguoiKL = dtgDS_TT14.CurrentRow.Cells[16].Value.ToString();

            txtHoten.Text = hoten;
            if(gioitinh == "Nam")
            {
                cbGioitinh.SelectedIndex = 0;
            }
            else { cbGioitinh.SelectedIndex = 1; }
            txtNamsinh.Text = namsinh;
            if (namsinh != string.Empty)
            {
                int parseNamsinh = int.Parse(namsinh);
                int namHientai = int.Parse(DateTime.Now.ToString("yyyy"));
                int tuoi = namHientai - parseNamsinh;
                txtTuoi.Text = tuoi.ToString();
            }
            txtCMND.Text = cmnd;
            dtpNgaycap.Value = DateTime.ParseExact(ngaycap, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            txtDiachi.Text = diachi;
            txtLydokham.Text = lydo;
            txtChieucao.Text = chieucao;
            txtCannang.Text = cannang;
            txtBMI.Text = bmi;
            txtMach.Text = mach;
            txtHuyetap.Text = huyetap;
            switch (pltl)
            {
                case "1": 
                    cbPLTL.SelectedIndex = 0;
                    break;
                case "2":
                    cbPLTL.SelectedIndex = 1;
                    break;
                case "3":
                    cbPLTL.SelectedIndex = 2;
                    break;
                case "4":
                    cbPLTL.SelectedIndex = 3;
                    break;
                case "5":
                    cbPLTL.SelectedIndex = 4;
                    break;
                default:
                    cbPLTL.SelectedIndex = 0;
                    break;

            }
            switch (plsk)
            {
                case "1":
                    cbPLSK.SelectedIndex = 0;
                    break;
                case "2":
                    cbPLSK.SelectedIndex = 1;
                    break;
                case "3":
                    cbPLSK.SelectedIndex = 2;
                    break;
                case "4":
                    cbPLSK.SelectedIndex = 3;
                    break;
                case "5":
                    cbPLSK.SelectedIndex = 4;
                    break;
                default:
                    cbPLSK.SelectedIndex = 0;
                    break;

            }
            txtBenhkhac.Text = benhkhac;
            txtNguoiKL.Text = nguoiKL;

            tabCrlTT14.SelectedIndex = 0;
            btnSua.Enabled = true;
        }

        //ham sua
        private void suaBN()
        {
            string timenow = DateTime.Now.ToString("dd-MM-yyyy");
            CLASS.thongtinBN bn = new CLASS.thongtinBN();
            CLASS.thongtinSK sk = new CLASS.thongtinSK();
            bn.idBN = int.Parse(dtgDS_TT14.CurrentRow.Cells[0].Value.ToString());
            bn.hoten = txtHoten.Text;
            bn.gioitinh = cbGioitinh.Text;
            if (txtNamsinh.Text == string.Empty)
            {
                bn.namsinh = 0;
            }
            else { bn.namsinh = int.Parse(txtNamsinh.Text); }
            bn.cmnd = txtCMND.Text;
            bn.ngaycap = dtpNgaycap.Text;
            bn.diachi = txtDiachi.Text;
            bn.lydo = txtLydokham.Text;
            if (txtChieucao.Text == string.Empty)
            {
                sk.chieucao = 0;
            }
            else { sk.chieucao = int.Parse(txtChieucao.Text); }
            if (txtCannang.Text == string.Empty)
            {
                sk.cannang = 0;
            }
            else { sk.cannang = int.Parse(txtCannang.Text); }
            if (sk.cannang == 0 || sk.chieucao == 0)
            {
                sk.bmi = 0;
            }
            else
            {
                double FirstNumber = Convert.ToDouble(sk.chieucao);
                double second = Convert.ToDouble(sk.cannang);
                double BMI = second / ((FirstNumber / 100) * (FirstNumber / 100));
                int bmi = (int)BMI;
                sk.bmi = bmi;
            }

            if (txtMach.Text == string.Empty)
            {
                sk.mach = 0;
            }
            else { sk.mach = int.Parse(txtMach.Text); }

            sk.huyetap = txtHuyetap.Text;
            sk.pltl = cbPLTL.Text;
            sk.plsk = cbPLSK.Text;
            sk.benhkhac = txtBenhkhac.Text;
            sk.nguoiKL = txtNguoiKL.Text;
            sk.ngaykham = timenow;

            bool kq = BUS.BUS_TT14.SuaBN(bn, sk);
            if (kq == true)
            {
                MessageBox.Show("Cập nhật thành công!!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                getDSBN();
            }
            else
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSua.Enabled = true;
            }
        }

        //tinh tuoi
        private void txtCMND_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtNamsinh.Text != string.Empty)
            {
                int namsinh = int.Parse(txtNamsinh.Text);
                int namHientai = int.Parse(DateTime.Now.ToString("yyyy"));
                int tuoi = namHientai - namsinh;
                txtTuoi.Text = tuoi.ToString();
            }
            
        }

        private void txtNamsinh_Enter(object sender, EventArgs e)
        {
            if (txtNamsinh.Text != string.Empty)
            {
                int namsinh = int.Parse(txtNamsinh.Text);
                int namHientai = int.Parse(DateTime.Now.ToString("yyyy"));
                int tuoi = namHientai - namsinh;
                txtTuoi.Text = tuoi.ToString();
            }
        }

        //tinh bmi
        private void txtMach_MouseClick(object sender, MouseEventArgs e)
        {
           

           if (txtCannang.Text == string.Empty || txtChieucao.Text == string.Empty)
            {
                txtBMI.Text = "0";
            }
            else
            {
                double FirstNumber = Convert.ToDouble(txtChieucao.Text);
                double second = Convert.ToDouble(txtCannang.Text);
                double BMI = second / ((FirstNumber / 100) * (FirstNumber / 100));
                int bmi = (int)BMI;
                txtBMI.Text = Convert.ToString(bmi);
            }

        }
            

       /* //clear textbox
        private void btnMoi_Click(object sender, EventArgs e)
        {
            string timenow = DateTime.Now.ToString("dd-MM-yyyy");
            txtHoten.Text = "";
            cbGioitinh.SelectedIndex = 0;
            txtNamsinh.Text = "";
            txtTuoi.Text = "0";
            txtCMND.Text = "";
            dtpNgaycap.Value = DateTime.ParseExact(timenow, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            txtDiachi.Text = "";
            txtLydokham.Text = "";
            txtChieucao.Text = "";
            txtCannang.Text = "";
            txtBMI.Text = "";
            txtMach.Text = "";
            txtHuyetap.Text = "";
            cbPLTL.SelectedIndex = 0;
            cbPLSK.SelectedIndex = 0;
            txtBenhkhac.Text = "";
            txtNguoiKL.Text = "";
        }*/

        //định dang nhap so
        private void txtChieucao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtNamsinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCannang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void clear()
        {
            string timenow = DateTime.Now.ToString("dd-MM-yyyy");
            txtHoten.Text = "";
            cbGioitinh.SelectedIndex = 0;
            txtNamsinh.Text = "";
            txtTuoi.Text = "0";
            txtCMND.Text = "";
            dtpNgaycap.Value = DateTime.ParseExact(timenow, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            txtDiachi.Text = "";
            txtLydokham.Text = "";
            txtChieucao.Text = "";
            txtCannang.Text = "";
            txtBMI.Text = "";
            txtMach.Text = "";
            txtHuyetap.Text = "";
            cbPLTL.SelectedIndex = 0;
            cbPLSK.SelectedIndex = 0;
            txtBenhkhac.Text = "";
            txtNguoiKL.Text = "";
            errorProvider1.Clear();
            btnSua.Enabled = false;
        }
        private void btnMoi_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            themBN();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                suaBN();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            btnSua.Enabled = false;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            int idx = dtgDS_TT14.CurrentRow.Index;
            if (dtgDS_TT14.Rows[idx].Cells[0].Value.ToString() != "")
            {
                int idx_bm = int.Parse(dtgDS_TT14.CurrentRow.Cells[0].Value.ToString());

                DialogResult result = MessageBox.Show("Xác nhận xóa thông tin?!!!", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                if (result == DialogResult.Yes)
                {

                    bool kq_bm = BUS.BUS_TT14.xoaBN(idx_bm);
                    if (kq_bm == true)
                    {
                        try
                        {
                            MessageBox.Show("Đã xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getDSBN();
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); };
                    }
                    else { MessageBox.Show("Không thể xoá kết quả!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                }
            }
            else { MessageBox.Show("Lỗi! Vui long liên hệ IT!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void bntKetthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNamsinh_Enter_1(object sender, EventArgs e)
        {
            
        }

        private void txtCMND_Click(object sender, EventArgs e)
        {
            if (txtNamsinh.Text != string.Empty)
            {
                int parseNamsinh = int.Parse(txtNamsinh.Text);
                int namHientai = int.Parse(DateTime.Now.ToString("yyyy"));
                int tuoi = namHientai - parseNamsinh;
                txtTuoi.Text = tuoi.ToString();
            }
        }

        private void txtNamsinh_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (txtNamsinh.Text != string.Empty)
                {
                    int parseNamsinh = int.Parse(txtNamsinh.Text);
                    int namHientai = int.Parse(DateTime.Now.ToString("yyyy"));
                    int tuoi = namHientai - parseNamsinh;
                    txtTuoi.Text = tuoi.ToString();
                }
                this.SelectNextControl((Control)txtTuoi, true, true, true, true);
                
            }
        }
    }
}
