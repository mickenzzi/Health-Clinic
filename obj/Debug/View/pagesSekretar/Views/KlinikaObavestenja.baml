   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Bolnica.View.pagesSekretar.Views Bolnica.View.pagesSekretar.Views  5      9    3Bolnica.View.pagesSekretar.Views.KlinikaObavestenja   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Bolnica.View.pagesSekretar.Views     5        N� Title$  KlinikaObavestenja��5	      .��5
      � ���	#FF273828.+�5   
   � $
��Left=�6   $	��492��6*   $��	19,18,0,0q�67   $	��Top=�6J   $	��342��6b   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFA5B5C5��6#    � Offset$ 0Q�65   � 5      $ 	#FFD8D1D1��6#   $ 1Q�65   5      .+�5      &   System.Windows.Controls.DataGrid  -   5        $��PorukeK��5         
IsReadOnly .    CanUserAddRows .   �� Left$ 91��6�   
 �� Top$ 78��6  $��14,0,13,125q�6  	   AutoGenerateColumns	 .  $��4q�6M  $	��273��6a  $��Bottom=�6n  ��6O   �� *Obavestenja+
 �� UpdateSourceTrigger$
 PropertyChanged=� �� SelectedItem 6�   ��  �� Path$ SelectedObavestenje� �� Mode$ TwoWay=�$
 PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Poruka��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *Poruka+5      �� 5      $��Dodaj��6   $
��Left=�6D   $��28��6_   $	��Top=�6k   $��96��6�   $��135,388,0,0q�6�   
���������6%   �� *
AddCommand+��5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5      � $ 	#FF54719B��6'   $ 0Q�69   � 5      $ 	#FF4B658B��6'   $ 1Q�69   5      5      �� 5      $��Izmeni��6   $
��Left=�6J   $��28��6e   $	��Top=�6q   $��89��6�   $��239,388,0,0q�6�   
���������6&   �� *TransferCommand+��5       �� 5!      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5"      � $ 	#FF8AC574��6'   $ 0Q�69   � 5#      $ 	#FF5E8D4C��6'   $ 1Q�69   5$      5&      �� 5'      $��Obrisi��6   $
��Left=�6H   $��28��6c   $	��Top=�6o   $	��110��6�   $��
18,388,0,0q�6�   
���������6&   �� *DeleteCommand+��5(      �� 5)      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5*      � $ 	#FFF05050��6'   $ 0Q�69   � 5+      $ 	#FFA61212��6'   $ 1Q�69   5,      5.      �� 5/      $
��Left=�6   $��42��60   $��	66,22,0,0q�6<   $	��Top=�6O   $	��222��6g   ��50      �� 51      $ 0.5,1&�6*   $ 0.5,0&�6;   .��52      � $ 	#FFF7F1F1��6'   $ 0Q�69   � 53      $ 	#FFE2D9D9��6'   $ 1Q�69   54      .+�56      �� $��Klinika-obavestenja��6   $
��Left=�66   $��36��6Q   $	��Top=�6]   $	��182��6u   $ 22��6�   $ 3��6�   $��18(�6�   $��Italic$�6�   $
��Bold"�6�   57      �� 58      $
��Left=�6   $��40��60   $��-19,522,-14,-70q�6<   $	��Top=�6U   $	��375��6m   ��59      �� 5:      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5;      � $ 	#FFA2B4BD��6'   $ 0Q�69   � 5<      $ 	#FFD0D8DC��6'   $ 1Q�69   5=      .+�5?      �� $
��Left=�6   $��36��64   $	��Top=�6`   $��36��6x   $	 171��6�   $ 2��6�   ��6@   �� *HomeCommand+��6�   Z� ��6�   Z� .��5@      �� $
��Left=�6   $��30��67   $	��Top=�6C   $��33��6[   $/��)/Bolnica;component/View/images/homean.png��6f   5A      �� 5B      $
��Left=�69   $	��Top=�6T   $��36��6l   $��36��6w   $	 117��6�   $ 3��6�   ��6   �� *BackCommand+��6�   Z� ��6�   Z� .��5C      �� $
��Left=�6   $��28��67   $	��Top=�6C   $��27��6[   $.��(/Bolnica;component/View/images/bckan.png��6f    J� RenderTransformOrigin$ 1.056,0.552&�6�   5D      5E      5F      5G      5H      