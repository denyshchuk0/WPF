   M S B A M L   `   `   `  ����F  BCatalogMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CatalogMVVMCatalogMVVM  5   	   =#clr-namespace:CatalogMVVM.ViewModelCatalogMVVM.ViewModel  5   	       CatalogMVVM.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CatalogMVVM     5   	   2vm#clr-namespace:CatalogMVVM.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��300��6   $	��500��6)    � 	Resources 5
      $  CatalogMVVM.ViewModel.PeopleVM   vm��%   &	          5   
   6   5      .��5   
   �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      $	��21* �6   �� 5      $
��248* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   ]� $��3��6   .+�5      o� $	��Top=�6   .@�5      m� -   5         m�Name$
 lang��5   <     menu#���  6     lang#���  6J   .@�5      m� -   5        $ en��5   ?   #���  6    
 � Tag$ en��6K    m� 	IsChecked .   en#���  6x   m� 5      -   5        $ ua��5   ?   #���  6   $ ua��6K     ua#���  6h   5      m� 5      -   5        $ themes��5   <   #���  6    
 themes#���  6L   .@�5      m� -   5        $ light��5   @   #���  6    $ light��6O    	 light#���  6o   5       m� 5!      -   5        $
 dark��5!   @   #���  6    $
 dark��6N     dark#���  6n   5"      5#      5$      �� 5%   
   $��0��6   $��1��6"   ��6/   �� *	peoples+ �� SelectedItem 6O   �� *People+��5&      �� 5'      .R�5(      �� 	 �� Orientation$	 
Horizontal=�6!   .+�5)      �� ��6    �� *Name+6;   �� 5*      
 ��Name$
 lEdit��6!    	 lEdit#���  60   6T   �� 5+      $
 lDelete��6!    	 lDelete#��� 	 62   6X   5,      5-      5/      �� 50   
   $��1��6   $��1��6!   ._�51      ��  6   �� *People+.+�52      �� -   5         ��Name$
 name��52      ��6(   �� *Name+6A   �� 53      -   5        $ surname��53      ��6+   �� *	Surname+6F   �� 54      -	   5        $ number��54      ��6*   �� *Number+6D   �� 55      -
   5        $	
 add��55       
 add#��� 
 6&   6H   �� 56      -   5        $
 clear��56       	 clear#���  6(   6L   57      58      �� 59   
   $��2��6   $��1��6"   ._�5:      �� .+�5;      �� {�.  60   �� 5<      {�.  6/   �� 5=      6   �� 5>      -   5        $

 edit��5>        edit#���  6'   6J   �� 5?      -   5        $
 close��5?       	 close#���  6(   6L   5@      5A      5B      5C      