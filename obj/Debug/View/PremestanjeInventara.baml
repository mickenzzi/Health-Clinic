   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Bolnica.ViewBolnica.View  5   	   '    !Bolnica.View.PremestanjeInventara   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Bolnica.View     5   	     � WindowStartupLocation$  CenterScreen=�5   5    � Title$ PremestanjeInventara��5   	   $	��450��6&   $	��800��63   .��5	      � .+�5
   
   �� $��Soba iz koje premestate: ��6   $��10,41,637.6,331q�64   6O   �� 5   
   $��
Kolicina: ��6   $��221,101,488,273q�6%    J� RenderTransformOrigin$ -0.387,1.141&�6>   6e   �� 5   
   -   5         ��Name$ soba1��5      $��161,39,538.6,352q�6!   6>   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ InventarSobe1��5      $��10,92,581.6,126q�6*      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Tip Inventara��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *tipInventara+6]     5      $ Kolicina��6%   $	 100 6T    67   �� *
kolicina+6T   5        5   
   -   5        $ InventarSobe2��5      $��582,92,9.6,126q�6*    5        5      $ Tip Inventara��6%   $	 100 6]    6<   �� *tipInventara+6]     5      $ Kolicina��6%   $	 100 6T    67   �� *
kolicina+6T   5      �� 5   
   -   5        	 ��Name$	 Povratak��5      $��Povratak��6#   $��419,352,289.6,34q�6N   6j   �� 5   
   -   5        $	 Azuriraj��5      $��Premesti��6#   $��258,352,450.6,34q�6N   6j   �� 5   
   -   5        $	 Prikazi1��5      $��Prikazi��6#   $��287,41,445.6,350q�6M   6i   �� 5   
   -   5        $	 Prikazi2��5      $��Prikazi��6#   $��723,39,9.6,352q�6M   �� 5   
   -   5        $ soba2��5      $��596,39,103.6,352q�6!   �� 5   
   $��Soba u koju premestate: ��6   $��450,39,197.6,335q�63   �� 5   
   $��Datum prmestanja: ��6   $��221,151,441.6,222q�6-   6J   �� 5    
   $��Vreme premestanja: ��6   $��212,211,450.6,161q�6.   6K   �� 5!   
   $��h��6   $��410,211,343.6,161q�6   69   �� 5"   
   $	��min��6   $��514,209,233.6,163q�6   6;   (  "System.Windows.Controls.DatePicker  5#   
   -	   5        $��DatumPomeranja��5#      $��352,152,285.6,233q�6+   
   BlackoutDates
 5$      /  )System.Windows.Controls.CalendarDateRange  5%         Start$ 1/1/2010��6$   
   End$ 	4/18/2020��65   5'      �� 5(   
   -
   5        $ brojSati��5(      $��348,211,391.6,182q�6$   6A   �� 5)   
   -   5        $ 
brojMinuta��5)      $��450,211,289.6,182q�6&   6C   �� 5*   
   -   5        $ kolicina��5*      $��352,101,356.6,290q�6$   5+      5,      