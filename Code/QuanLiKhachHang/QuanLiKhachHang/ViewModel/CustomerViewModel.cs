using QuanLiKhachHang.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLiKhachHang.ViewModel
{
   public class CustomerViewModel : BaseViewModel
    {
        private ObservableCollection<tblKhachHang> _KhachHangList;
        public ObservableCollection<tblKhachHang> KhachHangList { get => _KhachHangList; set { _KhachHangList = value; OnPropertyChanged(); } }

        private tblKhachHang _SelectedItem;
        public tblKhachHang SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    MaKH = SelectedItem.MaKH;
                    NgheNghiep = SelectedItem.NgheNghiep;
                    HoTen = SelectedItem.HoTen;
                    GioiTinh= SelectedItem.GioiTinh;
                    NamSinh= SelectedItem.NamSinh;
                    SDT= SelectedItem.SDT;
                    DiaChi= SelectedItem.DiaChi;
                    CMND = SelectedItem.CMND;
                    Email = SelectedItem.Email;
                }
            }
        }

        private string _HoTen;
        public string HoTen { get => _HoTen; set { _HoTen = value; OnPropertyChanged(); } }

        private string _CMND;
        public string CMND { get => _CMND; set { _CMND = value; OnPropertyChanged(); } }

        private DateTime? _NamSinh;
        public DateTime? NamSinh { get => _NamSinh; set { _NamSinh = value; OnPropertyChanged(); } }

        private DateTime? _NgayThamGia;
        public DateTime? NgayThamGia { get => _NgayThamGia; set { _NgayThamGia = value; OnPropertyChanged(); } }

        private string _GioiTinh;
        public string GioiTinh { get => _GioiTinh; set { _GioiTinh = value; OnPropertyChanged(); } }

        private string _SDT;
        public string SDT { get => _SDT; set { _SDT = value; OnPropertyChanged(); } }

        private string _NgheNghiep;
        public string NgheNghiep { get => _NgheNghiep; set { _NgheNghiep = value; OnPropertyChanged(); } }

        private string _Email;
        public string Email { get => _Email; set { _Email = value; OnPropertyChanged(); } }

        private string _DiaChi;
        public string DiaChi { get => _DiaChi; set { _DiaChi = value; OnPropertyChanged(); } }

        private string _LoaiKhachHang;
        public string LoaiKhachHang { get => _LoaiKhachHang; set { _LoaiKhachHang = value; OnPropertyChanged(); } }

        private int _MaKH;
        public int MaKH { get => _MaKH; set { _MaKH = value; OnPropertyChanged(); } }

        private int _DiemTichLuy;
        public int DiemTichLuy { get => _DiemTichLuy; set { _DiemTichLuy = value; OnPropertyChanged(); } }

        private int _DiemHienCo;
        public int DiemHienCo { get => _DiemHienCo; set { _DiemHienCo = value; OnPropertyChanged(); } }

        private string _Key;
        public string Key { get => _Key; set { _Key = value; OnPropertyChanged(); } }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand EditCommand1 { get; set; }
        public ICommand Scommand { get; set; }
        private List<String> _property;
        public List<String> Property
        {
            get => new List<string>() { "Nam", "Nữ" };
            set
            {
                _property = value;
                OnPropertyChanged();
            }

        }



        public void LoadDL()
        {
            KhachHangList = new ObservableCollection<tblKhachHang>(DataProvider.Ins.DB.tblKhachHang.OrderByDescending(x => x.MaKH).Where(x => x.TrangThai != "Đã Xóa"));

        }
        public CustomerViewModel()
        {
            LoadDL();
            Scommand = new RelayCommand<object>((p) =>
            {

                return true;

            }, (p) =>
            {

                KhachHangList = new ObservableCollection<tblKhachHang>(DataProvider.Ins.DB.tblKhachHang.OrderByDescending(x => x.MaKH).Where(x => x.TrangThai != "Đã Xóa" && x.HoTen.Contains(Key)));




                if (KhachHangList.Where(x=>x.HoTen.Contains(Key)).Count() != 0)
                {
                    KhachHangList = new ObservableCollection<tblKhachHang>(DataProvider.Ins.DB.tblKhachHang.OrderByDescending(x => x.MaKH).Where(x => x.TrangThai != "Đã Xóa" && x.HoTen.Contains(Key)));

                }
                else
                {
                    MessageBox.Show("Không có dữ liệu");
                    KhachHangList = new ObservableCollection<tblKhachHang>(DataProvider.Ins.DB.tblKhachHang.OrderByDescending(x => x.MaKH).Where(x => x.TrangThai != "Đã Xóa"));

                }

            });
            AddCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(MaKH.ToString()))
                    return false;

                var displayList = DataProvider.Ins.DB.tblKhachHang.Where(x => x.MaKH == MaKH);
                if (displayList == null || displayList.Count() != 0)
                    return false;

                return true;

            }, (p) =>
            {
                var khachHang = new tblKhachHang();
                khachHang.HoTen = HoTen;
                khachHang.NamSinh = NamSinh;
                khachHang.SDT = SDT;
                khachHang.CMND = CMND;
                khachHang.DiaChi = DiaChi;
                khachHang.NgayThamGia = DateTime.Now;
                khachHang.Email = Email;
                khachHang.GioiTinh = GioiTinh;
                khachHang.NgheNghiep = NgheNghiep;
                
                khachHang.TrangThai = "Hoạt Động";
                khachHang.DiemHienCo = 0;
                khachHang.DiemTichLuy = 0;
                khachHang.LoaiKhachHang = "Thân Thiết";
                DataProvider.Ins.DB.tblKhachHang.Add(khachHang);

                try
                {
                    DataProvider.Ins.DB.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    MessageBox.Show("Lỗi");
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                    
                }


                LoadDL();
                MessageBox.Show("Thêm khách hàng thành công!");
                SelectedItem = null;
                MaKH = 0;
                HoTen = null;
                SDT = null;
                CMND = null;
                DiaChi = null;
                Email = null;
                GioiTinh = null;
               
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.tblKhachHang.Where(x => x.MaKH == MaKH);
                if (displayList == null || displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var khachHang = DataProvider.Ins.DB.tblKhachHang.Where(x => x.MaKH == SelectedItem.MaKH).SingleOrDefault();
                khachHang.HoTen = HoTen;
                khachHang.NamSinh = NamSinh;
                khachHang.SDT = SDT;
                khachHang.CMND = CMND;
                khachHang.DiaChi = DiaChi;
                khachHang.Email = Email;
                khachHang.GioiTinh = GioiTinh;
                khachHang.NgheNghiep = NgheNghiep;
                DataProvider.Ins.DB.SaveChanges();
                
                SelectedItem.MaKH = MaKH;
                SelectedItem.HoTen = HoTen;
                SelectedItem.GioiTinh = GioiTinh;
                SelectedItem.NamSinh = NamSinh;
                SelectedItem.SDT = SDT;
                SelectedItem.DiaChi = DiaChi;
                SelectedItem.Email = Email;
                SelectedItem.CMND = CMND;
                SelectedItem.NgheNghiep = NgheNghiep;
                LoadDL();
                MessageBox.Show("Sửa khách hàng thành công!");
                SelectedItem = null;
                MaKH = 0;
                HoTen = null;
                SDT = null;
                CMND = null;
                DiaChi = null;
                Email = null;
                GioiTinh = null;
               
            });

            EditCommand1 = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.tblKhachHang.Where(x => x.MaKH == MaKH);
                if (displayList == null || displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var khachHang = DataProvider.Ins.DB.tblKhachHang.Where(x => x.MaKH == SelectedItem.MaKH).SingleOrDefault();
                khachHang.TrangThai = "Đã Xóa";

                DataProvider.Ins.DB.SaveChanges();

                SelectedItem.MaKH = MaKH;
                SelectedItem.HoTen = HoTen;
                SelectedItem.GioiTinh = GioiTinh;
                SelectedItem.NamSinh = NamSinh;
                SelectedItem.SDT = SDT;
                SelectedItem.DiaChi = DiaChi;
                SelectedItem.Email = Email;
                SelectedItem.CMND = CMND;
                SelectedItem.NgheNghiep = NgheNghiep;
                LoadDL();
                MessageBox.Show("Xóa khách hàng thành công!");
                SelectedItem = null;
                MaKH = 0;
                HoTen = null;
                SDT = null;
                CMND = null;
                DiaChi = null;
                Email = null;
                GioiTinh = null;
               
            });
        }
    }
}
