   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Bolnica.View.pagesSekretar.Views Bolnica.View.pagesSekretar.Views  5      8    2Bolnica.View.pagesSekretar.Views.PrikazObavestenja   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Bolnica.View.pagesSekretar.Views     5        N� Title$  PrikazObavestenja��5	      .��5
      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF3D4751��6    � Offset$ 0Q�61   � 5      $ Black��6   $ 1Q�6-   5      .+�5   
   �� $
��Left=�6   $	��248��6,   $��	16,16,0,0q�69   $	��Top=�6L   $	��342��6d   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ White��6#   $ 0Q�61   � 5      $ 	#FF305480��6#   $ 1Q�65   5      .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ PorukeP��5         
IsReadOnly .    CanUserAddRows .  $	��146��6�    �� Left$ 22��6�   
	 �� Top$	 38��6�   $	��298��6  
   AutoGenerateColumns
 .  ��6Q   �� *ObavestenjaPacijenta+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� *SelectedObavestenjePacijenta+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Poruka��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *Poruka+5      �� 5      $��Obrisi��6   $
��Left=�6T   $��28��6o   $	��Top=�6{   $��91��6�   $	 126��6�   $		 197��6�   
���������6&   �� *DeleteObavestenjeCommand+��5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5       � $ 	#FFEC1F1F��6'   $ 0Q�69   � 5!      $ 	#FFDA6161��6'   $ 1Q�69   5"      5$      �� 5%      $��Pacijent-obavestenja��6   $
��Left=�63   $	��Top=�6N   $ 99��6f   $	 6��6w   $��14(�6�   $��Italic$�6�   5&      �� 5'   
   $
��Left=�6   $	��248��6,   $��
16,280,0,0q�69   $	��Top=�6M   $	��342��6e   ��5(      �� 5)      $ 0.5,1&�6&   $ 0.5,0&�67   .��5*      � $ White��6#   $ 0Q�61   � 5+      $ 	#FF305480��6#   $ 1Q�65   5,      .+�5.      �� $��Klinika-obavestenja��6   $
��Left=�62   $��28��6M   $	��Top=�6Y   $	��136��6q   $	 107��6}   $	 7��6�   $��14(�6�   $��Italic$�6�     5/      -   5        $ PorukeK��5/       .  .  $	��158��6u   $ 26��6�   $	 44��6�   $	��289��6�   
 .  ��6Q   �� *Obavestenja+ 50        51      $ Poruka��6)    69   �� *Poruka+53      54      �� 55   
   $
��Left=�6   $��40��6,   $��	0,540,0,0q�68   $	��Top=�6K   $	��375��6c   ��56      �� 57      $ 0.5,1&�6&   $ 0.5,0&�67   .��58      � $ 	#FFA2B4BD��6#   $ 0Q�65   � 59      $ 	#FFD0D8DC��6#   $ 1Q�65   5:      .+�5<      �� $
��Left=�6   $��36��60   $	��Top=�6\   $��36��6t   $	 171��6�   $	 2��6�   ��6<   �� *HomeCommand+��6   Z� ��6�   Z� .��5=      �� $
��Left=�6   $��30��63   $	��Top=�6?   $��33��6W   $/��)/Bolnica;component/View/images/homean.png��6b   5>      �� 5?      $
��Left=�65   $	��Top=�6P   $��36��6h   $��36��6s   $	 117��6�   $	 3��6�   ��6   �� *BackCommand+��6   Z� ��6�   Z� .��5@      �� $
��Left=�6   $��28��63   $	��Top=�6?   $��27��6W   $.��(/Bolnica;component/View/images/bckan.png��6b    J� RenderTransformOrigin$ 1.056,0.552&�6�   5A      5B      5C      5D      