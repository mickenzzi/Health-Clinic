   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Bolnica.View.pagesSekretar.Views Bolnica.View.pagesSekretar.Views  5      >    8Bolnica.View.pagesSekretar.Views.HitnoPomeranjeOperacija   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Bolnica.View.pagesSekretar.Views     5        N� Title$  HitnoPomeranjeOperacija��5	      .��5
      � ���	#FF3F7378.+�5   
   �� $
��Left=�6   $	��363��6,   $��	12,58,0,0q�69   $	��Top=�6L   $	��351��6d   ���	#FFA9BDA7.+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ Termini��5         
IsReadOnly .    CanUserAddRows .     AutoGenerateColumns .     HorizontalGridLinesBrush
 �   �$	��282��6�    �� Left$ 9��6�   
 �� Top$ 14��6�   $	��333��6  ��6m   �� *	Termini+ �� SelectedItem 6�   �� *SelectedTermin+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Datum/Vreme��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 190 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *
DatumVreme+6]     5      $
 Lekar��6)   $	 230 6V    68   �� *	LekarInfo+6V   5      5      �� 5   
   $
��Left=�6   $��40��6,   $��	0,540,0,0q�68   $	��Top=�6K   $	��375��6c   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFA2B4BD��6#    � Offset$ 0Q�65   � 5      $ 	#FFD0D8DC��6#   $ 1Q�65   5      .+�5      �� $
��Left=�6   $��36��6P   $	��Top=�6\   $��36��6t   $	 171��6�   $ 2��6�   ��60   �� *HomeCommand+��6   Z� ��6�   Z� .��5      �� $
��Left=�6   $��30��63   $	��Top=�6?   $��33��6W   $/��)/Bolnica;component/View/images/homean.png��6b   5      �� 5      $
��Left=�65   $	��Top=�6P   $��36��6h   $��36��6s   $	 117��6�   $ 3��6�   ��6   �� *BackCommand+��6   Z� ��6�   Z� .��5      �� $
��Left=�6   $��28��63   $	��Top=�6?   $��27��6W   $.��(/Bolnica;component/View/images/bckan.png��6b    J� RenderTransformOrigin$ 1.056,0.552&�6�   5      5       �� 5!   
   $��Potvrdi��6   $
��Left=�6N   $	��Top=�6i   $��75��6�   $��25��6�   ���	#FFAAAAAA
���   �$��1,1,1,4q�6�   $��151,457,0,0q�6�   ��6#   �� *PomeriOperacijuCommand+6�   5"      5#      