   M S B A M L   `   `   `  ����B  >WPFapp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPFapp1WPFapp1  5   	       WPFapp1.employee3   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPFapp1     5   	     � Title$  	employee3��5   	   $��462.575��6   $	��800��6,   .��5	      � $	��440��6   $��	0,-8,-6,2q�6   $��Bottom=�6+    � RowDefinitions 5
   
   �� 5      $��0* �6   �� 5      $��0* �6   �� 5      $��0* �6   �� 5      .+�5   
   �� -   5         ��Name$ lblEmpId��5      $��empId��6"   $
��Left=�62   $��	264,0,0,0q�6M   $	��Top=�6`   $��26��6x   $��44��6�   $��3��6�   �� 5   
   -   5         ��Name$ txtEmpId��5      $
��Left=�6$   $��23��6?   $��	373,0,0,0q�6K    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��199��6�   $��3��6�   �� 5   
   -   5        $ 
lblEmpName��5      $
��Name��6$   $
��Left=�63   $��
264,34,0,0q�6N   $	��Top=�6b    J� RenderTransformOrigin$ 5.401,0.633&�6z   $��26��6�   $��42��6�   $��3��6�   �� 5   
   -   5        $ 
txtEmpName��5      $
��Left=�6&   $��22��6A   $��
373,34,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��199��6�   $��3��6�   �� 5   
   -   5        $ lblEmpSalary��5      $��Salary��6&   $
��Left=�67   $��
264,86,0,0q�6R   $	��Top=�6f   $ 4.068,0.664&�6~   $��26��6�   $��41��6�   $��3��6�   �� 5   
   -   5        $ txtEmpSalary��5      $
��Left=�6(   $��22��6C   $��
373,86,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��199��6�   $��3��6�   �� 5   
   -   5        $ lblEmpDeptId��5      $��DeptId��6&   $
��Left=�67   $��264,156,0,0q�6R   $	��Top=�6g   $��26��6   $��46��6�   $��3��6�   �� 5   
   -   5        $ txtEmpDeptId��5      $
��Left=�6(   $��24��6C   $��373,156,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��199��6�   $��3��6�   �� 5   
   -	   5         ��Name$ 	btnInsert��5      $��Insert��6$   $
��Left=�65   $��306,232,0,0q�6P   $	��Top=�6e   $��75��6}   $��20��6�   $��3��6�   �� 5   
   -
   5        $ 	btnUpdate��5      $��update��6$   $
��Left=�65   $��444,232,0,0q�6P   $	��Top=�6e   $��75��6}   $��20��6�   $��3��6�   �� 5   
   -   5        $ 	btnDelete��5      $��Delete��6$   $
��Left=�65   $��589,232,0,0q�6P   $	��Top=�6e   $��75��6}   $��20��6�   $��3��6�   �� 5   
   -   5        $ 
btnDisplay��5      $��Display��6%   $
��Left=�67   $��162,232,0,0q�6R   $	��Top=�6g   $��75��6   $��20��6�   $��3��6�   5      5      