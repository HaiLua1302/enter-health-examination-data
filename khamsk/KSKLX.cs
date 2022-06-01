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
    public partial class KSKLX : Form
    {
        public KSKLX()
        {
            InitializeComponent();
        }

        private void KSKLX_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            formatDate();
            disBtn();
            setDataCB();
            getDSBNLX();
            complete();
        }
        //autocomplete
        private void complete()
        {
            autoCompleteData_morphin();
            autoCompleteData_amphe();
            autoCompleteData_metham();
            autoCompleteData_cansa();
            autoCompleteData_nongdocon();
            autoCompleteData_ketluan();
            autoCompleteData_nguoiKL();
            autoCompleteData_LydoLX();

        }
        //disable button
        private void disBtn()
        {
            btnSuaLX.Enabled = false;
            btnXoaLX.Enabled = false;
        }
        //set data mac dinh
        private void setDataCB()
        {
            cbGioitinhLX.Items.Add("Nam");
            cbGioitinhLX.Items.Add("Nữ");
            cbGioitinhLX.SelectedIndex = 0;
        }

        //format ngay thang
        private void formatDate()
        {
            dtpNgaycapLX.Format = DateTimePickerFormat.Custom;
            dtpNgaycapLX.CustomFormat = "dd-MM-yyyy";

        }
        //auto completedata
        private void autoCompleteData_LydoLX()
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
            txtLydokhamLX.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //Set AutoCompleteMode property of txt_StateName as SuggestAppend. SuggestAppend Applies both Suggest and Append
            txtLydokhamLX.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtLydokhamLX.AutoCompleteCustomSource = autoCompleteCollection;
            con.Close();
        }
        private void autoCompleteData_morphin()
        {
            SqlConnection con = new SqlConnection(DB.getDB._connectionString);
            SqlCommand com = new SqlCommand("Select morphin from xetnghiem", con);
            con.Open();
            SqlDataReader rdr = com.ExecuteReader();
            //AutoCompleteStringCollection Contains a collection of strings to use for the auto-complete feature on certain Windows Forms controls.
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            while (rdr.Read())
            {
                autoCompleteCollection.Add(rdr.GetString(0));
            }
            //Set AutoCompleteSource property of txt_StateName as CustomSource
            txtMorphin.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //Set AutoCompleteMode property of txt_StateName as SuggestAppend. SuggestAppend Applies both Suggest and Append
            txtMorphin.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMorphin.AutoCompleteCustomSource = autoCompleteCollection;
            con.Close();
        }
        private void autoCompleteData_amphe()
        {
            SqlConnection con = new SqlConnection(DB.getDB._connectionString);
            SqlCommand com = new SqlCommand("Select amphe from xetnghiem", con);
            con.Open();
            SqlDataReader rdr = com.ExecuteReader();
            //AutoCompleteStringCollection Contains a collection of strings to use for the auto-complete feature on certain Windows Forms controls.
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            while (rdr.Read())
            {
                autoCompleteCollection.Add(rdr.GetString(0));
            }
            //Set AutoCompleteSource property of txt_StateName as CustomSource
            txtAmphe.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //Set AutoCompleteMode property of txt_StateName as SuggestAppend. SuggestAppend Applies both Suggest and Append
            txtAmphe.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtAmphe.AutoCompleteCustomSource = autoCompleteCollection;
            con.Close();
        }
        private void autoCompleteData_metham()
        {
            SqlConnection con = new SqlConnection(DB.getDB._connectionString);
            SqlCommand com = new SqlCommand("Select metham from xetnghiem", con);
            con.Open();
            SqlDataReader rdr = com.ExecuteReader();
            //AutoCompleteStringCollection Contains a collection of strings to use for the auto-complete feature on certain Windows Forms controls.
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            while (rdr.Read())
            {
                autoCompleteCollection.Add(rdr.GetString(0));
            }
            //Set AutoCompleteSource property of txt_StateName as CustomSource
            txtMetham.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //Set AutoCompleteMode property of txt_StateName as SuggestAppend. SuggestAppend Applies both Suggest and Append
            txtMetham.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMetham.AutoCompleteCustomSource = autoCompleteCollection;
            con.Close();
        }
        private void autoCompleteData_cansa()
        {
            SqlConnection con = new SqlConnection(DB.getDB._connectionString);
            SqlCommand com = new SqlCommand("Select cansa from xetnghiem", con);
            con.Open();
            SqlDataReader rdr = com.ExecuteReader();
            //AutoCompleteStringCollection Contains a collection of strings to use for the auto-complete feature on certain Windows Forms controls.
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            while (rdr.Read())
            {
                autoCompleteCollection.Add(rdr.GetString(0));
            }
            //Set AutoCompleteSource property of txt_StateName as CustomSource
            txtCansa.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //Set AutoCompleteMode property of txt_StateName as SuggestAppend. SuggestAppend Applies both Suggest and Append
            txtCansa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCansa.AutoCompleteCustomSource = autoCompleteCollection;
            con.Close();
        }
        private void autoCompleteData_nongdocon()
        {
            SqlConnection con = new SqlConnection(DB.getDB._connectionString);
            SqlCommand com = new SqlCommand("Select nongdocon from xetnghiem", con);
            con.Open();
            SqlDataReader rdr = com.ExecuteReader();
            //AutoCompleteStringCollection Contains a collection of strings to use for the auto-complete feature on certain Windows Forms controls.
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            while (rdr.Read())
            {
                autoCompleteCollection.Add(rdr.GetString(0));
            }
            //Set AutoCompleteSource property of txt_StateName as CustomSource
            txtNongdocon.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //Set AutoCompleteMode property of txt_StateName as SuggestAppend. SuggestAppend Applies both Suggest and Append
            txtNongdocon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNongdocon.AutoCompleteCustomSource = autoCompleteCollection;
            con.Close();
        }
        private void autoCompleteData_ketluan()
        {
            SqlConnection con = new SqlConnection(DB.getDB._connectionString);
            SqlCommand com = new SqlCommand("Select ketluan from xetnghiem", con);
            con.Open();
            SqlDataReader rdr = com.ExecuteReader();
            //AutoCompleteStringCollection Contains a collection of strings to use for the auto-complete feature on certain Windows Forms controls.
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            while (rdr.Read())
            {
                autoCompleteCollection.Add(rdr.GetString(0));
            }
            //Set AutoCompleteSource property of txt_StateName as CustomSource
            txtKetluanLX.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //Set AutoCompleteMode property of txt_StateName as SuggestAppend. SuggestAppend Applies both Suggest and Append
            txtKetluanLX.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtKetluanLX.AutoCompleteCustomSource = autoCompleteCollection;
            con.Close();
        }
        private void autoCompleteData_nguoiKL()
        {
            SqlConnection con = new SqlConnection(DB.getDB._connectionString);
            SqlCommand com = new SqlCommand("Select nguoiKL from xetnghiem", con);
            con.Open();
            SqlDataReader rdr = com.ExecuteReader();
            //AutoCompleteStringCollection Contains a collection of strings to use for the auto-complete feature on certain Windows Forms controls.
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            while (rdr.Read())
            {
                autoCompleteCollection.Add(rdr.GetString(0));
            }
            //Set AutoCompleteSource property of txt_StateName as CustomSource
            txtNguoiKLLX.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //Set AutoCompleteMode property of txt_StateName as SuggestAppend. SuggestAppend Applies both Suggest and Append
            txtNguoiKLLX.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNguoiKLLX.AutoCompleteCustomSource = autoCompleteCollection;
            con.Close();
        }

        //nut moi
        private void btnMoiLX_Click(object sender, EventArgs e)
        {
            clearBN();
        }
        private void btnThemLX_Click(object sender, EventArgs e)
        {
            themBN();
        }

        private void btnSuaLX_Click(object sender, EventArgs e)
        {
            try
            {
                suaBN();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            btnSuaLX.Enabled = false;
        }

        private void bntKetthucLX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLayDSLX_Click(object sender, EventArgs e)
        {
            getDSBNLX();
        }

        private void btnXoaLX_Click(object sender, EventArgs e)
        {
            xoaBN();
        }
        //get ds
        private void getDSBNLX()
        {
            try
            {
                DataTable _dskq = BUS.BUS_KSKLX.getDS_KSKLX();
                dtgDS_KSKLX.DataSource = _dskq;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //clear
        private void clearBN()
        {
            string timenow = DateTime.Now.ToString("dd-MM-yyyy");
            txtHotenLX.Text = "";
            cbGioitinhLX.SelectedIndex = 0;
            txtNamsinhLX.Text = "";
            txtTuoiLX.Text = "0";
            txtCMNDLX.Text = "";
            dtpNgaycapLX.Value = DateTime.ParseExact(timenow, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            txtDiachiLX.Text = "";
            txtLydokhamLX.Text = "";
            txtMorphin.Text = "";
            txtAmphe.Text = "";
            txtMetham.Text = "";
            txtCansa.Text = "";
            txtNongdocon.Text = "";
            txtKetluanLX.Text = "";
            txtNguoiKLLX.Text = "";
            errorProvider2.Clear();
            btnSuaLX.Enabled = false;
        }
        //them benh nhan
        private void themBN()
        {
            if (txtHotenLX.Text == string.Empty)
            {
                errorProvider2.SetError(txtHotenLX, "Nhập họ tên!!!");
            }
            else if (txtNamsinhLX.Text != string.Empty)
            {
                if (txtNamsinhLX.Text.Length != 4)
                {
                    errorProvider2.SetError(txtNamsinhLX, "Năm sinh không hợp lệ!!!");
                }
                else
                {
                    string timenow = DateTime.Now.ToString("dd-MM-yyyy");
                    CLASS.thongtinBN bn = new CLASS.thongtinBN();
                    CLASS.thongtinXN xn = new CLASS.thongtinXN();
                    bn.hoten = txtHotenLX.Text;
                    bn.gioitinh = cbGioitinhLX.Text;
                    if (txtNamsinhLX.Text == string.Empty)
                    {
                        bn.namsinh = 0;
                    }
                    else { bn.namsinh = int.Parse(txtNamsinhLX.Text); }
                    bn.cmnd = txtCMNDLX.Text;
                    bn.ngaycap = dtpNgaycapLX.Text;
                    bn.diachi = txtDiachiLX.Text;
                    bn.lydo = txtLydokhamLX.Text;
                    if (txtMorphin.Text == string.Empty)
                    {
                        xn.morphin = "";
                    }
                    else { xn.morphin = txtMorphin.Text; }

                    if (txtAmphe.Text == string.Empty)
                    {
                        xn.amphe = "";
                    }
                    else { xn.amphe = txtAmphe.Text; }

                    if (txtMetham.Text == string.Empty)
                    {
                        xn.metham = "";
                    }
                    else { xn.metham = txtMetham.Text; }

                    if (txtCansa.Text == string.Empty)
                    {
                        xn.cansa = "";
                    }
                    else { xn.cansa = txtCansa.Text; }

                    if (txtNongdocon.Text == string.Empty)
                    {
                        xn.nongdocon = "";
                    }
                    else { xn.nongdocon = txtNongdocon.Text; }

                    if (txtKetluanLX.Text == string.Empty)
                    {
                        xn.ketluan = "";
                    }
                    else { xn.ketluan = txtKetluanLX.Text; }

                    if (txtNguoiKLLX.Text == string.Empty)
                    {
                        xn.nguoiKL = "";
                    }
                    else { xn.nguoiKL = txtNguoiKLLX.Text; }

                    xn.ngaykham = timenow;
                    try
                    {
                        bool kq = BUS.BUS_KSKLX.ThemBNLX(bn, xn);
                        if (kq == true)
                        {
                            MessageBox.Show("Thêm thành công!!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            getDSBNLX();
                            clearBN();
                        }
                        else
                        {
                            MessageBox.Show("Thêm dữ liệu thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); };
                   

                }

            }

        }

        //xoa bn
        private void xoaBN()
        {
            int idx = dtgDS_KSKLX.CurrentRow.Index;
            try {  
                if (dtgDS_KSKLX.Rows[idx].Cells[0].Value.ToString() != "")
                {
                    int idx_bm = int.Parse(dtgDS_KSKLX.CurrentRow.Cells[0].Value.ToString());

                    DialogResult result = MessageBox.Show("Xác nhận xóa thông tin?!!!", "Cảnh Báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    if (result == DialogResult.Yes)
                    {

                        bool kq_bm = BUS.BUS_KSKLX.xoaBNLX(idx_bm);
                        if (kq_bm == true)
                        {
                            try
                            {
                                MessageBox.Show("Đã xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                getDSBNLX();
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); };
                        }
                        else { MessageBox.Show("Không thể xoá kết quả!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                    }
                }
                else { MessageBox.Show("Lỗi! Vui long liên hệ IT!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            
        }

        //suabn
        private void suaBN()
        {
            if (txtHotenLX.Text == string.Empty)
            {
                errorProvider2.SetError(txtHotenLX, "Nhập họ tên!!!");
            }
            else if (txtNamsinhLX.Text != string.Empty)
            {
                if (txtNamsinhLX.Text.Length != 4)
                {
                    errorProvider2.SetError(txtNamsinhLX, "Năm sinh không hợp lệ!!!");
                }
                else
                {
                    string timenow = DateTime.Now.ToString("dd-MM-yyyy");
                    CLASS.thongtinBN bn = new CLASS.thongtinBN();
                    CLASS.thongtinXN xn = new CLASS.thongtinXN();
                    bn.idBN = int.Parse(dtgDS_KSKLX.CurrentRow.Cells[0].Value.ToString());
                    bn.hoten = txtHotenLX.Text;
                    bn.gioitinh = cbGioitinhLX.Text;
                    if (txtNamsinhLX.Text == string.Empty)
                    {
                        bn.namsinh = 0;
                    }
                    else { bn.namsinh = int.Parse(txtNamsinhLX.Text); }
                    bn.cmnd = txtCMNDLX.Text;
                    bn.ngaycap = dtpNgaycapLX.Text;
                    bn.diachi = txtDiachiLX.Text;
                    bn.lydo = txtLydokhamLX.Text;
                    if (txtMorphin.Text == string.Empty)
                    {
                        xn.morphin = "";
                    }
                    else { xn.morphin = txtMorphin.Text; }

                    if (txtAmphe.Text == string.Empty)
                    {
                        xn.amphe = "";
                    }
                    else { xn.amphe = txtAmphe.Text; }

                    if (txtMetham.Text == string.Empty)
                    {
                        xn.metham = "";
                    }
                    else { xn.metham = txtMetham.Text; }

                    if (txtCansa.Text == string.Empty)
                    {
                        xn.cansa = "";
                    }
                    else { xn.cansa = txtCansa.Text; }

                    if (txtNongdocon.Text == string.Empty)
                    {
                        xn.nongdocon = "";
                    }
                    else { xn.nongdocon = txtNongdocon.Text; }

                    if (txtKetluanLX.Text == string.Empty)
                    {
                        xn.ketluan = "";
                    }
                    else { xn.ketluan = txtKetluanLX.Text; }

                    if (txtNguoiKLLX.Text == string.Empty)
                    {
                        xn.nguoiKL = "";
                    }
                    else { xn.nguoiKL = txtNguoiKLLX.Text; }
                    xn.ngaykham = timenow;
                    bool kq = BUS.BUS_KSKLX.ThemBNLX(bn, xn);
                    if (kq == true)
                    {
                        MessageBox.Show("Cập nhật thành công!!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearBN();
                        getDSBNLX();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

        //getdata from datafridview
        private void getdata_datagridview()
        {
            string hoten = dtgDS_KSKLX.CurrentRow.Cells[1].Value.ToString();
            string gioitinh = dtgDS_KSKLX.CurrentRow.Cells[2].Value.ToString();
            string namsinh = dtgDS_KSKLX.CurrentRow.Cells[3].Value.ToString();
            string cmnd = dtgDS_KSKLX.CurrentRow.Cells[4].Value.ToString();
            string ngaycap = dtgDS_KSKLX.CurrentRow.Cells[5].Value.ToString();
            string diachi = dtgDS_KSKLX.CurrentRow.Cells[6].Value.ToString();
            string lydo = dtgDS_KSKLX.CurrentRow.Cells[7].Value.ToString();
            string morphin = dtgDS_KSKLX.CurrentRow.Cells[8].Value.ToString();           
            string amphe = dtgDS_KSKLX.CurrentRow.Cells[9].Value.ToString();           
            string metham = dtgDS_KSKLX.CurrentRow.Cells[10].Value.ToString();           
            string cansa = dtgDS_KSKLX.CurrentRow.Cells[11].Value.ToString();           
            string nongdocon = dtgDS_KSKLX.CurrentRow.Cells[12].Value.ToString();           
            string ketluan = dtgDS_KSKLX.CurrentRow.Cells[13].Value.ToString();           
            string nguoiKL = dtgDS_KSKLX.CurrentRow.Cells[14].Value.ToString();           

            txtHotenLX.Text = hoten;
            if (gioitinh == "Nam")
            {
                cbGioitinhLX.SelectedIndex = 0;
            }
            else { cbGioitinhLX.SelectedIndex = 1; }
            txtNamsinhLX.Text = namsinh;
            if (namsinh != string.Empty)
            {
                int parseNamsinh = int.Parse(namsinh);
                int namHientai = int.Parse(DateTime.Now.ToString("yyyy"));
                int tuoi = namHientai - parseNamsinh;
                txtTuoiLX.Text = tuoi.ToString();
            }
            txtCMNDLX.Text = cmnd;
            dtpNgaycapLX.Value = DateTime.ParseExact(ngaycap, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            txtDiachiLX.Text = diachi;
            txtLydokhamLX.Text = lydo;
            txtMorphin.Text = morphin;
            txtAmphe.Text = amphe;
            txtMetham.Text = metham;
            txtCansa.Text = cansa;
            txtNongdocon.Text = nongdocon;
            txtKetluanLX.Text = ketluan;
            txtNguoiKLLX.Text = nguoiKL;

            tabCrlTT14LX.SelectedIndex = 0;
            btnSuaLX.Enabled = true;

        }
        private void dtgDS_KSKLX_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try { getdata_datagridview(); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); };
        }

        private void dtgDS_KSKLX_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dtgDS_KSKLX.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                dtgDS_KSKLX.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void dtgDS_KSKLX_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dtgDS_KSKLX.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 193);
                dtgDS_KSKLX.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void txtNamsinhLX_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCMNDLX_Click(object sender, EventArgs e)
        {
            if (txtNamsinhLX.Text != string.Empty)
            {
                int parseNamsinh = int.Parse(txtNamsinhLX.Text);
                int namHientai = int.Parse(DateTime.Now.ToString("yyyy"));
                int tuoi = namHientai - parseNamsinh;
                txtTuoiLX.Text = tuoi.ToString();
            }
        }

        private void txtNamsinhLX_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (txtNamsinhLX.Text != string.Empty)
                {
                    int parseNamsinh = int.Parse(txtNamsinhLX.Text);
                    int namHientai = int.Parse(DateTime.Now.ToString("yyyy"));
                    int tuoi = namHientai - parseNamsinh;
                    txtTuoiLX.Text = tuoi.ToString();
                }
                this.SelectNextControl((Control)txtTuoiLX, true, true, true, true);

            }
        }
    }
}
