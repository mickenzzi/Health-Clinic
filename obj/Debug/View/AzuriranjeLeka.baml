   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Bolnica.ViewBolnica.View  5   	   !    Bolnica.View.AzuriranjeLeka   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Bolnica.View     5   	     � WindowStartupLocation$  CenterScreen=�5   /    � Title$ AzuriranjeLeka��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   �� $��Zamena:��6   $��20(�6"   $��317,45,374,333q�60   �� 5   
   $��	Sastojci:��6   $��20(�6$   $��317,205,374,173q�62   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Lekovi��5      $��430,95,60,219q�6#      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Naziv��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 300 6[   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *naziv+ �� Mode$ OneWay=�6[   5      �� 5   
   -   5         ��Name$ Sastojci��5      $��430,210,60,109q�6$   	 �� TextWrapping$
	 Wrap=�6<   
 �� AcceptsReturn
 . 6P   �� 5   
   -   5         ��Name$ Potvrdi��5      $��Potvrdi��6"   $��20(�64   $��200,342,452,40q�6Y   �� 5   
   -   5        $ Odustani��5      $��Odustani��6#   $��20(�66   $��452,342,200,40q�6\   �� 5   
   $��Label��6   $
��Left=�6    $��0��6;   $��339,182,0,0q�6F   $	��Top=�6[   $��1��6s   �� 5   
   -   5        $ PostojecaZamena��5      $��430,45,60,333q�6+   �� 5   
   $��Naziv: ��6   $��20(�6"   $��60,22,631,356q�60   �� 5   
   $��
Kolicina: ��6   $��20(�6%   $��60,174,631,204q�63   �� 5   
   $��Sifra sobe: ��6   $��20(�6'   $��60,250,603,128q�65   �� 5   
   -   5        $ 	NazivLeka��5      $��60,60,546,318q�6%   �� 5   
   -   5        $ KolicinaLeka��5      $��60,212,546,166q�6(   �� 5   
   -   5        $ 	SifraSobe��5      $��60,288,546,90q�6%   �� 5   
   $��Doza:��6   $��20(�6    $��60,98,631,280q�6.   �� 5   
   -	   5        $
 Doza��5      $��60,136,546,242q�6    5$      5%      