using IronBarCode;
using QuanLiKhachHang.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLiKhachHang.ViewModel
{
    public class GiaoDichViewModel : BaseViewModel
    {
        

        private int _MaKH;
        public int MaKH { get => _MaKH; set { _MaKH = value; OnPropertyChanged(); } }

        private string _TenKH;
        public string TenKH { get => _TenKH; set { _TenKH = value; OnPropertyChanged(); } }

        private string _Key;
        public string Key { get => _Key; set { _Key = value; OnPropertyChanged(); } }

        public ICommand PrintCommand { get; set; }

        public GiaoDichViewModel()
        {
            PrintCommand = new RelayCommand<object>((p) =>
            {

                return true;

            }, (p) =>
            {
                var kh = DataProvider.Ins.DB.tblKhachHang.Where(x => x.SDT == Key).FirstOrDefault();
                if (kh != null)
                {
                    MessageBox.Show("Xác nhận khách hàng " + kh.HoTen + " MaSo:" + kh.MaKH + "-CMND:" + kh.CMND + "");

                    QRCodeWriter.CreateQrCode("MaSo:" + kh.MaKH + "-CMND:" + kh.CMND + "", 200, QRCodeWriter.QrErrorCorrectionLevel.Medium).SaveAsPdf("D:\\MyQR.pdf");
                    Process pr = new Process();
                    pr.StartInfo = new ProcessStartInfo()
                    {
                        CreateNoWindow = true,
                        Verb = "print",
                        FileName = "D:\\MyQR.pdf"
                    };
                    pr.Start();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy!");
                }
            });

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
