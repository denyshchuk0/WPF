   M S B A M L   `   `   `  ����a  ]Classwork20200608_Registration_Trigger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:Classwork20200608_Registration_Trigger&Classwork20200608_Registration_Trigger  5   	   q=clr-namespace:Classwork20200608_Registration_Trigger.ViewMode/Classwork20200608_Registration_Trigger.ViewMode  5   	   7    1Classwork20200608_Registration_Trigger.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:Classwork20200608_Registration_Trigger     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   Fvm=clr-namespace:Classwork20200608_Registration_Trigger.ViewMode  5   	     � Title$  
MainWindow��5
   	   $	��600��6   $	��400��6)    � 	Resources 5      <   6Classwork20200608_Registration_Trigger.ViewMode.UserVM 
  vmUser��%   &	          5   
   6   5      .��5      ��  � DataContext# [  6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Right=�6.   .+�5   
   d� -   5         d�Name$ tbLogin��5      $	��100��6(    d� 	IsChecked$
 TrueY�64   $��10q�6F   ��5      �� 5      $ 
Horizontal=�6   .+�5      !  FontAwesome.WPF.FontAwesome     Icon$ SignIn=�6%   
���  ��$��24(�6D   �� 5      $��5q�6    	Sign In64   5      5      d� 5   
   -   5        $ tbRegistration��5      $	��100��6/   $
 TrueY�6;   $��10q�6L   ��6X   �� *Command_Registration+��5      �� 5      $ 
Horizontal=�6   .+�5        $ SignIn=�6%   
���  ��$��24(�6D   �� 5       $��5q�6    Registration69   5!      5#      5$      �� 5&   
   $	��300��6   ��5(      �� 5)       �� 
TargetType" ��6    �� Triggers 5*      �� 5+      	 �� Binding	 6&   �� 
 �� ElementName$
 tbLogin�� �� Path$ 	IsChecked� �� Value True6^   .a�5,      ��  �� Property � y� �� Value$ 	Collapsed=�6;   5-      5/      .+�51      �� $��Login��6   .��52      �� $��30��6   53      �� 54      $��Password��6   .��55      �� $��30��6   56      57      �� 5:   
   $	��300��6    6!   �� *User+��5<      �� 5=      " ��6    5>      �� 5?      	 6&   �� $
 tbRegistration��$ 	IsChecked� True6e   .a�5@      ��  � y�$ 	Collapsed=�6;   5A      5D      .+�5G      �� $
��Name��6   .��5H      �� $ 
Horizontal=�6   .+�5I      �� $��30��6   $	��130��6&   $��0,0,10,0q�62   �� 5J      $��30��6   $	��130��6&   5K      5L      �� 5M      $��Choose your username:��6   .��5N      �� $��30��6   ��6&   �� *	FirstName+5O      �� 5P      $��Login��6   .��5Q      �� $��30��6   ��6&   �� *
LastName+5R      �� 5S      $��Create a password��6   .��5T      �� $��30��6   ��6&   �� *
Password+5U      �� 5V      $��Сonfirm your password��6   .��5W      �� $��30��6   5X      �� 5Y      $��	Birthday:��6   .��5Z      (  "System.Windows.Controls.DatePicker     Text 6   �� *
Birthday+5[      �� 5\      $��Gender:��6   .��5]      ��  �� Text 6   �� *Gender+.@�5^      �� $
��Mail��6#   �� 5_      $��Femail��6#   5`      5a      �� 5b      $��Mobile phone:��6   .��5c      �� ��6   �� *Phone+5d      �� 5e      $!��Your current email address:��6   .��5f      �� ��6   �� *Email+5g      �� 5h      $��80��6   $��Create User��6    ��66   �� *Command_Registration+��6_   �� *User+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 5j      $��5q�6   ��6!   �� *Users+��5k      �� 5l      .R�5m      �� $ 
Horizontal=�6%   .+�5n      �� 
���  ����65   �� *User.FirstName+�� 5o      
���  ����65   �� *User.LastName+�� 5p      
���  ����65   �� *User.Password+�� 5q      
���  ����65   �� *
User.Email+�� 5r      
���  ����65   �� *User.Birthday+�� 5s      
��� � ���67   �� *
User.Phone+�� 5t      
����  ���66   �� *User.Gender+5u      5v      5x      5z      �� 5|   
   $��20,20,20,20q�6   .+�5}      �� $��Center=�6/   ��6   �� *Answer+6/   5~      5�      5�      