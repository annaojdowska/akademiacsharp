   M S B A M L   `   `   `  ����J  FAkademiaProjekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AkademiaProjektAkademiaProjekt  5   	        AkademiaProjekt.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:AkademiaProjekt     5   	     � Title$  Library��5   	   $	��370��6   $	��525��6&   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $��3* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��6* �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   .+�5      �� -   5         ��Name$ header1��5      $��0��6%   $��Publications��62   $��Center=�6I   $��Center=�6f   $��Cambria)�6�   $��16(�6�   �� 5      -   5         ��Name$ authorsListBox��5      $��1��6.   $��3q�6<   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6p   ��6G   �� *PublicationsView+6p   5      �� 5   
   $��1��6   .+�5      �� -   5        $ header2��5      $��0��6%   $��Details��62   $��Center=�6D   $��Center=�6a   $��Cambria)�6|   $��16(�6�   �� 5      -   5         ��Name$ 	textBlock��5      $��1��6+   $��10q�68   $
��Wrap=�6E   $��Center=�6v   $��Center=�6�   $��Cambria)�6�   $��13(�6�   ��6Y   �� *Description+6�   5      �� 5   
   $��2��6   $��2��6"   .+�5      �  5      �� 5      $��1* �6'   �� 5      $��1* �6'   �� 5       $��1* �6'   .+�5"      �� -   5         ��Name$	 add��5"      $��Add publication��6&   $��0��6@   $��30��6Q   
�������6u   �� 5#      -   5        $
 save��5#      $��Save to file��6'   $��1��6>   $��30��6O   
�������6s   �� 5$      -   5        $
 load��5$      $��Load from file��6'   $��2��6@   $��30��6R   
�������6v   5%      5&      5(      5)      