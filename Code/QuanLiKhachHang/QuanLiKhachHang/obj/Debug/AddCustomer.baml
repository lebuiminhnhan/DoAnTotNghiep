   M S B A M L   `   `   `  ����J  FQuanLiKhachHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:QuanLiKhachHangQuanLiKhachHang  5   	   M+clr-namespace:QuanLiKhachHang.MyUserControlQuanLiKhachHang.MyUserControl  5	   
   !    QuanLiKhachHang.AddCustomer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:QuanLiKhachHang     5   	   :uc+clr-namespace:QuanLiKhachHang.MyUserControl     5	   
   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          �Name$  window��5   	      MaterialDesignBody#���   5   	   $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5       � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	     
CustomerVM � DataContext# [ 5   
    � Title$ Khách hàng��5   	   $	��500��6   $	��900��6+   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      2   ,QuanLiKhachHang.MyUserControl.UserControlBar  
	 � Tag	 6    �� *Title+
 �� ElementName$
 window��6L   5      � 5!   
   $��1��6    5"      �� 5#      $
��auto �6    60   �� 5$      $
��auto �6    60   �� 5%      6"   .+�5)      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�6/   .��5*      � $��0 0 0 10q�6   .+�5+      �� -   5        $��5 5 15 5q�5+   g   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên khách hàng��6y    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6   �� *HoTen+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5-      $��	5 5 15 -7q�50      $ Giới tính��51      $
��Left=�52      ��5-       �� *
Property+ �� SelectedItem 5.      �� *
GioiTinh+$ TwoWay=�$ PropertyChanged=�56      �� 58      -   5        $��5 5 15 5q�58   f   $
 CMND��6x   #��[ 6�   ��6   �� *CMND+$ TwoWay=�$ PropertyChanged=�6�   �� 59      $��5 5 15 5q�6h   $ Địa chỉ��6z   #��[ 6�   ��6   �� *DiaChi+$ TwoWay=�$ PropertyChanged=�6�   �� 5:      -   5        $��5 5 15 5q�5:   l   $ Nghề Nghiệp��6~   #��[ 6�   ��6   �� *
NgheNghiep+$ TwoWay=�$ PropertyChanged=�6�   �� 5<      -   5        $��5 5 15 5q�5<   e   $ Điện thoại��6w   #��[ 6�   ��6   �� *SDT+$ TwoWay=�$ PropertyChanged=�6�   �� 5=      $��5 5 15 5q�6g   $ Email��6y   #��[ 6�   ��6   �� *Email+$ TwoWay=�$ PropertyChanged=�6�   (  "System.Windows.Controls.DatePicker  5>      $��Center=�6!   $	��100��6�   $��5 5 15 0q�6�   $ 	Năm Sinh��6�    ( $MaterialDesignFloatingHintDatePicker#��[ 6�      SelectedDate 6<   �� *	NamSinh+$ TwoWay=�$ PropertyChanged=�6�   5?      5@        5B      $��1��6"   $��5q�6/   .��5C      � .+�5D      �� $��Thêm��6<   $��5q�6K   $	��100��6V   ��6   �� *
AddCommand+6d   �� 5E      $��Sửa��6=   $��5q�6L   $	��100��6W   ��6   �� *EditCommand+6e   �� 5F      $��Xóa��6>   $��5q�6M   $	��100��6X   ��6   �� *EditCommand1+6f   �� 5G      $��10q�5I      #��[ 5J      $	��360��6>   ��5H      �� *Key+$ TwoWay=�$ PropertyChanged=�.��5K       5L      �� 5M       �� Orientation$ 
Horizontal=�5N      $��-2 0 0 0q�5O      .+�5P   "   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ Search=�5Q   	   �� 5R   "   �� 6-   $�Tìm kiếm khách hàng��61   6O   5S      .��5T   :   5U      �� 5V       �� 	IsDefault . $
��Tìm��6K   $��5q�6Y   $	��100��6d   ��6   �� *
Scommand+6r   5W      5X        5Z      $��2��6"   $��5q�6/   $��Stretch=�6:   .��5[      �� $
��Auto=�6   .��5\      �� ��6   �� *KhachHangList+$ TwoWay=�$ PropertyChanged=� 6x   �� *SelectedItem+$ TwoWay=� �� View 5]      �� 5^      .P�5_   "   �� $��ID Khách Hàng��61    �� DisplayMemberBinding 6H   �� *MaKH+6p   �� 5`   "   $��Tên Khách Hàng��61    6I   �� *HoTen+6r   �� 5a   "   $��Giới Tính��61    6D   �� *
GioiTinh+6p   �� 5b   "   $��	Năm Sinh��61    6C   �� *	NamSinh+6n   �� 5c   "   $
��CMND��61    6?   �� *CMND+6g   �� 5d   "   $��Nghề Nghiệp��61    6F   �� *
NgheNghiep+6t   �� 5e   "   $��Điện Thoại��61    6E   �� *SDT+6l   �� 5f   "   $��Địa Chỉ��61    6B   �� *DiaChi+6l   �� 5g   "   $��Email��61    6@   �� *Email+6i   �� 5h   "   $��Loại Khách Hàng��61    6J   �� *LoaiKhachHang+6{   �� 5i   "   $��Điểm Tích Luỹ��61    6H   �� *DiemTichLuy+6w   �� 5j   "   $��Điểm Hiện Có��61    6G   �� *
DiemHienCo+6u   5l      5n      5o      5p      5q      5r      5s      