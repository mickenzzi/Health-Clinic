   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Bolnica.ModelBolnica.Model  5   	       Bolnica.View.LekarView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Bolnica.Model     5   	   -   5          � Title$  Lekar - početna��5   	   $	��720��6!   $
��1280��6.   $��20(�5	      .��5      � $��0,0,0,0q�6    � ColumnDefinitions 5   
   �� 5      $	��151 �6   �� 5      $��1122* �6    � RowDefinitions 5   
   �� 5      �� 5      $��38 �6   .+�5   
   �� $��Lekar��6   $��535,18,478,0q�6    $	��Top=�66   $��30(�6N   $��1��6\   �� 5   
   $	��100��6   $��129,18,127,0q�6!   $	��Top=�67   $��1��6O   �� 5   
   -   5         ��Name$ LekariComboBox��5       �� 
IsEditable .  �� 
IsReadOnly .  �� Text$ --- Izaberite lekara ---��6�   $��432,444,432,0q�6�   $	��Top=�6�   $��Center=�6�   $��1��6  $��24(�6  ��6+   �� *Lekari+ �� SelectedItem 6J   �� *SelectedLekar+6   � 5   
   -   5          �Name$ frejm��5      	  � NavigationUIVisibility$	 Hidden=�6   $��1��6?   �� 5   
   
 �� TextWrapping$

 Wrap=�6   $�� ��6&   {�.  $��2��6A   $��	2,2,2,5.7q�6U   ���	#FF9E9E9E$��1��6�   �� 5   
   $
��Left=�6   {�.  $��Bottom=�6A   $��0,0,0,7q�6]   $
��Wrap=�6n   $��  Bolnica Zdravo  ��6�   $��20(�6�   $
��Bold"�6�   $	��190��6�   $��2��6�   $��1��6�   �� 5   
   -   5         ��Name$ Vreme��5      $��20(�6#   $��Bottom=�61   $
��Bold"�6L   {�.   �� TextAlignment$ Right=�6p   $��1��6�   $��	891,0,0,7q�6�   $��1��6�   � 5   
   $
��Left=�6   $	��150��6*   $��0,0,0,0q�66    5       �� 5!      $	��93* �6    �� 5"      $	��93* �6    �� 5#      $	��93* �6    �� 5$      $	��93* �6    �� 5%      $	��93* �6    �� 5&      $	��93* �6    �� 5'      $	��93* �6    .+�5)      �� -   5         ��Name$ Pocetna��5)      
��� ���$��Center=�6:   $��Center=�6\    � Cursor$
 Hand��6�   .��5*      �� $��Stretch=�6   $
 Hand��6;   .+�5+      �� $3��-/Bolnica;component/View/images/LEKAR-Home.png��6   $��36��6S   $��36��6_   �� 5,      
Početna6)   5-       J� Effect 5.      3  -System.Windows.Media.Effects.DropShadowEffect  5/         
BlurRadius$ 15Q�6'      ShadowDepth$ 0Q�67   51      �� 52      -   5        $ Prikazi��52      
��� ���$��1��6c   $
 Hand��6p   ��6&   �� *PrikazTerminaCommand+.��53      �� .+�54      �� $6��0/Bolnica;component/View/images/LEKAR-Patient.png��6   $��36��6V   $��36��6b   �� 55      $��Bottom=�6    	Pacijenti6F   56       57        58      $ 15Q�6'   $ 0Q�67   5:      �� 5;      -   5        $ PrikazLekova��5;      
��� ���$��2��6g   $
 Hand��6t   ��6+   �� *PrikazLekovaCommand+.��5<      �� .+�5=      �� $5��//Bolnica;component/View/images/LEKAR-Lekovi.png��6   $��40��6U   $��40��6a   �� 5>      $��Bottom=�6    Lekovi6C   5?       5@        5A      $ 15Q�6'   $ 0Q�67   5C      �� 5D      
��� ���$��3��6)    5E        5F      $ 15Q�6'   $ 0Q�67   5H      �� 5I      
��� ���$��4��6)    5J        5K      $ 15Q�6'   $ 0Q�67   5M      �� 5N      
��� ���$��5��6)    5O        5P      $ 15Q�6'   $ 0Q�67   5R      �� 5S      -   5        $ Odjava��5S      
���  ��$��6��6K   $
 Hand��6Y   .��5T      �� .+�5U      �� $5��//Bolnica;component/View/images/LEKAR-Logout.png��6   $��36��6U   $��36��6a   �� 5V      $��Bottom=�6    Odjava6C   5W       5X        5Y      $ 15Q�6'   $ 0Q�67   5[      5\      5]      5^      