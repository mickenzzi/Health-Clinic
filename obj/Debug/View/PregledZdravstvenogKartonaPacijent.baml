   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Bolnica.ViewBolnica.View  5   	   5    /Bolnica.View.PregledZdravstvenogKartonaPacijent   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Bolnica.View     5   	     � WindowStartupLocation$  CenterScreen=�5   C    � Title$  ��5   	   $	��768��6   $
��1024��6    � WindowStyle$
 None=�5	   	   .��5
      � .+�5   
   �� $��3��6   
���   �$��25,60,25,436q�67   �� 5   
   -   5         ��Name$ 
imePrezime��5   2   $��25(�6    �� 
IsReadOnly . $��40��6F   $��212,85,515,635q�6R   �� 5   
   -   5        $��datumRodjenja��5   4   $��25(�6    . $��40��6I   $��226,133,515,587q�6U   �� 5   
   -   5        $��mestoStanovanja��5   4   $��25(�6    . $��40��6K   $��256,204,489,516q�6W   �� 5   
   -   5        $��
ulicaIBroj��5   4   $��25(�6    . $��40��6G   $��677,207,73,513q�6S   �� 5   
   -   5        $
��JMBG��5   4   $��25(�6    . $��40��6@   $��622,142,122,578q�6L   �� 5   
   -   5        $	��pol��5   4   $��25(�6    . $��40��6?   $��592,87,144,633q�6K   �� 5   
   -   5        $��bracniStatus��5   3   $��25(�6    . $��40��6G   $��212,273,538,447q�6S   �� 5   
   -   5        $��telefon��5   4   $��25(�6    . $��40��6C   $��645,262,122,458q�6O   �� 5   
   $��25(�6   $��Ime i prezime��6   $��40,80,790,628q�66   6O   �� 5   
   $��25(�6   $
��JMBG��6   $��532,137,399,573q�6-   6H   �� 5   
   $��25(�6   $	��Pol��6   $��532,80,429,628q�6,   6F   �� 5   
   $��25(�6   $��Bračni status��6   $��40,263,804,436q�66   6P   �� 5   
   $��25(�6   $��Mesto stanovanja��6   $��40,202,760,497q�69   6S   �� 5   
   $��25(�6   $��Datum rođenja��6   $��40,137,790,563q�66   6P   �� 5   
   $��25(�6   $��Telefon��6   $��532,263,371,447q�60   6K   �� 5   
   $��25(�6   $��Ulica i broj��6   $��532,202,339,511q�65   6P   �� 5   
   $��Osnovni Podaci��6   $��30(�6)   $��SemiBold"�67   $��24,10,760,685q�6M   6g   �� 5   
   $��Lista bolesti��6   $��30(�6(   $��SemiBold"�66   $��25,345,759,344q�6L   6g   &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ Bolesti��5   �   $   HorizontalScrollBarVisibility$ Disabled=�6      CanUserResizeColumns .     CanUserReorderColumns .  $��3q�6w   
���   �$��25(�6�   	   AutoGenerateColumns	 .  $��32,395,470,121q�6�   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ Naziv bolesti��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 240 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *Naziv+6V     5!      $ Datum dijagnoze��6%   $	 270 6a    6>   �� *DatumDijagnoze+6a   5#      �� 5$   
   -
   5         ��Name$ prikaziTerapiju��5$      $��Prikazi terapiju��6*   $��167,668,594,26q�6e   $��65��6}   $	��255��6�   $��25(�6�   $��2q�6�   6�   �� 5%   
   -   5        $ nazad��5%      $��Nazad��6    $��532,668,229,26q�6E   $��65��6]   $	��255��6i   $��25(�6u   $��2q�6�   6�   �� 5&   
   $��Anamneza��6   $��30(�6#   $��SemiBold"�61   $��575,345,209,344q�6G   6c   �� 5'   
   -   5        $��anamneza��5'       . $��25(�66   $��3q�6D   
���   �$��575,395,25,121q�6l   6�   5(      5)      