   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Bolnica.View.pagesSekretar.Views Bolnica.View.pagesSekretar.Views  5      ;    5Bolnica.View.pagesSekretar.Views.ZakazivanjeOperacije   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Bolnica.View.pagesSekretar.Views     5        N� Title$  ZakazivanjeOperacije��5	      .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFD2E2F9��6    � Offset$ 0Q�61   � 5      $ 	#FFD5AEE4��6   $ 1Q�61   5      .+�5   
   �� $
��Left=�6   $	��549��6,   $��	17,15,0,0q�69   $	��Top=�6L   $	��343��6d   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF294663��6#   $ 1Q�65   � 5      $ 	#FFB396C3��6#   5      .+�5      �� $
��Left=�6   $	��167��60   $	��Top=�6=   $	��274��6U   ���	#FFAEBFA1 �� Left$ 32��6x   
 �� Top$	 309��6�   .+�5      �� $
��Left=�6   $��21��64   $	��Top=�6@   $	��222��6X   ���	#FF27485B$ 24��6{   $ 9��6�   .+�5      �� $��Lekar��6   $
��Left=�6,   $	��Top=�6G   $	��100��6_   
�������$ 85��6~   $ -5��6�   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ Lekari��5   �   $	��117��6      
IsReadOnly . 	   CanUserAddRows	 .  $ 32��6�   $ 38��6�   $	��212��6�   ��6Q   �� *Lekari+
 �� SelectedItem
 6p   �� *SelectedLekar+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Ime��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 6R   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *Ime+6R     5       $ Prezime��6-   $	 110 6Z    6>   �� *	Prezime+6Z   5"      5#      �� 5$      $
��Left=�6   $	��244��60   $	��Top=�6=   $	��274��6U   ���	#FFAEBFA1$ 32��6x   $ 59��6�   .+�5%      (  "System.Windows.Controls.DatePicker  -   5          Name$ Kalendar��5%   �   $
��Left=�6   $	��168��6�   $	��Top=�6�   $	��180��6�   $ 46��6�   $ 27��6�      IsDropDownOpen .    SelectedDateFormat$ Short=�6�      Text 68   �� *Datum+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5&      $
��Left=�6   $��21��64   $	��Top=�6@   $	��222��6X   ���	#FF27485B$ 25��6{   $ 5��6�   .+�5'      �� $��Datum termina��6   $
��Left=�64   $��23��6O   $	��Top=�6[   $ 60��6s   $ -3��6�   
�������6�   5(      �� 5)      $��Vreme termina:��6   $
��Left=�61   $��29��6L   $	��Top=�6X   $ 28��6p   $	 203��6�   �� 5*      -   5         ��Name$ Vreme��5*   l   $
��Left=�6   $��23��65    �� TextWrapping$
 Wrap=�6A   $	��Top=�6{   $	��120��6�   
���   �$	 135��6�   $	 206��6�   ��6U   �� *Vreme+6�   �� 5+      $��HH:MM��6   $
��Left=�6(   $	��Top=�6C   $	��100��6[   
���  �� J� RenderTransformOrigin$ -4.63,-0.923&�6x   $	 136��6�   $	 224��6�   $��10(�6�   5,      �� 5-      $
��Left=�6   $��47��60   $	��Top=�6<   $	��316��6T   ���	#FF1D5EAC$ 13��6w   $ 6��6�   .+�5.      �� $��Unos podataka operacije��6   $
��Left=�6:   $	��Top=�6U   $ 64��6m   $ 6��6~   $��18(�6�   $��Italic$�6�   
�������6�   5/      �� 50      $��Potvrdi��6   $
��Left=�6R   $	��Top=�6m   $��75��6�   $��25��6�   $	 136��6�   $	 482��6�   ���	#FFAAAAAA
���   �$��1,1,1,4q�6�   ��6'   �� *ZakaziOperacijuCommand+6�   51      �� 52   
   -   5        $ JMBG1��52   -   $
��Left=�6   $��23��6<   $��
653,88,0,0q�6H   $
 Wrap=�6\   $��TextBox��6p   $	��Top=�6   $	��120��6�   $y�Hidden=�6�   �� 53   
   $
��Left=�6   $��40��6,   $��	0,540,0,0q�68   $	��Top=�6K   $	��375��6c   ��54      �� 55      $ 0.5,1&�6&   $ 0.5,0&�67   .��56      � $ 	#FFA2B4BD��6#   $ 0Q�65   � 57      $ 	#FFD0D8DC��6#   $ 1Q�65   58      .+�5:      �� $
��Left=�6   $��36��60   $	��Top=�6\   $��36��6t   $	 171��6�   $ 2��6�   ��6<   �� *HomeCommand+��6   Z� ��6�   Z� .��5;      �� $
��Left=�6   $��30��63   $	��Top=�6?   $��33��6W   $/��)/Bolnica;component/View/images/homean.png��6b   5<      �� 5=      $
��Left=�65   $	��Top=�6P   $��36��6h   $��36��6s   $	 117��6�   $ 3��6�   ��6   �� *BackCommand+��6   Z� ��6�   Z� .��5>      �� $
��Left=�6   $��28��63   $	��Top=�6?   $��27��6W   $.��(/Bolnica;component/View/images/bckan.png��6b   $ 1.056,0.552&�6�   5?      5@      5A      5B      