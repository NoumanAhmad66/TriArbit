   M S B A M L   `   `   `  ����F  BTriArbit v1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:TriArbit_v1.AppServicesTriArbit_v1.AppServices  5      '    !TriArbit_v1.AppServices.Dashboard   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:TriArbit_v1.AppServices     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � $��
15 0 15 15q�6     � ColumnDefinitions  5   
   �� 5      $
��auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��0 0 0 15q�6   $��0��60   $��0��6=   $
��Left=�6M   $	��100��6h   $	��250��6u   .��5      ��  �� Orientation$ 
Horizontal=�6   $
��Left=�62   $��Center=�6M   .+�5      �� $��Available USDT: ��6   $��25 0 0 0q�63   �� 5      -   5         ��Name$ Balance��5      $	��N/A��6-   $��Center=�68   5      5      �� 5   
   $ 
Horizontal=�6   $��0��6.   $��1��6;   .+�5        $��0 0 0 15q�6"   $
��Left=�64   $	��200��6O   .��5      �� $��Center=�6   $��Center=�6:   .+�5      �� $��1��6    $��20(�6-   $��Center=�6;   $��Spot Account��6X   �� 5      -   5         ��Name$ UpdateDashboard��5   /   $��Refresh��6      	bottomBTN#��[  5       5!      5"        5#      $��	15 0 0 15q�6"   $	��130��65   .��5$      �� $��Center=�6   $��Center=�6:   .+�5%      �� $��Status: ��6   $��20(�6/   A� 5&      -   5         A�Name$ Status��5&      
�������$��20��6:   $��20��6E   5'      5(      5)        5+   
   $	��250��6   $��1��6*   $��0��67      UniformCornerRadius$ 5Q�6G   $��0 0 15 0q�6_   .��5,      &   System.Windows.Controls.DataGrid  -   5          Name$ 
AssetsGrid��5,         AutoGenerateColumns .  	   Columns	 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Asset��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 68   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *Asset+  5/      $
 Balance��6)   $ * 6:    6D   �� *	Available+51      52        54   
   $��1��6   $��1��6+   $ 5Q�6;   .��55        -   5        $ openOrdersDataGrid��55       .  	 56        57      $

 Side��6%   $ * 6L    63   �� *Side+6L     58      $
 	Pair Name��6%   $
 auto 6S    68   �� *Symbol+6S     59      $
 Quantity��6%   $ * 6T    67   �� *
Quantity+6T     5:      $
 Price��6%   $ * 6N    64   �� *Price+6N   5<      5=      5@      5A      