   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Bolnica.View.pagesSekretar.Views Bolnica.View.pagesSekretar.Views  5      6    0Bolnica.View.pagesSekretar.Views.IzmenaPacijenta   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Bolnica.View.pagesSekretar.Views     5        N� Title$  IzmenaPacijenta��5	      .��5
      � 
�������$��0,0,0,0q�6   .+�5   
   �� $
��Ime:��6   $
��Left=�6   $��	17,62,0,0q�6:   $	��Top=�6M   �� 5   
   $��Prezime:��6   $
��Left=�6#   $��	17,93,0,0q�6>   $	��Top=�6Q   �� 5   
   $��JMBG:��6   $
��Left=�6    $��
17,124,0,0q�6;   $	��Top=�6O   �� 5   
   $��Hitan slucaj:��6   $
��Left=�6(   $��
17,155,0,0q�6C   $	��Top=�6W   �� 5   
   -   5        $��JMBGP��5   -   $
��Left=�6   $��23��6:   $��
80,128,0,0q�6F    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6�   $	��120��6�   ��6n   �� *JmbgPacijenta+6�   �� 5   
   -   5        $��PrezimeP��5   -   $
��Left=�6   $��23��6=   $��	80,97,0,0q�6I   $
 Wrap=�6\   $	��Top=�6�   $	��120��6�   ��6p   �� *PrezimePacijenta+6�   �� 5   
   -   5        $
��ImeP��5   -   $
��Left=�6   $��23��69   $��	80,65,0,0q�6E   $
 Wrap=�6X   $	��Top=�6�   $	��120��6�   ��6l   �� *ImePacijenta+6�   �� 5   
   -   5        $��HitanP��5      $
��Left=�6!   $��
96,161,0,0q�6<   $	��Top=�6w    d� 	IsChecked 6P   �� *HitanSlucajCheck+6w   �� 5   
   $��Datum rodjenja:��6   $
��Left=�6*   $��
17,182,0,0q�6E   $	��Top=�6Y   �� 5   
   $��Mesto stanovanja:��6   $
��Left=�6,   $��
17,217,0,0q�6G   $	��Top=�6[   �� 5   
   $��Telefon:��6   $
��Left=�6#   $��
17,310,0,0q�6>   $	��Top=�6R    J� RenderTransformOrigin$ -4.741,-2.331&�6j   �� 5   
   $��Ulica,broj:��6   $
��Left=�6&   $��
17,279,0,0q�6A   $	��Top=�6U   �� 5   
   $
��Pol:��6   $
��Left=�6   $��
17,248,0,0q�6:   $	��Top=�6N   �� 5   
   $��Bracni status:��6   $
��Left=�6)   $��
17,341,0,0q�6D   $	��Top=�6X   �� 5   
   -   5        $��DatumP��5      $
��Left=�6    $��23��6;   $��132,183,0,0q�6G   $
 Wrap=�6\   $	��Top=�6�   $	��120��6�   ��6p   �� *DatumRodjenjaPacijenta+6�   �� 5   
   -   5        $��MestoStanovanjaP��5      $
��Left=�6*   $��23��6E   $��132,220,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6�   $	��120��6�   ��6z   �� *MestoStanovanjaPacijenta+6�   �� 5   
   -   5        $��UlicaIBrojP��5      $
��Left=�6%   $��23��6@   $��
96,283,0,0q�6L   $
 Wrap=�6`   $	��Top=�6�   $	��120��6�   ��6t   �� *UlicaPacijenta+6�   �� 5   
   -   5        $��TelefonP��5      $
��Left=�6"   $��23��6=   $��
80,314,0,0q�6I   $
 Wrap=�6]   $	��Top=�6�   $	��120��6�   ��6q   �� *TelefonPacijenta+6�   �� 5   
   -	   5        $
��PolP��5      $��80,252,223,0q�6   $	��Top=�65   4  .System.Windows.Automation.AutomationProperties   IsOffscreenBehavior$ Onscreen=�6M    �� SelectedValuePath$ Content��6�    �� SelectedValue 6�   �� *PolPacijenta+ �� UpdateSourceTrigger$ PropertyChanged=�.@�5      �� $��Muski��6   �� 5      $��Zenski��6   5       �� 5!   
   -
   5        $��BracniStatusP��5!      $��102,341,177,0q�6(   $	��Top=�6?   $ Onscreen=�6W   $ Content��6�   $��25��6�    6�   �� *BracniStatusPacijenta+$ PropertyChanged=�.@�5"      �� $��NeozenjenNeudata��6   �� 5#      $��OzenjenUdata��6   �� 5$      $��RazvedenRazvedena��6   �� 5%      $��UdovacUdovica��6   5&      &   System.Windows.Controls.DataGrid  5'   
   -   5          Name$ Alergije��5'      	   
IsReadOnly	 . 
   CanUserAddRows
 .  $��18,374,131,117q�6N      AutoGenerateColumns .  $ 0.5,0.5&�6  ��6f   �� *
Alergije+ �� SelectedItem 6�   ��  �� Path$ SelectedAlergija� �� Mode$ TwoWay=�$ PropertyChanged=�   Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ Sifra alergije��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *SifraAlergije+6_     5*      $ Alergen��6%   $	 110 6P    66   �� *Naziv+6P   5,      �� 5-   
   $��Izmeni��6   $
��Left=�6P   $��
18,462,0,0q�6k   $	��Top=�6   $��78��6�   $��20��6�   $ -0.301,0.158&�6�   ��6"   �� *GoToIzmeniAlergijuCommand+6�   �� 5.   
   $��Obrisi��6   $
��Left=�6L   $��
96,462,0,0q�6g   $	��Top=�6{   $��76��6�   ��6"   �� *RemoveAlergijaCommand+6�   �� 5/   
   $��Dodaj��6   $
��Left=�6R   $��172,462,0,0q�6m   $	��Top=�6�   $��72��6�   $��20��6�   ��6!   �� *GoToDodavanjeAlergijeCommand+6�   �� 50   
   $��Prikaz podataka pacijenta��6   $
��Left=�64   $��
104,22,0,0q�6O   $	��Top=�6c   $��14(�6{   $��Italic$�6�   �� 51   
   $
��Left=�6   $��28��6/   $��	37,42,0,0q�6;   $	��Top=�6N   $	��304��6f   
���   �6r   �� 52   
   $��
dd.mm.yyyy��6   $
��Left=�6%   $��131,197,0,0q�6@   $	��Top=�6U   ���	#FFE22E2E6m   �� 53   
   $
��Left=�6   $��22��6,   $	��Top=�68   $	��375��6P   ��54      �� 55       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��56      �  � Color$ 	#FF9E9E9E��6#    � Offset$ 0Q�65   � 57      $ 	#FFC9C9C9��6#   $ 1Q�65   58      .+�5:      �� $��Obavestenja pacijenta��6   $
��Left=�64   $��28��6O   $	��Top=�6[   $	��129��6s   $��Italic$�6    �� Left$ 6��6�   
 �� Top$ -3��6�   �� 5;      $
��Left=�6   $��25��60   $	��Top=�6g   $��26��6   $	 137��6�   $ -1��6�   ��6<   �� *GoToObavestenjaCommand+��6�   Z� ��6�   Z� .��5<      �� $
��Left=�6   $��22��63   $	��Top=�6?   $��20��6W   $-��'/Bolnica;component/View/images/info.png��6b   5=      5>      �� 5?   
   $
��Left=�6   $��40��6,   $��	0,540,0,0q�68   $	��Top=�6K   $	��375��6c   ��5@      �� 5A      $ 0.5,1&�6&   $ 0.5,0&�67   .��5B      � $ 	#FFA2B4BD��6#   $ 0Q�65   � 5C      $ 	#FFD0D8DC��6#   $ 1Q�65   5D      .+�5F      �� $
��Left=�6   $��36��60   $	��Top=�6\   $��36��6t   $	 171��6�   $ 2��6�   ��6<   �� *HomeCommand+��6   Z� ��6�   Z� .��5G      �� $
��Left=�6   $��30��63   $	��Top=�6?   $��33��6W   $/��)/Bolnica;component/View/images/homean.png��6b   5H      �� 5I      $
��Left=�65   $	��Top=�6P   $��36��6h   $��36��6s   $	 117��6�   $ 3��6�   ��6   �� *BackCommand+��6   Z� ��6�   Z� .��5J      �� $
��Left=�6   $��28��63   $	��Top=�6?   $��27��6W   $.��(/Bolnica;component/View/images/bckan.png��6b   $ 1.056,0.552&�6�   5K      5L      �� 5M   
   $��Potvrdi��6   $
��Left=�6K   $	��Top=�6f   $��75��6~   $��25��6�   ���	#FFAAAAAA
���   �$��153,497,0,0q�6�   $��1,1,1,4q�6�   ��6#   �� *EditPacijentCommand+5O      5P      5Q      