   M S B A M L   `   `   `  ����M  IRäknaProgramTilde, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:RäknaProgramTildeRäknaProgramTilde  5   	   "    RäknaProgramTilde.StartMenu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:RäknaProgramTilde     5   	     � Title$  	StartMenu��5   	   $��296.673��6   $��266.858��6,   .��5	      � -   5         �Name$
 Grid��5	      $��0,0,-7,-151.667q�6   $	��419��62   $	��Top=�6?   $
��Left=�6W   $	��267��6r   
��� ��� � Triggers 5
   
   :� 5       :� RoutedEvent$ 
MouseEnter��6   .[�5      �� .��5      �� .��5      ��  �� From$ TomatoX�6)   	 �� To$
 GoldX�67    �� TargetProperty$/ )(Grid.Background).(SolidColorBrush.Color)�5   -    g� FillBehavior$
 Stop=�5   -    g� RepeatBehavior$ 10��5   -   	 g� AutoReverse	 . 
 g� Duration$
 0:0:3D�5   -   5      5      5      .+�5   
   �� -   5         ��Name$ btNormalMode��5      $��
NormalMode��6'   $
��Left=�6<   $��	10,32,0,0q�6W   $	��Top=�6j   $��75��6�   $��61��6�   �� 5   
   -   5        $ btMixedMode��5      $��	MixedMode��6&   $
��Left=�6:   $��	90,32,0,0q�6U   $	��Top=�6h   $��75��6�   $��61��6�   �� 5   
   -   5        $ btAdditonAndSubtraction��5      $��+ And -��62   $
��Left=�6D   $��
170,32,0,0q�6_   $	��Top=�6s   $��75��6�   $��61��6�   6�   �� 5   
   -   5         ��Name$ comboBox��5      $
��Left=�6%   $	��Top=�6@   $	��235��6X   $��
10,121,0,0q�6d    �� 
IsReadOnly . $��21��6�   5      5      