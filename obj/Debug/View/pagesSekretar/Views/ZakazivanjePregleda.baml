   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Bolnica.View.pagesSekretar.Views Bolnica.View.pagesSekretar.Views  5      :    4Bolnica.View.pagesSekretar.Views.ZakazivanjePregleda   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Bolnica.View.pagesSekretar.Views     5        N� Title$  ZakazivanjePregleda��5	      .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFD5AEE4��6    � Offset$ 1Q�61   � 5      $ 	#FFD2E2F9��6   5      .+�5   
   �� $
��Left=�6   $	��550��6,   $��	16,14,0,0q�69   $	��Top=�6L   $	��342��6d   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF294663��6#   $ 1Q�65   � 5      $ 	#FFB396C3��6#   5      .+�5      �� $��Potvrdi��6   $
��Left=�6P   $	��Top=�6k   $��75��6�   $��25��6�    �� Left$	 134��6�   
 �� Top$	 488��6�   ���	#FFAAAAAA
���   �$��1,1,1,4q�6�   ��6'   �� *ZakaziPregledCommand+6�   5      �� 5   
   -   5         ��Name$
 JMBG��5   -   $
��Left=�6   $��23��6;   $��687,50,-15,0q�6G    �� TextWrapping$
 Wrap=�6]   $��TextBox��6q   $	��Top=�6�   $	��120��6�   $y�Hidden=�6�   �� 5   
   $
��Left=�6   $	��244��6,   $��	52,76,0,0q�69   $	��Top=�6L   $	��274��6d   ���	#FFAEBFA1.+�5      (  "System.Windows.Controls.DatePicker  -   5        	  Name$	 Kalendar��5   4   $
��Left=�6   $	��168��6�   $	��Top=�6�   $	��180��6�   $ 46��6�   $ 27��6�   
   IsDropDownOpen
 .    SelectedDateFormat$ Short=�6�      Text 6F   �� *Datum+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $
��Left=�6   $��21��60   $	��Top=�6<   $	��222��6T   ���	#FF27485B$ 25��6w   $ 3��6�   .+�5      �� $��Datum termina��6   $
��Left=�60   $��23��6K   $	��Top=�6W   $ 60��6o   $ -3��6�   
�������6�   5       �� 5!      $��Vreme termina:��6   $
��Left=�6-   $��29��6H   $	��Top=�6T   $ 28��6l   $	 201��6}   �� 5"      -   5        $ Vreme��5"   h   $
��Left=�6   $��23��61   $
 Wrap=�6=   $	��Top=�6w   $	��120��6�   
���   �$	 135��6�   $	 204��6�   ��6Q   �� *Vreme+6�   �� 5#      $��HH:MM��6   $
��Left=�6$   $	��Top=�6?   $	��100��6W   ���	#FFF50808$��10(�6z   $	 133��6�   $	 222��6�   5$      �� 5%   
   $
��Left=�6   $��47��6,   $��	30,24,0,0q�68   $	��Top=�6K   $	��316��6c   ���	#FF1D5EAC.+�5&      �� $��Unos podataka pregleda��6   $
��Left=�65   $	��Top=�6P   $ 70��6h   $ 7��6y   $��18(�6�   $��Italic$�6�   
�������6�   5'      �� 5(   
   $
��Left=�6   $	��164��6,   $��
52,326,0,0q�69   $	��Top=�6M   $	��274��6e   ���	#FFAEBFA1.+�5)      �� $
��Left=�6   $��21��60   $	��Top=�6<   $	��222��6T   ���	#FF27485B$ 24��6w   $ 9��6�   .+�5*      �� $��Lekar��6   $
��Left=�6(   $	��Top=�6C   $	��100��6[   
�������$ 85��6z   $ -5��6�   5+      &   System.Windows.Controls.DataGrid  5,      -   5          Name$ Lekari��5,   �   $	��117��6      
IsReadOnly .    CanUserAddRows .  $ 31��6�   $ 40��6�   $	��212��6�   ��6M   �� *Lekari+ �� SelectedItem 6l   �� *SelectedLekar+   Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$	 Ime��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Ime+6N     5/      $ Prezime��6)   $	 110 6V    6:   �� *	Prezime+6V   51      52      �� 53   
   $
��Left=�6   $��40��6,   $��	0,540,0,0q�68   $	��Top=�6K   $	��375��6c   ��54      �� 55      $ 0.5,1&�6&   $ 0.5,0&�67   .��56      � $ 	#FFA2B4BD��6#   $ 0Q�65   � 57      $ 	#FFD0D8DC��6#   $ 1Q�65   58      .+�5:      �� $
��Left=�6   $��36��60   $	��Top=�6\   $��36��6t   $	 171��6�   $ 2��6�   ��6<   �� *HomeCommand+��6   Z� ��6�   Z� .��5;      �� $
��Left=�6   $��30��63   $	��Top=�6?   $��33��6W   $/��)/Bolnica;component/View/images/homean.png��6b   5<      �� 5=      $
��Left=�65   $	��Top=�6P   $��36��6h   $��36��6s   $	 117��6�   $ 3��6�   ��6   �� *BackCommand+��6   Z� ��6�   Z� .��5>      �� $
��Left=�6   $��28��63   $	��Top=�6?   $��27��6W   $.��(/Bolnica;component/View/images/bckan.png��6b    J� RenderTransformOrigin$ 1.056,0.552&�6�   5?      5@      5A      5B      