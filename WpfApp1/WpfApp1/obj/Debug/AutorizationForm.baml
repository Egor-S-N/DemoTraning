   M S B A M L   `   `   `  ????J  FEasyCaptcha.Wpf, Version=0.9.0.1, Culture=neutral, PublicKeyToken=nullJ6clr-namespace:EasyCaptcha.Wpf;assembly=EasyCaptcha.WpfEasyCaptcha.Wpf  5   	   B >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1 5   	      WpfApp1.MainWindow   5   	   ?easy6clr-namespace:EasyCaptcha.Wpf;assembly=EasyCaptcha.Wpf  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     ? Title$  Авторизация??5	   	   $	??450??6   $	??800??6*   .??5
      ? .+?5   
   G? -   5        $??PasswordHidden??5       G? PasswordChar$	 •??6,   $??19??6=   $	??190??6I   $??296,193,296,199q?6U   ?? 5   
   -   5        $??PasswordUnmask??5      $y?Hidden=?6(   $??19??6<   $	??190??6H   $??296,193,296,199q?6T   ?? 5   
   -   5        $??CB??5      $'??!Отобразить пароль??6   $
??Left=?69   $??525,197,0,0q?6T   $	??Top=?6i   6?   ?? 5   
   -   5        $??EnterButton??5      $??
Войти??6$   $
??Left=?64   $??358,253,0,0q?6O   $	??Top=?6d   $??75??6|   6?   ?? 5   
   -   5        $??LoginTextBox??5      $
??Left=?6&   $??20??6A   $??296,137,0,0q?6M    ?? TextWrapping$
 Wrap=?6b   $	??Top=?6w   $	??190??6?   ?? 5   
   $
??Left=?6   $	??100??6+   $??
346,23,0,0q?68   $	??Top=?6L   $	??100??6d   $??Sources/logo.png??6p      EasyCaptcha.Wpf.Captcha  5   
   -   5          Name$ 	MyCaptcha??5      $	??200??6*   $??50??66   $??296,236,296,133q?6B   $y?Hidden=?6[   ?? 5   
   -   5         ??Name$ CaptchaTextBox??5      $
??Left=?6*   $??20??6E   $??296,300,0,0q?6Q   $
 Wrap=?6f   $y?Hidden=?6z   $	??Top=?6?   $	??200??6?   ?? 5   
   -   5        $??ButtonAnotherCaptcha??5      $??Другая капча??6-   $
??Left=?6D   $??508,249,0,0q?6_   $	??Top=?6t   $??93??6?   $??24??6?   $y?Hidden=?6?   6?   5      5      