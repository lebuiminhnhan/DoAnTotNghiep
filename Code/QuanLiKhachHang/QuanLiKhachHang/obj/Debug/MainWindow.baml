   M S B A M L   `   `   `  ����J  FQuanLiKhachHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:QuanLiKhachHang.MyUserControlQuanLiKhachHang.MyUserControl  5   	   1clr-namespace:QuanLiKhachHangQuanLiKhachHang  5   	   | xSystem.Windows.Controls.DataVisualization.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35�rclr-namespace:System.Windows.Controls.DataVisualization;assembly=System.Windows.Controls.DataVisualization.Toolkit)System.Windows.Controls.DataVisualization 5
      �{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting 5           QuanLiKhachHang.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :uc+clr-namespace:QuanLiKhachHang.MyUserControl     5   	   /localclr-namespace:QuanLiKhachHang     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	      {DVrclr-namespace:System.Windows.Controls.DataVisualization;assembly=System.Windows.Controls.DataVisualization.Toolkit  5
      �DVC{clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit  5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��
mainWindow��5   
      MaterialDesignBody#���   5   	   $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    
 MainVM � DataContext# [ 5   	     MaterialDesignFont#���  5       � Title$+ %Phần mềm Quản Lí Khách Hàng ��5   	   $	��720��6.   $
��1280��6;    � WindowStartupLocation$ CenterScreen=�6H    � Icon$ user.png��6m    � 	Resources 5      	 �� 
TargetType
 �� Property �� Value��%T   'm�       �� 5   
   "	 m�6   .�5      �� 
 � ��
 �����6:   5      5      .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5       6  0System.Windows.Interactivity.InvokeCommandAction     Command 6$   �� *LoadedWindowCommand+   CommandParameter 6L   ��  �� ElementName$ 
mainWindow��5!      .��5#      �  � RowDefinitions 5$   
   �� 5%      $
��auto �6   6,   �� 5&      6   .+�5(   
   � $��0��6   .+�5)      2   ,QuanLiKhachHang.MyUserControl.UserControlBar  
 � Tag 6    �� *Title+$ 
mainWindow��6P   5*      � 5,   
   $��1��6    5-      �� 5.      $
��auto �6    60   �� 5/      6"   .+�53      � $��0��6   .+�54      � $��Stretch=�6   $��Stretch=�65   #��� ��6R    55      ��%�   '��       �� 56      "	 ��6    .�57      �� 
 � ��$ 2 4 2 4q�67   6I   �� 58      
 � ��
 �����6O   59      5:       � ColumnDefinitions 5;      �� 5<      6-   �� 5=      6-   �� 5>      6-   �� 5?      6-   .+�5B      �� $��0��6    � ToolTip$ Quản Lí Khách Hàng��6Q   ��6-   �� *CustomerCommand+.��5C      �  5D      �� 5E   "   62   �� 5F   "   62   .+�5H      � $��0��6#   .+�5I   "   �� $(��"Quản Lí Thông Tin Khách Hàng��6,   $��Center=�6P   6o   5J      � 5K      $��1��6#   .+�5L   "   '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�6:   $��24��6W   $��24��6b   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ Human=�6o   5M      5N      5O      �� 5^      -   5        $��2��5^      $$ Xuất Danh Sách Khách Hàng��6-   .��5_      �  5`      �� 5a   "   62   �� 5b   "   62   .+�5d      � $��0��6#   .+�5e   "   �� $��Xuất Danh Sách��6,   $��Center=�6B   6a   5f      � 5g      $��1��6#   .+�5h   "     $��24��6:   $��24��6E   $��Center=�6R   $ 	Altimeter=�6p   5i      5j      5k      �� 5l      $��1��6   $ Tìm Kiếm��6-   ��6@   �� *SearchCommand+.��5m      �  5n      �� 5o   "   62   �� 5p   "   62   .+�5r      � $��0��6#   .+�5s   "   �� $��Tìm Kiếm��6,   $��Center=�6<   $��16��6Y   $	��Top=�6e   6   5t      � 5u      $��1��6#   .+�5v   "     $��24��6:   $��24��6E   $��Center=�6R   $ DatabaseSearch=�6p   5w      5x      5y      �� 5z      $��3��6   $ In Mã Thẻ��6-   ��6A   �� *GiaoDichCommand+.��5{      �  5|      �� 5}   "   62   �� 5~   "   62   .+�5�      � $��0��6#   .+�5�   "   �� $��In Mã Thẻ��6,   $��Center=�6=   6\   5�      � 5�      $��1��6#   .+�5�   "     $��24��6:   $��24��6E   $��Center=�6R   $ BarcodeScanner=�6p   5�      5�      5�      5�      5�      � 5�      $��1��6    5�      �� 5�      $
��auto �6$   64   �� 5�      6&   .+�5�      � $��0��6   .+�5�      #	  MaterialDesignThemes.Wpf.Card	  $��5q�6*   .��5�      � $��0��6    5�      �� 5�   "   $
��auto �60   6@   �� 5�   "   $
��auto �60   6@   �� 5�   "   62   .+�5�      � $��0��6#   $��5q�60    5�   "   �� 5�   &   $
��auto �67   6F   �� 5�   &   $
��auto �67   6F   �� 5�   &   $
��auto �67   6F   .+�5�   "   � $��0��6'   5�   #   � 5�   "   $��1��6'   5�   #   � 5�   "   $��2��6'   5�   #   5�      � 5�      $��1��6#   .+�5�   "   �� $��5q�6,   69   5�      � 5�      $��2��6#   #��� ��60    5�   "   �� 5�   &   $
��auto �67   6F   �� 5�   &   $
��auto �67   6F   �� 5�   &   $
��auto �67   6F   �� 5�   &   $
��auto �67   6F   �� 5�   &   $
��auto �67   6F   �� 5�   &   $
��auto �67   6F   .+�5�   "   � $��0��6'   .+�5�   &   	  ���#03a9f4$��5q�6P    ! PrimaryHueDarkForegroundBrush#���  5�   :   $��0q�5�   :   $	��200��6F   .��5�   *   �  5�   .   �� 5�   2   $
��Auto �6@   �� 5�   2   $
��Auto �6@   �� 5�   2   $
��Auto �6@   .+�5�   .   �� $��0��68   $��
16 16 16 4q�6E   $ ��Số Lượng Khách Hàng��5�   8    # MaterialDesignHeadlineTextBlock#��[ 5�   8   $��16(�6q   5�   /   �� 5�   .   $��1��68      MaterialDesignLightSeparator#��[ 6E   �� 5�   .   $��2��68   $��	16 0 16 8q�6E   $��Center=�6X   $
��Left=�5�   8    # MaterialDesignDisplay1TextBlock#��[ 5�   8   ��5�   8   ��  �� Path$	 Tam� �� Mode$ OneWay=� �� StringFormat$ {0} Người��5�   /   5�   +   5�   '   5�   #   � 5�   "   $��3��6'   .+�5�   &   	  ���#03a9f4$��5q�6O   #���  5�   :   $��0q�5�   :   $	��200��6F   .��5�   *   �  5�   .   �� 5�   2   $
��Auto �6@   �� 5�   2   $
��Auto �6@   �� 5�   2   $
��Auto �6@   .+�5�   .   �� $��0��68   $��
16 16 16 4q�6E   $��Số Lượt Giao Dịch ��5�   8   #��[ 5�   8   $��16(�6q   5�   /   �� 5�   .   $��1��68   #��[ 6E   �� 5�   .   $��2��68   $��	16 0 16 8q�6E   $��Center=�6X   $
��Left=�5�   8   #��[ 5�   8   ��5�   8   �� $
 SLGD�$ OneWay=�$ {0} Lượt��5�   /   5�   +   5�   '   5�   #   � 5�   "   $��4��6'   .+�5�   &   	  ���#03a9f4$��5q�6P   #���  5�   :   $��0q�5�   :   $	��200��6F   .��5�   *   � $	��107��6/    5�   .   �� 5�   2   $
��Auto �6@   �� 5�   2   $
��Auto �6@   �� 5�   2   $
��Auto �6@   .+�5�   .   �� $��0��68   $��
16 16 16 4q�6E   $��Tổng Doanh Thu��5�   8   #��[ 5�   8   $��16(�6q   5�   /   �� 5�   .   $��1��68   #��[ 6E   �� 5�   .   $��2��68   $��	16 0 16 8q�6E   $��Center=�6X   $
��Left=�5�   8   #��[ 5�   8   $��20(�6q   ��5�   8   �� $ TongThu�$ OneWay=�$ {0} VND��5�   /   5�   +   5   '   5  #   � 5  "   $��1��6'   .+�5  &   	  ���#03a9f4$��5q�6P   #���  5  :   $��0q�5  :   $	��200��6F   .��5  *   � $	��107��6/    5  .   �� 5  2   $
��Auto �6@   �� 5	  2   $
��Auto �6@   �� 5
  2   $
��Auto �6@   .+�5  .   �� $��0��68   $��
16 16 16 4q�6E   $��Số Lượng Nam��5  8   #��[ 5  8   $��16(�6q   5  /   �� 5  .   $��1��68   #��[ 6E   �� 5  .   $��2��68   $��	16 0 16 8q�6E   $��Center=�6X   $
��Left=�5  8   #��[ 5  8   $��36(�6q   ��5  8   �� $ SLNam�$ OneWay=�$ {0} Người��5  /   5  +   5  '   5  #   � 5  "   $��2��6'   .+�5  &   	  ���#03a9f4$��5q�6P   #���  5  :   $��0q�5  :   $	��200��6F   $��34(�6R   .��5  *   � $	��107��6/    5   .   �� 5!  2   $
��Auto �6@   �� 5"  2   $
��Auto �6@   �� 5#  2   $
��Auto �6@   .+�5%  .   �� $��0��68   $��
16 16 16 4q�6E   $��Số Lượng Nữ��5&  8   #��[ 5'  8   $��16(�6q   5)  /   �� 5*  .   $��1��68   #��[ 6E   �� 5+  .   $��2��68   $��	16 0 16 8q�6E   $��Center=�6X   $
��Left=�5,  8   #��[ 5.  8   $��34(�6q   ��5-  8   �� $
 SLNu�$ OneWay=�$ {0} Người��5/  /   51  +   52  '   53  #   � 55  "   $��5��6'   .+�56  &   �� $0 *Nhấn nút này để refresh dữ liệu��6I    & "MaterialDesignFloatingActionButton#��[ 57     3
  -MaterialDesignThemes.Wpf.ButtonProgressAssist 
  IsIndicatorVisible .  
  Value$ -1Q�59      
  IsIndeterminate . $��20(�5;  6   ���	#FF51B73A���	#FF51B73A��56  -   �� *	Refresh+��5;     0  *MaterialDesignThemes.Wpf.PackIconExtension  *DotsHorizontal+6[   5<  #   5=     5>     5?     5@     	  5C     $��1��6&   $��5q�63   $��Stretch=�6>   .��5D     �  5E     �� 5F     $
��auto �6,   6<   �� 5G     $
��auto �6,   6<   �� 5H     6.   .+�5K     � $��0��6   $��5q�6,   $��Stretch=�67    5L     �� 5M  "   $
��auto �63   6B   �� 5N  "   65   .+�5Q     � .+�5R  "   � $��0��6'   $��Center=�67   .+�5S  &   >  8System.Windows.Controls.DataVisualization.Charting.Chart  -   5        $��mcChart��5S  �   
 �� Top$ 10��60   $G ABiểu đồ tỉ lệ khách hàng siêu thị VinMart Trà Vinh��6@    �� Left$ 10��6}   $	��580��6�   $	��250��6�   
����İ�$��Right=�6�      Series 5U  .   B  <System.Windows.Controls.DataVisualization.Charting.PieSeries  ?  9System.Windows.Controls.DataVisualization.Charting.Series    Title$6  0Biểu đồ tỉ lệ khách hàng Nam và Nữ��6<   $
��Left=�6�   $��
10,10,0,10q�6�   $	��538��6�   H  BSystem.Windows.Controls.DataVisualization.Charting.DataPointSeries!   IndependentValueBinding! 6g   �� $	 Key�"   DependentValueBinding" 6�   �� $ Value�5V  /   5X  '   5Z  #   � 5[  "   $��1��6'   $��Stretch=�67   $��Stretch=�6U   $
��auto��6q   .+�5\  &     -   5        $��	mcChartCl��5\  �   $; 5Biểu đồ 5 khách hàng tích lũy nhiều nhất��60   $	 100��6c   $ 10��6t   $	��680��6�   $	��250��6�   
����İ�$��Right=�6�   $	��Top=�6�    5^  .   E  ?System.Windows.Controls.DataVisualization.Charting.ColumnSeries  $  Điểm tích lũy��6@   $
��Left=�6�   $	��511��6�   ! 6V   �� $ HoTen�" 6�   �� $ DiemTichLuy�6�   5`  '   5a  #   5b     5f     5j     5k     5m     5n     5o     5p     