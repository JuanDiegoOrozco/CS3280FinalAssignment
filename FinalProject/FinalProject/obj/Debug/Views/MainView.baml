   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FinalAssignmentFinalAssignment  5   	   $    FinalAssignment.Views.MainView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FinalAssignment     5   	     � Title$  
New Tester��5   	   $��530.927��6   $	��537��6-   .��5	      � 
����� �.+�5
   
   �� -   5         ��Name$ OrdersB��5
      $��Orders��6"   $
��Left=�63   $��
20,433,0,0q�6N   $	��Top=�6b   $	��115��6z   6�   �� 5   
   -   5        $ 
InventoryB��5      $��	Inventory��6%   $��Center=�69   $��215,433,199,0q�6V   $	��Top=�6m   $	��103��6�   6�   �� 5   
   -   5        $ 
NewOrdersB��5      $��
New Orders��6%   $��Right=�6:   $��
0,433,10,0q�6V   $	��Top=�6j   $	��103��6�   6�   �� 5   
   -   5         ��Name$ OrdersViewList��5      $
��Left=�6+   $	��172��6F   $��	35,39,0,0q�6S   $	��Top=�6f   $	��457��6~   ��6�   ��  �� Path$ 	AllOrders� �� View 5      �� 5       �� ColumnHeaderStringFormat$  ��6   .P�5      ��  �� Width$ 85��6%   $��Order Number��60    �� DisplayMemberBinding 5   %   �� $ OrderNumber��� 5      $	 135��6%   $��Date Placed��61    5   %   �� $ 
DatePlaced��� 5      $	 121��6%   $��	Purchaser��61    5   %   �� $ Purchaser.Name��� 5      $	 110��6%   $��Order Total��61    5   %   �� $ 	TotalCost�5      5      �� 5   
   -   5        $ OrdersViewDisplay��5      $
��Left=�6.   $	��186��6I   $��
20,225,0,0q�6V   $	��Top=�6j   $	��487��6�   ��5      �� $ AllItems� 5      �� 5      $  ��6   .P�5      �� $ 80��6%   $��Item Number��60    5    %   �� $ 
ItemNumber��� 5!      $ 80��6%   $��	Item Name��60    5"   %   �� $ ItemName��� 5#      $ 85��6%   $��	Item Cost��60    5$   %   �� $ ItemCost��� 5%      $	 115��6%   $��Quantity Purchased��61    5&   %   �� $ QuantityPurchased��� 5'      $	 110��6%   $��Cost Paid Per Item��61    5(   %   �� $ CostPaidPerItem�5)      5+      5-      5.      