   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Bolnica.View.pagesLekarBolnica.View.pagesLekar  5   	   2    ,Bolnica.View.pagesLekar.WindowAzuriranjeLeka   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Bolnica.View.pagesLekar     5   	     � Title$  windowAzuriranjeLeka��5   	   $	��500��6&   $	��800��63   .��5	      � .+�5
   
   � ���	#FFEBCC6D$��10,80,10,10q�6&   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ Lekovi��5      $��	0,83,60,0q�6'   $��Right=�6�   $	��313��6�   $��20(�6�   $��98��6�   $	��Top=�6�   ��6:   �� *Lekovi+ �� SelectedItem 6Y   �� *SelectedLek+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Naziv��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 320* 6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *Naziv+$ OneWay=�6_   5      �� 5      -   5        	 ��Name$	 Potvrdi��5      $��Potvrdi��6&   $��20(�68   $��199,0,0,20.4q�6s   $��38��6�   $��Bottom=�6�   $
��Left=�6�   $	��142��6�   ���	#FF0096FF��6F   �� *PotvrdaIzmeneLekaCommand+6�   �� 5      -   5        $	 Odustani��5      $��Odustani��6'   $��20(�6:   $��0,0,199.6,20.4q�6x   $��38��6�   $��Bottom=�6�   
���  ��$��Right=�6�   $	��142��6�   ��6H   �� *OdustaniOdIzmeneLekaCommand+6�   �� 5      $��Zamena:��6   $��20(�6&   $��0,29,373.6,0q�64   $��42��6J   $	��Top=�6V   $��Right=�6n   $	��103��6�   �� 5      $��	Sastojci:��6   $��20(�6(   $��297,195,393.6,132.4q�66   �� 5      -   5        
 ��Name$
 PostojecaZamena��5      $��0,35,58.6,0q�6P   $��30��6e   $	��Top=�6q   $��Right=�6�   $	��314��6�   $��20(�6�   ��6/   �� *NazivZameneLeka+6�   �� 5      -   5        $
 Sastojci��5      $��	0,0,59,83q�6(    �� TextWrapping$
 Wrap=�6Y    �� AcceptsReturn . $��Right=�6�   $	��314��6�   $��20(�6�   $��93��6�   $��Bottom=�6�   ��6;   �� *SastojciLeka+6�   �� 5      $��Naziv: ��6   $��20(�6&   $��	60,29,0,0q�64   $
��Left=�6G   $	��103��6b   $��42��6n   $	��Top=�6z   �� 5      $��
Kolicina: ��6   $��20(�6)   $��
60,167,0,0q�67   $
��Left=�6K   $	��103��6f   $��42��6r   $	��Top=�6~   �� 5      $��Sifra sobe: ��6   $��20(�6+   $��
60,235,0,0q�69   $
��Left=�6M   $	��131��6h   $��42��6t   $	��Top=�6�   �� 5      -   5        $
 	NazivLeka��5      $��	60,65,0,0q�6D   $
��Left=�6W   $	��188��6r   $��30��6~   $	��Top=�6�   $��20(�6�   ��6)   �� *	NazivLeka+6�   �� 5      -   5        $
 KolicinaLeka��5      $��
60,203,0,0q�6J   $
��Left=�6^   $	��188��6y   $��30��6�   $	��Top=�6�   $��20(�6�   ��6,   �� *KolicinaLeka+6�   �� 5      -   5        $
 	SifraSobe��5      $��
60,271,0,0q�6)   $
��Left=�6X   $	��188��6s   $��30��6   $	��Top=�6�   $��20(�6�   ��6=   �� *	SifraSobe+6�   �� 5      $��Doza:��6   $��20(�6$   $��	60,97,0,0q�62   $
��Left=�6E   $	��103��6`   $��42��6l   $	��Top=�6x   �� 5      -	   5        $

 Doza��5      $��
60,133,0,0q�6>   $
��Left=�6R   $	��188��6m   $��30��6y   $	��Top=�6�   $��20(�6�   ��6$   �� *
DozaLeka+6�   5      �� 5    
   $��23��6   $��218,57,218.6,0q�6    $	��Top=�68   �� 5!   
   $��Izmena leka��6   $	��Top=�6&   $��328,10,328.6,0q�6>   $��24(�6V   5"      5#      