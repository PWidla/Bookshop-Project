   M S B A M L   `   `   `  ����F  BWpfBookshop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfBookshopWpfBookshop  5   	       WpfBookshop.PostScreen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfBookshop     5   	     � Title$  BOOKSHOP��5   	   $	��450��6   $	��800��6'   
������� � 	Resources 5	      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%$  '        �� 5
   
   "  6   .�5      ��  � ��
 �**��6;   �� 5       � ��$ 30��6'   64   �� 5       � ��$ 12(�6)   66   �� 5       � ��$
 Bold"�6+   6:   �� 5       � ��$ Center=�62   6C   �� 5       � ��
 �����6;   5      5      .��5      �� 
���?��� �� CornerRadius$ 20��6   $��20q�61   ._�5   
   �� .+�5      �  � DataContext$ MyViewModel��6   .+�5      �� $��RECENT POSTS��6   
�������$��Center=�6E   $��22(�6b   &   System.Windows.Controls.DataGrid  5      -   5          Name$ 	PostsGrid��5   �      CanUserAddRows .  	   AutoGenerateColumns	 . 
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 * 6�   $	��200��6�   $	��500��6�   $��Center=�6  $��Center=�6&  $��0,30,0,0q�6C  ��6   ��  �� Path$ 	PostsList�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ content of post��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *body+   ElementStyle 5      �� 5   "   .�5   &   ��  � ��$
 Wrap=�6O   �� 5   &    �@��TextAlignment$ Center=�6P   5   #   5       5"      5#      �� 5$      -   5         ��Name$ Go_back��5$      $��Go back��6&   $��80��68   $��0,20,0,0q�6C   
��� ���6k   �� 5%      -   5        $ 
btn_LogOut��5%      $��Log out��6)   $��56��6;   $��0,45,0,0q�6F   
�������6z   5&      5'      5(      