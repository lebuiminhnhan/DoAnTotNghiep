   M S B A M L   `   `   `  ����J  FQuanLiKhachHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:QuanLiKhachHang.MyUserControlQuanLiKhachHang.MyUserControl  5   	   1clr-namespace:QuanLiKhachHangQuanLiKhachHang  5   	        QuanLiKhachHang.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :uc+clr-namespace:QuanLiKhachHang.MyUserControl     5   	   /localclr-namespace:QuanLiKhachHang     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��
mainWindow��5   
      MaterialDesignBody#���   5   	   $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    
 MainVM � DataContext# [ 5   	     MaterialDesignFont#���  5       � Title$+ %Phần mềm Quản Lí Khách Hàng ��5   	   $	��720��6.   $
��1280��6;    � WindowStartupLocation$ CenterScreen=�6H    � Icon$ user.png��6m    � 	Resources 5      	 �� 
TargetType
 �� Property �� Value��%T   'm�       �� 5   
   "	 m�6   .�5      �� 
 � ��
 �����6:   5      5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *LoadedWindowCommand+   CommandParameter 6L   ��  �� ElementName$ 
mainWindow��5       .��5"      �  � RowDefinitions 5$   
   �� 5%      $
��auto �6   6,   �� 5&      6   .+�5(   
   � $��0��6   .+�5)      2   ,QuanLiKhachHang.MyUserControl.UserControlBar  
 � Tag 6    �� *Title+$ window��6L   5*      � 5,   
   $��1��6   $��Stretch=�6    � ColumnDefinitions 5-      �� 5.      6%   �� 5/      6%   .+�51      � $��0��6    52      �� 53      $
��auto �6$   64   �� 54      $
��auto �6$   64   �� 55      $
��auto �6$   64   �� 56      $
��auto �6$   64   �� 57      $
��auto �6$   64   .+�5;      #  MaterialDesignThemes.Wpf.Card  $��0��6&   $��5q�63   $��Stretch=�6>   .��5<      � .+�5>      � $��0 0 0 10q�6$   .+�5?      �� -   5        $��5 5 15 5q�5?   n   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mã Khách Hàng��6�    % !MaterialDesignFloatingHintTextBox#��[ 6�   $��24(�6  $	��240��6$  ��6&   �� *MaKH+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6$  (	  "System.Windows.Controls.DatePicker	  5@      {�.  $��Center=�6;   $	��340��6�   $��5 5 15 0q�6�   $ Ngày Giao Dịch��6�    ( $MaterialDesignFloatingHintDatePicker#��[ 6�   $��24(�6:   	  SelectedDate 6V   �� *NgayGiaoDich+$ TwoWay=�$ PropertyChanged=�6:  5C      5E      5H        5J      $��1��6&   $��5q�63   .��5K      � $��5q�6    .+�5L      �� $��Thêm Giao Dịch��6@   $��30 5 5 5q�6Y   $	��180��6k   ��6!   �� *
AddCommand+6y   �� 5M      $��Hủy Giao Dịch��6C   $��	200 5 5 5q�6[   $	��180��6n   ��6!   �� *DeleteCommand+6|   5P      5Q        5S      $��2��6&   $��5q�63   .��5T      � .+�5V      �� $
��Auto=�6'   .��5W      �� $
��auto��6�   $	��300��6�   ��6'   �� *List+$ TwoWay=�$ PropertyChanged=� �� SelectedItem 6w   �� *SelectedItem+$ TwoWay=� �� View 5X   "   �� 5Y   &   .P�5Z   *   �� $��Mã Giao Dịch��69    �� DisplayMemberBinding 6O   �� *MaGD+6w   �� 5[   *   $��Khách Hàng��69    6M   �� *MaKH+6u   �� 5\   *   $��Nhân Viên��69    6L   �� *MaNVGD+6v   �� 5]   *   $��Ngày Giao Dịch��69    6Q   �� *NgayGiaoDich+6�   5_   '   5a      5b      5e      5g        5h      $��3��6&   $��5q�63   $	��100��6>   .��5i      �� .+�5j      �� $!��PHƯƠNG THỨC THANH TOÁN��6    $
��Bold"�6A   $��12(�6S   $��Center=�6a   ���	#DDF7F5F5���	#FFC508086�   � 5k      $��5q�6$   .+�5l      �� -   5        $��5 5 15 5q�5l   q   $ Trừ Điểm��6�   #��[ 6�   $��24(�6  $
��Bold"�6"  $	��200��64  ��6&   �� *	DiemTru+$ TwoWay=�$ PropertyChanged=�64  �� 5n      -   5        $��
180 5 15 5q�5n   q   $ Trả Tiền��6�   #��[ 6�   $��24(�6  $
��Bold"�6$  $	��200��66  ��6&   �� *	TienTra+$ TwoWay=�$ PropertyChanged=�66  5o      5q      5r        5s      $��4��6&   $��5q�63   $	��100��6>   .��5t      �� .+�5u      �� $$��TRA CỨU ĐIỂM KHÁCH HÀNG��6    $
��Bold"�6B   $��12(�6T   $��Center=�6b   ���	#DDF7F5F5���	#FFC508086�   � 5v      $��20q�6$   $��Stretch=�60   .+�5w      �� $��5q�5y      #��[ 5z      $	��462��6>   $��20(�6J   ��5x      �� *MaKH+$ TwoWay=�$ PropertyChanged=�.��5{       5|   "   �� 5}   &    �� Orientation$ 
Horizontal=�5~      $��-2 0 0 0q�5      .+�5�   *   '
  !MaterialDesignThemes.Wpf.PackIcon
  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ Search=�5�   	   �� 5�   *   �� 65   $�Mã khách hàng��69   6Q   5�   '   .��5�   B   5�      �� 5�       �� 	IsDefault . $
��Tìm��6S   $��5q�6a   $	��100��6l   ��6%   �� *
Scommand+6z   5�      5�      5�      5�      � 5�      $��1��6   $��Right=�6#   $	��640��6?    5�      �� 5�      $
��auto �6$   64   �� 5�      $
��auto �6$   64   �� 5�      $
��auto �6$   64   �� 5�      $
��auto �6$   64   �� 5�      $
��auto �6$   64   .+�5�        $��0��6&   $��5q�63   .��5�      � .+�5�      � $��0 0 0 10q�6$   .+�5�      �� -   5        $��5 5 15 5q�5�   n   $ Mã Giao Dịch��6�   #��[ 6�   $��24(�6  $	��189��6#  ��6&   �� *MaGD+$ TwoWay=�$ PropertyChanged=�6#  �� 5�      -   5        $��5 5 15 5q�5�   n   $ Mã Sản Phẩm��6�   #��[ 6�   $��24(�6  $	��190��6"  ��6&   �� *MaSP+$ TwoWay=�$ PropertyChanged=�6"  �� 5�      -   5        $��5 5 15 5q�5�   q   $ Số Lượng��6�   #��[ 6�   $��24(�6  $	��189��6"  ��6&   �� *	SoLuong+$ TwoWay=�$ PropertyChanged=�6"  5�      5�      5�        5�      $��1��6&   $��5q�63   .��5�      � $��5q�6    .+�5�      �� $��Thêm Sản Phẩm��6B   $��30 5 5 5q�6Z   $	��180��6m   ��6!   �� *AddCommandSP+6{   �� 5�      $��Đổi Sản Phẩm��6C   $��5q�6Z   $	��180��6e   ��6!   �� *EditCommandSP+6s   �� 5�      $��Bỏ Sản Phẩm��6E   $��5q�6[   $	��180��6f   ��6!   �� *DeleteCommandSP+6t   5�      5�        5�      $��2��6&   $��5q�63   .��5�      � .+�5�      �� $
��Auto=�6'   .��5�      �� $
��auto��6�   $	��300��6�   ��6'   �� *ListGD+$ TwoWay=�$ PropertyChanged=� 6y   �� *SelectedItemSP+$ TwoWay=� 5�   "   �� 5�   &   .P�5�   *   �� $��Mã Giao Dịch��69    6O   �� *MaGD+6w   �� 5�   *   $��Sản phẩm��69    6K   �� *MaSP+6s   �� 5�   *   $��Số Lượng��69    6K   �� *	SoLuong+6v   5�   '   5�      5�      5�      5�        5�      $��3��6&   $��5q�63   $	��100��6>   .��5�      �� .+�5�      �� $��TỔNG TIỀN THANH TOÁN��6    $
��Bold"�6?   $��12(�6Q   $��Center=�6_   ���	#DDF7F5F5���	#FFC508086�   � 5�      .+�5�      �� $��5q�6$   $��30(�6/   $
��Bold"�6�   $	��190��6�   $��Arial Black)�6�   ��6=   �� *TienThanhToan+$ TwoWay=�$ PropertyChanged=�6�   �� 5�      $��5 10 q�6$   $��24(�63   $	��VND��6A   $
��Bold"�6O   $��80��6a   $��Bodoni MT Black)�6l   6�   �� 5�      $��Xuất Hóa Đơn��6G   $��	130 5 5 5q�6^   $	��200��6q   $��50��6}   ���	#FFB73A3A$��24(�6�   ��6%   �� *ReportCommand+6�   5�      5�      5�        5�      $��4��6&   $��5q�63   $	��100��6>   .��5�      �� .+�5�      #  MaterialDesignThemes.Wpf.Chip  $	��615��5�   !   $��5,5,0,5q�5�   !     PrimaryHueDarkBrush   IconBackground# �  5�   "    ! PrimaryHueDarkForegroundBrush    IconForeground#  �  5�   "   ��5�   "   �� ! �� Path$! HoTen�$ OneWay=�"   Icon" 5�      
  5�   "   $
 User=�5�   *   68   5�        5�      $��5,5,0,5q�5�   !   $	��615��5�   !   # �  5�   "   #  �  5�   "   ��5�   #   �� $! DiemTichLuy�$ OneWay=�# �� StringFormat$# {0} điểm��" 5�      
  5�   "   $ Contrast=�5�   *   6<   5�      5�      5�      5�      5�      5�      5�      