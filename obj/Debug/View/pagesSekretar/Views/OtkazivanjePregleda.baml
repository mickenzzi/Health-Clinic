   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Bolnica.View.pagesSekretar.Views Bolnica.View.pagesSekretar.Views  5      :    4Bolnica.View.pagesSekretar.Views.OtkazivanjePregleda   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Bolnica.View.pagesSekretar.Views     5        N� Title$  OtkazivanjePregleda��5	      .��5
      � ���	#FF3F7378$��0,0,0,0q�6"   .+�5   
   �� $
��Left=�6   $	��497��6,   $��	24,26,0,0q�69   $	��Top=�6L   $	��331��6d   ���	#FFA9BDA7.+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ Termini��5         
IsReadOnly .    CanUserAddRows .     AutoGenerateColumns .  $	��211��6�    �� Left$ 15��6�   
 �� Top$ 73��6�   $	��300��6�   ��6Q   �� *
Pregledi+ �� SelectedItem 6r   �� *SelectedPregled+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Datum/Vreme��6)   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 150 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *
DatumVreme+6]     5      $	 Lekar��6)   $	
 150 6V    68   �� *	LekarInfo+6V   5      �� 5      $��Otkazi��6   $
��Left=�6O   $	��Top=�6j   $	��132��6�   $��29��6�   
�������$ 19��6�   $	 423��6�   ��6&   �� *OtkaziPregledCommand+��5      �� 5       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5      �  � Color$ 	#FFC74343��6'    � Offset$ 0Q�69   � 5      $ 	#FFCF7F7F��6'   $ 1Q�69   5      5      �� 5      $��Pomeri��6   $
��Left=�6O   $	��Top=�6j   $	��132��6�   $��29��6�   
�������$	 185��6�   $	 422��6�   ��6&   �� *PomeriPregledCommand+��5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5      � $ 	#FF63AE52��6'   $ 0Q�69   � 5      $ 	#FF66B853��6'   $ 1Q�69   5      5!      5"      �� 5#   
   $
��Left=�6   $��40��6,   $��	0,540,0,0q�68   $	��Top=�6K   $	��375��6c   ��5$      �� 5%      $ 0.5,1&�6&   $ 0.5,0&�67   .��5&      � $ 	#FFA2B4BD��6#   $ 0Q�65   � 5'      $ 	#FFD0D8DC��6#   $ 1Q�65   5(      .+�5*      �� $
��Left=�6   $��36��60   $	��Top=�6\   $��36��6t   $	 171��6�   $ 2��6�   ��6<   �� *HomeCommand+��6   Z� ��6�   Z� .��5+      �� $
��Left=�6   $��30��63   $	��Top=�6?   $��33��6W   $/��)/Bolnica;component/View/images/homean.png��6b   5,      �� 5-      $
��Left=�65   $	��Top=�6P   $��36��6h   $��36��6s   $	 117��6�   $ 3��6�   ��6   �� *BackCommand+��6   Z� ��6�   Z� .��5.      �� $
��Left=�6   $��28��63   $	��Top=�6?   $��27��6W   $.��(/Bolnica;component/View/images/bckan.png��6b    J� RenderTransformOrigin$ 1.056,0.552&�6�   5/      50      51      52      