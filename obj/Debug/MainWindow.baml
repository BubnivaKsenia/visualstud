   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	       WpfApp.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � Icon$! /Resources/service_logo.ico��65   .��5	      �  � RowDefinitions 5
   
   �� 5      $��60 �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   � $��0��6   
�������6   � 5   
   $��2��6   
�������6   �� 5   
   $
��Auto��6   $
��Auto��6   $��0��6+   $
��Left=�68   $��10,0,0,0q�6S   $!��/Resources/service_logo.png��6e   �� 5   
   $��Center=�6   $��Center=�61   $��22(�6L   $��Comic Sans MS)�6Z   ��6u   ��  �� ElementName$ MainFrameGrid�� �� Path$ Content.Title��� 5   
   -   5         ��Name$ Btn_Back��5      $��0��6#   $��Right=�60   $��0,0,10,0q�6L   $	��100��6_   $��30��6k   ��6w   Z� .��6�   Back6�    � 5   
   -   5          �Name$ MainFrameGrid��5        � NavigationUIVisibility$ Hidden=�6'   $��1��6G   5      5      