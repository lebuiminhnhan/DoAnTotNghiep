using QuanLiKhachHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Office.Interop.Excel;
using System.Windows.Controls.DataVisualization.Charting;
using System.Collections.ObjectModel;

namespace QuanLiKhachHang
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        private int _DiemTichLuy;
        public int DiemTichLuy { get => _DiemTichLuy; set { _DiemTichLuy = value; } }

        private int _HoTen;
        public int HoTen { get => _HoTen; set { _HoTen = value; } }

        private ObservableCollection<tblKhachHang> _KhachHangList;
        public ObservableCollection<tblKhachHang> KhachHangList { get => _KhachHangList; set { _KhachHangList = value; } }



        public MainWindow()
        {
            int SLTT = DataProvider.Ins.DB.tblKhachHang.Where(x => x.LoaiKhachHang == "Thân Thiết" && x.TrangThai == "Hoạt Động").Count();
            int SLV = DataProvider.Ins.DB.tblKhachHang.Where(x => x.LoaiKhachHang == "VIP" && x.TrangThai == "Hoạt Động").Count();
            KhachHangList = new ObservableCollection<tblKhachHang>(DataProvider.Ins.DB.tblKhachHang.OrderByDescending(x => x.DiemTichLuy).Where(z=>z.TrangThai=="Hoạt Động").Take(5).ToList());
            InitializeComponent();

            ((PieSeries)mcChart.Series[0]).ItemsSource = new KeyValuePair<string, int>[]
            {
                new KeyValuePair<string, int>("KH Thân Thiết", SLTT),
                new KeyValuePair<string, int>("KH VIP", SLV),

            };

            ((ColumnSeries)mcChartCl.Series[0]).ItemsSource = KhachHangList;
           
        
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            app.WindowState = XlWindowState.xlMaximized;

            Workbook wb = app.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = wb.Worksheets[1];
           

            ws.Range["A1"].Value = "Mã Khách Hàng";
            ws.Range["B1"].Value = "Tên Khách Hàng";
            ws.Range["C1"].Value = "Giới Tính";
            ws.Range["D1"].Value = "Năm Sinh";
            ws.Range["E1"].Value = "Địa Chỉ";
            ws.Range["F1"].Value = "Số Điện Thoại";
            ws.Range["G1"].Value = "Email";
            ws.Range["H1"].Value = "CMND";
            ws.Range["I1"].Value = "Điểm Tích Lũy";
            ws.Range["J1"].Value = "Điểm Hiện Có";
            ws.Range["K1"].Value = "Loại Khách Hàng";
            int i = 2;
           
            foreach ( var item in DataProvider.Ins.DB.tblKhachHang.Where(x=>x.TrangThai != "Đã Xóa").ToList())
            {
                    ws.Range["A" +i].Value = item.MaKH;
                    ws.Range["B" + i].Value = item.HoTen;
                    ws.Range["C" + i].Value = item.GioiTinh;
                    ws.Range["D" + i].Value = item.NamSinh;
                    ws.Range["E" + i].Value = item.DiaChi;
                    ws.Range["F" + i].Value = item.SDT;
                    ws.Range["G" + i].Value = item.Email;
                    ws.Range["H" + i].Value = item.CMND;
                ws.Range["I" + i].Value = item.DiemHienCo;
                    ws.Range["J" + i].Value = item.DiemTichLuy;
                    ws.Range["K" + i].Value = item.LoaiKhachHang;
                    i++;
                if(i> DataProvider.Ins.DB.tblKhachHang.Where(x => x.TrangThai != "Đã Xóa").Count())
                {
                    break;
                }
                
            }
            Random n = new Random();
            int so = n.Next(9999);
            wb.SaveAs("D:\\ds"+so+".xlsx");
        }
    }
}
