   M S B A M L   `   `   `  ����L  HFilmManagement.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:FilmManagement.UI.ViewsFilmManagement.UI.Views  5   	   K*clr-namespace:FilmManagement.UI.ViewModelsFilmManagement.UI.ViewModels  5   	   0    *FilmManagement.UI.Views.FilmManagementView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:FilmManagement.UI.Views     5   	   @	ViewModel*clr-namespace:FilmManagement.UI.ViewModels     5   	     � Title$  FilmManagement��5	   	   $	��330��6    $	��320��6-   $	��950��6=   $	��950��6I    � Icon$< 6/FilmManagement.UI;component/Icon/Film-Shooting-01.ico��5
   	    � DataContext 5      :   4FilmManagement.UI.ViewModels.FilmManagementViewModel  5   
    J� InputBindings 5      �� 5   
   
 �� Key$ Enter��6    �� Command 6#   �� *Search+ � 	Resources 5         	ViewModel  ToggleButtonStyle �� 
TargetType �� Triggers	 P� Property
 P� Value �� Property �� Value��%�   &	        &	        5   
   6,   �� 5   
   " ��6+    5      P� 5      	 � ��

 � � �. �5      ��  � ��
 �����63   5      5      5      .��5      � # [  6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $	��120 �6   �� 5"      $��* �6   �� 5#      $	��120 �6    � RowDefinitions 5%   
   �� 5&      $��30 �6   �� 5'      $��25 �6   �� 5(      $	��200 �6   �� 5)      $��30 �6   �� 5*      $��* �6   .+�5,   
   �� -   5         ��Name$ LblName��5,      $��0��6!   $��0��6.   $
��Name��6>   $��5,5,0,0q�6M   �� 5-   
   -   5         ��Name$ BtnNewEntry��5-      $��0��6&   $��5��63   $��Neuer Eintrag��6C   $	��5,0q�6[   $��25��6h   $��Bottom=�6t   #��[ 5.      ��6<   �� *NewEntryBackground+��6f   �� *
NewEntry+�� 5/   
   -   5         ��Name$ 	TxbSearch��5/      $��1��6%   $��0��62   $��3��6B   $��5,0,0,0q�6V   {�6g   �� *	IsEnabled+��6�   �� *
SearchWord+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 50   
   -   5        $ 	BtnSearch��50      $��1��6$   $��3��61   $��Suchen��6A   $��5,0,5,0q�6R   {�6c   �� *	IsEnabled+��6�   �� *Search+�� 51   
   -   5         ��Name$ 
PersonList��51      $��0��6'   $��2��67   $��4��6D   $��3��6X    %� IsVirtualizing .  %� VirtualizationMode$ Standard=�6�    �� SelectionMode$ Single=�6�   ! �� IsDeferredScrollingEnabled .  �� AlternationCount$ 2��52   @   $
��Auto��6U   $��5,5,5,10q�6b   # [  53      ��54      �� *
FilmList+$ TwoWay=�$ PropertyChanged=� �� SelectedItem 55      �� *SelectedFilm+$ TwoWay=�$ PropertyChanged=�{�6i   �� *	IsEnabled+ �� View 56      �� 57      .P�58      �� $��
Film Titel��6%    �� Width$	 100��6q    �� DisplayMemberBinding 69   �� *	TitleName+$ TwoWay=�6q   �� 59      $��	Regisseur��6%   $	 100��6o    68   �� *
Director+$ TwoWay=�6o   �� 5:      $��Erscheinungsjahr��6%   $	 100��6y    6?   �� *ReleaseYear+$ TwoWay=�6y   �� 5;      $��	Spielzeit��6%   $	 100��6o    68   �� *
PlayTime+$ TwoWay=�6o   �� 5<      $��	Bewertung��6%   $	 100��6m    68   �� *Rating+$ TwoWay=�6m   �� 5=      $��Genre��6%   $	 100��6l    64   �� *	GenreName+$ TwoWay=�6l   5>      5@      �� 5A   
   -   5         ��Name$ GrpFilmManagement��5A      $��1��6.   $��4��6;   $��2��6K   $��2��6\   $��0,0,5,5q�6p   ��5B      �� 5C      $
��Film��6   $��Bottom=�6)   .��5E      � # [  6    5F      �� 5G      $��65 �6'   �� 5H      $��* �6'    5J      �� 5K      $��30 �6$   �� 5L      $��30 �6$   �� 5M      $��30 �6$   �� 5N      $��30 �6$   �� 5O      $��30 �6$   �� 5P      $��30 �6$   .+�5R      �� -   5        $ LblPersName��5R      $��0��6-   $��0��6:   $��
Film Titel��6J   �� 5S      -   5        $ TxbPersName��5S      $��0��6/   $��1��6<   $��5q�6L   ��6W   �� *SelectedFilm.TitleName+$ TwoWay=�$ PropertyChanged=��� 5T      -	   5        $ LblPersSecondName��5T      $��1��63   $��0��6@   $��	Regisseur��6P   �� 5U      -
   5        $ TxbPersSecondName��5U      $��1��65   $��1��6B   $��5q�6R   ��6]   �� *SelectedFilm.Director+$ TwoWay=�$ PropertyChanged=��� 5V      -   5        $ LblPersStreet��5V      $��2��6/   $��0��6<   $��Erscheinungsjahr��6L   �� 5W      -   5        $ TxbPersStreet��5W      $��2��61   $��1��6>   $��5q�6N   ��6Y   �� *SelectedFilm.ReleaseYear+$ TwoWay=�$ PropertyChanged=��� 5X      -   5        $ 
LblPersPlz��5X      $��3��6,   $��0��69   $��	Spielzeit��6I   �� 5Y      -   5        $ 
TxbPersPlz��5Y      $��3��6.   $��1��6;   $��5q�6K   ��6V   �� *SelectedFilm.PlayTime+$ TwoWay=�$ PropertyChanged=��� 5Z      -   5        $ LblPersPlace��5Z      $��4��6.   $��0��6;   $��	Bewertung��6K   �� 5[      -   5        $ TxbPersPlace��5[      $��4��60   $��1��6=   $��5q�6M   ��6X   �� *SelectedFilm.Rating+$ TwoWay=�$ PropertyChanged=��� 5\      -   5        $ LblPersWorkPlace��5\      $��5��62   $��0��6?   $��Genre��6O   �� 5]      -   5         ��Name$ TxbPersWorkPlace��5]      $��5��65   $��1��6B   $��5q�6R   ��5^      �� *GenreListNamen+$ TwoWay=�$ PropertyChanged=�  �� Text  5_      �� *SelectedFilm.GenreName+$ TwoWay=�5`      5a      �� 5b   
   -   5        $ BtnSave��5b      $��3��6"   $��5��6/   $��	Speichern��6?   $��5,0,5,5q�6S   ��6d   �� *Save+�� 5c   
   -   5        $ 	BtnDelete��5c      $��3��6$   $��4��61   $	��120��6A   $��Löschen��6M   $��5,0,5,5q�6_   $��Right=�6p   {�6�   �� *	IsEnabled+��6�   �� *Delete+5d      5e      