   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Bolnica.View.pagesSekretar.Views Bolnica.View.pagesSekretar.Views  5      8    2Bolnica.View.pagesSekretar.Views.PomeranjePregleda   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Bolnica.View.pagesSekretar.Views     5        N� Title$  PomeranjePregleda��5	      .��5
      � 
�������.+�5   
   �� $��Izmena termina pregleda��6   $
��Left=�62   $��
103,42,0,0q�6M   $	��Top=�6a   $��14(�6y   $��Italic$�6�   $	��192��6�   �� 5   
   $
��Left=�6   $��31��6/   $��	45,57,0,0q�6;   $	��Top=�6N   $	��294��6f   
���   �6r   �� 5   
   $��Datum i vreme:��6   $
��Left=�6)   $��
36,406,0,0q�6D   $	��Top=�6X   �� 5   
   -   5        $��Datum��5   -   $
��Left=�6   $��23��6:   $��144,410,0,0q�6F    �� TextWrapping$
 Wrap=�6[   $	��Top=�6�   $	��120��6�   ��6o   �� *Datum+6�   �� 5   
   -   5        $
��JMBG��5   -   $
��Left=�6   $��23��69   $��687,50,-15,0q�6E   $
 Wrap=�6[   $��TextBox��6o   $	��Top=�6~   $	��120��6�   $y�Hidden=�6�   �� 5   
   -   5        $	��IdL��5   -   $
��Left=�6   $��23��68   $��682,228,-10,0q�6D   $
 Wrap=�6[   $��TextBox��6o   $	��Top=�6~   $	��120��6�   $y�Hidden=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Lekari��5         
IsReadOnly .    CanUserAddRows .     AutoGenerateColumns .   �� Left$ 31��6�   
 �� Top$ 89��6�   $��62,210,92,216q�6�   ��6h   �� *Lekari+ �� SelectedItem 6�   �� *SelectedLekar+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$	
 Ime��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Ime+6J     5      $
 Prezime��6%   $	 110 6R    66   �� *	Prezime+6R   5      �� 5   
   $��Lekar:��6   $
��Left=�6!   $��
40,159,0,0q�6<   $	��Top=�6P   $	��242��6h   �� 5   
   $��dd.mm.yyyy HH:MM��6   $
��Left=�6+   $��142,433,0,0q�6F   $	��Top=�6[   $	��174��6s   
���  ��$��30��6�   ��6   Z� 6�   �� 5   
   $
��Left=�6   $��40��6,   $��	0,540,0,0q�68   $	��Top=�6K   $	��375��6c   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFA2B4BD��6#    � Offset$ 0Q�65   � 5      $ 	#FFD0D8DC��6#   $ 1Q�65   5      .+�5       �� $
��Left=�6   $��36��60   $	��Top=�6\   $��36��6t   $	 171��6�   $ 2��6�   ��6<   �� *HomeCommand+��6   Z� ��6�   Z� .��5!      �� $
��Left=�6   $��30��63   $	��Top=�6?   $��33��6W   $/��)/Bolnica;component/View/images/homean.png��6b   5"      �� 5#      $
��Left=�65   $	��Top=�6P   $��36��6h   $��36��6s   $	 117��6�   $ 3��6�   ��6   �� *BackCommand+��6   Z� ��6�   Z� .��5$      �� $
��Left=�6   $��28��63   $	��Top=�6?   $��27��6W   $.��(/Bolnica;component/View/images/bckan.png��6b    J� RenderTransformOrigin$ 1.056,0.552&�6�   5%      5&      �� 5'   
   $��Potvrdi��6   $
��Left=�6L   $	��Top=�6g   $��75��6   $��26��6�   ���	#FFAAAAAA
���   �$��1,1,1,4q�6�   $��151,482,0,0q�6�   ��6#   �� *PomeriPregledCommand+6�   5)      5*      