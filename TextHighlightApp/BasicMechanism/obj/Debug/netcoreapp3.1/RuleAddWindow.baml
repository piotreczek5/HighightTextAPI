   M S B A M L   `   `   `  ����I  EBasicMechanism, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BasicMechanismBasicMechanism  5   	   "    BasicMechanism.RuleAddWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TXceed.Wpf.Toolkit, Version=4.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44wpfx)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   (localclr-namespace:BasicMechanism  5   	     � Title$  RuleAddWindow��5	   	   $	��450��6   $	��800��6,   .��5
      �  J� IsHitTestVisible$
 True��6   $��0,0,0,0q�6#   .+�5   
   �� $��Text to highlight:��6   $
��Left=�6-   $��	48,79,0,0q�6H   $	��Top=�6[   $	��169��6s   $��20(�6   �� 5   
   -   5         ��Name$ RuleText��5      $
��Left=�6$   $��
222,79,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��444��6   $��69��6�    � Cursor$ IBeam��6�   �� 5   
   $��Color:��6   $
��Left=�6!   $��102,217,0,0q�6<   $	��Top=�6Q   $��20(�6i   �� 5   
   -   5         ��Name$ ButtonAccept��5      $��ACCEPT��6'   $
��Left=�68   $��465,346,0,0q�6S   $	��Top=�6h   $��41��6�   $	��122��6�   $
 Hand��6�   �� 5   
   -   5        $ ButtonCancel��5      $��CANCEL��6'   $
��Left=�68   $��640,346,0,0q�6S   $	��Top=�6h   $��41��6�   $	��122��6�   $
 Hand��6�   #  Xceed.Wpf.Toolkit.ColorPicker  5   
   -   5        $��ColorPickerRule��5         DisplayColorAndName$
 True��62   $��222,207,356,170q�6M   $
 Hand��6f   �� 5   
   -   5         ��Name$ EditRuleDisclaimer��5      $
��Left=�60   $��537,199,0,0q�6K   $
��Wrap=�6`   $	��Top=�6t   $��73��6�   $	��175��6�   $
��Bold"�6�   $��14(�6�   5      5      