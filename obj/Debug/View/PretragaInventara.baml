   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Bolnica.ViewBolnica.View  5   	   $    Bolnica.View.PretragaInventara   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Bolnica.View     5   	     � WindowStartupLocation$  CenterScreen=�5   2    � Title$ PretragaInventara��5   	   $	��450��6#   $	��800��60   .��5	      � .+�5
   
   �� -   5         ��Name$
 soba��5
      $��209,97,445.6,294q�6    6=   �� 5   
   $��	Broj Sobe��6   $��83,97,615.6,273q�6$   6?   �� 5   
   -   5         ��Name$ brojSobeBitan��5      $��380,97,376,294q�6*    d� 	IsChecked$
 TrueY�6B   6S   �� 5   
   -   5        $ tipInventaraBitan��5      $��380,154,376,237q�6.   $
 TrueY�6G   6X   �� 5   
   -   5         ��Name$ Prikazi��5      $��Prikazi��6"   $��209,233,523.6,158q�6K   6h   �� 5   
   -   5        $ Odustani��5      $��Odustani��6#   $��287,233,445.6,158q�6N   6k   �� 5   
   -   5        $��tipInventara��5      $��209,153,445.6,237q�6'   .@�5      �� $��Krevet��6   6.   �� 5      $��Operacioni sto��6   66   �� 5      $��Defibrilator��6   64   �� 5      $��AparatZaAnesteziju��6   6:   �� 5      $��Sterilizator��6   64   �� 5      $��MasinaZaEKG��6   63   5      �� 5   
   $��Tip Inventara��6   $��83,153,615.6,214q�6(   6D   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Inventar��5      $��490,97,101.6,121q�6%      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Tip Inventara��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 6]   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6<   �� *tipInventara+6]     5      $ Kolicina��6%   $		 100 6T   
 67   �� *
kolicina+6T   5      5      5       