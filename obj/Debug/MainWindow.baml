   M S B A M L   `   `   `  ����X  TFLoating Dialog Visualization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:FloatingDialogVisualisation.viewmodel%FloatingDialogVisualisation.viewmodel  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5   	   h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35�aclr-namespace:Microsoft.Expression.Interactivity.Input;assembly=Microsoft.Expression.Interactions(Microsoft.Expression.Interactivity.Input 5   	   ,    &FloatingDialogVisualisation.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:FloatingDialogVisualisation.viewmodel     5   	   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5   	   qiexaclr-namespace:Microsoft.Expression.Interactivity.Input;assembly=Microsoft.Expression.Interactions     5   	     � Title$#  Floating Dialog Visualization��5
   	   $	��650��6/   $	��900��6<    � Icon$ img/pin.png��6H   $��14(�6[   $
��Bold"�6i   $��Stretch=�6{   $��Stretch=�6�    � 
ResizeMode$ NoResize=�6�    � DataContext 5      3   -FloatingDialogVisualisation.viewmodel.VwModal  5   
   ��5      �� 5   
    �� ImageSource$! /img/current_background.jpg��6   6A   .��5      �� .+�5   
   ��  �� Orientation$ Vertical=�6    �� Left$ 86��6,   
 �� Top$	 145��6=   .+�5      �� -   5        $
��img1��5   0   $��img/vaccumpump.png��6   $ 86��6<   $	 114��6M   $	��120��6^   $	��129��6k   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5      	   	EventName$	 
MouseEnter��6%   .  (System.Windows.Interactivity.TriggerBase
   Actions.
 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 60   �� *VaccumPopOpen+5      5      � 5      -   5        $��
vaccumMenu��5      $��Right=�6&   .��5       o� ��5!      �� 5"      .R�5#      $�  $� Orientation$ Vertical=�65   5$      .@�5&      m� -   5        $��closeVaccumMenu��5&      $��Right=�66    m� Icon 5'      �� 5(      $��/img/close.png��6$    5)   "     5*   &   $	 PreviewMouseDown��65   .
 5+   *      6@   �� *VaccumPopClose+5,   '   5.      50      m� 51      -   5        $��vaccumMenuNameHeader��51       52      �� 53      -   5        $��vaccumNamePin��53   F   $��/img/pin.png��6$   $��16��6:   $y�Hidden=�6[    54   "     55   &   $	 PreviewMouseDown��65   .
 56   *      6@   �� *VaccumNameClicked+57   '   59      5;      m� 5<      -   5        $��vaccumMenuPower��5<       5=      �� 5>      -   5        $��vaccumPowerPin��5>   F   $��/img/pin.png��6$   $��16��6:    5?   "     5@   &   $	 PreviewMouseDown��65   .
 5A   *      6@   �� *VaccumPowerClicked+5B   '   5D      .@�5F      �� $ 
Horizontal=�6%   .+�5G      �� -   5        $��vaccumMenuPowerTxt��5G   &   �� 5H      $��/img/save.png��6$   $��20��6;    5I   "     5J   &   $	 PreviewMouseDown��65   .
 5K   *      6@   �� *VaccumChanged+5L   '   5N      5O      5P      m� 5Q      -	   5        $��vaccumMenuPressure��5Q       5R      �� 5S      -
   5        $��vaccumPressurePin��5S   F   $��/img/pin.png��6$   $��16��6:    5T   "     5U   &   $	 PreviewMouseDown��65   .
 5V   *      6@   �� *VaccumPressureClicked+5W   '   5Y      .@�5[      �� $ 
Horizontal=�6%   .+�5\      �� -   5        $��vaccumMenuPressureTxt��5\   &   �� 5]      $��/img/save.png��6$   $��20��6;    5^   "     5_   &   $	 PreviewMouseDown��65   .
 5`   *      6@   �� *VaccumChanged+5a   '   5c      5d      5e      m� 5f      -   5        $��vaccumMenuSpeed��5f       5g      �� 5h      -   5        $��vaccumSpeedPin��5h   F   $��/img/pin.png��6$   $��16��6:    5i   "     5j   &   $	 PreviewMouseDown��65   .
 5k   *      6@   �� *VaccumSpeedClicked+5l   '   5n      .@�5p      �� $ 
Horizontal=�6%   .+�5q      �� -   5        $��vaccumMenuSpeedTxt��5q   &   �� 5r      $��/img/save.png��6$   $��20��6;    5s   "     5t   &   $	 PreviewMouseDown��65   .
 5u   *      6@   �� *VaccumChanged+5v   '   5x      5y      5z      m� 5{      -   5        $��vaccumMenuTemperature��5{       5|      �� 5}      -   5        $��vaccumTemperaturePin��5}   F   $��/img/pin.png��6$   $��16��6:    5~   "     5   &   $	 PreviewMouseDown��65   .
 5�   *      6@   �� *VaccumTemperatureClicked+5�   '   5�      .@�5�      �� $ 
Horizontal=�6%   .+�5�      �� -   5        $��vaccumMenuTemperatureTxt��5�   &   �� 5�      $��/img/save.png��6$   $��20��6;    5�   "     5�   &   $	 PreviewMouseDown��65   .
 5�   *      6@   �� *VaccumChanged+5�   '   5�      5�      5�      5�      5�      5�      �� 5�   
   $ 
Horizontal=�6   $ 86��6.   $	 265��6?   .+�5�      �� $	 215��6   $	 114��6+   $ Vertical=�6<   .+�5�      �� $ 
Horizontal=�6   .+�5�      �� -   5        $��vaccumMenuName_prop_img��5�   A   $��/img/pinned.png��6   $��16��65    5�        5�      $	 PreviewMouseDown��6-   .
 5�   "      68   �� * VaccumMenuLabelImgName_clicked+5�      5�      �� 5�      -   5        $��vaccumMenuName_prop��5�      $��Name : Vacuum Pump��67   6V   5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� -   5        $��vaccumMenuPower_prop_img��5�   U   $��/img/pinned.png��6   $��16��65   $y�Hidden=�6A    5�        5�      $	 PreviewMouseDown��6-   .
 5�   "      68   �� *!VaccumMenuLabelImgPower_clicked+5�      5�      �� 5�      -   5        $��vaccumMenuPower_prop��5�      6:   5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� -   5        $$��vaccumMenuTemperature_prop_img��5�   U   $��/img/pinned.png��6   $��16��65   $y�Hidden=�6A    5�        5�      $	 PreviewMouseDown��6-   .
 5�   "      68   �� *'%VaccumMenuLabelImgTemperature_clicked+5�      5�      �� 5�      -   5        $ ��vaccumMenuTemperature_prop��5�      6@   5�      5�      �� 5�      $ Vertical=�6   .+�5�      �� $ 
Horizontal=�6   .+�5�      �� -   5        $!��vaccumMenuPressure_prop_img��5�   U   $��/img/pinned.png��6   $��16��65   $y�Hidden=�6A    5�        5�      $	 PreviewMouseDown��6-   .
 5�   "      68   �� *$"VaccumMenuLabelImgPressure_clicked+5�      5�      �� 5�      -   5        $��vaccumMenuPressure_prop��5�      6=   5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� -   5        $��vaccumMenuSpeed_prop_img��5�   U   $��/img/pinned.png��6   $��16��65   $y�Hidden=�6A    5�        5�      $	 PreviewMouseDown��6-   .
 5�   "      68   �� *!VaccumMenuLabelImgSpeed_clicked+5�      5�      �� 5�      -   5        $��vaccumMenuSpeed_prop��5�      6:   5�      5�      5�      �� 5�   
   $ Vertical=�6   $	 470��6,   $	 145��6>   .+�5�      �� -   5        $	��img��5�   2   $��/img/generator_1.png��6   $	 485��6=   $	 109��6O   $	��125��6`   $	��163��6m    5�        5�      $	 
MouseEnter��6%   .
 5�         60   �� *GeneratorPopOpen+5�      5�      � 5�      -   5        $��generatorMenu��5�      $��Right=�6)   .��5�      o� ��5�      �� 5�      .R�5�      $� $ Vertical=�65   5�      .@�5�      m� -   5        $��closeGeneratorMenu��5�      $��Right=�69    5�      �� 5�      $��/img/close.png��6$    5�   "     5�   &   $	 PreviewMouseDown��65   .
 5�   *      6@   �� *GeneratorPopClose+5�   '   5�      5�      m� 5�      -   5        $��generatorName��5�       5�      �� 5�      -    5        $��generatorNamePin��5�   F   $��/img/pin.png��6$   $��20��6:   $y�Hidden=�6^    5�   "     5�   &   $	 PreviewMouseDown��65   .
 5�   *      6@   �� *GeneratorNameClicked+5�   '   5�      5�      m� 5�      -!   5        $��generatorPower��5�       5�      �� 5�      -"   5        $��generatorPowerPin��5�   F   $��/img/pin.png��6$   $��20��6:    5�   "     5�   &   $	 PreviewMouseDown��65   .
 5�   *      6@   �� *GeneratorPowerClicked+5�   '   5�      .@�5�      �� $ 
Horizontal=�6%   .+�5�      �� -#   5        $��generatorMenuPowerTxt��5�   &   �� 5�      $��/img/save.png��6$   $��20��6;    5�   "     5�   &   $	 PreviewMouseDown��65   .
 5   *      6@   �� *GeneratorChanged+5  '   5     5     5     m� 5     -$   5        $��generatorPressure��5      5     �� 5     -%   5        $��generatorPressurePin��5  F   $��/img/pin.png��6$   $��20��6:    5	  "     5
  &   $	 PreviewMouseDown��65   .
 5  *      6@   �� *GeneratorPressureClicked+5  '   5     .@�5     �� $ 
Horizontal=�6%   .+�5     �� -&   5        $��generatorMenuPressureTxt��5  &   �� 5     $��/img/save.png��6$   $��20��6;    5  "     5  &   $	 PreviewMouseDown��65   .
 5  *      6@   �� *GeneratorChanged+5  '   5     5     5     m� 5     -'   5        $��generatorSpeed��5      5     �� 5     -(   5        $��generatorSpeedPin��5  F   $��/img/pin.png��6$   $��20��6:    5  "     5  &   $	 PreviewMouseDown��65   .
 5   *      6@   �� *GeneratorSpeedClicked+5!  '   5#     .@�5%     �� $ 
Horizontal=�6%   .+�5&     �� -)   5        $��generatorMenuSpeedTxt��5&  &   �� 5'     $��/img/save.png��6$   $��20��6;    5(  "     5)  &   $	 PreviewMouseDown��65   .
 5*  *      6@   �� *GeneratorChanged+5+  '   5-     5.     5/     m� 50     -*   5        $��generatorTemperature��50      51     �� 52     -+   5        $��generatorTemperaturPin��52  F   $��/img/pin.png��6$   $��16��6:    53  "     54  &   $	 PreviewMouseDown��65   .
 55  *      6@   �� *GeneratorTemperatureClicked+56  '   58     .@�5:     �� $ 
Horizontal=�6%   .+�5;     �� -,   5        $!��generatorMenuTemperatureTxt��5;  &   �� 5<     $��/img/save.png��6$   $��20��6;    5=  "     5>  &   $	 PreviewMouseDown��65   .
 5?  *      6@   �� *GeneratorChanged+5@  '   5B     5C     5D     5E     5F     5G     �� 5H  
   $ 
Horizontal=�6   $	 470��6.   $	 275��6@   .+�5I     �� $	 653��6   $	 114��6,   $ Vertical=�6=   .+�5J     �� $ 
Horizontal=�6   .+�5K     �� --   5        $��generatorName_prop_img��5K  A   $��/img/pinned.png��6   $��16��65    5L       5M     $	 PreviewMouseDown��6-   .
 5N  "      68   �� *GeneratorLabelImgName_clicked+5O     5Q     �� 5R     -.   5        $��generatorName_prop��5R     $��Name : Generator��66   6S   5S     �� 5T     $ 
Horizontal=�6   .+�5U     �� -/   5        $��generatorPower_prop_img��5U  U   $��/img/pinned.png��6   $��16��65   $y�Hidden=�6A    5V       5W     $	 PreviewMouseDown��6-   .
 5X  "      68   �� * GeneratorLabelImgPower_clicked+5Y     5[     �� 5\     -0   5        $��generatorPower_prop��5\     69   5]     �� 5^     $ 
Horizontal=�6   .+�5_     �� -1   5        $#��generatorTemperature_prop_img��5_  U   $��/img/pinned.png��6   $��16��65   $y�Hidden=�6A    5`       5a     $	 PreviewMouseDown��6-   .
 5b  "      68   �� *&$GeneratorLabelImgtemperature_clicked+5c     5e     �� 5f     -2   5        $��generatorTemperature_prop��5f     6?   5g     5h     �� 5i     $ Vertical=�6   .+�5j     �� $ 
Horizontal=�6   .+�5k     �� -3   5        $ ��generatorPressure_prop_img��5k  U   $��/img/pinned.png��6   $��16��65   $y�Hidden=�6A    5l       5m     $	 PreviewMouseDown��6-   .
 5n  "      68   �� *#!GeneratorLabelImgPressure_clicked+5o     5q     �� 5r     -4   5        $��generatorPressure_prop��5r     6<   5s     �� 5t     $ 
Horizontal=�6   .+�5u     �� -5   5        $��generatorSpeed_prop_img��5u  U   $��/img/pinned.png��6   $��16��65   $y�Hidden=�6A    5v       5w     $	 PreviewMouseDown��6-   .
 5x  "      68   �� * GeneratorLabelImgSpeed_clicked+5y     5{     �� 5|     -6   5        $��generatorSpeed_prop��5|     69   5}     5~     5     �� 5�  
   $ Vertical=�6   $ 86��6,   $	 355��6=   .+�5�     �� $	��132��6   $ 86��6!   $	 252��62   $��/img/turbine_use.png��6C   $	��129��6a    5�       5�     $	 
MouseEnter��6%   .
 5�        60   �� *TurbinePopOpen+5�     5�     � 5�     -7   5        $��turbineMenu��5�     $��Right=�6'   .��5�     o� ��5�     �� 5�     .R�5�     $� $ Vertical=�65   5�     .@�5�     m� -8   5        $��closeturbineMenu��5�     $��Right=�67    5�     �� 5�     $��/img/close.png��6$    5�  "     5�  &   $	 PreviewMouseDown��65   .
 5�  *      6@   �� *TurbinePopClose+5�  '   5�     5�     m� 5�     -9   5        $��turbineMenuName��5�      5�     �� 5�     -:   5        $��turbineNamePin��5�  F   $��/img/pin.png��6$   $��16��6:   $y�Hidden=�6\    5�  "     5�  &   $	 PreviewMouseDown��65   .
 5�  *      6@   �� *TurbineMenuNameClicked+5�  '   5�     5�     m� 5�     -;   5        $��turbineMenuPower��5�      5�     �� 5�     -<   5        $��turbinePowerPin��5�  F   $��/img/pin.png��6$   $��16��6:    5�  "     5�  &   $	 PreviewMouseDown��65   .
 5�  *      6@   �� *TurbineMenuPowerClicked+5�  '   5�     .@�5�     �� $ 
Horizontal=�6%   .+�5�     �� -=   5        $��turbineMenuPowerTxt��5�  &   �� 5�     $��/img/save.png��6$   $��20��6;    5�  "     5�  &   $	 PreviewMouseDown��65   .
 5�  *      6@   �� *TurbineChanged+5�  '   5�     5�     5�     m� 5�     ->   5        $��turbineMenuPressure��5�      5�     �� 5�     -?   5        $��turbinePressurePin��5�  F   $��/img/pin.png��6$   $��16��6:    5�  "     5�  &   $	 PreviewMouseDown��65   .
 5�  *      6@   �� *TurbineMenuPressureClicked+5�  '   5�     .@�5�     �� $ 
Horizontal=�6%   .+�5�     �� -@   5        $��turbineMenuPressureTxt��5�  &   �� 5�     $��/img/save.png��6$   $��20��6;    5�  "     5�  &   $	 PreviewMouseDown��65   .
 5�  *      6@   �� *TurbineChanged+5�  '   5�     5�     5�     m� 5�     -A   5        $��turbineMenuSpeed��5�      5�     �� 5�     -B   5        $��turbineSpeedPin��5�  F   $��/img/pin.png��6$   $��16��6:    5�  "     5�  &   $	 PreviewMouseDown��65   .
 5�  *      6@   �� *TurbineMenuSpeedClicked+5�  '   5�     .@�5�     �� $ 
Horizontal=�6%   .+�5�     �� -C   5        $��turbineMenuSpeedTxt��5�  &   �� 5�     $��/img/save.png��6$   $��20��6;    5�  "     5�  &   $	 PreviewMouseDown��65   .
 5�  *      6@   �� *TurbineChanged+5�  '   5�     5�     5�     m� 5�     -D   5        $��turbineMenuTemperature��5�      5�     �� 5�     -E   5        $��turbineTemperaturePin��5�  F   $��/img/pin.png��6$   $��16��6:    5�  "     5�  &   $	 PreviewMouseDown��65   .
 5�  *      6@   �� *TurbineMenuTemperatureClicked+5�  '   5�     .@�5�     �� $ 
Horizontal=�6%   .+�5�     �� -F   5        $��turbineMenuTemperatureTxt��5�  &   �� 5�     $��/img/save.png��6$   $��20��6;    5�  "     5�  &   $	 PreviewMouseDown��65   .
 5�  *      6@   �� *TurbineChanged+5�  '   5�     5�     5�     5�     5�     5�     �� 5�  
   $ 
Horizontal=�6   $ 86��6.   $	 492��6?   .+�5�     �� $	 215��6   $	 252��6,   $ Vertical=�6=   .+�5�     �� $ 
Horizontal=�6   .+�5      �� -G   5        $��turbineMenuName_prop_img��5   A   $��/img/pinned.png��6   $��16��65    5       5     $	 PreviewMouseDown��6-   .
 5  "      68   �� *!TurbineMenuLabelImgName_clicked+5     5     �� 5     -H   5        $��turbineMenuName_prop��5     $��Name : Turbine��68   6S   5     �� 5	     $ 
Horizontal=�6   .+�5
     �� -I   5        $��turbineMenuPower_prop_img��5
  U   $��/img/pinned.png��6   $��16��65   $y�Hidden=�6A    5       5     $	 PreviewMouseDown��6-   .
 5  "      68   �� *" TurbineMenuLabelImgPower_clicked+5     5     �� 5     -J   5        $��turbineMenuPower_prop��5     6;   5     �� 5     $ 
Horizontal=�6   .+�5     �� -K   5        $%��turbineMenuTemperature_prop_img��5  U   $��/img/pinned.png��6   $��16��65   $y�Hidden=�6A    5       5     $	 PreviewMouseDown��6-   .
 5  "      68   �� *(&TurbineMenuLabelImgTemperature_clicked+5     5     �� 5     -L   5        $!��turbineMenuTemperature_prop��5     6A   5     5     �� 5     $ Vertical=�6   .+�5     �� $ 
Horizontal=�6   .+�5      �� -M   5        $"��turbineMenuPressure_prop_img��5   U   $��/img/pinned.png��6   $��16��65   $y�Hidden=�6A    5!       5"     $	 PreviewMouseDown��6-   .
 5#  "      68   �� *%#TurbineMenuLabelImgPressure_clicked+5$     5&     �� 5'     -N   5        $��turbineMenuPressure_prop��5'     6>   5(     �� 5)     $ 
Horizontal=�6   .+�5*     �� -O   5        $��turbineMenuSpeed_prop_img��5*  U   $��/img/pinned.png��6   $��16��65   $y�Hidden=�6A    5+       5,     $	 PreviewMouseDown��6-   .
 5-  "      68   �� *" TurbineMenuLabelImgSpeed_clicked+5.     50     �� 51     -P   5        $��turbineMenuSpeed_prop��51     6;   52     53     54     �� 56  
   $ Vertical=�6   $	 470��6,   $	 355��6>   .+�57     �� $	��132��6   $	 475��6!   $	 241��63   $	��163��6D   $��/img/condensor_new.png��6P    58       59     $	 
MouseEnter��6%   .
 5:        60   �� *CondensorPopOpen+5;     5=     � 5>     -Q   5        $��condensorMenu��5>     $��Right=�6)   .��5?     o� ��5@     �� 5A     .R�5B     $� $ Vertical=�65   5C     .@�5E     m� -R   5        $��condensorMenuclose��5E     $��Right=�69    5F     �� 5G     $��/img/close.png��6$    5H  "     5I  &   $	 PreviewMouseDown��65   .
 5J  *      6@   �� *CondensorPopClose+5K  '   5M     5O     m� 5P     -S   5        $��condensorMenuitemName��5P      5Q     �� 5R     -T   5        $��condensorNamePin��5R  F   $��/img/pin.png��6$   $��16��6:   $y�Hidden=�6^    5S  "     5T  &   $	 PreviewMouseDown��65   .
 5U  *      6@   �� *CondensorMenuNameClicked+5V  '   5X     5Z     m� 5[     -U   5        $��condensorMenuPower��5[      5\     �� 5]     -V   5        $��condensorPowerPin��5]  F   $��/img/pin.png��6$   $��16��6:    5^  "     5_  &   $	 PreviewMouseDown��65   .
 5`  *      6@   �� *CondensorMenuPowerClicked+5a  '   5c     .@�5e     �� $ 
Horizontal=�6%   .+�5f     �� -W   5        $��condensorMenuPowerTxt��5f  &   �� 5g     $��/img/save.png��6$   $��20��6;    5h  "     5i  &   $	 PreviewMouseDown��65   .
 5j  *      6@   �� *CondensorChanged+5k  '   5m     5n     5o     m� 5p     -X   5        $��condensorMenuPressure��5p      5q     �� 5r     -Y   5        $��condensorPressurePin��5r  F   $��/img/pin.png��6$   $��16��6:    5s  "     5t  &   $	 PreviewMouseDown��65   .
 5u  *      6@   �� *CondensorMenuPressureClicked+5v  '   5x     .@�5z     �� $ 
Horizontal=�6%   .+�5{     �� -Z   5        $��condensorMenuPressureTxt��5{  &   �� 5|     $��/img/save.png��6$   $��20��6;    5}  "     5~  &   $	 PreviewMouseDown��65   .
 5  *      6@   �� *CondensorChanged+5�  '   5�     5�     5�     m� 5�     -[   5        $��condensorMenuSpeed��5�      5�     �� 5�     -\   5        $��condensorSpeedPin��5�  F   $��/img/pin.png��6$   $��16��6:    5�  "     5�  &   $	 PreviewMouseDown��65   .
 5�  *      6@   �� *CondensorMenuSpeedClicked+5�  '   5�     .@�5�     �� $ 
Horizontal=�6%   .+�5�     �� -]   5        $��condensorMenuSpeedTxt��5�  &   �� 5�     $��/img/save.png��6$   $��20��6;    5�  "     5�  &   $	 PreviewMouseDown��65   .
 5�  *      6@   �� *CondensorChanged+5�  '   5�     5�     5�     m� 5�     -^   5        $��condensorMenuTemperature��5�      5�     �� 5�     -_   5        $��condensorTemperaturePin��5�  F   $��/img/pin.png��6$   $��16��6:    5�  "     5�  &   $	 PreviewMouseDown��65   .
 5�  *      6@   �� *!CondensorMenuTemperatureClicked+5�  '   5�     .@�5�     �� $ 
Horizontal=�6%   .+�5�     �� -`   5        $!��condensorMenuTemperatureTxt��5�  &   �� 5�     $��/img/save.png��6$   $��20��6;    5�  "     5�  &   $	 PreviewMouseDown��65   .
 5�  *      6@   �� *CondensorChanged+5�  '   5�     5�     5�     5�     5�     5�     �� 5�  
   $ 
Horizontal=�6   $	 470��6.   $	 492��6@   .+�5�     �� $	 624��6   $ Vertical=�6+   $	 241��6B   .+�5�     �� $ 
Horizontal=�6   .+�5�     �� -a   5        $$��condensorMenuitemName_prop_img��5�  A   $��/img/pinned.png��6   $��16��65    5�       5�     $	 PreviewMouseDown��6-   .
 5�  "      68   �� *#!CondensorMenuLabelImgName_clicked+5�     5�     �� 5�     -b   5        $ ��condensorMenuitemName_prop��5�     $��Name : Condensor��6>   6[   5�     �� 5�     $ 
Horizontal=�6   .+�5�     �� -c   5        $!��condensorMenuPower_prop_img��5�  U   $��/img/pinned.png��6   $��16��65   $y�Hidden=�6A    5�       5�     $	 PreviewMouseDown��6-   .
 5�  "      68   �� *$"CondensorMenuLabelImgPower_clicked+5�     5�     �� 5�     -d   5        $��condensorMenuPower_prop��5�     6=   5�     �� 5�     $ 
Horizontal=�6   .+�5�     �� -e   5        $'��!condensorMenuTemperature_prop_img��5�  U   $��/img/pinned.png��6   $��16��65   $y�Hidden=�6A    5�       5�     $	 PreviewMouseDown��6-   .
 5�  "      68   �� **(CondensorMenuLabelImgTemperature_clicked+5�     5�     �� 5�     -f   5        $#��condensorMenuTemperature_prop��5�     6C   5�     5�     �� 5�     $ Vertical=�6   .+�5�     �� $ 
Horizontal=�6   .+�5�     �� -g   5        $$��condensorMenuPressure_prop_img��5�  U   $��/img/pinned.png��6   $��16��65   $y�Hidden=�6A    5�       5�     $	 PreviewMouseDown��6-   .
 5�  "      68   �� *'%CondensorMenuLabelImgPressure_clicked+5�     5�     �� 5�     -h   5        $ ��condensorMenuPressure_prop��5�     6@   5�     �� 5�     $ 
Horizontal=�6   .+�5�     �� -i   5        $!��condensorMenuSpeed_prop_img��5�  U   $��/img/pinned.png��6   $��16��65   $y�Hidden=�6A    5�       5�     $	 PreviewMouseDown��6-   .
 5�  "      68   �� *$"CondensorMenuLabelImgSpeed_clicked+5�     5�     �� 5�     -j   5        $��condensorMenuSpeed_prop��5�     6=   5�     5�     �� 5�     $ 
Horizontal=�6   5�     5�     5�     5�     