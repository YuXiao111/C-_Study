   M S B A M L   `   `   `  ����M  ISqliteForFramework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:SqliteForFrameworkSqliteForFramework  5   	   #    SqliteForFramework.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:SqliteForFramework     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��5	   	   $	��800��5
   	   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataGrid1��5      $��0q�5      
������    HorizontalGridLinesBrush
 �   �   VerticalGridLinesBrush
 �   �   GridLinesVisibility$
 None=�5         RowDetailsVisibilityMode$ 	Collapsed=�5       � ForceCursor .  � 	Resources 5       �� 
TargetType	 �� Property
 �� Value �� 
TargetType �� CornerRadius J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   ShadowDepth   	Direction   Color �� Padding J� SnapsToDevicePixels ��Name � ColumnDefinitions � RowDefinitions   SelectAllCommand �� 
ResourceId �� TypeInTargetAssembly7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!   HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name    Column! ��Name" �� CanContentScroll# ��Name$ �� ScrollableHeight% � Maximum& �� Orientation*' �� #ComputedVerticalScrollBarVisibility( �� ViewportHeight) �� ViewportSize* � Value+ �� Mode, �� ScrollableWidth,- �� %ComputedHorizontalScrollBarVisibility. �� ViewportWidth/ �� Triggers0 ]� 
Conditions1 �� Property2 �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader3 ��Name4 �� Triggers5 P� Property6 P� Value7 �� 
TargetName)  #System.Windows.Controls.DataGridRow8 ��Name?  9System.Windows.Controls.Primitives.DataGridCellsPresenter*  $System.Windows.Controls.DataGridCell��%�  '        '  +
    '  �    '      �� 5      "  6   .�5      �� 	 � ��#
 � ��5      �� 5      	 � ��#
 � ��5      �� 5      	 � ��
 �	#FF688CAF5      �� 5      	 � ��$
 1q�5      �� 5'      	 �@ AutoGenerateColumns
 .  5(      �� 5)      	 �@ ColumnHeaderHeight$
 50Q�5*      �� 5+      	 � ��$
 20(�5,      �� 5-      	 �@ 	RowHeight$
 50Q�5.      �� 5/      	 �@��AlternationCount$
 2��50      �� 51      	 � ��
 52      �� 53      "  6.   .R�54   "   � .+�55   &   �� 
�������$ 6��56   -    57   *     58   .   $ 0Q�6?   $ 0Q�59   ?   $ 	#FFDADADA��5:   ?   5<   '   �� 5=   &   #��z��6-   #��z��5>   -   #��z��5?   -   # z��5@   -    . ._�5B   *   �� $ DG_ScrollViewer��67   |�.  ��5D   .   �� 5E   2   " ��6B   .R�5F   6   �  5G   :   �� 5H   >   $
��Auto �6O   �� 5I   >   $��* �6O   �� 5J   >   $
��Auto �6O    5L   :   �� 5M   >   $
��Auto �6L   �� 5N   >   $��* �6L   �� 5O   >   $
��Auto �6L   .+�5Q   :   � 
�������$��1��5R   ?    5S   >     5T   B   $	 270Q�6S   $ 	#FFF3F3F3��5U   S   5W   ;   �� 5X   :   #��Z 6A   |�.  ��5Z   A   C� *�� $" DataGridSelectAllButtonStyle��"  +y�5[   A   �� *HeadersVisibility+# Z # Z  �� "  ��5\   A   �� *CellsPanelHorizontalOffset+ �� "    5]   :   $! PART_ColumnHeadersPresenter��6Y   $��1��5^   Y   y�5_   Y   �� *HeadersVisibility+# Z  # Z  �� "  �� 5`   :   $!! PART_ScrollContentPresenter��6Q   #" z��5a   Q   $��2��5b   Q   $��1��5c   Q   �� 5e   :   $# PART_VerticalScrollBar��6D   $��2��5f   D   #% z$ 5g   D   $& Vertical=�5h   D   $��1��5i   D   #y�z' 5j   D   #) z( 5l   D   * 5k   D   �� *VerticalOffset+$+ OneWay=� �� *TemplatedParent+5l   D   � 5m   :   $��1��6?   $��2��5n   ?    5o   >   �� 5p   B   ��6S   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� 5q   B   $��* �6S   .+�5s   >   �� $# PART_HorizontalScrollBar��6H   $��1��5t   H   #% z, 5u   H   $& 
Horizontal=�5v   H   #y�z- 5w   H   #) z. 5y   H   * 5x   H   �� *HorizontalOffset+$+ OneWay=� �� *TemplatedParent+5y   H   5z   ;   5{   7   5|   3   .��5~   .   �� # z 6=   5   +   5�   '   5�   #   5�      5�      / 5�      ]� 5�      0 5�      �� 5�   "   1 �@��
IsGrouping2 . 5�   ,   �� 5�   "   "1 �@%�IsVirtualizingWhenGrouping2 .  5�   ,   ./�5�      �� 	 � ��
 .  5�   %   5�      5�      �� 5�      "  6   .�5�      �� 	 � ��

 ���� 5�      �� 5�      	 � ��$
 Center=�5�      �� 5�      	 � ��$
 Center=�5�      �� 5�      	 � ��
 5�      �� 5�      "  6.   .R�5�   "   � #��z��6'    5�   &   �� 5�   *   �� 5�   *   $��20 �6;   .+�5�   &   �� $��20 0 0 0q�67   #��z��5�   7   #��z��5�   7   �� 5�   &   $3 	SortArrow��5�   0   $��1��5�   0   $y�Visible=�5�   0   $��Center=�5�   0   $,��&/DataGrid;component/Fonts/#FontAwesome)�5�   0   5�   #   4 5�   "   P� 5�   &   5 �@ SortDirection$6 	AscendingX�5�   .   . �5�   *   �� $7 	SortArrow��61   	 � y�$
 Visible=�5�   1   �� 5�   *   $7 	SortArrow��61   	 � ��$	
 ��5�   1   5�   '   P� 5�   &   5 �@ SortDirection$6 
DescendingX�5�   .   . �5�   *   �� $7 	SortArrow��61   	 � y�$
 Visible=�5�   1   �� 5�   *   $7 	SortArrow��61   	 � ��$	
 ��5�   1   5�   '   5�      5�      5�      �� 5�      "  6   .�5�      �� 	 �@�Cursor$

 Hand��5�      �� 5�      	 � ��
 5�      �� 5�      "  6.   .R�5�   "   � .+�5�   &   �� $8 border��6-   #��z��5�   -   $��1q�5�   -   
������ 5�   -     5�   &   5�   #   4 5�   "   P� 5�   &   5 �@J�IsMouseOver6 . . �5�   *   �� $7 border��5�   1   	 � ��
 �#00BCD45�   1   5�   '   P� 5�   &   5 �@ 
IsSelected6 . . �5�   *   �� $7 border��5�   1   	 � ��
 �#00BCD45�   1   5�   '   5�      5�      / 5�      P� 5�      5 �@��AlternationIndex$6 0��5�   "   . �5�      �� 	 � ��
 �#F8F9FA5�   %   5�      P� 5�      5 �@��AlternationIndex$6 1��5�   "   . �5�      �� 	 � ��

 �����5�   %   5�      5�      �� 5�      "  6   .�5�      �� 	 � ��

 ���� 5�      �� 5�      	 � ��$
 Center=�5�      �� 5�      	 � ��$
 Center=�5�      �� 5�      	 � ��
 5�      �� 5�      "  6.   .R�5�   "   � #��z��6'   .+�5�   &   �� #��z��67   #��z��5�   7   5�   #   4 5�   "   P� 5�   &   5 �@ 
IsSelected6 . . �5�   *   �� 	 � ��

 �   �5�   1   5   '   5     5     5     5     9   Columns9 5     0	  *System.Windows.Controls.DataGridTextColumn	  5     ,
  &System.Windows.Controls.DataGridColumn: 
  Width5  /System.Windows.Controls.DataGridLengthConverter$: * 5	  %   ; 
  Header$; ID��5
  %   < 
  
IsReadOnly< . 1  +System.Windows.Controls.DataGridBoundColumn=   Binding= 5  %   �� *id+$+ OneWay=�5  %   	  5     $: * 5  %   $; 年龄��5  %   < . = 5  %   �� *age+$+ OneWay=�5  %   	  5     $: * 5  %   $; 成绩��5  %   = 5  %   �� *grade+5  %   5     �� 5  
   -   5        > ��Name$> Update��5     $	��200��5     $��30��5     $
��Left=�5     $��Bottom=�5     $��修改��5     5     �� 5  
   -   5        $> Factory��5     $	��200��5     $��30��5     $��Right=�5     $��Bottom=�5      $��恢复工厂��5!     5"     �� 5$  
   -   5        $> Select��5$     $	��200��5%     $��30��5&     $��Center=�5'     $��Bottom=�5(     $��查询某个成绩��5)     5*     5+     5,     