   M S B A M L   `   `   `  ����E  AProblema01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Problema01.windowsProblema01.windows  5   	   ,    &Problema01.windows.ListaOraseLocuitori   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Problema01.windows     5   	     � Title$2  ,Lista Orașelor peste 1 000 000 de locuitori��5   	   $	��450��6=   $	��500��6J    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � 	Resources 5         tbStyle �� Property �� Value �� 
TargetType��%D  &	        '��     '�� g    �� 5   
   �5      �� 5       � ��$ Product Sans)�67   �� 5       � ��$ 26(�65   �� 5       � ��$ Center=�6@   �� 5       � ��$ Center=�6>   �� 5       � ��$ 10 15q�63   �� 5       � ��
 ��=H�67   5      �� 5   
   " ��6   �5      �� 5       � ��
 �����67   5      �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$ 0q�60   �� 5       � ��$ Center=�64   �� 5        � ��$ 0 10 0 5q�6'   5!      5"      .��5#      �  � RowDefinitions 5$   
   �� 5%      $��* �6   �� 5&      $��6* �6   .+�5(   
   �� $��0��6   .+�5)      �� $3��-Lista orașelor peste 1 000 000 de locuitori:��6   #��[  5*      5+      �� 5-   
   -   5         ��Name$ lvOrase��5.      $��1��5-      	 �� View	 5/      �� 50      .P�51      �� $��Denumire��6%   
 �� Width$	
 160��67    �� DisplayMemberBinding 6C   �� *
Denumire+�� 52      $��Număr de locuitori��6%   $	
 160��6A    6M   �� *NrLocuitori+�� 53      $��Țara��6%   $	
 160��63    6?   �� *Tara.Denumire+54      56      57      58      