   M S B A M L   `   `   `  ����A  =MediaP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:_05_Controls_3_05_Controls_3  5   	       _05_Controls_3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:_05_Controls_3     5   	     � Title$  
MainWindow��5   	   $	��610��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��10* �6   �� 5      .+�5   
   ]� .+�5      r� -   5        $��media��5       r� LoadedBehavior$ Manual=�6(   5      5      �� 5   
   -   5         ��Name$ spList��5      $y�Hidden=�6%   .+�5      �� -   5         ��Name$ listPlay��5      5      5      �� 5   
   $��1��6   .+�5      �� -   5         ��Name$ 	sTimeLips��5      $��1q�6(    � Minimum$ 0Q�5   !   6-   �� 5      $��Center=�5      $��Center=�5       �� Orientation$ 
Horizontal=�5      .+�5      �� -   5         ��Name$
 time��5      $��0 0 10 0q�6*   $��00:00��6<   $	��Top=�6I   $��17��6a   �� 5      -   5        	 ��Name$	 btnSoundOnOff��5      $��20��60   $��20��6;   $��2q�6G   $	��off��6R   5!      �� 5"      -   5        $	 btnSoundSub��5"      $��20��6.   $��20��69   $��2q�6E   .��6d   
 � ToolTip$
 
sub volume��5%   &   -5&      �� 5'      -   5        $��slider��5'   c   $��1q�6   $	��125��6&   $��20��62    � SmallChange$	 0.1Q�6>    � LargeChange$
 0.25Q�6P   $ 0Q�5(       � Maximum$ 1Q�6%    � Value 61   ��  �� ElementName$ media�� �� Path$ Volume�5*      �� 5+      -	   5        $	 btnSoundAdd��5+      $��20��6.   $��20��69   $��	 0 0 40 0q�6E   .��6k   $
 
add volume��5.   &   +5/      �� 53      -
   5        $��20��53      $��20��6$   $��2q�60   $��<<��6;   $
 -20 sek��56   &   57      �� 58      -   5        $	 btnPlay��58      $��40��6*   $��30��65   $��2q�6A   $
��Play��6_   5:      �� 5;      -   5        $��20��5;      $��20��6$   $��2q�60   $��>>��6;   $
 +20 sek��5>   &   5?      �� 5@      -   5        $��50��5@      $��20��6$   $��60 0 0 0q�60   .��6U   $
 Open and start video��5C   &   Open5D      �� 5E      -   5        $	 btnPlayList��5E      $��10 0 0 0q�6.   $��70��6@   $��20��6K   $��Show playlist��6W   6�   �� 5F      -   5        $	 btnAddPlayList��5F      $��10 0 0 0q�61   $��80��6C   $��20��6N   .��6w   $
 Add one video to playlist��5I   &   Add playlist5J      5L      5N      5O      5P      