   M S B A M L   `   `   `  ����E  AProblema01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Problema01
Problema01  5   	       Problema01.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Problema01     5   	     � Title$  Orase��5   	   $	��500��6   $	��600��6$    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � 	Resources 5       �� 
TargetType �� Property �� Value   
stckStyle1  
stckStyle2 �� 
TargetType �� CornerRadius	 �� Triggers
 P� Property P� Value��%�  '��       &	      &	 d    '�� �    '�� .    �� 5   
   " ��6   �5      �� 5       � ��$ Product Sans)�6/   �� 5       � ��$ 26(�6-   �� 5       � ��$ Center=�68   �� 5       � ��$ Center=�66   �� 5       � ��$ 10q�6+   �� 5       � ��
 ��  �6/   5      �� 5   
   �5      �� 5       � ��
 �����67   5      �� 5   
   �5      �� 5       � ��
 ���w�67   �� 5       � ��$	 220��62   5       �� 5!   
   " ��6   �5"      �� 5#       � ��$ Product Sans)�6/   �� 5$       � ��
 ��ح�6/   �� 5%       � ��$ 15(�6-   �� 5&       � ��$	 5 8q�6+   �� 5'       � ��$ 10q�6,   �� 5(       �@�Cursor$
 Hand��6+   �� 5)       � �� 5*      �� 5+      " ��6*   .R�5,      �� $ 10��6%   #��z��5-   %   ._�5.   "   �� $��Center=�63   $��Center=�5/   3   #��z��50   3   51      52      54      	 56      P� 57      
 �@J�IsMouseOver$
 True��61   . �58      ��  � ��
 �����63   59      5;      �� 5<   
   " ��6   �5=      �� 5>       � ��$ UniformToFill=�6,   �� 5?       � ��$ Center=�68   5A      5B      .��5D      ]� .+�5E   
   �� $	��Top=�6   #��[  5F      .+�5G      �� $��Aplicația Orașe��5H      5I      �� 5J   
   $
��Left=�6   #��[ 5K      .+�5L      �� -   5         ��Name$ btnIntroduTari��5M      $��Introdu țări��5L      ��5N      �� *AddCommandTari+�� 5P      -   5        $ btnListaTarilor��5Q      $��Lista țărilor��5P      ��5R      �� *
ShowTari+�� 5T      -   5        $ btnIntroduOrase��5U      $��Introdu orașe��5T      ��5V      �� *AddCommandOrase+�� 5X      -   5        $ btnListaOraselor��5Y      $��Lista orașelor��5X      ��5Z      �� *	ShowOrase+�� 5\      -   5        $ btnListaOraseLocuitori��5\      ��5]      �� *ShowListaOraseLocuitori+.��5^      �� $2��,Lista orașelor cu locuitori peste 1 000 000��6   $
��Wrap=�5_       �� TextAlignment$ Center=�5a      ��5`      Z� 5a      5b      �� 5d      -   5        $ btnListaTariContinent��5d      ��5e      �� *ShowListaTariContinent+.��5f      �� $+��%Lista țărilor unui anumit continent��6   $
��Wrap=�5g      $ Center=�5i      ��5h      Z� 5i      5j      �� 5k      -   5        $ btnListaTaraCuOrase��5k      ��5l      �� *ShowListaTaraCuOrase+.��5m      �� $+��%Lista țărilor cu numărul de orașe��6   $
��Wrap=�5n      $ Center=�5p      ��5o      Z� 5p      5q      5s      �� 5t   
   $��Right=�6   $��images/city.jpg��5u      5v      5w      