   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.PagesWpfApp1.Pages  5          WpfApp1.Pages.Bmi   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp1.Pages     5        N� Title$	  Bmi��5      $	��600��6   $	��800��6    .��5	      �� 
���   �$��2q�6!   ._�5
      � 
�������.+�5   
   � $��80��6   $	��Top=�6   .+�5      �� $��40(�6   $��Body mass index��6"   �� 5      -   5        $
��save��5      $��17(�69   $	��100��6G   $��40��6S   $	��Top=�6_   $��Right=�6~   $��0,0,30,0q�6�   .��6�   Ulož měření6�   5      � 5   
    � ColumnDefinitions 5   
   �� 5      $	��270 �6   6-   �� 5      6!   .+�5   
   �� $��0��6   $��0, 100, 0, 0q�6%   .+�5      �� $��40��6   $��0, 0, 0, 10q�6    $��25(�65   $��BMI: ��6C   �� 5      $��40��6   $��0, 0, 0, 10q�6    $��25(�65   $��Klinická interpretace: ��6C   �� 5      $��40��6   $��0, 0, 0, 10q�6    $��25(�65   $��Komentář: ��6C   �� 5      $��40��6   $��0, 80q�6    $��25(�6/   $��Ovliňující faktory: ��6=   5      �� 5   
   $��1��6   $	��500��6%   $
��Left=�61   $��0, 100, 0, 0q�6L   .+�5      �� -   5        $	��bmi��5   l   $��40��6   $��0, 0, 0, 10q�6"   $	��250��67   $
��Left=�6C   $��25(�6^   .��6x   6{   �� 5      -   5        $��	interpret��5   m   $��40��6   $��0, 0, 0, 10q�6#   $��25(�68   $	��250��6F   $
��Left=�6R   6�   �� 5      -   5        $��comment��5   �    �� TextWrapping$
 Wrap=�6   $��0, 0, 0, 10q�6*   " �� VerticalScrollBarVisibility$
 Auto=�6?    �� AcceptsReturn$
 True��6b   $	��120��6w   $��25(�6�   .��6�   6�   �� 5       -   5        $��
cofounding��5    �   $
 Wrap=�6   $��0, 0, 0, 10q�6*   $
 Auto=�6?   $
 True��6b   $	��120��6w   $��25(�6�   .��6�   6�   5!      5#      5$      5%      5&      