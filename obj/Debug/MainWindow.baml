   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BolnicaBolnica  5   	       Bolnica.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Bolnica     5   	     � WindowStartupLocation$  CenterScreen=�5   &    � Title$ Klinika��5   	   $	��620��6   $	��388��6&    � 
ResizeMode$ NoResize=�5	   	   .��5
      � $��0,0,0,0q�6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF202985��6    � Offset$ 0Q�61   � 5      $ 	#FFC9AEDC��6   $
 0.73Q�61   5      .+�5   
   �� $��Right=�6   $	��100��6,   $��Bottom=�69   $	��100��6T   $��View/images/logo.png��6`   $��	0,0,145,3q�6~    J� RenderTransformOrigin$ 2.875,-0.13&�6�   � 5   
   $��Center=�6   $	��356��6,   $��
43,84,39,0q�69   $	��Top=�6M   $	��300��6e   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ White��6#   $ 0Q�61   � 5      $ 	#FFB1B3B5��6#   $ 1Q�65   5      .+�5      �� $��Sifra��6   $
��Left=�6$   $	��Top=�6?   $��18(�6W   ���	#FF040404$ 0.324,0.483&�6|   $
��Bold"�6�   $��
16,148,0,0q�6�   �� 5      $��Korisnicko ime��6   $
��Left=�6-   $	��Top=�6H   ���	#FF040404$ 0.324,0.483&�6w   $
��Bold"�6�   $��	19,93,0,0q�6�   $��18(�6�   �� 5      -   5        $��Login��5      $��Center=�66   $	��Top=�6S   $	��206��6k   $��36��6x   ���	#FFF9F9F9$��16(�6�   $
��Bold"�6�   $��44,264,50,0q�6�   ��5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5      � $ 	#FFC9AEDC��6'   $ 0Q�69   � 5      $ 	#FF202985��6'   $ 0.833Q�69   5       5"      �� 5#      $��LOGIN��6   ���	#FF131313$��Times New Roman)�6;   $��36(�6X   $��Italic$�6f   $ 0.5,0.5&�6y   $��ExtraExpanded&�6�   $��80,24,77,278q�6�   z�5$      V� 5%      .~�5&      �� �� 5'       �� AngleX$ -1.975Q�6(   �� 5(      T� 5)      	 T� X$	 0.466Q�6-   5*      5,      G� 5-      -   5        
 G�Name$
 Sifra��5-      $��20,181,16,148q�6)   �� 5.      -   5         ��Name$ Korisnik��5.   1   $
��Left=�6   $��24��6D    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��262��6|    � UseLayoutRounding .  
�������$ 0.452,2.348&�6�   $��
20,127,0,0q�6�   �� 5/      $��Nemate nalog?��6   $
��Left=�6,   $��
50,302,0,0q�6G   $	��Top=�6[   $
��Bold"�6s   $��14(�6�   �� 50      -   5        $��Registrujte se!��50      $
��Left=�6O   $��152,302,0,0q�6j   $	��Top=�6   ���	#FF1600EA$��14(�6�   51       � 52   
   -   5          �Name$ _mainWindow��52        � NavigationUIVisibility$ Hidden=�6%   53      54      