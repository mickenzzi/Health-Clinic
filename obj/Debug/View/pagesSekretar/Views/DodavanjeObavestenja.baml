   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Bolnica.View.pagesSekretar.Views Bolnica.View.pagesSekretar.Views  5      ;    5Bolnica.View.pagesSekretar.Views.DodavanjeObavestenja   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Bolnica.View.pagesSekretar.Views     5        N� Title$  DodavanjeObavestenja��5	      .��5
      � 
�������.+�5   
   �� $��Unos podataka obavestenja��6   $
��Left=�64   $��28��6O   $��
105,50,0,0q�6[   $	��Top=�6o   $	��185��6�   $��14(�6�   $��Italic$�6�   �� 5   
   $
��Left=�6   $��39��6/   $��	35,64,0,0q�6;   $	��Top=�6N   $	��307��6f   
���   �6r   �� 5   
   -   5        $��Poruka��5   ~   $
��Left=�6.   $	��183��6I   $��
36,177,0,0q�6V    �� TextWrapping$
 Wrap=�6j   $	��Top=�6�   $	��311��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ��6   �� *
PorukaText+6�   �� 5   
   $��Poruka:��6   $
��Left=�6"   $��23��6=   $��
34,145,0,0q�6I   $	��Top=�6]   $��80��6u   �� 5   
   $
��Left=�6   $��35��6/   $��
42,361,0,0q�6;   $
��Wrap=�6P   
���  ��$	��Top=�5   1   $	��230��6I   ��5   d   �� *-+CurrentObavestenje.ValidationErrors[Poruka]+5   I   �� 5   
   $
��Left=�6   $��40��6,   $��	0,540,0,0q�68   $	��Top=�6K   $	��375��6c   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFA2B4BD��6#    � Offset$ 0Q�65   � 5      $ 	#FFD0D8DC��6#   $ 1Q�65   5      .+�5      �� $
��Left=�6   $��36��6P   $	��Top=�6\   $��36��6t    �� Left$	 171��6�   
 �� Top$ 2��6�   ��60   �� *HomeCommand+��6   Z� ��6�   Z� .��5      �� $
��Left=�6   $��30��63   $	��Top=�6?   $��33��6W   $/��)/Bolnica;component/View/images/homean.png��6b   5      �� 5      $
��Left=�65   $	��Top=�6P   $��36��6h   $��36��6s   $	 117��6�   $ 3��6�   ��6   �� *BackCommand+��6   Z� ��6�   Z� .��5      �� $
��Left=�6   $��28��63   $	��Top=�6?   $��27��6W   $.��(/Bolnica;component/View/images/bckan.png��6b   $ 1.056,0.552&�6�   5      5      �� 5    
   $��Potvrdi��6   $
��Left=�6N   $	��Top=�6i   $��75��6�   $��25��6�   ���	#FFAAAAAA
���   �$��1,1,1,4q�6�   $��151,459,0,0q�6�   ��6#   �� *AddObavestenjeCommand+6�   5"      5#      