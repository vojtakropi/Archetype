   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $	��140 �6   6+   �� 5      6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   6-   �� 5      6!   �� 5      $	��250 �6   6-   .+�5   
   �� $��1��6   $��0��6!   
����ح�61   �� 5   
   $��1��6   $��0��6!   
����  �$	��250��6?   $	��150��6K   $	��Top=�6X   6r   �� 5   
   $��0��6   $��0��6!   
����d�61   �� 5   
   $��0��6   $��1��6!   
����d�61   �� 5   
   $��0��6   $��2��6!   
����d�61   �� 5   
   $��1��6   $��2��6!   
����ح�61   �� 5   
   -   5         ��Name$ IcVis��5   4   $��1��6   $��2��6$   ��5      �� 5      .R�5      �� -   5        $	��220��5   :   $��60��6F   
����ح�$��15(�5   0   
���   �$��3q�6R   ��5      �� *ButtonContent+5       5!      5#      �� 5$   
   -   5        $ Ic��5$   4   $��1��6   $��2��6$   ��5%      �� 5&      .R�5'      �� -   5        $	��220��5)   9   $��60��6E   $��5q�6Q   
����ح�$��20(�5*   4   $��Medium"�6B   
���   �$��3q�6j   ��5(      �� *ButtonContent+5+      5,      5.      � 5/   
   $��1��6   $��0��6   .+�50      �� .+�51      �� $��30(�6   .��6&   Vybraný pacient:69   �� 52      $��15(�6   .��6&   	Jméno:6.   �� 53      $��15(�6   .��6&   Přijmení:61   �� 54      $��15(�6   .��6&   Rodné číslo:64   55      �� 56      $��85, 50, 0, 0q�6   .+�57      �� -   5        $
��name��57   &   $��15(�6   64   �� 58      -   5        $��surname��58   &   $��15(�6   67   �� 59      -   5        $
��rnum��59   &   $��15(�6   64   5:      5;      �� 5<   
   -   5        $��Tools��5<   K   $��0��6   $��1��6"    �� Orientation$ 
Horizontal=�62   .+�5=      �� -	   5        $	��100��5=      $	��100��6"   
���2͚�$��10q�6Y   .��5>      �� .+�5?      �� $��90��6   $��60��6'   $	��Top=�63   $��img/BMI.png��6K   �� 5@      $��20(�6   $
��Bold"�6*   $��20, 0, 0, 0q�6<   .��6Q   BMI6X   5A      5B      �� 5C      -
   5        $	��100��5C      $	��100��6"   
���2͚�$��10q�6c   .��5D      �� .+�5E      �� $��90��6   $��60��6'   $	��Top=�63   $��img/bloodpressure.jpg��6K   �� 5F      $��15(�6   $
��Bold"�6*   $��
0, 0, 0, 0q�6<   .��6P   Krevní tlak6_   5G      5H      �� 5I      -   5        $	��100��5I      $	��100��6"   
���2͚�$��10q�6\   .��5J      �� .+�5K      �� $��90��6   $��60��6'   $	��Top=�63   $��img/scale.jpg��6K   �� 5L      $��15(�6   $
��Bold"�6*   $��20, 0, 0, 0q�6<   .��6Q   Váha6Y   5M      5N      5O      �� 5P   
   $��0��6   $��1��6"   $ 
Horizontal=�62   $��Right=�6K   $��0,0,70,0q�6g   .+�5Q      �� -   5        $	��100��5Q      $	��100��6"   
���2͚�$��10q�6i   .��5R      �� .+�5S      �� $��90��6   $��60��6'   $	��Top=�63   $��img/healthrisk.jpg��6K   �� 5T      $��15(�6   $
��Bold"�6*   $��
0, 0, 0, 0q�6<   .��6P   Zdrav. rizika6a   5U      5V      �� 5W      -   5        $	��100��5W      $	��100��6"   
���2͚�$��10q�6`   .��5X      �� .+�5Y      �� $��90��6   $��60��6'   $	��Top=�63   $��img/medication.jpg��6K   �� 5Z      $��15(�6   $
��Bold"�6*   $��10, 0, 0, 0q�6<   .��6Q   
Medikace6]   5[      5\      5]      �� 5^   
   -   5        $��0��5^      $��2��6   $	��100��6.   
��� ���$��20q�6l   $��Right=�6x   $��15(�6�   $��DemiBold"�6�   .��5_      �� .+�5`      �� $��90��6   $��60��6#   $	��Top=�6/   $��img/plus.png��6G   �� 5a      $��13(�6   $
��Bold"�6&   $��
0, 0, 0, 0q�68   .��6L   Nový pacient6\   5b      5c      �� 5d   
   -   5        $��0��5d      $��2��6   $	��100��6.   $��20q�6]   $
��Left=�6i   
��� ���.��5e      �� .+�5f      �� $��90��6   $��60��6#   $	��Top=�6/   $��img/choose.png��6G   �� 5g      $��12(�6   $
��Bold"�6&   $��
0, 0, 0, 0q�68   .��6L   Vyber pacienta6\   5h      5i       � 5j   
   -   5          �Name$
 Main��5j   -   $��1��6   $��1��6     � NavigationUIVisibility$ Hidden=�6;   6^   5l      5m      