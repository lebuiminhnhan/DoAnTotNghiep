﻿using QuanLiKhachHang.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace QuanLiKhachHang.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<ListKHnew> _List;
        public ObservableCollection<ListKHnew> List { get => _List; set { _List = value; OnPropertyChanged(); } }

        private ObservableCollection<tblSanPhamGiaoDich> _ListGD;
        public ObservableCollection<tblSanPhamGiaoDich> ListGD { get => _ListGD; set { _ListGD = value; OnPropertyChanged(); } }

        private ObservableCollection<tblKhachHang> _KhachHangList;
        public ObservableCollection<tblKhachHang> KhachHangList { get => _KhachHangList; set { _KhachHangList = value; OnPropertyChanged(); } }


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
                    MaNVGD = SelectedItem.MaNVGD;
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

                private int? _MaKH;
        public int? MaKH { get => _MaKH; set { _MaKH = value; OnPropertyChanged(); } }

        private string _TenKH;
        public string TenKH { get => _TenKH; set { _TenKH = value; OnPropertyChanged(); } }

        private string _TenNV;
        public string TenNV { get => _TenNV; set { _TenNV = value; OnPropertyChanged(); } }

                private int _MaGD;
        public int MaGD { get => _MaGD; set { _MaGD = value; OnPropertyChanged(); } }

        private int _MaGDSP;
        public int MaGDSP { get => _MaGDSP; set { _MaGDSP = value; OnPropertyChanged(); } }

        private int? _MaNVGD;
        public int? MaNVGD { get => _MaNVGD; set { _MaNVGD = value; OnPropertyChanged(); } }

        private DateTime? _NgayGiaoDich;
        public DateTime? NgayGiaoDich { get => _NgayGiaoDich; set { _NgayGiaoDich = value; OnPropertyChanged(); } }

        private int? _TienThanhToan;
        public int? TienThanhToan { get => _TienThanhToan; set { _TienThanhToan = value; OnPropertyChanged(); } }

        private int _TienTra;
        public int TienTra { get => _TienTra; set { _TienTra = value; OnPropertyChanged(); } }

        private string _HoTen;
        public string HoTen { get => _HoTen; set { _HoTen = value; OnPropertyChanged(); } }

        private int? _DiemTichLuy;
        public int? DiemTichLuy { get => _DiemTichLuy; set { _DiemTichLuy = value; OnPropertyChanged(); } }

        private int _DiemTru;
        public int DiemTru { get => _DiemTru; set { _DiemTru = value; OnPropertyChanged(); } }

        private int? _SoLuong;
        public int? SoLuong { get => _SoLuong; set { _SoLuong = value; OnPropertyChanged(); } }

        private int? _DonGia;
        public int? DonGia { get => _DonGia; set { _DonGia = value; OnPropertyChanged(); } }

        private int? _DiemTichHD;
        public int? DiemTichHD { get => _DiemTichHD; set { _DiemTichHD = value; OnPropertyChanged(); } }

        public ICommand LoadedWindowCommand { get; set; }
        public bool Isloaded = false;

        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public ICommand AddCommandSP { get; set; }
        public ICommand EditCommandSP { get; set; }
        public ICommand DeleteCommandSP { get; set; }

        public ICommand ReportCommand { get; set; }
        public ICommand Scommand { get; set; }

        
        public void LoadDL()
        {
            var query = from g in DataProvider.Ins.DB.tblGiaoDich
                        where g.TrangThai != "Đã Xóa"
                        select new ListKHnew
                        {
                            MaGD = g.MaGD,
                            MaKH = g.MaKH,
                            MaNVGD = g.MaNV,
                            NgayGiaoDich = g.NgayGiaoDich
                        };


            List = new ObservableCollection<ListKHnew>(query.OrderByDescending(x=>x.MaGD).Take(7));
            
        }


        public MainViewModel()
        {
            NgayGiaoDich = DateTime.Now;
            LoadedWindowCommand = new RelayCommand<System.Windows.Window>((p) => { return true; }, (p) => {
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
                if(MaKH == 0)
                {
                    MessageBox.Show("Cần thêm mã khách hàng !");
                }
                else
                {
                    var giaodich = new tblGiaoDich();
                    giaodich.MaKH = MaKH;
                    giaodich.MaNV = Convert.ToInt32(System.Windows.Application.Current.Properties["NameStaff"]);

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
                    var GDtam = DataProvider.Ins.DB.tblGiaoDich.OrderByDescending(x => x.MaGD).Select(y => y.MaGD).Take(1).FirstOrDefault();
                    MaGD = GDtam;
                    //TienThanhToan = 0;
                    //MaNVGD = 0;
                    //MaGD = 0;
                    //MaKH = 0;
                    //TienTra = 0;
                    //DiemTru = 0;
                    //DiemTichLuy = 0;
                    //NgayGiaoDich = DateTime.Now;
                }
               
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
            //try
            //{
                var sp = DataProvider.Ins.DB.tblSanPhamGiaoDich.Where(x => x.MaSP == MaSP && x.MaGD == MaGDSP).FirstOrDefault();
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
                    ListGD = new ObservableCollection<tblSanPhamGiaoDich>(DataProvider.Ins.DB.tblSanPhamGiaoDich.OrderByDescending(x => x.MaGD).Where(y => y.MaGD == MaGDSP));
                SelectedItemSP = null;
                    MaSP = 0;
                    SoLuong = 0;
                //}
                //catch
                //{
                //    MessageBox.Show("Đã xảy ra lỗi vui lòng thực hiện lại !");
                //}

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
                var giaodich = DataProvider.Ins.DB.tblSanPhamGiaoDich.Where(x => x.MaSP == MaSP && x.MaGD == MaGDSP).FirstOrDefault();
                DataProvider.Ins.DB.tblSanPhamGiaoDich.Remove(giaodich);

                DataProvider.Ins.DB.SaveChanges();
                SelectedItemSP.MaGD = MaGDSP;
                SelectedItemSP.MaSP = MaSP;
                SelectedItemSP.SoLuong = SoLuong;

                TienThanhToan = DataProvider.Ins.DB.tblSanPhamGiaoDich.Where(y => y.MaGD == MaGDSP).Sum(x => x.TongTien);
                var gd = DataProvider.Ins.DB.tblGiaoDich.Where(y => y.MaGD == MaGD).FirstOrDefault();
                gd.TienThanhToan = TienThanhToan;
                DataProvider.Ins.DB.SaveChanges();
                LoadDL();

                MessageBox.Show("Bỏ sản phẩm thành công!");
                ListGD = new ObservableCollection<tblSanPhamGiaoDich>(DataProvider.Ins.DB.tblSanPhamGiaoDich.OrderByDescending(x => x.MaGD).Where(y => y.MaGD == MaGDSP));
                SelectedItemSP = null;
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
                SelectedItem.MaNVGD = MaNVGD;
                SelectedItem.TienGiam = TienTra;
                SelectedItem.DiemTich = DiemTichLuy;
                SelectedItem.DiemTru = DiemTru;
                SelectedItem.NgayGiaoDich = NgayGiaoDich;

                LoadDL();
                MessageBox.Show("Xóa giao dịch thành công!");
                
            });


            ReportCommand = new RelayCommand<object>((p) =>
            {
                return true;

            }, (p) =>
            {
                // tích điểm cho khách hàng
                 
                var kh = DataProvider.Ins.DB.tblKhachHang.Where(x => x.MaKH == MaKH).FirstOrDefault();
                if(kh.LoaiKhachHang == "VIP")
                {
                    DiemTichHD = (TienThanhToan * 10) / 100000;
                    if (DiemTichHD < 1)
                    {
                        DiemTichHD = 1;
                    }
                }
                else
                {
                  DiemTichHD = (TienThanhToan * 3) / 100000;
                    if (DiemTichHD < 1)
                    {
                        DiemTichHD = 1;
                    }
                }
                kh.DiemTichLuy = kh.DiemTichLuy + DiemTichHD;
                int? Diemphaitru = (kh.DiemHienCo-DiemTru) * 1000;
                    kh.DiemHienCo = kh.DiemHienCo - DiemTru + DiemTichHD;

                    DataProvider.Ins.DB.SaveChanges();
                    // cập nhật lịch sử giao dịch
                    tblLichSuGiaoDich ls = new tblLichSuGiaoDich();
                    ls.MaGD = MaGD;
                    ls.MaKH = MaKH;
                    ls.TongTienGD =  TienThanhToan;
                    DataProvider.Ins.DB.tblLichSuGiaoDich.Add(ls);

                    DataProvider.Ins.DB.SaveChanges();
                    //  cập nhật giao dịch
                    var giaodich = DataProvider.Ins.DB.tblGiaoDich.Where(x => x.MaGD == MaGD).SingleOrDefault();
                    giaodich.DiemTich = DiemTichHD;
                    giaodich.DiemTru = DiemTru;
                    giaodich.TienThem = TienTra;
                    int? TienQuiDoi = DiemTru * 1000;
                    int? TienTraLai = (TienQuiDoi + TienTra) - TienThanhToan;
                    giaodich.TienThanhToan = TienThanhToan;
                    giaodich.TienGiam = TienTraLai;
                    DataProvider.Ins.DB.SaveChanges();

                    MessageBox.Show("Giao dịch hoàn tất, thối lại "+TienTraLai+" đồng");
                // cập nhật loại khách hàng
                int? tienGD = DataProvider.Ins.DB.tblLichSuGiaoDich.Where(x => x.MaKH == MaKH && x.tblGiaoDich.TrangThai != "Đã Xóa").Sum(y => y.TongTienGD);
                if(tienGD >= 200000000)
                {
                    var kha = DataProvider.Ins.DB.tblKhachHang.Where(x => x.MaKH == MaKH).FirstOrDefault();
                    kha.LoaiKhachHang = "VIP";
                    DataProvider.Ins.DB.SaveChanges();
                    MessageBox.Show("Xin chúc mừng khách hàng" + kha.HoTen + " đã được nâng cấp lên VIP!");

                }
                // xuất exel

                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Visible = true;
                app.WindowState = XlWindowState.xlMaximized;

                Workbook wb = app.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                Worksheet ws = wb.Worksheets[1];
                ws.Range["A:A"].ColumnWidth = 15;
                ws.Range["B:B"].ColumnWidth = 20;
                ws.Range["C:C"].ColumnWidth = 10;
                ws.Range["D:D"].ColumnWidth = 10;
                ws.Range["E:E"].ColumnWidth = 10;
                ws.Range["A3"].Value = "Mã GD: ";
                ws.Range["A2"].Value = "Mã KH: ";
                ws.Range["B1"].Value = "Siêu thị VinMart Trà Vinh";
                ws.Range["C2"].Value = "Mã NV: ";
                ws.Range["A10"].Value = "Tiền Chữ: ";
                ws.Range["A9"].Value = "Điểm Tích Lũy: ";
                ws.Range["A5"].Value = "Điểm Trừ: ";
                ws.Range["A6"].Value = "Tiền Nhận Vào: ";
                ws.Range["A7"].Value = "Tiền Trả Lại: ";
                ws.Range["A8"].Value = "Tiền Thanh Toán: ";
                ws.Range["A4"].Value = "Ngày Giao Dịch: ";
                ws.Range["A11"].Value = "Mã SP: ";
                ws.Range["B11"].Value = "Tên SP: ";
                ws.Range["C11"].Value = "Đơn Giá: ";
                ws.Range["D11"].Value = "Số Lượng: ";
                ws.Range["E11"].Value = "Tổng: ";

                var q = DataProvider.Ins.DB.tblGiaoDich.Where(x => x.MaGD == MaGD).FirstOrDefault();
                ws.Range["B2"].Value = q.MaKH;
                
                ws.Range["D2"].Value = q.MaNV;
                
                ws.Range["B3"].Value = q.MaGD;
                ws.Range["B4"].Value = q.NgayGiaoDich;
                ws.Range["B5"].Value = q.DiemTru;
                ws.Range["B6"].Value = q.TienThem;
                ws.Range["B7"].Value = q.TienGiam;
                ws.Range["B8"].Value = q.TienThanhToan;
                ws.Range["B9"].Value = q.DiemTich;
                ws.Range["B10"].Value = ToText(q.TienThanhToan.ToString()) + " đồng" ;

                int i = 12;
                var listsp = (from a in DataProvider.Ins.DB.tblSanPhamGiaoDich
                             where a.MaGD == MaGD
                             select new SPnew
                             {
                                 MaSP = a.MaSP,
                                 TenSP = a.tblSanPham.TenSP,
                                 SL = a.SoLuong,
                                 TongTien = a.TongTien,
                                 DonGia = a.tblSanPham.DonGia

                             }).ToList();

                foreach (var item in listsp)
                {
                    ws.Range["A" + i].Value = item.MaSP;
                    ws.Range["B" + i].Value = item.TenSP;
                    ws.Range["C" + i].Value = item.DonGia;
                    ws.Range["D" + i].Value = item.SL;
                    ws.Range["E" + i].Value = item.TongTien;


                    i++;
                  
                }
                Random r = new Random();
                int so = r.Next(9999);
                wb.SaveAs("D:\\report"+so+".xlsx");
                PrintMyExcelFile("D:\\report" + so + ".xlsx");
            });

            Scommand = new RelayCommand<object>((p) =>
            {

                return true;

            }, (p) =>
            {
                LoadDL();
                

                KhachHangList = new ObservableCollection<tblKhachHang>(DataProvider.Ins.DB.tblKhachHang.Where(x => x.MaKH == MaKH));

                if (KhachHangList.Count() != 0)
                {
                    foreach (var i in KhachHangList)
                    {
                        HoTen = i.HoTen;
                        DiemTichLuy = i.DiemHienCo;

                    }
                    
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu");
                }

            });


        }
        public Microsoft.Office.Interop.Excel.Application APP = null;
        public Microsoft.Office.Interop.Excel.Workbook WB = null;
        public Microsoft.Office.Interop.Excel.Worksheet WS = null;
        public Microsoft.Office.Interop.Excel.Range Range = null;
       

        void PrintMyExcelFile(string link)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

            // Open the Workbook:
            Microsoft.Office.Interop.Excel.Workbook wb = excelApp.Workbooks.Open(
                link,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            // Get the first worksheet.
            // (Excel uses base 1 indexing, not base 0.)
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];

            // Print out 1 copy to the default printer:
            ws.PrintOut(
                Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            // Cleanup:
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.FinalReleaseComObject(ws);

            wb.Close(false, Type.Missing, Type.Missing);
            Marshal.FinalReleaseComObject(wb);

            excelApp.Quit();
            Marshal.FinalReleaseComObject(excelApp);
        }
        public string ToText(string str)
        {
            string[] word = { "", " một", " hai", " ba", " bốn", " năm", " sáu", " bẩy", " tám", " chín" };
            string[] million = { "", " mươi", " trăm", "" };
            string[] billion = { "", "", "", " nghìn", "", "", " triệu", "", "" };
            string result = "{0}";
            int count = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (count > 0 && count % 9 == 0)
                    result = string.Format(result, "{0} tỷ");
                if (!(count < str.Length - 3 && count > 2 && str[i].Equals('0') && str[i - 1].Equals('0') && str[i - 2].Equals('0')))
                    result = string.Format(result, "{0}" + billion[count % 9]);
                if (!str[i].Equals('0'))
                    result = string.Format(result, "{0}" + million[count % 3]);
                else if (count % 3 == 1 && count > 1 && !str[i - 1].Equals('0') && !str[i + 1].Equals('0'))
                    result = string.Format(result, "{0} lẻ");
                var num = Convert.ToInt16(str[i].ToString());
                result = string.Format(result, "{0}" + word[num]);
                count++;
            }
            result = result.Replace("{0}", "");
            return result.Trim();
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
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int? SL { get; set; }
        public int? TongTien { get; set; }
        public int MaGD { get;  set; }
        public int? DonGia { get;  set; }
    }

    public class ListKHnew
    {
        public int MaGD { get; set; }
        public string TenKH { get; set; }
        public string TenNV { get; set; }
        public int TienThanhToan { get; set; }
        public int TienGiam { get; set; }
        public int? DiemTich { get; set; }
        public int DiemTru { get; set; }
        public int? MaKH { get; set; }
        public int? MaNVGD { get; set; }
        public int TienTra { get; set; }
        public DateTime? NgayGiaoDich { get; set; }
    }
    

}
