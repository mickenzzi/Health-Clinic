   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Bolnica.View.pagesSekretar.Views Bolnica.View.pagesSekretar.Views  5      6    0Bolnica.View.pagesSekretar.Views.DodavanjeLekara   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Bolnica.View.pagesSekretar.Views     5        N� Title$  DodavanjeLekara��5	      .��5
      � 
�������.+�5   
   �� -   5         ��Name$	 Ime��5   H   $
��Left=�6   $��23��6U   $��140,138,0,0q�6a    �� TextWrapping$
 Wrap=�6v   $	��Top=�6�   $	��120��6�   ��6-   �� *	ImeLekara+6�   �� 5   
   $
��Ime:��6   $
��Left=�6   $��
42,138,0,0q�6:   $	��Top=�6N    J� RenderTransformOrigin$ 0.374,0.317&�6f   �� 5   
   $��Prezime:��6   $
��Left=�6#   $��
42,178,0,0q�6>   $	��Top=�6R   �� 5   
   -   5        $ Prezime��5   -   $
��Left=�6   $��23��6?   $��140,178,0,0q�6K   $
 Wrap=�6`   $	��Top=�6�   $	��120��6�   ��6t   �� *PrezimeLekara+6�   �� 5   
   $��JMBG:��6   $
��Left=�6    $��
42,218,0,0q�6;   $	��Top=�6O   �� 5   
   -   5        $
 JMBG��5   -   $
��Left=�6   $��23��6<   $��140,218,0,0q�6H   $
 Wrap=�6]   $	��Top=�6�   $	��120��6�   ��6q   �� *
JmbgLekara+6�   �� 5   
   $��Specijalista:��6   $
��Left=�6(   $��
42,338,0,0q�6C   $	��Top=�6W   �� 5   
   -   5         ��Name$ OblastiSpecijalizacije��5   2   $��Oblast specijalizacije:��6   $
��Left=�6R   $��
40,365,0,0q�6m   $	��Top=�6�   $y�Hidden=�6�   �� 5   
   -   5         ��Name$ Specijalnosti��5   C   $
��Left=�6   $��171,368,0,0q�6.    �� SelectedValuePath$ Content��6�   $	��Top=�6�   $	��120��6�   $y�Hidden=�6�    �� SelectedValue 6Z   �� *IzborSpecijalizacije+ �� UpdateSourceTrigger$ PropertyChanged=�.@�5      �� $��Kardiologija��6   �� 5      $��	Hirurgija��6   �� 5      $��Pedijatrija��6   �� 5      $��Neurologija��6   �� 5      $��
Ortopedija��6   5      �� 5   
   -   5        	 ��Name$	 Specijalista��5   &   $��CheckBox��6   $
��Left=�6�   $��17��6�   $��118,346,0,0q�6�   $	��Top=�6�   $��16��6�   
 d� 	IsChecked
 6<   �� *CheckBoxPrikaz+6�   �� 5   
   $��Datum rodjenja:��6   $
��Left=�6*   $��
42,258,0,0q�6E   $	��Top=�6Y   �� 5   
   -   5        $ DatumRodjenja��5   R   $
��Left=�6   $��23��6i   $��140,258,0,0q�6u   $
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6-   �� *DatumRodjenjaLekara+6�   �� 5   
   $��Mesto rodjenja:��6   $
��Left=�6*   $��
42,298,0,0q�6E   $	��Top=�6Y   �� 5   
   -   5        $ MestoRodjenja��5   -   $
��Left=�6   $��23��6D   $��140,298,0,0q�6P   $
 Wrap=�6e   $	��Top=�6�   $	��120��6�   ��6y   �� *MestoRodjenjaLekara+6�   �� 5    
   $&�� Unos osnovnih informacija lekara��6   $
��Left=�6;   $��	97,41,0,0q�6V   $	��Top=�6i   $��14(�6�   $��Italic$�6�   $	��215��6�   �� 5!   
   $
��Left=�6   $��52��6/   $��	40,46,0,0q�6;   $	��Top=�6N   $	��297��6f   
���   �6r   �� 5"   
   $
��Left=�6   $��17��6/   $��141,161,0,0q�6;   $
��Wrap=�6P   
���  ��$	��Top=�5#   1   $	��172��6I   $��10(�6U   ��5"   d   �� *$"CurrentLekar.ValidationErrors[Ime]+5#   U   �� 5$   
   $
��Left=�6   $��17��6/   $��141,201,0,0q�6;   $
��Wrap=�6P   
���  ��$	��Top=�5%   1   $	��172��6I   $��10(�6U   ��5$   d   �� *(&CurrentLekar.ValidationErrors[Prezime]+5%   U   �� 5&   
   $
��Left=�6   $��17��6/   $��141,240,0,0q�6;   $
��Wrap=�6P   
���  ��$	��Top=�5'   1   $	��172��6I   $��10(�6U   ��5&   d   �� *%#CurrentLekar.ValidationErrors[Jmbg]+5'   U   �� 5(   
   $
��Left=�6   $��17��6/   $��141,281,0,0q�6;   $
��Wrap=�6P   
���  ��$	��Top=�5)   1   $	��172��6I   $��10(�6U   ��5(   d   �� *.,CurrentLekar.ValidationErrors[DatumRodjenja]+5)   U   �� 5*   
   $
��Left=�6   $��17��6/   $��141,322,0,0q�6;   $
��Wrap=�6P   
���  ��$	��Top=�5+   1   $	��172��6I   $��10(�6U   ��5*   d   �� *.,CurrentLekar.ValidationErrors[MestoRodjenja]+5+   U   �� 5,   
   $��
dd.mm.yyyy��6   $
��Left=�6%   $��
44,271,0,0q�6@   $	��Top=�6T   $��76��6l   ���	#FFFD22176w   �� 5-   
   $
��Left=�6   $��40��6,   $��	0,540,0,0q�68   $	��Top=�6K   $	��375��6c   ��5.      �� 5/       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��50      �  � Color$ 	#FFA2B4BD��6#    � Offset$ 0Q�65   � 51      $ 	#FFD0D8DC��6#   $ 1Q�65   52      .+�54      �� $
��Left=�6   $��36��6Q   $	��Top=�6]   $��36��6u    �� Left$	 171��6�   
 �� Top$ 2��6�   ��60   �� *HomeCommand+��6�   Z� ��6�   Z� .��55      �� $
��Left=�6   $��30��63   $	��Top=�6?   $��33��6W   $/��)/Bolnica;component/View/images/homean.png��6b   56      �� 57      $
��Left=�65   $	��Top=�6P   $��36��6h   $��36��6s   $	 117��6�   $ 3��6�   ��6   �� *BackCommand+��6   Z� ��6�   Z� .��58      �� $
��Left=�6   $��28��63   $	��Top=�6?   $��27��6W   $.��(/Bolnica;component/View/images/bckan.png��6b   $ 1.056,0.552&�6�   59      5:      �� 5;   
   $��Potvrdi��6   $
��Left=�6H   $	��Top=�6c   $��74��6{   $��25��6�   ���	#FFAAAAAA
���   �$��1,1,1,4q�6�   $��152,470,0,0q�6�   ��6#   �� *AddLekarCommand+6�   5<      5=      