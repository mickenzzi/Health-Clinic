   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Bolnica.View.pagesLekarBolnica.View.pagesLekar  5   	   -clr-namespace:Bolnica.ModelBolnica.Model  6=   0    *Bolnica.View.pagesLekar.WindowIzmeniTermin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Bolnica.View.pagesLekar     5   	   -Modelclr-namespace:Bolnica.Model     6=     � Title$  IzmeniTermin��5   	   $	��450��6   $	��600��6+   .��5	      � .+�5
   
   � ���	#FFEBCC6D$��10,80,10,10q�6&   .+�5      �� $��	Pacijent:��6   $��	90,35,0,0q�6(   $
��Left=�6;   $��95��6V   $��35��6a   $	��Top=�6m   $��20(�6�   �� 5      $��JMBG:��6   $��	90,75,0,0q�6$   $
��Left=�67   $��95��6R   $��35��6]   $	��Top=�6i   $��20(�6�   �� 5      $��Prostorija:��6   $��
90,115,0,0q�6*   $��40��6>   $	��Top=�6J   $
��Left=�6b   $	��100��6}   $��20(�6�   �� 5      -   5         ��Name$ InfoPacijenta��5      $��254,40,89.6,0q�6-    �� TextWrapping$
 Wrap=�6D   {�.  $��30��6�   $	��Top=�6�   $��20(�6�   ��6j   �� *PacijentInfo+6�   �� 5      -   5        $
 JMBG��5      $��254,80,89.6,0q�6$   $
 Wrap=�6;   {�.  $��30��6�   $	��Top=�6�   $��20(�6�   ��6a   �� *JmbgPacijenta+6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DatumTermina��5      $
��Left=�6V   $��254,162,0,0q�6q   $	��Top=�6�   $	��158��6�   $��30��6�    J� RenderTransformOrigin$ 0.322,-0.457&�6�   $��20(�6�      SelectedDate 6/   �� *SelectedDatum+6�   �� 5      -   5         ��Name$ VremeTermina��5       �� 
IsEditable .  �� 
IsReadOnly . $��416,162,89.6,0q�6�   $��30��6�   $	��Top=�6�   $��20(�6�   ��6?   �� *	Vremena+	 �� SelectedItem	 6_   �� *SelectedVreme+6�   �� 5      $��Datum i vreme:��6   $
��Left=�6-   $��
90,155,0,0q�6H   $	��Top=�6\   $��20(�6t   �� 5      -   5        $��Odustani��5      $��
0,0,150,40q�6(   $��Right=�6M   $	��100��6i   $��30��6u   $��Bottom=�6�   $��20(�6�   
���  ��6�   �� 5      $��Potvrdi��6   $��
150,0,0,40q�6'   $
��Left=�6k   $	��100��6�   $��30��6�   $��Bottom=�6�   $��20(�6�   ���	#FF0096FF��6;   �� *PotvrdaIzmeneTerminaCommand+6�   �� 5      $��Lekar:��6   $��
90,197,0,0q�6%   $
��Left=�69   $��83��6T   $��37��6_   $	��Top=�6k   $��20(�6�   �� 5      -   5        $ 
InfoLekara��5      $��0,199,89.6,0q�6*   $
 Wrap=�6@   {�.  $��20(�6�   $��35��6�   $	��Top=�6�   $��Right=�6�   $	��230��6�   ��6f   �� *	LekarInfo+6�   �� 5      -   5        $ ProstorijeComboBox��5       .  . $��254,117,89.6,0q�6�   $	��Top=�6�   $��30��6�   $��20(�6�   ��6W   �� *Sobe+	 6t   �� 
 �� Path$
 SelectedSoba� �� Text 6�   �� *SelectedSobaText+5      �� 5      $��Izmena termina��6   $��212,-65,212,0q�6-   $	��Top=�6D   $��20(�6\   �� 5      $��20��6   $��181,-23,181,0q�6$   $	��Top=�6;   5!      5"      5#      