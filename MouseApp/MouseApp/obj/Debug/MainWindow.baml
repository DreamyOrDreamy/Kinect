   M S B A M L   `   `   `  ����C  ?MouseApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MouseAppMouseApp  5   	   9!clr-namespace:MouseApp.PropertiesMouseApp.Properties  5   	       MouseApp.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:MouseApp     5   	   8
Properties!clr-namespace:MouseApp.Properties     5   	   -   5          � Title$  KCI Application��5	   	   $	��400��6!   $	��800��6.   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      -   5         ��Name$ 
OptionsRow��5      $
��Auto �60   $��35��6>    � ColumnDefinitions 5   
   �� 5      �� 5      -   5         ��Name$ OptionsColumn��5      $	��140 �66   .+�5   
   �� ���	#FFD0D0D0$��0q�6%   (� 5   
   $��Center=�6   .��5      �� $��UniformToFill=�63   ��6   �� *ImageSource+63   5      �� 5   
   -   5         ��Name$ gridSplitter��5      $��0q�6-   $��5��68    J� Opacity$ 0Q�6B   �� 5   
   -   5        $ gridSplitter1��5      $��Stretch=�6.   $��5��6L   $��0q�6W   $��Bottom=�6b   $ 0Q�6}   �� 5   
   -   5         ��Name$ checkBox_MotionType��5      $��Absolute Motion��60   $
��Left=�6J   $��
10,0.6,0,0q�6e   $��1��6y   $��Center=�6�   $��15��6�   6�   �� 5   
   -   5        $ 	checkBox1��5      $��Show Drawings��6&   $
��Left=�6>   $��124,0.6,0,-0.6q�6Y   $��Center=�6q   $��16��6�   $��1��6�   6�   �� 5!   
   -   5         ��Name$ slider��5!      $��10.4,31,9.6,0q�6!   	 � Maximum$	 2Q�6[   $��1��6g   $	��Top=�6w   $��18��6�   
 � SmallChange$

 0.01Q�6�    � LargeChange$	 0.1Q�6�   �� 5"   
   -	   5         ��Name$ 	textBlock��5"      $��
9.4,10,0,0q�6'   $
��Wrap=�6;   $	��Top=�6O   $��1��6g   $
��Left=�6w   $��16��6�   �� 6�   $�Sensitivity: ��6�   �� 6�   �� 6�   �� 6�   �� 6�   6�   �� 5$   
   -
   5        $ slider1��5$      $��10.4,75,9.6,0q�6"   $		 1.5Q�6]   $��1��6k   $	��Top=�6{   $��18��6�   $

 0.01Q�6�   $	 0.1Q�6�   �� 5%   
   -   5        $ 
textBlock1��5%      $��
9.4,54,0,0q�6(   $
��Wrap=�6<   $	��Top=�6P   $��1��6h   $
��Left=�6x   $��16��6�   �� 6�   $�Drift Radius: ��6�   �� 6�   �� 6�   �� 6�   �� 6�   6�   5&      5'      