   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Bolnica.View.pagesSekretar.Views Bolnica.View.pagesSekretar.Views  5      7    1Bolnica.View.pagesSekretar.Views.PrikazPacijenata   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Bolnica.View.pagesSekretar.Views     5        N� Title$  PrikazPacijenata��5	      .��5
      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$ 0Q�6-   � 5      $ 	#FF346A72��6   $ 1Q�61   5      .+�5   
   �� $
��Left=�6   $	��513��6,   $��	20,21,0,0q�69   $	��Top=�6L   $	��334��6d   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ 	#FF283B5D��6#   $ 0Q�65   � 5      $ 	#FFAAAEB4��6#   $ 1Q�65   5      .+�5      �� $
��Left=�6   $��23��61    �� TextWrapping$
 Wrap=�6=   $	��Top=�6�   $	��158��6�    �� Left$	 152��6�   
 �� Top$ 53��6�   $��1,1,1,4q�6�   ��6Q   �� *	SearchIme+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   �� 5      $��Pretraga po imenu:��6   $ 20��61   $ 49��6B   $	��130��6R   $��14(�6^   $��Italic$�6l   
�������6   &   System.Windows.Controls.DataGrid  5      -   5        
  Name$
 	Pacijenti��5         
IsReadOnly .    CanUserAddRows .     AutoGenerateColumns .  $	��295��6�   $
��Left=�6�   $	��211��6  $ 21��6!  $	 106��62  ��6S   �� *	Pacijenti+ �� SelectedItem 6u   �� *SelectedPacijent+$ TwoWay=�$	 PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Ime��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Ime+6N     5      $ Prezime��6)   $ 80 6V    6:   �� *	Prezime+6V     5       $
 JMBG��6)   $ 60 6P    67   �� *Jmbg+6P     5!      $ Hitan slucaj��6)   $ 80 6_    6?   �� *HitanSlucaj+6_   5#      �� 5$      $��Izmeni��6   $
��Left=�6\   $	��Top=�6w   $	��138��6�   $��25��6�   
�������$ 20��6�   $	 359��6�   ��6&   �� *" TransferToIzmeniPacijentaCommand+��5%      �� 5&      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5'      � $ 	#FF65AA5A��6'   $ 0.003Q�69   � 5(      $ 	#FF588352��6'   $ 1Q�69   5)      5+      �� 5,      $��Obrisi��6   $
��Left=�6Q   $	��Top=�6l   $	��138��6�   $��25��6�   
�������$	 178��6�   $	 359��6�   ��6&   �� *ObrisiPacijentaCommand+��5-      �� 5.      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5/      � $ 	#FFF04141��6'   $ 0Q�69   � 50      $ 	#FFBB5353��6'   $ 1Q�69   51      53      �� 54      $��Termin��6   $
��Left=�6\   $	��Top=�6w   $	��220��6�   $ 56��6�   $	 416��6�   $��25��6�   ��6&   �� *" TransferToTerminPacijentaCommand+6�   55      �� 56   
   $
��Left=�6   $��40��6,   $��	0,540,0,0q�68   $	��Top=�6K   $	��375��6c   ��57      �� 58      $ 0.5,1&�6&   $ 0.5,0&�67   .��59      � $ 	#FFA2B4BD��6#   $ 0Q�65   � 5:      $ 	#FFD0D8DC��6#   $ 1Q�65   5;      .+�5=      �� $
��Left=�6   $��36��60   $	��Top=�6\   $��36��6t   $	 171��6�   $ 2��6�   ��6<   �� *HomeCommand+��6   Z� ��6�   Z� .��5>      �� $
��Left=�6   $��30��63   $	��Top=�6?   $��33��6W   $/��)/Bolnica;component/View/images/homean.png��6b   5?      �� 5@      $
��Left=�65   $	��Top=�6P   $��36��6h   $��36��6s   $	 117��6�   $ 3��6�   ��6   �� *BackCommand+��6   Z� ��6�   Z� .��5A      �� $
��Left=�6   $��28��63   $	��Top=�6?   $��27��6W   $.��(/Bolnica;component/View/images/bckan.png��6b    J� RenderTransformOrigin$ 1.056,0.552&�6�   5B      5C      5D      5E      