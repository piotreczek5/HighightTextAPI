   M S B A M L   `   `   `  ����I  EBasicMechanism, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BasicMechanismBasicMechanism  5   	       BasicMechanism.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TXceed.Wpf.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44wpfx)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   (localclr-namespace:BasicMechanism  5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � SizeToContent$ Manual=�65    � 
ResizeMode$ NoResize=�6L   .��5
      �  � Cursor$
 Hand��6   .+�5   
   �� .@�5      �� -   5         ��Name$ ManagementTab��5      $��Rule Management��6-   $
 Hand��6F   .��5      � 
�������$ Arrow��6*   .+�5      �� -   5         ��Name$ 	ButtonAdd��5      $	��ADD��60   $
��Left=�6>   $��
10,328,0,0q�6Y   $	��Top=�6m   $��45��6�   $��20��6�   $
 Hand��6�   ���	#FF7FC9276�   �� 5      -   5        $ ButtonDelete��5      $��DELETE��63   $
��Left=�6D   $��154,328,0,0q�6_   $	��Top=�6t   $��44��6�   $��20��6�   $
 Hand��6�   ���	#FFE82E2E6�   �� 5      -   5        $ 
ButtonEdit��5      $
��EDIT��61   $
��Left=�6@   $��
82,328,0,0q�6[   $	��Top=�6o   $��20��6�   $��44��6�   ���	#FF2586E6$
 Hand��6�   �� 5      $��List of Rules:��6   $
��Left=�65   $��	10,15,0,0q�6P   $	��Top=�6c   $	��188��6{   �� 5      -   5         ��Name$ ListOfRules��5      $��10,41,596,83q�64   
���   �6z   �� 5      -   5         ��Name$ 
TextOfRule��5       $
��Left=�64   $��
278,41,0,0q�6O   $
��Wrap=�6c   $	��Top=�6w   $	��164��6�   $	��456��6�   $ Arrow��6�   5      5      �� 5      -   5        $ UseTab��5      $��
Rule Usage��6&   $
 Hand��6:   .��5      � 
�������$ Arrow��6*   .+�5      �� $
��Left=�6    $��	32,50,0,0q�6;   $6��0Enter text that you want to be colored by rules:��6N   $
��Wrap=�6�   $	��Top=�6�   $��80��6�   $	��150��6�   �� 5      $
��Left=�6    $��
32,255,0,0q�6;   $!��Your text colored by rules:��6O   $
��Wrap=�6r   $	��Top=�6�   $��80��6�   $	��150��6�   �� 5      -   5        $ ApplyRulesButton��5      $��Apply Rules��67   $
��Left=�6M   $��	523,0,0,0q�6h   $��Center=�6{   $��30��6�   $��90��6�   ���	#FF38F32F$
 Hand��6�   �� 5      -	   5        $ ClearTextButton��5      $��
Clear Text��66   $
��Left=�6K   $��	640,0,0,0q�6f   $��Center=�6y   $��30��6�   $��90��6�   ���	#FFF3882F$
 Hand��6�   �� 5      -
   5         ��Name$ RawText��5   "   $��230,50,64,248q�63   . �5      /� .T�5      J� .*�6(   .*�5   "   �� $� ��6&   5       5!      5"      �� 5#      -   5        $ ColoredText��5#   "   $��230,244,64,60q�67   ${�False��6N   4  .System.Windows.Automation.AutomationProperties	   IsOffscreenBehavior$	 Onscreen=�6`   . �5$      /� .T�5%      J� .*�6(   .*�5&   "   �� $� ��6&   5'      5(      5)      5*      5+      5,      5-      5.      