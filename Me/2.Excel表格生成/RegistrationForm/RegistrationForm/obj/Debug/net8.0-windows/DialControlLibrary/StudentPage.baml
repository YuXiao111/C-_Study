   M S B A M L   `   `   `  ����K  GRegistrationForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:RegistrationForm.DialControlLibrary#RegistrationForm.DialControlLibrary  5      5    /RegistrationForm.DialControlLibrary.StudentPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:RegistrationForm.DialControlLibrary     5      $	��450��5      $	��600��5      .��5	      �   � RowDefinitions  5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�5      $��Center=�5      .+�5      �� $'��!安徽师范大学毕业生表格��6   $��Center=�5      $��25(�5      $
��Bold"�5      5      �� 5   
   $ 
Horizontal=�6   $��Center=�5      $��1��5      .+�5      �� $��	姓名：��6   $��Center=�5      �� 5       -   5         ��Name$ NameText��5       $	��200��5!      $��30��5"      �� 5$      $��	性别：��6   $��Center=�5%      �� 5&      -   5         ��Name$ SexText��5&      $	��200��5'      $��30��5(      .@�5)      �� -   5        $
��Sex1��5)       �� 
IsSelected$
 True��5*      .��61   男64   �� 5+      -   5        $
��Sex2��5+      .��6+   女6.   5,      5-      �� 5.   
   $ 
Horizontal=�6   $��Center=�5/      $��2��50      .+�51      �� $��曾用名：��6   $��Center=�52      �� 53      -   5        $ 	Name2Text��53      $	��200��54      $��30��55      �� 57      $��出生年月日：��6   $��Center=�58      (  "System.Windows.Controls.DatePicker  59      -   5          Name$ BithdayText��59      $	��200��5:      $��30��5;      5<      �� 5=   
   $ 
Horizontal=�6   $��Center=�5>      $��3��5?      .+�5@      �� $��	民族：��6   $��Center=�5A      �� 5B      -   5        $ 	minzuText��5B      $	��200��5C      $��30��5D      �� 5F      $��政治面貌：��6   $��Center=�5G      �� 5H      -   5        $ zzText��5H      $	��200��5I      $��30��5J      5K      �� 5L   
   $ 
Horizontal=�6   $��Center=�5M      $��4��5N      .+�5O      �� $��	籍贯：��6   $��Center=�5P      �� 5Q      -	   5        $ 
jiguanText��5Q      $	��200��5R      $��30��5S      �� 5U      $��健康状况：��6   $��Center=�5V      �� 5W      -
   5        $ jkText��5W      $	��200��5X      $��30��5Y      5Z      �� 5[   
   $ 
Horizontal=�6   $��5��5\      $��Center=�5]      .+�5^      �� -   5        $	��200��5^      $��60��5_      $��生成Excel表格��5`      5a      5b      5d      5e      