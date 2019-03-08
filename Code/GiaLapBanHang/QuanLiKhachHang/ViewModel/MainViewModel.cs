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
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<ListKHnew> _List;
        public ObservableCollection<ListKHnew> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<tblSanPhamGiaoDich> _ListGD;
        public ObservableCollection<tblSanPhamGiaoDich> ListGD { get => _ListGD; set { _ListGD = value; OnPropertyChanged(); } }

     
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

                    NgayGiaoDich = SelectedItem.NgayGiaoDich;
                    DiemTichLuy = SelectedItem.DiemTich;
                    MaKH = SelectedItem.MaKH;
                    MaNVGD = SelectedItem.MaNV;
                    TienThanhToan = DataProvider.Ins.DB.tblSanPhamGiaoDich.Where(y=>y.MaGD == SelectedItem.MaGD).Sum(x => x.TongTien);
                    TienTra = SelectedItem.TienGiam;
                    DiemTru = SelectedItem.DiemTru;

                    ListGD = new ObservableCollection<tblSanPhamGiaoDich>(DataProvider.Ins.DB.tblSanPhamGiaoDich.OrderByDescending(x => x.MaGD).Where(y => y.MaGD == SelectedItem.MaGD));

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

        private DateTime? _NgayGiaoDich;
        public DateTime? NgayGiaoDich { get => _NgayGiaoDich; set { _NgayGiaoDich = value; OnPropertyChanged(); } }

        private int? _TienThanhToan;
        public int? TienThanhToan { get => _TienThanhToan; set { _TienThanhToan = value; OnPropertyChanged(); } }

        private int _TienTra;
        public int TienTra { get => _TienTra; set { _TienTra = value; OnPropertyChanged(); } }


        private int _DiemTichLuy;
        public int DiemTichLuy { get => _DiemTichLuy; set { _DiemTichLuy = value; OnPropertyChanged(); } }

        private int _DiemTru;
        public int DiemTru { get => _DiemTru; set { _DiemTru = value; OnPropertyChanged(); } }

        private int? _SoLuong;
        public int? SoLuong { get => _SoLuong; set { _SoLuong = value; OnPropertyChanged(); } }

        private int? _DonGia;
        public int? DonGia { get => _DonGia; set { _DonGia = value; OnPropertyChanged(); } }


        public ICommand LoadedWindowCommand { get; set; }
        public bool Isloaded = false;

        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public ICommand AddCommandSP { get; set; }
        public ICommand EditCommandSP { get; set; }
        public ICommand DeleteCommandSP { get; set; }


        public void LoadDL()
        {
            var query = from g in DataProvider.Ins.DB.tblGiaoDich
                        where g.TrangThai != "Đã Xóa"
                        select new ListKHnew
                        {
                            MaGD = g.MaGD,
                            TenKH = g.tblKhachHang.HoTen,
                            TenNV = g.tblNhanVien.HoTen,
                            NgayGiaoDich = g.NgayGiaoDich
                        };


            List = new ObservableCollection<ListKHnew>(query);
            
        }


        public MainViewModel()
        {
            NgayGiaoDich = DateTime.Now;
            LoadedWindowCommand = new RelayCommand<Window>((p) => { return true; }, (p) => {
                Isloaded = true;
                if (p == null)
                    return;
                p.Hide();
                LoginForm loginWindow = new LoginForm();
                loginWindow.ShowDialog();

                if (loginWindow.DataContext == null)
                    return;
                var loginVM = loginWindow.DataContext as LoginViewModel;

                if (loginVM.IsLogin)
                {
                    p.Show();
                    LoadDL();

                }
                else
                {
                    p.Close();
                }
            }
              );
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
                DonGia = DataProvider.Ins.DB.tblSanPham.Where(x => x.MaSP == sp.MaSP).Select(y => y.DonGia).FirstOrDefault();
                //Application.Current.Properties["MaGD"] = MaGD;
                sp.TongTien = sp.SoLuong * DonGia;
                DataProvider.Ins.DB.tblSanPhamGiaoDich.Add(sp);

                DataProvider.Ins.DB.SaveChanges();
                TienThanhToan = DataProvider.Ins.DB.tblSanPhamGiaoDich.Where(y => y.MaGD == MaGD).Sum(x => x.TongTien);
              ListGD = new ObservableCollection<tblSanPhamGiaoDich>(DataProvider.Ins.DB.tblSanPhamGiaoDich.OrderByDescending(x => x.MaGD).Where(y => y.MaGD == MaGD));
                var gd = DataProvider.Ins.DB.tblGiaoDich.Where(y => y.MaGD == MaGD).FirstOrDefault();
                gd.TienThanhToan = TienThanhToan;
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
                    return true;

                return true;

            }, (p) =>
            {
                var giaodich = new tblGiaoDich();
                giaodich.MaKH = MaKH;
                giaodich.MaNV = Convert.ToInt32(Application.Current.Properties["NameStaff"]);
                
                giaodich.TrangThai = "Hoạt Động";
               

                giaodich.NgayGiaoDich = DateTime.Now;

                DataProvider.Ins.DB.tblGiaoDich.Add(giaodich);

                try
                {
                    DataProvider.Ins.DB.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
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



               
                
                DataProvider.Ins.DB.SaveChanges();
                LoadDL();
                MessageBox.Show("Thêm giao dịch thành công!");
                SelectedItem = null;
                TienThanhToan = 0;
                MaNVGD = 0;
                MaGD = 0;
                MaKH = 0;
                TienTra = 0;
                DiemTru = 0;
                DiemTichLuy = 0;
                NgayGiaoDich = DateTime.Now;
            });


            EditCommandSP = new RelayCommand<object>((p) =>
            {
                if (SelectedItemSP == null)
                    return false;

                var displayList = DataProvider.Ins.DB.tblSanPhamGiaoDich.Where(x => x.MaGD == MaGDSP);
                if (displayList == null || displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var sp = DataProvider.Ins.DB.tblSanPhamGiaoDich.Where(x => x.MaSP == SelectedItemSP.MaSP).FirstOrDefault();
                sp.MaGD = SelectedItemSP.MaGD;
                sp.MaSP = MaSP;
                sp.SoLuong = SoLuong;
                DonGia = DataProvider.Ins.DB.tblSanPham.Where(x => x.MaSP == sp.MaSP).Select(y => y.DonGia).FirstOrDefault();
                sp.TongTien = sp.SoLuong * DonGia;


                DataProvider.Ins.DB.SaveChanges();
                SelectedItemSP.MaGD = MaGDSP;
                SelectedItemSP.MaSP = MaSP;
                SelectedItemSP.SoLuong = SoLuong;


                TienThanhToan = DataProvider.Ins.DB.tblSanPhamGiaoDich.Where(y => y.MaGD == MaGD).Sum(x => x.TongTien);
                var gd = DataProvider.Ins.DB.tblGiaoDich.Where(y => y.MaGD == MaGD).FirstOrDefault();
                gd.TienThanhToan = TienThanhToan;
                DataProvider.Ins.DB.SaveChanges();


                ListGD = new ObservableCollection<tblSanPhamGiaoDich>(DataProvider.Ins.DB.tblSanPhamGiaoDich.OrderByDescending(x => x.MaGD).Where(y => y.MaGD == MaGDSP));

                LoadDL();
                MessageBox.Show("Sửa sản phẩm vào giao dịch thành công!");
                MaSP = 0;
                SoLuong = 0;
            });

        DeleteCommandSP = new RelayCommand<object>((p) =>
            {
                if (SelectedItemSP == null)
                    return false;

                var displayList = DataProvider.Ins.DB.tblSanPhamGiaoDich.Where(x => x.MaGD == MaGD);
                if (displayList == null || displayList.Count() != 0)
                    return true;

                return false;

            }, (p) =>
            {
                var giaodich = DataProvider.Ins.DB.tblSanPhamGiaoDich.Where(x => x.MaSP == SelectedItemSP.MaSP).FirstOrDefault();
                DataProvider.Ins.DB.tblSanPhamGiaoDich.Remove(giaodich);

                DataProvider.Ins.DB.SaveChanges();
                SelectedItemSP.MaGD = MaGDSP;
                SelectedItemSP.MaSP = MaSP;
                SelectedItemSP.SoLuong = SoLuong;

                LoadDL();
                ListGD = new ObservableCollection<tblSanPhamGiaoDich>(DataProvider.Ins.DB.tblSanPhamGiaoDich.OrderByDescending(x => x.MaGD).Where(y => y.MaGD == MaGDSP));

                MessageBox.Show("Bỏ sản phẩm thành công!");
                MaSP = 0;
                SoLuong = 0;
                
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
                var giaodich = DataProvider.Ins.DB.tblGiaoDich.Where(x => x.MaGD == SelectedItem.MaGD).SingleOrDefault();
                giaodich.TrangThai = "Đã Xóa";

                DataProvider.Ins.DB.SaveChanges();
                SelectedItem.MaGD = MaGD;
                SelectedItem.MaKH = MaKH;
                SelectedItem.MaNV = MaNVGD;
                SelectedItem.TienGiam = TienTra;
                SelectedItem.DiemTich = DiemTichLuy;
                SelectedItem.DiemTru = DiemTru;
                SelectedItem.NgayGiaoDich = NgayGiaoDich;

                LoadDL();
                MessageBox.Show("Xóa giao dịch thành công!");
                SelectedItem = null;
                TienThanhToan = 0;
                MaNVGD = 0;
                MaGD = 0;
                MaKH = 0;
                TienTra = 0;
                DiemTru = 0;
                DiemTichLuy = 0;
                NgayGiaoDich = DateTime.Now;
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

    public class SPnew
    {
        public int? TongTien { get; set; }
        public int MaGD { get;  set; }
    }

    public class ListKHnew
    {
        public int MaGD { get; set; }
        public string TenKH { get; set; }
        public string TenNV { get; set; }
        public int TienThanhToan { get; set; }
        public int TienGiam { get; set; }
        public int DiemTich { get; set; }
        public int MaKH { get; set; }
        public int MaNV { get; set; }
        public int DiemTru { get; set; }
        public DateTime? NgayGiaoDich { get; set; }
    }

}
