   M S B A M L   `   `   `  ����F  BTriArbit v1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:TriArbit_v1.AppServicesTriArbit_v1.AppServices  5      %    TriArbit_v1.AppServices.Profile   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:TriArbit_v1.AppServices     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      .��5      � $��15 0 0 0q�6     � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0 0 0 15q�6   $��Update Profile��6"   $��30(�6;   ���#000$��0��6[   $��SemiBold"�6h   � 5   
   -   5         �Name$ Success��5       � 	StaysOpen . $��Center=�62   $	��200��6E   $	��300��6R   .��5      �� ���#fff$��1q�6'   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$
 Gray��6'      ShadowDepth$ 5Q�64      
BlurRadius$ 10Q�6D      Opacity$	 1.5Q�6T   ._�5      � $��Center=�6   $��Center=�64     5      �� 5       $
��auto �6(   �� 5!      $
��auto �6(   �� 5"      $
��auto �6(   .+�5%      �� $��/assets/success.png��6   $	��100��69   $	��100��6E   �� 5&      $��18(�6   $#��Details Updated Successfully!��6*   ���#000$��1��6d   �� 5'      $��2��6!    �� Orientation$ 
Horizontal=�6.   $��Center=�6G   $��Bottom=�6d   $��0,20,0,0q�6   .+�5(      �� -   5        	 ��Name$	 
PopupClose��5(   1   $��Close��6!      	bottomBTN#��[  6^   $��15(�6�   �� 5)      -   5        $	 GoDashboard��5)   5   $��	Dashboard��6!     mainBTN#��[ 6d   $��15(�6�   5*      5+      5,      5-      �� 50   
   $ 
Horizontal=�6   $��0 0 0 15q�6.   $��1��6@   .+�51      �� $��Profile Picture��6   $��18(�62   $��0 0 15 0q�6@   $��Center=�6R   �� 52      -   5        $	 
ProfilePic��52   /   $��Choose File��6   #��[ 6\   $	��125��6}   53      �� 54      -   5        
 ��Name$
 FullName��58   .   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Full Name��54      $��18(�55      $��40��6$   $	��400��60   $��5q�6<   $��0 0 0 15q�56      .  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �#114EFF
�������$��0 0 0 2q�57   /   $
��Left=�6I   
�������$��2��59      5:      �� 5<      -   5        $
 Username��5A   .   $ Username��5<      $��5q�6@   $��18(�5=      $��40��6$   $	��400��60    �#114EFF$��0 0 0 15q�5>      $
��Left=�6(   $��3��5?       �� 
IsReadOnly . 
�������$��0 0 0 2q�5@   /   
�������5A   .   �� 5C      -   5        $
 Email��5H   .   $ Email��5C      $��18(�5D      $��40��6$   $	��400��60   $��5q�6<   $��0 0 0 15q�5E      $
��Left=�6(    �#114EFF$��4��5F      
�������$��0 0 0 2q�5G   /   
�������5H   =   G� 5J      -   5         G�Name$ Password��5O   .   $ Password��5J      $��18(�5K      $��40��6$   $	��400��60   $��5q�6<   $��0 0 0 15q�5L      $
��Left=�6(    �#114EFF$��5��5M      
�������$��0 0 0 2q�5N   /   
�������5O   @   �� 5Q   
   $��6��6   �� 5R   
   $��7��6   $��0 0 0 15q�6"   $��Right=�64   $ 
Horizontal=�6P   .+�5S      �� -	   5        $	 	CancelBTN��5S   &   $��Cancel��6   #��[  6Q   �� 5T      -
   5        $	 	UpdateBTN��5T   &   $��Update��6   $
��25 0q�6Q   #��[ 6_   5U      5V      5Y      