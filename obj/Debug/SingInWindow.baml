   M S B A M L   `   `   `  ����A  =kurwa1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:kurwa1kurwa1  5   	       kurwa1.SingInWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:kurwa1     5   	     � Title$  SingInWindow��5   	   $	��450��6   $	��400��6+    � WindowStyle$
 None=�67    � WindowStartupLocation$ CenterScreen=�6J   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      $	��160 �6   �� 5      $
��130* �6   �� 5      $
��100* �6   .+�5   
   � -   5        $��0��5      
������ .+�5      �� $��Right=�6   .+�5      �� -   5        $��MinusB��5      $��50��6&   $��25��61   $��0 12.5 85 0q�6=   ��5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value$ Source/Minus_Passive.png��67    �� Triggers 5      �� 5   "    �� Binding 6.   �� *IsMouseOver+	 �� ElementName$	 MinusB��
 �� Value
 True6b   .a�5   &   ��  � ��$ Source/Minus_Active.png��6?   5   #   5      5      5      �� 5      $��Right=�6   .+�5       �� -   5        $��CloseB��5       $��50��6&   $��50��61   $��0 0 10 0q�6=   ��5!      �� 5"      " ��6    .�5#      ��  � ��$ Source/Close_Passive.png��67    5$      �� 5%   "    6.   �� *IsMouseOver+$	 CloseB��
 True6b   .a�5&   &   ��  � ��$ Source/Close_Active.png��6?   5'   #   5)      5+      5,      5-      � 5.   
   $��1��6   .+�5/      �� $��Center=�6   .+�50      �� $��Center=�6   $
��0 15q�6:   .+�51      �� $��Логин:��6    �� 52      -   5        $��textboxUsername��52      $	��350��65   $��35��6A   53      �� 54      $��Center=�6   $
��0 20q�6:   .+�55      �� $��Пароль:��6    �� 56      -   5        $��textboxPassword��56      $	��350��65   $��35��6A   57      58      59      � 5:   
   $��2��6   .+�5;      �� $��Center=�6   $
��0 25q�66   .+�5<      �� -   5        $��SumbitButton��5<      $��
Войти��6H   $	��100��6X   $��35��6d   5=      5>      5?      5@      