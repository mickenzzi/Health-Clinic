   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Bolnica.View.pagesSekretar.Views Bolnica.View.pagesSekretar.Views  5      3    -Bolnica.View.pagesSekretar.Views.PrikazLekara   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Bolnica.View.pagesSekretar.Views     5        N� Title$  PrikazLekara��5	      .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF527089��6    � Offset$ 0Q�61   � 5      $ 	#FFE8D1D1��6   $ 1Q�61   5      .+�5   
   �� $
��Left=�6   $	��478��6,   $��	16,41,0,0q�69   $	��Top=�6L   $	��343��6d   ���	#FF334D37.+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ Lekari��5         
IsReadOnly .    CanUserAddRows .  $	��312��6�   $
��Left=�6�      AutoGenerateColumns .  $	��243��6  	 �� Left$	 17��6"  

 �� Top$	
 112��63  ��6P   �� *Lekari+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� *SelectedLekar+$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 Ime��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 6s   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Ime+$ PropertyChanged=�6s     5      $ Prezime��6)   $	 100 6z    6:   �� *	Prezime+$ PropertyChanged=�6z     5      $ Oblast specijalizacije��6)   $	 120 6�    6I   �� *Specijalizacija+$ PropertyChanged=�6�   5      �� 5      $
��Left=�6   $��23��61    �� TextWrapping$
 Wrap=�6=   $	��Top=�6�   $	��173��6�   $		 155��6�   $
 50��6�   $��1,1,1,4q�6�   ��6Q   �� *	SearchIme+$ PropertyChanged=�$ TwoWay=�6�   �� 5      $��Pretraga po imenu:��6   $	 20��61   $
 45��6B   $	��130��6R   $��14(�6^   $��Italic$�6l   
�������6   5      �� 5   
   $��Obrisi��6   $
��Left=�6I   $��
32,425,0,0q�6d   $	��Top=�6x   $	��132��6�   $��29��6�   
���������6"   �� *DeleteLekarCommand+��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5       � $ 	#FFF92222��6#   $ 0Q�65   � 5!      $ 	#FFB66767��6#   $ 1Q�65   5"      5$      �� 5%   
   $��Izmeni��6   $
��Left=�6H   $��213,423,0,0q�6c   $	��Top=�6x   $	��128��6�   $��31��6�   
���������6"   �� *EditLekarCommand+��5&      �� 5'      $ 0.5,1&�6&   $ 0.5,0&�67   .��5(      � $ 	#FF5CA84A��6#   $ 0Q�65   � 5)      $ 	#FF68BD55��6#   $ 1Q�65   5*      5,      �� 5-   
   $
��Left=�6   $��40��6,   $��	0,540,0,0q�68   $	��Top=�6K   $	��375��6c   ��5.      �� 5/      $ 0.5,1&�6&   $ 0.5,0&�67   .��50      � $ 	#FFA2B4BD��6#   $ 0Q�65   � 51      $ 	#FFD0D8DC��6#   $ 1Q�65   52      .+�54      �� $
��Left=�6   $��36��60   $	��Top=�6\   $��36��6t   $		 171��6�   $
 2��6�   ��6<   �� *HomeCommand+��6   Z� ��6�   Z� .��55      �� $
��Left=�6   $��30��63   $	��Top=�6?   $��33��6W   $/��)/Bolnica;component/View/images/homean.png��6b   56      �� 57      $
��Left=�65   $	��Top=�6P   $��36��6h   $��36��6s   $		 117��6�   $
 3��6�   ��6   �� *BackCommand+��6   Z� ��6�   Z� .��58      �� $
��Left=�6   $��28��63   $	��Top=�6?   $��27��6W   $.��(/Bolnica;component/View/images/bckan.png��6b    J� RenderTransformOrigin$ 1.056,0.552&�6�   59      5:      5;      5<      