   M S B A M L   `   `   `  ����K  GAdminApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:AdminApplicationAdminApplication  5   	   $    AdminApplication.QuanLySanPham   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:AdminApplication     5   	   -   5          � Title$  Sản Phẩm��5
   	   $	��507��6   $
��1000��6'    � WindowStartupLocation$ CenterScreen=�64    � OverridesDefaultStyle .  � ContextMenu 5      �� 5   
   .��5      ]� .+�5   
   ]� $
��Left=�6   $��Stretch=�6*   .+�5      �� $	��Top=�6   ���	#FF232323.+�5      �� $��THÊM SẢN PHẨM��5      $
��Bold"�5      $��17(�5      $��10q�5      $	��Top=�5      $��Center=�5      $��Center=�5      $��0,0,0,0q�5      ���	#FFF7F7F7���	#FF2323236=   �� 5       �� Orientation$ 
Horizontal=�6   $��Center=�66   .+�5      �� $��Tên người dùng: ��6   $
��Bold"�67   
�������6I   �� 5      $��Nguyễn Sơn Dương��6   
�������67   5      �� 5      $ 
Horizontal=�6   $��Center=�66   $��0,0,0,10q�6S   .+�5       �� $��Thời gian hiện tại:��6   $
��Bold"�6:   
�������6L   �� 5!      $��00:00:00 01/01/2020��6   
�������6:   5"      5#      �� 5$      $��Center=�6   $��0,0,0,20q�69   $	��320��6M   .��5%      "   AdminApplication.ThemSanPham  -   5          Name$ uscThemSanPham��5%   $   $��0,0,0,30q�6<   5&      5'      � 5)   
   $	��Top=�6   .+�5*      ]� .+�5+      �� $	��Top=�6   .+�5,      �� $��Center=�6   $��Center=�6@   $
��Bold"�6b   $%��QUẢN LÝ SHOP ĐIỆN THOẠI��6t   $
��auto��6�   $��40��6�   $��17(�6�   ���	#FF232323
�������6�   �� 5-      $��	0,20,0,20q�6!   $ 
Horizontal=�64   $��Center=�6M   .+�5.      �� .+�5/      �� $(��"Hệ thống quản lý bán hàng��50   %   $	��Top=�51   %   $��Stretch=�52   %   $
��Left=�53   %   $��0,0,0,0q�54   %   $��0q�55   %   $
��Bold"�56   %   $��17(�57   %   ���	#FF99181863   �� 58      $8��2Phần mềm hỗ trợ nhập thông tin cho Shop��59   %   $
��Left=�5:   %   $��10(�5;   %   $��0q�5<   %   5=      �� 5>      $	��300��6"   $��10,0,0,0q�6.   $��7q�6@   ���	#FF151515 �� SelectionBrush �	#FFD74E00$��Center=�6�   $��Center=�6�   �� 5?      -   5        $��Stretch=�5?   "   $��3q�6>   $��7q�6I   $��Tìm kiếm��6U   $
��auto��6h   ���	#FF151515���	#FFFDFDFD���	#FF080808   btnHideHightLight#���   6�   6�   5@      �� 5A      $*��$DANH SÁCH SẢN PHẨM HIỆN TẠI��5B      $��17(�5C      $��Center=�5D      $
��Bold"�5E      ���	#FF232323
�������6F   5G      &   System.Windows.Controls.DataGrid  5H      -   5          Name$ 	dgSanPham��5K      $��20,20,20,20q�5H      $��Bottom=�5I   !      AutoGenerateColumns .  $
��Auto=�5L      $��Visible=�5M      
���   �	   GridLinesVisibility$	 Vertical=�5N   2   $
��Auto��6Q   ��.  
 � UseLayoutRounding
 .    Columns 5O      0  *System.Windows.Controls.DataGridTextColumn  5P      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *id+  5Q      $ Tên sản phẩm��6-    6C   �� *product_name+  5R      $ Công ty sản xuất��6-    6G   �� *	company+  5S      $ Nơi sản xuất��6-    6C   �� *product_country+  5T      $ Số lượng��6-    6?   �� *amount+  5U      $
 Giá��6-    6:   �� *price+  5V      $ Mô tả chung��6-    6B   �� *description+  5W      $ Ngày sản xuất��6-    6D   �� *ngay_san_xuat+  5X      $ Hạn sử dụng��6-    6B   �� *han_su_dung+  5Y      $ Chú thích thêm��6-    6E   �� *note+  5Z      $ Ngày tạo��6-    6?   �� *
createAt+  5[      $ Ngày cập nhật��6-    6D   �� *
updateAt+5]      5^      5_      5`      5a      