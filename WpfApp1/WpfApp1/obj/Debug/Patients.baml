   M S B A M L   `   `   `  ????B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Patients   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     ? Title$  Patients??5   	   $	??450??6   $	??800??6'   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $
??115* ?6   ?? 5      $
??274* ?6   ?? 5      $??* ?6   ?? 5      $	??44* ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ Table??5      $??	0,0,296,0q?6"      CanUserAddRows .  $??4??6L   ?? 5   
   -   5        $??
ButtonFind??5      $??
Найти??6#   $??
0,10,142,0q?63   $	??Top=?6G   $??1??6x   $??Right=?6?   $??60??6?   $??30??6?   ?? 5   
   -   5        $??FindTextBox??5      $??
0,101,82,0q?6%    ?? TextWrapping$
 Wrap=?69   $	??Top=?6M   $??Right=?6e   $	??120??6?   $??2??6?   ?? 5   
   -   5        $??	TimeLabel??5      $??
0,222,42,0q?6!   
????? ?$??1??6G   $??Right=?6T   $??78??6p   ?? 5   
   -   5        $??ResetButton??5      $??Сбросить??6$   $
??Left=?67   $??680,102,0,0q?6R   $??1??6g   $	??Top=?6t   $??55??6?   $??78??6?   6?   5      5      