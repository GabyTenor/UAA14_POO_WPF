   M S B A M L   `   `   `  ����G  CACT_8-Banque, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ACT_8_Banque.FenetresACT_8_Banque.Fenetres  5      %    ACT_8_Banque.Fenetres.Interface   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:ACT_8_Banque.Fenetres     5        N� 
Background
  ����� N� FontSize$ 20(�5	       N� Title$ 	Interface��5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��2��6   .+�5      �� $��Informations du compte : ��6   �� 5      -   5         ��Name$ compte��5   &   $��13(�6   $�� ��66   5      �� 5   
   $��1��6   $��0��6!   $��Center=�61   $��Center=�6N   .��5       ��  �� Orientation$ 
Horizontal=�6   .+�5!      	� -   5         	�Name$ courant��5!   ,   $��18(�6   $��Compte Courant ��6=   	� 5"      -   5        $ epargne��5"   ,   $��18(�6   $��Compte Epargne ��6=   5#      5$      �� 5%   
   $��1��6   $��1��6!   $��Center=�61   $��Center=�6N   .��5&      �� $ 
Horizontal=�6   .+�5'      	� -   5        $ transEpargne��5'   ,   $��18(�6   $��Vers compte épargne��6B   	� 5(      -   5        $ transCourant��5(   ,   $��18(�6   $��Vers compte courant��6B   5)      5*      �� 5,   
   $��2��6   .+�5-      �� $��Center=�6   $��Montant du virement : ��65   �� 5.      -   5         ��Name$ montant��5.      $��60��6'   5/      �� 50   
   $��2��6   $��1��6"   .+�51      �� $��Center=�6   $'��!Numero de compte du destinataire ��65   �� 52      -   5        $ destinataire��52      $��60��6,   53      �� 55   
   -   5        	 ��Name$	 valider��55      $��3��6   $��Valider la transaction��6/   �� 56   
   -	   5        $	 annuler��56      $��3��6   $��1��6/   $��Annuler��6?   �� 58   
   -
   5        $ resultat��58   �   $�� ��6   $��Center=�6   $��Center=�69   $��15(�6T   $��4��6b   $��2��6o   6�   59      5:      