   M S B A M L   `   `   `  ����F  BWpfBookshop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfBookshopWpfBookshop  5   	       WpfBookshop.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfBookshop     5   	     � Title$  BOOKSHOP��5   	   $	��450��6   $	��800��6'   
������� � 	Resources 5	      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%$  '        �� 5
   
   "  6   .�5      ��  � ��
 �**��6;   �� 5       � ��$ 30��6'   64   �� 5       � ��$ 12(�6)   66   �� 5       � ��$
 Bold"�6+   6:   �� 5       � ��$ Center=�62   6C   �� 5       � ��
 �����6;   5      5      .��5      �� 
���?��� �� CornerRadius$ 20��6   $��20q�61   ._�5   
   �� .+�5      �  � DataContext$ MyViewModel��6   .+�5      �� $��AVAILABLE BOOKS��6   
�������$��Center=�6H   $��22(�6e   &   System.Windows.Controls.DataGrid  5      -   5          Name$ 	BooksGrid��5   �      CanUserAddRows .  	   AutoGenerateColumns	 . 
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 * 6�   $	��200��6�   $	��500��67  $��Center=�6C  $��Center=�6^  $��0,30,0,0q�6{  ��6   ��  �� Path$ 	BooksList� �� SelectedItem 6B   �� $ SelectedBook� �� Mode$ TwoWay=�6�  5      �� 5      -   5        $��btn_Reserve��5      $��Reserve��6(   
���iii�
�������$��10(�6e   $��0,30,0,0q�6s   $��17��6�   $��62��6�   6�   �� 5      -   5        $��	btn_Posts��5      $��
Show posts��6&   
���/kU�
�������$��10(�6m   $��0,30,0,0q�6{   $��17��6�   $��62��6�   6�   �� 5      -   5         ��Name$ 
btn_LogOut��5      $��Log out��6)   $��56��6;   $��0,25,0,0q�6F   
�������6z   5      5      5      