   M S B A M L   `   `   `  ����F  BTriArbit v1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:TriArbit_v1.AppServicesTriArbit_v1.AppServices  5      &     TriArbit_v1.AppServices.Exchange   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:TriArbit_v1.AppServices     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      .��5      � $��15 0 0 0q�6     � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   � -   5         �Name$ Success��5       � 	StaysOpen . $��Center=�62   $	��200��6E   $	��300��6R   .��5      �� ���#fff$��1q�6'   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$
 Gray��6'      ShadowDepth$ 5Q�64      
BlurRadius$ 10Q�6D      Opacity$	 1.5Q�6T   ._�5      � $��Center=�6   $��Center=�64     5      �� 5      $
��auto �6(   �� 5      $
��auto �6(   �� 5      $
��auto �6(   .+�5!      �� $��/assets/success.png��6   $	��100��69   $	��100��6E   �� 5"      $��18(�6   $#��Details Updated Successfully!��6*   ���#000$��1��6d   �� 5#      $��2��6!    �� Orientation$ 
Horizontal=�6.   $��Center=�6G   $��Bottom=�6d   $��0,20,0,0q�6   .+�5$      �� -   5        	 ��Name$	 
PopupClose��5$   1   $��Close��6!      	bottomBTN#��[  6^   $��15(�6�   �� 5%      -   5        $	 GoDashboard��5%   5   $��	Dashboard��6!     mainBTN#��[ 6d   $��15(�6�   5&      5'      5(      5)      �� 5+   
   $��0��6   ���#f1f1f1
 �� Padding$
 10 10 100 10q�63   $
��Left=�6J   ._�5,      �� $ 
Horizontal=�6   .+�5-      �� $��30��6   $��30��6#   $��/assets/Binance.png��6/   �� 5.      -   5         ��Name$ Exch_1��5.   +   $��Binance��6   $��18(�6;   $��SemiBold"�6I   $��5 0 0 0q�6_   $��Center=�6p   5/      50      �� 52   
   $��1��6   $��0 25 0 0q�6"   $ 
Horizontal=�64   .+�53      �� -   5         ��Name$	 Api��57   .   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$	 API��53      $��18(�54      $��40��6$   $	��400��60   $��5q�6<   .  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#114EFF
�������$��0 0 0 2q�56   /   $
��Left=�6I   
�������57   .   �� 58      -   5        $	 PasteAPI��58   %   $��Paste��6   $
��25 0q�6N   #��[ 6\   59      �� 5;   
   $��2��6   $��0 15 0 0q�6"   $ 
Horizontal=�64   .+�5<      �� -   5        $ Secret��5@   .   $ Secret��5<      $��18(�5=      $��40��6$   $	��400��60   $��5q�6<    �#114EFF
�������$��0 0 0 2q�5?   /   $
��Left=�6I   
�������5@   .   �� 5A      -   5        $	 PasteSecret��5A   %   $��Paste��6   $
��25 0q�6T   #��[ 6b   5B      �� 5F   
   $��4��6   $��More are coming��6   $��Center=�67   $��30(�6R   $��SemiBold"�6`   $��Center=�6v   �� 5H   
   $��5��6   $��0 0 0 15q�6"   $��Right=�64   $ 
Horizontal=�6P   .+�5I      �� -	   5        $	 	CancelBTN��5I   &   $��Cancel��6   #��[  6Q   �� 5J      -
   5        $	 	UpdateBTN��5J   &   $��Update��6   $
��25 0q�6Q   #��[ 6_   5L      5M      5O      