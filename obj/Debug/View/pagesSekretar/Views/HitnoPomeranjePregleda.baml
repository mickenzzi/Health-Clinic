   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Bolnica.View.pagesSekretar.Views Bolnica.View.pagesSekretar.Views  5      =    7Bolnica.View.pagesSekretar.Views.HitnoPomeranjePregleda   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Bolnica.View.pagesSekretar.Views     5        N� Title$  HitnoPomeranjePregleda��5	      .��5
      � ���	#FF3F7378.+�5   
   �� $
��Left=�6   $	��421��6,   $��	15,41,0,0q�69   $	��Top=�6L   $	��342��6d   ���	#FFA9BDA7 J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.085Q�6&   T� 5      5      .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ Termini��5         
IsReadOnly .    CanUserAddRows .     AutoGenerateColumns .  $	��343��6�    �� Left$ 15��6�   
 �� Top$ 18��6�   $	��312��6�   ��6m   �� *	Termini+	 �� SelectedItem	 6�   �� *SelectedTermin+
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Datum/Vreme��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 190 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *
DatumVreme+6]     5      $ Lekar��6)   $	 230 6V    68   �� *	LekarInfo+6V   5      5      �� 5   
   -   5         ��Name$
 JMBG��5   -   $
��Left=�6   $��23��6;   $��742,109,-70,0q�6G    �� TextWrapping$
 Wrap=�6^   $��TextBox��6r   $	��Top=�6�   $	��120��6�   $y�Hidden=�6�   �� 5   
   $
��Left=�6   $��40��6,   $��	0,540,0,0q�68   $	��Top=�6K   $	��375��6c   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFA2B4BD��6#    � Offset$ 0Q�65   � 5       $ 	#FFD0D8DC��6#   $ 1Q�65   5!      .+�5#      �� $
��Left=�6   $��36��6P   $	��Top=�6\   $��36��6t   $	 171��6�   $ 2��6�   ��60   �� *HomeCommand+��6   Z� ��6�   Z� .��5$      �� $
��Left=�6   $��30��63   $	��Top=�6?   $��33��6W   $/��)/Bolnica;component/View/images/homean.png��6b   5%      �� 5&      $
��Left=�66   $	��Top=�6Q   $��36��6i   $��36��6t   $	 117��6�   $ 3��6�   ��6   �� *BackCommand+��6�   Z� ��6�   Z� .��5'      �� $
��Left=�6   $��28��63   $	��Top=�6?   $��27��6W   $.��(/Bolnica;component/View/images/bckan.png��6b   $ 1.056,0.552&�6�   5(      5)      �� 5*   
   $��Potvrdi��6   $
��Left=�6L   $	��Top=�6g   $��76��6   $��25��6�   ���	#FFAAAAAA
���   �$��1,1,1,4q�6�   $��152,473,0,0q�6�   ��6#   �� *PomeriPregledCommand+6�   5,      5-      