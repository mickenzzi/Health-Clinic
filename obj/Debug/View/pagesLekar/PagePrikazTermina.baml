   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Bolnica.View.pagesLekarBolnica.View.pagesLekar  5      -clr-namespace:Bolnica.ModelBolnica.Model  6;   /    )Bolnica.View.pagesLekar.PagePrikazTermina   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Bolnica.View.pagesLekar     5      .local1clr-namespace:Bolnica.Model     6;     N� Title$  pagePrikazTermina��5	      .��5      � 
�������$��0,0,0,0q�6   .+�5   
   �� $��0,28,0,0q�6   .@�5      �� $��Zakazani��6   $��20(�6(   .��5      � ���	#FF9CAE9E$��5q�6.    � ColumnDefinitions 5      �� 5      .+�5      &   System.Windows.Controls.DataGrid  -   5        $��ZakazaniTermini��5      $��20,60,20,20q�6�   $��20(�6�      AutoGenerateColumns .  ��66   �� *	Termini+ �� SelectedItem 6V   ��  �� Path$ SelectedTermin� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Pacijent��61   -   5        pacijentSirina��	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 270* 5   �   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6[   �� *PacijentInfo+$ OneWay=�6�     5      $" Prostorija(tip, sprat, broj)��61   -   5        ProstorijaSirina��$
	 270* 5   �   
 6q   �� *IspisTipSpratBroj+$ OneWay=�6�     5      $ Datum i vreme��61   -   5        datumSirina��$
	 270* 5   �   
 6]   �� *
DatumVreme+ �� StringFormat$ {0:dd.MM.yy   HH:mm:ss}��$ OneWay=�6�     5      $ Tip termina��61   -   5        terminSirina��$
	 270* 5   �   
 6\   �� *
TipTermina+$ OneWay=�6�   5      �� 5      $��Izmeni termin��6   $��	20,15,0,0q�65   $��20(�6p   $
��Left=�6~   $	��150��6�   $��34��6�   $	��Top=�6�   ���	#FF0096FF��6H   �� *IzmeniTerminCommand+6�   �� 5      $��Otkaži termin��6   $��
189,15,0,0q�65   $��20(�6q   $
��Left=�6   $	��150��6�   $��34��6�   $	��Top=�6�   
���  ����6I   �� *OtkaziTerminCommand+6�   �� 5      $��Karton Pacijenta��6   $��
0,15,432,0q�68   $��20(�6w   $��34��6�   $	��Top=�6�   ���	#FF0096FF$��Right=�6�   $	��170��6�   ��6L   �� *KartonPacijentaCommand+6�   �� 5      -   5        $��Nazad��5      $��	0,15,20,0q�6-   $��20(�6N   $��Right=�6\   $	��100��6x   $��34��6�   $	��Top=�6�   
���  ��6�   �� 5      $��Pregled��6   $��
0,15,293,0q�6/   $��20(�6p   $��Right=�6~   $	��120��6�   $��34��6�   $	��Top=�6�   ���	#FF0096FF��6C   �� *AnamnezaPacijentaCommand+6�   5      5       �� 5"      $��
Nezakazani��6   $��20(�6*   .��5#      � ���	#FF9CAE9E$��5,5,5,5q�6.    5$      �� 5%      $
��Auto �6+   �� 5&      .+�5(        -   5        $��NezakazaniTermini��5(      $��20,60,380,20q�6�   $��2��6�   $��20(�6�    .  ��68   �� *	Pacijenti+ 6Z   �� $ SelectedPacijent�$ TwoWay=�$ PropertyChanged=� 5)        5*      $ Pacijent��61   $
	 350* 6q   
 6C   �� *PacijentInfo+$ OneWay=�6q     5+      $
 JMBG��61   $
	 350* 6e   
 6?   �� *Jmbg+$ OneWay=�6e   5-      �� 5/      -   5        $��ZakaziDugme��5/      $��Zakazi termin��60   $
��Left=�6H   $	��Top=�6c   $	��150��6{   $��34��6�   $��	20,15,0,0q�6�   $��2��6�   $��20(�6�   ���	#FF0096FF��6�   �� *ZakaziTerminCommand+6�   �� 50      $��Prostorija:��6   $��1��62   $��0,250,205,0q�6B   $	��Top=�6W   $��Right=�6o   $��98��6�   �� 51      -	   5        $��Nazad��51      $	��Top=�6-   $��
0,15,380,0q�6E   $��1��6g   $��Right=�6w   $	��100��6�   $��34��6�   
���  ��6�   �� 52      $��Lekar:��6   $��1��6-   $��0,160,242,0q�6=   $	��Top=�6R    J� RenderTransformOrigin$ -0.214,0.64&�6j   $��Right=�6�   $��61��6�   �� 56      -
   5         ��Name$ ProstorijeComboBox��56       �� 
IsEditable .  �� 
IsReadOnly .  �� Text$!  -- Izaberite prostoriju --��6_   $��1��6�   $��
0,290,61,0q�6�   $	��Top=�6�   $��Right=�6  $	��241��6#   6�   �� $ SelectedSoba���6�   �� *Sobe+58      �� 59      -   5        $ LekariComboBox��59       .  . $!   ---  Izaberite lekara ---��6[   $��
0,200,61,0q�6�   $	��Top=�6�   $��1��6�   $��Right=�6  $	��241��6"   6~   �� $ SelectedLekar���6�   �� *Lekari+5;      �� 5<      $��Datum i vreme:��6   $��1��65   $��
0,70,159,0q�6E   $	��Top=�6Y   $��Right=�6q   $	��144��6�   (  "System.Windows.Controls.DatePicker  5=      -   5          Name$ DatumTermina��5=   !   $��1��6c   $��0,110,158,0q�6s   $	��Top=�6�   $��Right=�6�   $	��147��6�      SelectedDate 67   �� $ SelectedDatum�6�   �� 5>      -   5        $ VremeTermina��5>      $��1��6�   $��
0,110,61,0q�6�   $	��Top=�6�   $��Right=�6�   $��92��6�   ��65   �� *	Vremena+ 6U   �� $ SelectedVreme�6�   5@      5A      �� 5C      $��Hospitalizovani��6   $��20(�6/   .��5D      � ���	#FF9CAE9E$��5q�6.    5E      �� 5F      .+�5H        -   5          Name$ Hospitalizovani��5H      $��20,60,20,20q�6�   $��20(�6�    .  ��68   �� *Hospitalizovani+ 6`   �� $ SelectedHospitalizovani�$ TwoWay=�$ PropertyChanged=� 5I        5J      $ Pacijent��61   -   5        PacijentInfo��$
	 200* 5J   �   
 6Y   �� *PacijentInfo+$ OneWay=�6�     5K      $" Prostorija(tip, sprat, broj)��61   -   5        ProstorijaInfo��$
	 250* 5K   �   
 6o   �� *IspisTipSpratBroj+$ OneWay=�6�     5L      $ Pocetak hospitalizacije��61   -   5        PocetakHospitalizacije��$
	 240* 5L   �   
 6r   �� *
DatumVreme+$ {0:dd.MM.yy   HH:mm:ss}��$ OneWay=�6�     5M      $ Kraj hospitalizacije��61   -   5        KrajHospitalizacije��$
	 240* 5M   �   
 6l   �� *KrajTermina+$ {0:dd.MM.yy   HH:mm:ss}��$ OneWay=�6�     5N      $ Krevet��61   -   5        
Krevet��$
	 200* 5N   �   
 6Q   �� *NazivKreveta+$ OneWay=�6�   5P      �� 5Q      -   5         ��Name$ Produzi��5Q      $��Produzi hospitalizaciju��6.   $
��Left=�6P   $	��Top=�6k   $	��229��6�   $��34��6�   $��	20,15,0,0q�6�   $��20(�6�   ���	#FF0096FF��6�   �� *ProduziHospitalizacijuCommand+�� 5R      -   5        $ Otpusti��5R      $��Otpusti pacijenta��6.   $
��Left=�6J   $	��Top=�6e   $	��200��6}   $��34��6�   $��
289,15,0,0q�6�   $��20(�6�   
���  ����6�   �� *OtpustiPacijentaCommand+�� 5S      -   5        $��Nazad��5S      $	��Top=�6-   $��0,15,20.4,0q�6E   $��Right=�6h   $	��100��6�   $��34��6�   
���  ��6�   5U      5W      5Y      �� 5Z   
   $��Center=�6   $
��Wrap=�61   $��Termini��6E   $	��Top=�6T   $	��127��6l   $��34��6x   $��523,6,464,0q�6�   $��24(�6�   �� 5\   
   $��Lekar:��6   $	��Top=�6!   $��
0,18,220,0q�69   $��20(�6M   $��Right=�6[   $��61��6w   �� 5]   
   -   5         ��Name$ PrijavljeniLekar��5]      {�.  $��33��6Y    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $��	0,20,10,0q�6�   $��20(�6�   $��Right=�6�   $	��200��6�   ��6>   �� *	LekarInfo+6�   5^      5_      