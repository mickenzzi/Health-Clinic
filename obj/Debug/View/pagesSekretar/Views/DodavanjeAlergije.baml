   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Bolnica.View.pagesSekretar.Views Bolnica.View.pagesSekretar.Views  5      8    2Bolnica.View.pagesSekretar.Views.DodavanjeAlergije   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:Bolnica.View.pagesSekretar.Views     5        N� Title$  DodavanjeAlergije��5      $	��580��6!   $	��375��6.   .��5	      � 
�������.+�5
   
   �� $(��"Unos osnovnih informacija alergije��6   $
��Left=�6=   $��	90,40,0,0q�6X   $	��Top=�6k   $��14(�6�   $��Italic$�6�   �� 5   
   $
��Left=�6   $��53��6/   $��	34,49,0,0q�6;   $	��Top=�6N   $	��320��6f   
���   �6r   �� 5   
   -   5        $��NazivA��5   -   $
��Left=�6   $��23��6;   $��180,323,0,0q�6G    �� TextWrapping$
 Wrap=�6\   $	��Top=�6�   $	��120��6�   ��6p   �� *NazivAlergije+ �� Mode$ TwoWay=�6�   �� 5   
   -   5        $��SifraA��5   -   $
��Left=�6   $��23��6;   $��182,253,0,0q�6G   $
 Wrap=�6\   $	��Top=�6�   $	��120��6�   ��6p   �� *SifraAlergije+$ TwoWay=�6�   �� 5   
   $��Sifra alergije:��6   $
��Left=�6*   $��
60,249,0,0q�6E   $	��Top=�6Y   �� 5   
   $��Alergen:��6   $
��Left=�6#   $��
60,319,0,0q�6>   $	��Top=�6R    J� RenderTransformOrigin$ -1.343,0.389&�6j   �� 5   
   $
��Left=�6   $��33��6/   $��182,280,0,0q�6;   $
��Wrap=�6P   
���  ��$	��Top=�5   1   $	��122��6I   ��5   d   �� *1/CurrentAlergija.ValidationErrors[SifraAlergije]+5   I   �� 5   
   $
��Left=�6   $��40��6/   $��179,346,0,0q�6;   $
��Wrap=�6P   
���  ��$	��Top=�5      $	��122��66   ��5   d   �� *)'CurrentAlergija.ValidationErrors[Naziv]+5   6   �� 5   
   $
��Left=�6   $��40��6,   $��	0,540,0,0q�68   $	��Top=�6K   $	��375��6c   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFA2B4BD��6#    � Offset$ 0Q�65   � 5      $ 	#FFD0D8DC��6#   $ 1Q�65   5      .+�5      �� $
��Left=�6   $��36��6P   $	��Top=�6\   $��36��6t    �� Left$	 171��6�   
	 �� Top$	 2��6�   ��60   �� *HomeCommand+��6   Z� ��6�   Z� .��5      �� $
��Left=�6   $��30��63   $	��Top=�6?   $��33��6W   $/��)/Bolnica;component/View/images/homean.png��6b   5      �� 5      $
��Left=�65   $	��Top=�6P   $��36��6h   $��36��6s   $	 118��6�   $	 2��6�   ��6   �� *BackCommand+��6   Z� ��6�   Z� .��5      �� $
��Left=�6   $��31��63   $	��Top=�6?   $��32��6W   $.��(/Bolnica;component/View/images/bckan.png��6b   5       5!      �� 5"   
   $��Potvrdi��6   $
��Left=�6K   $	��Top=�6f   $��75��6~   $��25��6�   ���	#FFAAAAAA
���   �$��151,455,0,0q�6�   $ 
0.113,1.08&�6�   $��1,1,1,4q�6�   ��6$   �� *AddAlergijaCommand+6�   5#      5$      