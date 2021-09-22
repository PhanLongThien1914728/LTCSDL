using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_QuanLyThongTin
{
    public partial class frmThongTinSV : Form
    {
        QuanLySinhVien qlsv;
        public frmThongTinSV()
        {
            InitializeComponent();
        }
        private void frmThongTinSV_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.MaSo = this.mtxtbMSSV.Text;
            sv.HoTen = this.txtHoTen.Text;
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.Lop = this.cbbLop.Text;
            sv.SĐT = this.mtxtbSĐT.Text;
            sv.Email = this.txtEmail.Text;
            sv.Diachi = this.txtDiaChi.Text;
            sv.Hinh = this.txtHinh.Text;

            return sv;
        }
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[2].Text == "Nam")
                sv.GioiTinh = true;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.Lop = lvitem.SubItems[4].Text;
            sv.SĐT = lvitem.SubItems[5].Text;
            sv.Email = lvitem.SubItems[6].Text;
            sv.Diachi = lvitem.SubItems[7].Text;
            sv.Hinh = lvitem.SubItems[8].Text;
            return sv;

        }
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtbMSSV.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            if (sv.GioiTinh) rdNam.Checked = true;
            else rdNu.Checked = true;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.cbbLop.Text = sv.Lop;
            this.mtxtbSĐT.Text = sv.SĐT;
            this.txtEmail.Text = sv.Email;
            this.txtDiaChi.Text = sv.Diachi;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation = sv.Hinh;
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HoTen);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.SĐT);
            lvitem.SubItems.Add(sv.Email);
            lvitem.SubItems.Add(sv.Diachi);
            lvitem.SubItems.Add(sv.Hinh);
            this.lvDSSV.Items.Add(lvitem);
        }
        private void LoadListView()
        {
            this.lvDSSV.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open File Image";
            dlg.Filter = "Image Files (*.bmp;*.jpg;*.png)|" + "*.bmp;*.jpg;*png|;" + "All files (*.*)|*.*";


            dlg.InitialDirectory = Environment.CurrentDirectory;
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                var fileName = dlg.FileName;
                txtHinh.Text = fileName;
                pbHinh.Load(fileName);
            }    
        }
        
        

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtbMSSV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = "";
            this.cbbLop.Text = this.cbbLop.Items[0].ToString();
            this.txtHinh.Text = "";
            this.pbHinh.ImageLocation = "";
            this.rdNu.Checked = true;
            this.txtEmail.Text = "";
            this.mtxtbSĐT.Text = "";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn lưu danh sách hay không ?", "Thông báo", MessageBoxButtons.YesNoCancel);
            if (dlr == DialogResult.Yes)
            {
                SinhVien sv = GetSinhVien();
                SinhVien kq = qlsv.Tim(sv.MaSo, delegate (object obj1, object obj2)
                {
                    return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
                });
                this.qlsv.Them(sv);
                this.LoadListView();
                MessageBox.Show("Danh sách đã được lưu");
            }
            else
            { Application.Exit(); }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MaSo, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
            });
            if (kq != null)
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
            }
        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvDSSV.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvDSSV.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }
        
        
       

        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MaSo.CompareTo(obj1);

        }

        private void lvDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvDSSV.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvDSSV.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

       
    }
}
