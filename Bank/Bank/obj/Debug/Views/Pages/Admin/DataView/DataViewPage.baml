   M S B A M L   `   `   `  ����?  ;Bank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Bank.Views.Pages.Admin.DataViewBank.Views.Pages.Admin.DataView  5      2    ,Bank.Views.Pages.Admin.DataView.DataViewPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:Bank.Views.Pages.Admin.DataView     5      -   5          N� Title$  DataViewPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $��* �6   �� 5      $
��0.3* �6   .+�5   
   � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $��Center=�6M   .+�5      �� $��
Поиск��6   $��19(�6)   $��80��67   �� 5      -   5         ��Name$ 	TxbSearch��5      $	��250��6-   $��19(�69   6G   5      5      � 5   
   $��1��6   .+�5       �� .+�5"      &   System.Windows.Controls.DataGrid  -   5          Name$ DataView��5"         AutoGenerateColumns .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6[      Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��6.   
   Width$

 0.3* 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *ID+6Q     5'      $	 Фамилия��6.   $
 * 6\    6?   �� *
LastName+6\     5(      $	 Имя��6.   $
 * 6Y    6;   �� *	FirstName+6Y     5)      $	 Отчество��6.   $
 * 6_    6@   �� *
Patronymic+6_     5*      $	 Дата Выдачи��6.   $
 * 6c    6C   �� *DateResults+6c     5+      $	 Кем выдан��6.   $
 * 6`    6A   �� *
IssuedWhom+6`     5,      $	 Пол��6.   $
 * 6V    6;   �� *Gender+6V     5-      $	 Дата Рождения��6.   $
 * 6c    6E   �� *	DateBrith+6c     5.      $!	 Место рождения��6.   $
 * 6e    6F   �� *
BirthPlace+6e     5/      $!	 Серия паспорта��6.   $
 * 6i    6F   �� *PassportSeries+6i     50      $!	 Номер паспорта��6.   $
 * 6i    6F   �� *PassportNumber+6i   54      56      58      5:      5;      