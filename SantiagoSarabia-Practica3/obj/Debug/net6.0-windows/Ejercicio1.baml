   M S B A M L   `   `   `  ����T  PSantiagoSarabia-Practica3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:SantiagoSarabia_Practica3SantiagoSarabia_Practica3  5   	   *    $SantiagoSarabia_Practica3.Ejercicio1   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:SantiagoSarabia_Practica3     5   	     � Title$  
Ejercicio1��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��287* �6   �� 5      $
��113* �6   .+�5   
   �� $
��Left=�6   $��
345,49,0,0q�6/   $
��Wrap=�6C   $��Ejercicio 1��6W   $	��Top=�6j   ���	#FF0E33FF$��25(�6�   �� 5   
   -   5         ��Name$ txtInitialAmount��5      $
��Left=�6,   $��156,112,0,0q�6G    �� TextWrapping$
 Wrap=�6\   $�� ��6p   $	��Top=�6x   $��90��6�   $��24��6�   $��10(�6�   �� 5   
   -   5         ��Name$ a��5      $
��Left=�6   $��
30,112,0,0q�6:   $
��Wrap=�6N   $��Monto Inicial��6b   $	��Top=�6w   ���	#FF0E33FF$��18(�6�   $��24��6�   �� 5   
   -   5        $ txtInterestRate��5      $
��Left=�6+   $��410,112,0,0q�6F   $
 Wrap=�6[   $�� ��6o   $	��Top=�6w   $��90��6�   $��24��6�   �� 5   
   $
��Left=�6   $��287,112,0,0q�6/   $
��Wrap=�6D   $��% de Interes��6X   $	��Top=�6l   ���	#FF0E33FF$��18(�6�   $��24��6�   �� 5   
   -   5        $ txtYears��5      $��Center=�6$   $��	0,112,0,0q�6A   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $��90��6�   $��24��6�   $��1��6�   �� 5   
   $
��Left=�6   $��	1,112,0,0q�6/   $
��Wrap=�6B   $	��Top=�6V   ���	#FF0E33FF$��18(�6�   $��24��6�   $��1��6�   �� 6�   $�A��6�   �� 6�    � Language$ es-es�6�   $�ñ��6�   �� 6�   $�os��6�   6�   �� 5   
   -   5         ��Name$ 
resultView��5      $��113,178,113,48q�6'   $��2��6?   �� 5   
   -   5        $��1��5      $��Calcular��6!   $
��Left=�64   $��	68,33,0,0q�6O   $	��Top=�6b   $	��117��6z   $��49��6�   ���	#FF0E33FF
�������6�   5      5      