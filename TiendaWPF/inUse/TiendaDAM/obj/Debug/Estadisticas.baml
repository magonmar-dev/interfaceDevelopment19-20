   M S B A M L   `   `   `  ����G  Cpresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:capa_presentacioncapa_presentacion  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      $    capa_presentacion.Estadisticas   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:capa_presentacion     5      X TXceed.Wpf.Toolkit, Version=3.8.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5      $	��961��5	      $	��624��6+     � 	Resources  5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ Diccionario.xaml?�6%   %    5      .��5      � .+�5   
   &   Xceed.Wpf.Toolkit.DateTimePicker  -   5          Name$ dpMes��5      $��138,40,597.2,555q�6-   &   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ Custom=�6G      FormatString$ 
MMMM, yyyy��6W   5  /Xceed.Wpf.Toolkit.Primitives.DateTimePickerBase   ShowDropDownButton .  
�������$��18(�6�   ��6�   Z� 6�   �� 5   
    	  label#��[  6   $	��Mes��6/   $��	69,40,0,0q�6=   $	��Top=�6P   $��69��6h   $��29��6s   $
��Left=�6   $��Center=�6�   $��18(�6�   #  LiveCharts.Wpf.CartesianChart  5   
   -   5          Name$ chartDia��5      &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Right=�5      ���	#FFFDFAFA$��0��5      $��10,114,490.8,33q�6*   	   AxisY	 5        LiveCharts.Wpf.Axis  -   5        $
��gd_y��5      
   MaxValue$	
 100Q�6'      MinValue$ 0Q�66      Title$ Cantidad��6C      	Separator 5        LiveCharts.Wpf.Separator  5      {�.     Step$ 10Q�6:   5         AxisX 5         -   5          Name$
 gd_x��5       $ Pedidos��6)    5!        5"      {�.  $ 1Q�6:   5$      5&        LiveCharts.Wpf.PieChart  5'   
   -   5          Name$ 	chartTipo��5'      $ Right=�6*   ���	#FFFDFAFA$��491,114,9.8,33q�6X   �� 5(   
   -   5         ��Name$ sinDatosDia��5(      $��	SIN DATOS��6%   
���   �
�������$��156,308,617.2,273q�6_   $��25(�6z   $
��Bold"�6�   �� 5)   
   -   5        $ sinDatosTipo��5)      $��	SIN DATOS��6&   
���   �
�������$��616,308,157.2,273q�6`   $��25(�6{   $
��Bold"�6�   5*      5+      