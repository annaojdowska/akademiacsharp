   M S B A M L   `   `   `  ����J  FAkademiaProjekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AkademiaProjektAkademiaProjekt  5   	       AkademiaProjekt.AddWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:AkademiaProjekt     5   	     � Title$  Add Publication��5   	   $	��400��6!   $	��300��6.   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��header��5      $��0��6   $��New Publication��6+   $��Center=�6E   $��Center=�6`   $��Cambria)�6}   $��16(�6�   �� 5   
   $��1��6   $��	50,0,50,0q�6"   .+�5      �  � ColumnDefinitions 5      �� 5      $��1* �6'   �� 5      $��1* �6'   .+�5      	� -   5        $��Novel��5   7    	� 	GroupName$ novelOrDrama��6   $��0��6D   $��Novel��6T   $��Cambria)�6d   $��10(�6y   $��Center=�6�    d� 	IsChecked$
 TrueY�6�   	� 5      -   5        $��Drama��5   7   $ novelOrDrama��6   $��1��6D   $��Drama��6T   $��Cambria)�6d   $��10(�6y   $��Center=�6�   5      5      �� 5   
   $��2��6   $��	50,0,50,0q�6"   .+�5       �� $��Title��6   $��Cambria)�6$   $��10(�69   $��Center=�6G   �� 5!      -   5         ��Name$ Title��5!      $��Cambria)�6%   $��10(�6:   5"      �� 5#   
   $��3��6   $��	50,0,50,0q�6"   .+�5$      �� $��Author��6   $��Cambria)�6%   $��10(�6:   $��Center=�6H   �� 5%      -   5        $ Author��5%      $��Cambria)�6&   $��10(�6;   5&      �� 5'   
   $��4��6   $��	50,0,50,0q�6"   .+�5(      �� $��Description��6   $��Cambria)�6*   $��10(�6?   $��Center=�6M   �� 5)      -   5        $ Description��5)      $��Cambria)�6+   $��10(�6@   $��80��6N   5*      �� 5+   
   $��5��6   $��
50,10,50,0q�6"   .+�5,      �  5-      �� 5.      $��1* �6'   �� 5/      $��1* �6'   .+�51      �� $��0��6   .+�52      �� $��Released in (for novels)��6   $��Cambria)�6?   $��7(�6T   $��Center=�6a   �� 53      -   5        $ 
ReleasedIn��53      $��Cambria)�62   $��10(�6H   $��Center=�6V   $��50��6s   54      �� 55      $��1��6   .+�56      �� $"��First played in (for dramas)��6   $��Cambria)�6D   $��7(�6Y   $��Center=�6f   �� 57      -   5        $ PlayedIn��57      $��Cambria)�60   $��10(�6F   $��Center=�6T   $��50��6q   58      59      5:      �� 5;   
   $��6��6   $��	50,0,50,0q�6"   .+�5<      �� $��Genre (for novels)��6   $��Cambria)�61   $��10(�6F   $��Center=�6T   �� 5=      -	   5         ��Name$ GenresComboBox��5=      $��Cambria)�6/   $��10(�6D   5>      �� 5?   
   -
   5         ��Name$ OKButton��5?      $��   Confirm   ��6#   
�������$��7��6T   $��Center=�6a   $��Center=�6~   $��10q�6�   $��23��6�   $	��120��6�   5A      5B      