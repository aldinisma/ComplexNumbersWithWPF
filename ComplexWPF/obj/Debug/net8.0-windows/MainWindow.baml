   M S B A M L   `   `   `  ����E  AComplexWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ComplexWPF
ComplexWPF  5   	       ComplexWPF.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ComplexWPF     5   	     � Title$  KomplexeZahlenRechner��5   	   $	��500��6'   $
��1000��64   .��5	      � ��5
   
   �� 5       �� ImageSource$R Lhttps://slidechef.net/wp-content/uploads/2023/10/Math-Background-768x432.jpg��6   .+�5   
   �� $��Komplexe Zahlen Rechner��6   $��Center=�62   $��0,78,0,0q�6O   $	��Top=�6a   $��24(�6y   �� 5   
   $��Komplexe Zahl 1��6   $
��Left=�6*   $��
39,123,0,0q�6E   $	��Top=�6Y   $	��112��6q   $
��Bold"�6}   �� 5   
   -   5         ��Name$ 	real_eins��5      $
��Left=�6%   $��138,161,0,0q�6@    �� TextWrapping$
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��120��6�   �� 5   
   -   5        $ img_eins��5      $
��Left=�6$   $��138,197,0,0q�6?   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��120��6�   �� 5   
   $��Realteil��6   $
��Left=�6#   $��
39,154,0,0q�6>   $	��Top=�6R   $��16(�6j   �� 5   
   $��Imaginärteil��6   $
��Left=�6'   $��
39,190,0,0q�6B   $	��Top=�6V   $��16(�6n   �� 5   
   $��Komplexe Zahl 2��6   $
��Left=�6*   $��
39,243,0,0q�6E   $	��Top=�6Y   $	��112��6q   $
��Bold"�6}   �� 5   
   -   5        $ 	real_zwei��5      $
��Left=�6%   $��138,281,0,0q�6@   $
 Wrap=�6U   $�� ��6i   $	��Top=�6q   $	��120��6�   �� 5   
   -   5        $ img_zwei��5      $
��Left=�6$   $��138,317,0,0q�6?   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��120��6�   �� 5   
   $��Realteil��6   $
��Left=�6#   $��
39,274,0,0q�6>   $	��Top=�6R   $��16(�6j   �� 5   
   $��Imaginärteil��6   $
��Left=�6'   $��
39,310,0,0q�6B   $	��Top=�6V   $��16(�6n   �� 5   
   $��	Rechenart��6   $
��Left=�6$   $��340,154,0,0q�6?   $	��Top=�6T   $��16(�6l   �� 5   
   -   5         ��Name$ combo_rechenart��5      $
��Left=�6-   $��455,159,0,0q�6H   $	��Top=�6]   $	��120��6u   .@�5      �� .��6   
Addieren6%   �� 5      .��6   Subtrahieren6)   �� 5      .��6   Multiplizieren6+   �� 5       .��6   
Dividieren6'   5!      �� 5#   
   $��Darstellung��6   $
��Left=�6&   $��340,190,0,0q�6A   $	��Top=�6V   $��16(�6n   �� 5$   
   -   5        $ combo_darstellung��5$      $
��Left=�6.   $��455,197,0,0q�6I   $	��Top=�6^   $	��120��6v   .@�5%      �� .��6   Kartesische Darstellung64   �� 5&      .��6   Polarform Darstellung62   5'      �� 5)   
   -   5        $��Rechnen��5)      $
��Left=�6#   $��396,242,0,0q�6>   $	��Top=�6S   $��16(�6k   $	��119��6y   6�   �� 5*   
   -   5         ��Name$ output_result��5*      $
��Left=�6'   $��358,295,0,0q�6B   $	��Top=�6W   $��22(�6o   $
��Bold"�6}   �� 5+   
   -	   5         ��Name$ ausgabe_img��5+      $��img/fragezeichen.jpg��6%   $
��Left=�6C   $	��212��6^   $��	696,0,0,0q�6k   $��Center=�6~   $	��214��6�   5.      5/      