   M S B A M L   `   `   `  ����F  BWpfBookshop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfBookshopWpfBookshop  5   	   !    WpfBookshop.PostScreenAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfBookshop     5   	     � Title$  BOOKSHOP��5   	   $	��550��6   $	��800��6'   
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
 Wrap=�6O   �� 5   &    �@��TextAlignment$ Center=�6P   5   #   5       5"      5#      �� 5$      $��Title of post��6   $��91��6,   $��5,3,16,5q�67   �� 5%      -   5        $��txtTitle��5%   *    �� TextWrapping$
 Wrap=�6   $	��120��6:   �� 5&      $��Content of post��6   $	��118��6.   $��5,3,16,5q�6:   �� 5'      -   5        $��
txtContent��5'   *   $
 Wrap=�6   $	��120��6<   �� 5(      -   5        $��btn_AddPost��5(      $��Add post��6(   $��66��6;   $��0,20,0,0q�6F   
�������6t   �� 5)      -   5        $��btn_RemovePost��5)      $��Remove post��6,   $��87��6B   $��0,10,0,0q�6M   
�������6r   �� 5*      -   5         ��Name$ Go_back��5*      $��Go back��6&   $��	0,20,0,25q�68   $��80��6K   
��� ���6m   �� 5+      -   5        $ 
btn_LogOut��5+      $��Log out��6)   $��56��6;   
�������6h   5,      5-      5.      