   M S B A M L   `   `   `  ����A  =WPFKCK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPFKCK.View.MainMenuWPFKCK.View.MainMenu  5   	   #    WPFKCK.View.MainMenu.Register   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WPFKCK.View.MainMenu     5   	     N� Title$  Register��5   	   $	��300��6   $	��300��6'   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��	InfoLabel��5      $��2��6!   $��10q�65   $��Center=�6A   6`   � 5   
   $��1��6    5      �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    .+�5      �� $��Center=�6   $��0��6/   $��Name: ��6<   �� 5      $��Center=�6   $��1��6/   $��
Password: ��6<   �� 5      $��Center=�6   $��2��6/   $��Re-Password: ��6<   �� 5       $��Center=�6   $��3��6/   $��Goal: ��6<   �� 5!      $��Center=�6   $��4��6/   $��Swim divider: ��6<   �� 5"      $��Center=�6   $��5��6/   $��Bike divider: ��6<   5#      � 5$   
   $��1��6   $��1��6    5%      �� 5&      $��* �6    �� 5'      $��* �6    �� 5(      $��* �6    �� 5)      $��* �6    �� 5*      $��* �6    �� 5+      $��* �6    .+�5-      �� -   5        $��NameTextBox��5-   ?   $��Center=�6   $��0��62   6?   G� 5.      -   5        $��PasswordTextBox��5.   C   $��Center=�6   $��1��66   6C   G� 5/      -   5        $��RePasswordTextBox��5/   C   $��Center=�6   $��2��66   6C   �� 50      -   5        $��GoalTextBox��50   ?   $��Center=�6   $��3��62   6R   �� 51      -   5        $��SwimDividerTextBox��51   ?   $��Center=�6   $��4��62   6Y   �� 52      -   5        $��BikeDividerTextBox��52   ?   $��Center=�6   $��5��62   6Y   53      �� 54   
   $��Center=�6    �� Orientation$ 
Horizontal=�62   $��2��6K   $��2��6X   .+�55      �� -   5        $��
BackButton��55   #   $
��10,5q�6   $
��Back��65   $��Center=�6D   $��Center=�6_   6|   �� 56      -	   5        $��RegisterButton��56   #   $
��10,5q�6   $��Register��69   $��Center=�6L   $��Center=�6g   6�   57      58      59      