   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Bolnica.ViewBolnica.View  5   	   *    $Bolnica.View.PretragaTerminaPacijent   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Bolnica.View     5   	     � WindowStartupLocation$  CenterScreen=�5   8    � Title$ PretragaTerminaPacijent��5   	   $	��450��6)   $	��800��66   .��5	      � $��310,369,-0.4,0q�6    � ColumnDefinitions 5
   
   �� 5      $��8* �6   �� 5      $
��113* �6   .+�5   
   �� 
���   �$��-298,-342,47,229q�6#   $��2��6=   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ DatumOd��5      $��-161,-302,37,322q�6'   {�.  6A     5   
   -   5        $ DatumDo��5      $��173,-303,123,323q�6'   {�.  $��1��6S   �� 5   
   -   5         ��Name$ lekari��5      $��-161,-146,37,166q�6$   �� 5   
   -   5         ��Name$ 
brojSatiOd��5      $��-161,-244,135,267q�6&   {�.  6A   �� 5   
   -   5        $ brojMinutaOd��5      $��-63,-245,37,267q�6(   {�.  6A   �� 5   
   -   5        $ 
brojSatiDo��5      $��173,-246,221,267q�6&   {�.  $��1��6R   �� 5   
   -   5        $ brojMinutaDo��5      $��271,-246,123,266q�6(   {�.  $��1��6T   �� 5   
   $��Pocetni datum:��6   $��-274,-303,198,322q�6)   �� 5   
   $��Pretraga po datumu��6   $��-242,-342,140,354q�6-   �� 5   
   $��Krajnji datum:��6   $��60,-304,295,312q�6)   $��1��6B   �� 5   
   $��Vreme za pocetni:��6   $��-274,-245,193,263q�6,   �� 5   
   $��Vreme za krajnji:��6   $��55,-246,284,264q�6,   $��1��6E   �� 5   
   $��h��6   $��-98,-244,95,262q�6   �� 5   
   $��h��6   $��231,-246,186,264q�6   $��1��66   �� 5   
   $	��min��6   $��0,-244,445,262q�6   $��2��66   �� 5   
   $	��min��6   $��334,-246,79,264q�6   $��1��67   �� 5    
   $��Lekar:��6   $��-220,-146,198,164q�6!   �� 5!   
   -   5         ��Name$ 
bitnoVreme��5!      $��-274,-335,274,354q�6?   �� 5#   
   -	   5         ��Name$ Pretrazi��5#      $��Pretrazi��6#   $��50��6N   $��60,-146,258,129q�6Z   $��1��6s   �� 5$   
   -
   5        $ Odsutani��5$      $��Odustani��6#   $��50��6N   $��231,-146,87,129q�6Z   $��1��6s   5'      5(      