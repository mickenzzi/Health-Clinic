   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Bolnica.View.pagesLekarBolnica.View.pagesLekar  5   	   <    6Bolnica.View.pagesLekar.WindowHospitalizacijaPacijenta   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Bolnica.View.pagesLekar     5   	     � Title$  HospitalizacijaPacijenta��5   
   $	��500��6+   $	��400��68   .��5	      � 
�������.+�5
   
   �� $��Hospitalizacija��6   $��128,10,117,0q�6*   $	��Top=�6@   $��20(�6X   �� 5   
   $��20��6   $��
91,50,90,0q�6    $	��Top=�64   � 5   
   $��10,70,10,10q�6   ���	#FFEBCC6D � RowDefinitions 5      �� 5      .+�5      �� $��	Pacijent:��6   $
��Left=�6(   $��	30,33,0,0q�6C   $	��Top=�6V   $��20(�6n   �� 5      -   5        $��Odustani��5      $��	0,0,60,20q�6(   $��30��6;   $��Bottom=�6G   $��Right=�6b   $	��100��6~   $��20(�6�   6�   �� 5      $��Zakazi��6   $
��Left=�6&   $��	60,0,0,20q�6A   $	��100��6T   $��30��6`   $��Bottom=�6l   $��20(�6�   ��6�   �� *ZakaziHospitalizacijuCommand+�� 5      -   5         ��Name$ PacijentInfo��5      $��142,40,30,0q�6,    �� TextWrapping$
 Wrap=�6A   {�.  $��20(�6�   $��30��6�   $	��Top=�6�   ��6U   �� *PacijentInfo+6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DatumHospitalizacije��5      $��142,140,30,0q�67   $	��Top=�6M   $��20(�6e   �� 5      $��Soba:��6   $
��Left=�6$   $��	30,88,0,0q�6?   $	��Top=�6R   $��20(�6j   �� 5      -   5         ��Name$
 Sobe��5      $��142,90,30,0q�6%   $��20(�6}   $��33��6�   $	��Top=�6�   ��6:   �� *Sobe+ �� SelectedItem 6W   �� *SelectedSoba+6�   �� 5      $��Datum:��6   $
��Left=�6%   $��
30,137,0,0q�6@   $	��Top=�6T   $��20(�6l   �� 5      $��	Trajanje:��6   $
��Left=�6(   $��
30,205,0,0q�6C   $	��Top=�6W   $��20(�6o   �� 5      -   5        $ TrajanjeHospitalizacije��5      $��142,210,180,0q�67   $
 Wrap=�6N   $��20(�6�   $��30��6�   $	��Top=�6�   ��6b   �� *TrajanjeHospitalizacije+6�   �� 5      $��(broj dana)��6   $��191,205,59.6,0q�6*   $	��Top=�6B   $��20(�6Z   �� 5      $��Krevet:��6   $��
31,256,0,0q�6&   $	��Top=�6:   $��20(�6R   $
��Left=�6`   $��70��6{   �� 5      -   5         ��Name$ TrenutnaHospitalizacija��5      $��Trenutna hospitalizacija?��6k   $��142,180,30,0q�6�   $	��Top=�6�   $��16(�6�    d� 	IsChecked 68   �� *TrenutnaHospitalizacijaCheck+6�   �� 5      -   5        $ KrevetiInventar��5      $��142,260,30,0q�60   $��20(�6�   $��33��6�   $	��Top=�6�   ��6F   �� *	Kreveti+ 6f   �� 	 �� Path$	 SelectedKrevet�6�   5       5#      5$      