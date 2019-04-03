using QuanLiKhachHang.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLiKhachHang.ViewModel
{
    public class GiaoDichViewModel : BaseViewModel
    {
        private ObservableCollection<ListKHnew> _List;
        public ObservableCollection<ListKHnew> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<tblSanPhamGiaoDich> _ListGD;
        public ObservableCollection<tblSanPhamGiaoDich> ListGD { get => _ListGD; set { _ListGD = value; OnPropertyChanged(); } }

        private ObservableCollection<tblNhanVien> _ListNV;
        public ObservableCollection<tblNhanVien> ListNV { get { return _ListNV; } set { _ListNV = value; OnPropertyChanged(); } }

        private tblNhanVien _SNV;
        public tblNhanVien SNV { get { return _SNV; } set { _SNV = value; OnPropertyChanged(); } }

        private ObservableCollection<tblKhachHang> _ListKH;
        public ObservableCollection<tblKhachHang> ListKH { get => _ListKH; set { _ListKH = value; OnPropertyChanged(); } }


        private ListKHnew _SelectedItem;
        public ListKHnew SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    MaGD = SelectedItem.MaGD;
                }
            }
        }

        private tblSanPhamGiaoDich _SelectedItemSP;
        public tblSanPhamGiaoDich SelectedItemSP
        {
            get => _SelectedItemSP;
            set
            {
                _SelectedItemSP = value;
                OnPropertyChanged();
                if (SelectedItemSP != null)
                {
                    MaGDSP = SelectedItemSP.MaGD;

                    MaSP = SelectedItemSP.MaSP;

                    SoLuong = SelectedItemSP.SoLuong;
                }
            }
        }

        private int _MaSP;
        public int MaSP { get => _MaSP; set { _MaSP = value; OnPropertyChanged(); } }


        private int _MaKH;
        public int MaKH { get => _MaKH; set { _MaKH = value; OnPropertyChanged(); } }

        private string _TenKH;
        public string TenKH { get => _TenKH; set { _TenKH = value; OnPropertyChanged(); } }

        private string _TenNV;
        public string TenNV { get => _TenNV; set { _TenNV = value; OnPropertyChanged(); } }


        private int _MaGD;
        public int MaGD { get => _MaGD; set { _MaGD = value; OnPropertyChanged(); } }
        private int _MaGDSP;
        public int MaGDSP { get => _MaGDSP; set { _MaGDSP = value; OnPropertyChanged(); } }

        private int _MaNVGD;
        public int MaNVGD { get => _MaNVGD; set { _MaNVGD = value; OnPropertyChanged(); } }

        private DateTime _NgayGiaoDich;
        public DateTime NgayGiaoDich { get => _NgayGiaoDich; set { _NgayGiaoDich = value; OnPropertyChanged(); } }

        private int _TienThanhToan;
        public int TienThanhToan { get => _TienThanhToan; set { _TienThanhToan = value; OnPropertyChanged(); } }

        private int _TienGiam;
        public int TienGiam { get => _TienGiam; set { _TienGiam = value; OnPropertyChanged(); } }


        private int _DiemTichLuy;
        public int DiemTichLuy { get => _DiemTichLuy; set { _DiemTichLuy = value; OnPropertyChanged(); } }

        private int _DiemTru;
        public int DiemTru { get => _DiemTru; set { _DiemTru = value; OnPropertyChanged(); } }

        private int? _SoLuong;
        public int? SoLuong { get => _SoLuong; set { _SoLuong = value; OnPropertyChanged(); } }


        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public ICommand AddCommandSP { get; set; }
        public ICommand EditCommandSP { get; set; }
        public ICommand DeleteCommandSP { get; set; }
       

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
            var query = from g in DataProvider.Ins.DB.tblGiaoDich
                        where g.TrangThai != "Đã Xóa"
                        select new ListKHnew
                        {
                            MaGD = g.MaGD,
                            TenKH = g.tblKhachHang.HoTen,
                            TenNV = g.tblNhanVien.HoTen,
                            TienThanhToan = g.TienThanhToan,
                            TienGiam = g.TienGiam,
                            DiemTich = g.DiemTich,
                            DiemTru = g.DiemTru,
                            NgayGiaoDich= g.NgayGiaoDich
                        };

            
            List = new ObservableCollection<ListKHnew>(query);
            ListNV = new ObservableCollection<tblNhanVien>(DataProvider.Ins.DB.tblNhanVien.OrderByDescending(x => x.MaNV));
            ListGD = new ObservableCollection<tblSanPhamGiaoDich>(DataProvider.Ins.DB.tblSanPhamGiaoDich.OrderByDescending(x=>x.MaGD));
        }
        public GiaoDichViewModel()
        {

            LoadDL();

            AddCommandSP = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(MaGD.ToString()))
                    return false;

                var displayList = DataProvider.Ins.DB.tblSanPhamGiaoDich.Where(x => x.MaGD == MaGD);
                if (displayList == null || displayList.Count() != 0)
                    return true;

                return true;

            }, (p) =>
            {
                var sp = new tblSanPhamGiaoDich();
                sp.MaGD = MaGD;
                sp.MaSP = MaSP;
                sp.SoLuong = SoLuong;

                DataProvider.Ins.DB.tblSanPhamGiaoDich.Add(sp);
                DataProvider.Ins.DB.SaveChanges();
                LoadDL();
                MessageBox.Show("Thêm sản phẩm vào giao dịch thành công!");
            });

            AddCommand = new RelayCommand<object>((p) =>
            {
                if (string.IsNullOrEmpty(MaGD.ToString()))
                    return false;

                var displayList = DataProvider.Ins.DB.tblGiaoDich.Where(x => x.MaGD == MaGD);
                if (displayList == null || displayList.Count() != 0)
                    return false;

                return true;

            }, (p) =>
            {
                
            });

            EditCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.tblGiaoDich.Where(x => x.MaGD == MaGD);
                if (displayList == null || displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                
            });

            DeleteCommand = new RelayCommand<object>((p) =>
            {
                if (SelectedItem == null)
                    return false;

                var displayList = DataProvider.Ins.DB.tblGiaoDich.Where(x => x.MaGD == MaGD);
                if (displayList == null || displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                
            });
        }
        public bool sn(DateTime n1, DateTime n2)
        {
            if (n1.Day == n2.Day && n1.Month == n2.Month)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
    public class ListKHnew
    {
        public int MaGD { get; set; }
        public string TenKH { get; set; }
        public string TenNV { get; set; }
        public int? TienThanhToan { get; set; }
        public int? TienGiam { get; set; }
        public int? DiemTich { get; set; }
        public int MaKH { get; set; }
        public int MaNV { get; set; }
        public int? DiemTru { get; set; }
        public DateTime? NgayGiaoDich { get; set; }
    }
}
