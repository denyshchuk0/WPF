   M S B A M L   `   `   `  ����?  ;mvvm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:mvvm.ViewModelmvvm.ViewModel  5   	   C&clr-namespace:mvvm.ViewModel.Convertosmvvm.ViewModel.Convertos  5   	       mvvm.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +vmclr-namespace:mvvm.ViewModel     5   	   6con&clr-namespace:mvvm.ViewModel.Convertos     5   	     � Title$  
WeatherApp��5
   	   $	��400��6   $	��300��6)    � 	Resources 5         mvvm.ViewModel.VM   vm4  .mvvm.ViewModel.Convertos.IsDayTimeToBackground  con4   .mvvm.ViewModel.Convertos.WeatherIconIntToImage 	 WIcon7  1mvvm.ViewModel.Convertos.HasPresipitationToString 	 conDP��%t   &	        &	      &	 &     &	 9       5   
   6     5   
   6$     5   
   6$     5   
   6'   5      .��5      �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      $
��259* �6   �� 5      $
��110* �6   .+�5   
   �� $��20q�6   .+�5      �� $��	40 0 40 0q�6   .��6'   
Imput City63   �� 5      $��	40 0 40 0q�6   $��20��6)   ��65   �� *Query+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $	��100��6   $��10q�6!   ��6-   �� *SearchCommand+��5   %   �� *Query+.��6H   Serach6P   �� 5      $	��127��6^   ��6   �� *Cities+ �� SelectedItem 68   �� *SelectedCity+��5      �� 5      .R�5      �� $
��auto=�6(   .��5       ��  �� Orientation$ 
Horizontal=�6)   .+�5!   "   �� $	��150��6,   ��68   �� *LocalizedName+�� 5"   "   ��6,   �� *" AdministrativeArea.LocalizedName+5#      5$      5%      5'      5(      � 5)   
   $��10q�6   $��1��6   ��6(   �� *CurrentConditions.IsDayTime+ �� 	Converter# [  5*      �� 5+      $��* �6    �� 5,      $��* �6    �� 5-      $��* �6    �� 5.      $��* �6    	 � ColumnDefinitions	 50      �� 51      $
��145* �6#   �� 52      $
��147* �6#   .+�54      �� $��0��6   $��2��6Q   $��3��6e   ��6%   �� *SelectedCity.LocalizedName+6e   �� 55      $��1��6   $��2��6a   $��3��6u   ��6%   �� *,*CurrentConditions.Temperature.Metric.Value+6u   �� 56      $��2��6   $��2��6T   $��3��6h   ��6%   �� *CurrentConditions.WeatherText+6h   �� 57      $��3��6   ��6%   �� *$"CurrentConditions.HasPrecipitation+# [ �� 58      $	��100��6   $
��Left=�6    $��1��6;   $	��0,3q�6�   $��3��6�   ��6K   �� *CurrentConditions.WeatherIcon+# [ 6�   59      5:      5;      