   M S B A M L   `   `   `  ����F  BTriArbit v1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:TriArbit_v1.UserServicesTriArbit_v1.UserServices  5      $    TriArbit_v1.UserServices.login   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:TriArbit_v1.UserServices     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      .��5      �   � ColumnDefinitions  5   
   �� 5      $	��300 �6   �� 5      $��* �6   .+�5   
   ��  �� CornerRadius$ 10��6   $��5q�6#   ���#114EFF._�5      �� $��0q�6   $��Center=�6$   $��Center=�6?   .+�5      �� $��/assets/logo.png��6   $	��125��62   $	��125��6>   �� 5      $��TriArbit��6   $
��Bold"�6+   $��45(�6=   $��0 0 0 50q�6K   $��Center=�6]   ���#ffff6z   �� 5      $��Let's Trade Together��6   $��25(�67   $��Center=�6E   ���#ffff6b   5      5      �� 5   
   $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0 5 15 0q�62   $��Right=�6D   $	��Top=�6`   .+�5      �� -   5         ��Name$ MimimizeBTN��5         MinimizeBTN#��[  6H   .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Minimize=�6.   5      �� 5      -   5        $ CloseBTN��5       
 topBTN#��[ 6B   .��5         $ Close=�6.   5!      5"      � 5$      -   5         �Name$ Loader��5$       � 	StaysOpen . $��Center=�65   $��Center=�5%      ��.  $��Center=�6@   .��5&      �� 
�������$	��400��6,   $	��500��69   ._�5'      �� $��Center=�6!   $��Center=�6>   .+�5(      � $��0��6&   ���#114EFF � IsIndeterminate . $	��300��6_   $��10��6k   �� 5)      $��1��6$   $��30(�61   ���#000$
��Bold"�6Q   $��Center=�6c   $��Please Wait..��6�   5*      5+      5,      � 5.      -   5        $ Success��5.       . $��Center=�66   $	��200��6I   $	��300��6V   .��5/      �� ���#fff$��1q�6+   
������� J� Effect 50      3  -System.Windows.Media.Effects.DropShadowEffect  51      	   Color$
	 Gray��6+   
   ShadowDepth$
 5Q�68      
BlurRadius$ 10Q�6H      Opacity$	 1.5Q�6X   ._�53      � $��Center=�6   $��Center=�68    � RowDefinitions 54      �� 55      $
��auto �6,   �� 56      $
��auto �6,   �� 57      $
��auto �6,   .+�5:      �� $��/assets/success.png��6    $	��100��6=   $	��100��6I   �� 5;      $��18(�6    $!��User Verified Successfully!��6.   ���#000$��1��6f   �� 5<      $��2��6%   $ 
Horizontal=�62   $��Center=�6K   $��Bottom=�6h   $��0,20,0,0q�6�   .+�5=      �� -   5        $ 
PopupClose��5=   6   $��Cancel��6%     	bottomBTN#��[ 6c   $��15(�6�   �� 5>      -   5        $ GoDashboard��5>   9   $��	Dashboard��6%     mainBTN#��[ 6h   $��15(�6�   5?      5@      5A      5B      � 5D      -   5        $ Failure��5D       . $��Center=�66   $	��200��6I   $	��300��6V   .��5E      �� ���#fff$��1q�6+   
������� 5F        5G      $
	 Gray��6+   $
 5Q�68   $ 10Q�6H   $	 1.5Q�6X   ._�5I      � $��Center=�6   $��Center=�68    5J      �� 5K      $
��auto �6,   �� 5L      $
��auto �6,   �� 5M      $
��auto �6,   .+�5P      �� $��/assets/failure.png��6    $	��100��6=   $	��100��6I   �� 5Q      $��18(�6    $��User Verification Failed!��6.   ���#000$��1��6d   �� 5R      $��2��6%   $ 
Horizontal=�62   $��Center=�6K   $��Bottom=�6h   $��0,20,0,0q�6�   .+�5S      �� -   5        $ FailureClose��5S   6   $��Cancel��6%   #��[ 6h   $��15(�6�   �� 5T      -	   5        $
 Exit��5T   4   $
��Exit��6%   #��[ 6Y   $��15(�6z   5U      5V      5W      5X      �� 5[      $
��0 50q�6   $��Center=�6'   $��Center=�6D   .+�5]      �� $��0 0 0 25q�6   $��Welcome Back, Sign In��6*   $��30(�6J   ���#000$
��Bold"�6j   �� 5_      -
   5         ��Name$ Username��5c   .   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��5_      $��5q�6D   $��18(�5`      $��40��6$   $	��400��60   .  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#114EFF$��0 0 0 25q�5a      $��Center=�6(   
�������$��0 0 0 2q�5b   /   
�������5c   @   G� 5e      -   5         G�Name$ Password��5i   .   $ Password��5e      $��18(�5f      $��40��6$   $	��400��60    �#114EFF$��0 0 0 15q�5g      $��Center=�6(   $��5q�6E   
�������$��0 0 0 2q�5h   /   
�������5i   @   �� 5k      -   5        $ LoginBTN��5k   )   $��Login��6   $��40��6R   $
��Bold"�6^   $��20(�6p   $��0 15 0 0q�6~   ���#114EFF$��0q�6�   �� 5m      $��0 15 0 0q�6   $ 
Horizontal=�6/   .+�5n      �� $��Don't have Account?��6   $��18(�6:   ���#0006H   �� 5o      -   5        $ 	SignupBTN��5o      $��Create Account��6I   
������ $��0q�6{   $��18(�6�   $
��Bold"�6�   ���#114EFF6�   5p      5r      5t      5u      5v      