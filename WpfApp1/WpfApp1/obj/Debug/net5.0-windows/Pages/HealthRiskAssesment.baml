   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.PagesWpfApp1.Pages  5      '    !WpfApp1.Pages.HealthRiskAssesment   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp1.Pages     5        N� Title$  HealthRiskAssesment��5      $	��600��6#   $	��800��60   .��5	      �� 
���   �$��2q�6    ._�5
      � 
�������.+�5   
   � $��80��6   $	��Top=�6   .+�5      �� $��40(�6   $#��Hodnocení zdravotních rizik��6"   �� 5      -   5        $
��save��5      $��17(�69   $	��100��6G   $��40��6S   $	��Top=�6_   $��Right=�6~   $��0,0,30,0q�6�   .��6�   Ulož měření6�   5      � 5   
    � ColumnDefinitions 5      �� 5      $	��270 �6#   61   �� 5      6%   .+�5      �� $��0��6   $��0, 100, 0, 0q�6)   .+�5      �� $��40��6   $��0, 0, 0, 10q�6$   $��25(�6:   $��Zdravotní riziko: ��6H   �� 5      $��40��6   $��0, 0, 0, 10q�6$   $��25(�69   $��Jména rizika: ��6G   �� 5      $��40��6   $��0, 0, 0, 10q�6$   $��25(�69   $��Přítomnost rikzika: ��6G   �� 5      $��40��6   $��0, 0, 0, 10q�6$   $��25(�69   $��Metoda určení: ��6G   �� 5      $��40��6   $��0, 0, 0, 10q�6$   $��25(�69   $��Komentář: ��6G   5      �� 5      $��1��6   $	��500��6)   $
��Left=�65   $��0, 100, 0, 0q�6P   .+�5      �� -   5        $
��risk��5   p   $��40��6   $��0, 0, 0, 10q�6&   $	��500��6;   $
��Left=�6G   $��25(�6b   .��6}   6�   �� 5      -   5        $��namerisk��5   p   $��40��6   $��0, 0, 0, 10q�6&   $��25(�6;   $	��300��6I   $
��Left=�6U   .��6�   6�   �� 5       -   5        $
��isin��5    q   $��40��6   $��0, 0, 0, 10q�6'   $��25(�6<   $	��250��6J   $
��Left=�6V   6�   �� 5!      -   5        $��methode��5!   p   $��40��6   $��0, 0, 0, 10q�6&   $��25(�6;   $	��500��6I   $
��Left=�6U   .��6�   6�   �� 5"      -   5        $��comment��5"   �    �� TextWrapping$
 Wrap=�6   " �� VerticalScrollBarVisibility$
 Auto=�6.    �� AcceptsReturn$
 True��6Q   $	��120��6f   $��25(�6s   .��6�   6�   5#      5%      5&      5'      5(      