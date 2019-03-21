using QuanLiKhachHang.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLiKhachHang.ViewModel
{
  public  class ControlBarViewModel : BaseViewModel
    {
        private ObservableCollection<tblKhachHang> _KhachHangList;
        public ObservableCollection<tblKhachHang> KhachHangList { get => _KhachHangList; set { _KhachHangList = value; OnPropertyChanged(); } }

        private int _Tam;
        public int Tam { get => _Tam; set { _Tam = value; OnPropertyChanged(); } }

        private int _SLGD;
        public int SLGD { get => _SLGD; set { _SLGD = value; OnPropertyChanged(); } }

        private int? _TongThu;
        public int? TongThu { get => _TongThu; set { _TongThu = value; OnPropertyChanged(); } }

        #region commands
        public ICommand CloseWindowCommand { get; set; }
        public ICommand MaximizeWindowCommand { get; set; }
        public ICommand MinimizeWindowCommand { get; set; }
        public ICommand MouseMoveWindowCommand { get; set; }
        #endregion

        public ControlBarViewModel()
        {


            CloseWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) => {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    w.Close();
                    LoadDL();
                }
                LoadDL();
            }



            );
            MaximizeWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    if (w.WindowState != WindowState.Maximized)
                        w.WindowState = WindowState.Maximized;
                    else
                        w.WindowState = WindowState.Normal;
                }
            }


            );
            MinimizeWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    if (w.WindowState != WindowState.Minimized)
                        w.WindowState = WindowState.Minimized;
                    else
                        w.WindowState = WindowState.Maximized;
                }
            }



            );
            MouseMoveWindowCommand = new RelayCommand<UserControl>((p) => { return p == null ? false : true; }, (p) =>
            {
                FrameworkElement window = GetWindowParent(p);
                var w = window as Window;
                if (w != null)
                {
                    w.DragMove();
                }
            }
           );
        }

        

        FrameworkElement GetWindowParent(UserControl p)
        {
            FrameworkElement parent = p;

            while (parent.Parent != null)
            {
                parent = parent.Parent as FrameworkElement;
            }

            return parent;
        }

        public void LoadDL()
        {

            KhachHangList = new ObservableCollection<tblKhachHang>(DataProvider.Ins.DB.tblKhachHang.OrderByDescending(x => x.MaKH).Where(x => x.TrangThai != "Đã Xóa"));
            SLGD = DataProvider.Ins.DB.tblGiaoDich.Count();
            Tam = KhachHangList.Count();
            TongThu = DataProvider.Ins.DB.tblGiaoDich.Sum(x => x.TienThanhToan);
        }



    }
}
