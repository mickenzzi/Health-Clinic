   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Bolnica.View.pagesLekarBolnica.View.pagesLekar  5   	   4    .Bolnica.View.pagesLekar.WindowIzdavanjeRecepta   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Bolnica.View.pagesLekar     5   	     � Title$  IzdavanjeRecepta��5   	   $	��500��6"   $	��600��6/   .��5	      � .+�5
   
   � ���	#FFEBCC6D$��10,80,10,10q�6&   .+�5      �� -   5         ��Name$ 	IdTermina��5      $
��Left=�6)   $��23��6D   $��
377,95,0,0q�6P   {�.   �� TextWrapping$
 Wrap=�6v   $�� ��6�   $	��Top=�6�   $	��200��6�   $y�Hidden=�6�   �� 5      $��Ime i prezime:��6   $��55,24,384.6,0q�6-   $	��Top=�6D   $��20(�6\   �� 5      $��JMBG:��6   $
��Left=�6$   $��	55,91,0,0q�6?   $	��Top=�6R   $��20(�6j   �� 5      $��Zdravstvena ustanova:��6   $
��Left=�64   $��
55,157,0,0q�6O   $	��Top=�6c   $��20(�6{   �� 5      $��Datum izdavanja leka:��6   $
��Left=�64   $��
55,224,0,0q�6O   $	��Top=�6c   $��20(�6{   �� 5      $
��Lek:��6   $��Right=�6#   $��0,24,204.6,0q�6?   $	��Top=�6U   $��20(�6m   �� 5      $��	Kolicina:��6   $��Right=�6(   $��0,91,166.6,0q�6D   $	��Top=�6Z   $��20(�6r   �� 5      $��Način upotrebe:��6   $��Right=�6.   $��0,158,97.6,0q�6J   $	��Top=�6`   $��20(�6x   �� 5      -   5        $ Pacijent��5      $
��Left=�6(   $��30��6C   $��	55,60,0,0q�6O   {�.  $
 Wrap=�6t   $	��Top=�6�   $	��200��6�   $��20(�6�   ��6�   �� *PacijentInfo+6�   �� 5      -   5        $
 JMBG��5      $
��Left=�6$   $��30��6?   $��
55,128,0,0q�6K   {�.  $
 Wrap=�6q   $	��Top=�6�   $	��200��6�   $��20(�6�   ��6�   �� *JmbgPacijenta+6�   �� 5      -   5        $ ZdravstvenaU��5      $
��Left=�6,   $��30��6G   $��
55,194,0,0q�6S   {�.  $
 Wrap=�6y   $��Bolnica KT5��6�   $	��Top=�6�   $	��200��6�   $��20(�6�   �� 5      -   5        $ DatumIzdavanjaLeka��5      $
��Left=�62   $��30��6M   $��
55,266,0,0q�6Y   {�.  $
 Wrap=�6   $	��Top=�6�   $	��200��6�   $��20(�6�   ��6�   �� *DatumIzdavanjaLeka+6�   �� 5      -   5        $ KolicinaLeka��5      $��30��6,   $��0,128,54.6,0q�68   $
 Wrap=�6N   $	��Top=�6|   $��20(�6�   $��Right=�6�   $	��195��6�   ��6b   �� *
Kolicina+6�   �� 5      -   5        $ NacinUpotrebe��5      $��0,194,54.6,0q�6-   $
 Wrap=�6C    �� AcceptsReturn . $��20(�6�   $	��102��6�   $	��Top=�6�   $��Right=�6�   $	��195��6�   ��6W   �� *NacinUpotrebe+6�   �� 5      $��Izdaj Recept��6   $
��Left=�6,   $��
130,0,0,25q�6G   $	��130��6[   $��20(�6�   $��31��6�   $��Bottom=�6�   ��6g   �� *IzdajReceptCommand+6�   �� 5      -   5        $��Odustani��5      $��0,0,129.6,24.4q�6(   $��Right=�6@   $	��100��6\   $��20(�6y   $��30��6�   $��Bottom=�6�   �� 5      -	   5         ��Name$ LekoviComboBox��5      $��0,60,54.6,0q�6z   $	��Top=�6�   $��20(�6�   $��Right=�6�   $	��195��6�   ��6/   �� *Lekovi+ �� SelectedItem 6N   ��  �� Path$ SelectedLek�6�   5      �� 5   
   $��Izdavanje recepta��6   $��214,13,215.6,0q�6,   $	��Top=�6D   $��20(�6\   �� 5    
   $��20��6   $��191,55,190.6,0q�6    $	��Top=�68   5!      5"      