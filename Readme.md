<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/DXPivotGrid_SortByColumn/MainPage.xaml) (VB: [MainPage.xaml](./VB/DXPivotGrid_SortByColumn/MainPage.xaml))
* [MainPage.xaml.cs](./CS/DXPivotGrid_SortByColumn/MainPage.xaml.cs) (VB: [MainPage.xaml](./VB/DXPivotGrid_SortByColumn/MainPage.xaml))
<!-- default file list end -->
# How to sort data by a particular column or row


<p>The following example demonstrates how to sort data by a particular column.</p><p>In this example, values of the Country field are sorted by Quarter 2, 1995 column summary values. To do this, two sort conditions represented by SortByCondition instances are created. One of them identifies the '1995' field value, while another identifies the 'Quarter 2' value. These sort conditions are added to the Country field's PivotGridField.SortByConditions collection to specify the column by which Country values should be sorted. A data field that identifies the column is specified via the PivotGridField.SortByField property.</p><br />


<br/>


