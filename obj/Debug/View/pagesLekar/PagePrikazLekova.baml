   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Bolnica.View.pagesLekarBolnica.View.pagesLekar  5      .    (Bolnica.View.pagesLekar.PagePrikazLekova   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Bolnica.View.pagesLekar     5        N� Title$  pagePrikazLekova��5	      .��5      � 
�������$��0,0,0,0q�6   .+�5   
   � ���	#FFACD987$��10,80,10,10q�6'    � RowDefinitions 5      �� 5      $
��214* �6    �� 5      $
��347* �6     � ColumnDefinitions 5      �� 5      $
��601* �6#   �� 5      $	��70* �6#   �� 5      $	��59* �6#   �� 5      $
��115* �6#   �� 5      $
��116* �6#   �� 5      $	��63* �6#   �� 5      $	��71* �6#   .+�5      �� -   5         ��Name$ 	OdobriLek��5      $��
Odobri lek��6(   $��	1,74,12,0q�6=   $��2��6�   $��20(�6�   ���	#FF0096FF$��40��6�   $	��Top=�6�   $��1��6�   $��2��6  {�6P   �� *OdobriLekIsEnabled+��6y   �� *OdobriLekCommand+6  �� 5      -   5        $��Nazad��5      $��46.5,0,42,30q�6%   $��3��6P   $��20(�6`   
���  ��$��40��6   $��Bottom=�6�   $��1��6�   $��2��6�   �� 5      $��
Izmeni lek��6   $��47.5,202,42,0q�6S   $��3��6�   $��20(�6�   ���	#FF0096FF$��40��6�   $	��Top=�6�   $��1��6�   $��2��6�   {�6*   �� *IzmeniLekIsEnabled+��6j   �� *IzmeniLekCommand+6�   �� 5      -   5        $ VratiNaIzmenu��5      $��Vrati na izmenu��6,   $	��Top=�6v   $��	17,74,0,0q�6�   $��40��6�   $��4��6�   $��20(�6�   ���	#FF0096FF$��1��6  $��2��6  {�6F   �� *VratiNaIzmenuLekIsEnabled+��6�   �� *VratiLekNaIzmenuCommand+6  &   System.Windows.Controls.DataGrid  5      -   5          Name$ Lekovi��5      $��
30,30,0,30q�6'   $��20(�6�      AutoGenerateColumns .  $��2��6�   ��6;   �� *Lekovi+ �� SelectedItem 6Z   ��  �� Path$ SelectedLek� �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ Naziv��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 200* 6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *Naziv+$ OneWay=�6_     5!      $
 Doza��6)   $	 80* 6]    67   �� *Doza+$ OneWay=�6]     5"      $ Kolicina��6)   $	 80* 6e    6;   �� *
Kolicina+$ OneWay=�6e     5#      $ Odobren��6)   $
 210* 6f    6:   �� *
StanjeLeka+$ OneWay=�6f   5%      �� 5&      $��Odobravanje leka��6   $��Center=�6/   $��33.5,7,30,0q�6S   $��3��6h   $��20(�6x   $��1��6�   $��40��6�   $	��Top=�6�   $��2��6�   �� 5'      $��12.5,38,8,0q�6   
���  ��$��3��6>   $��1��6N   $��18��6[   $	��Top=�6g   $��2��6   �� 5(      $��Izmena leka��6   $��Center=�6*   $��60.5,135,56,0q�6N   $��3��6e   $��20(�6u   $��1��6�   $��40��6�   $	��Top=�6�   $��2��6�   �� 5)      $��12.5,165,8,0q�6   
���  ��$��3��6?   $��20��6O   $	��Top=�6[   $��1��6s   $��2��6�   �� 5*      $��20(�64   $��2��6B   $��	1,77,0,11q�6R    �� TextWrapping$
 Wrap=�6e   $��4��6y   ��6   �� *SastojciLeka+6y   �� 5+      $��Sastojci leka:��6   $��2��6-   $��20(�6=   $
��Left=�6K   $��1,30,0,0q�6f   $	��Top=�6x   $��2��6�   5,      �� 5/   
   $��18��6   $��250,60,249.6,0q�6    $	��Top=�68   �� 50   
   $��Lekovi��6   $��Center=�6!   $	��Top=�6E   $��517,15,499.6,0q�6]   $��24(�6u   54      55      