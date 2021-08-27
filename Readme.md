<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128578269/11.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3678)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/DXPivotGrid_SortByColumn/MainPage.xaml) (VB: [MainPage.xaml](./VB/DXPivotGrid_SortByColumn/MainPage.xaml))
* [MainPage.xaml.cs](./CS/DXPivotGrid_SortByColumn/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/DXPivotGrid_SortByColumn/MainPage.xaml.vb))
<!-- default file list end -->
# How to sort data by a particular column or row


<p>The following example demonstrates how to sort data by a particular column.</p><p>In this example, values of the Country field are sorted by Quarter 2, 1995 column summary values. To do this, two sort conditions represented by SortByCondition instances are created. One of them identifies the '1995' field value, while another identifies the 'Quarter 2' value. These sort conditions are added to the Country field's PivotGridField.SortByConditions collection to specify the column by which Country values should be sorted. A data field that identifies the column is specified via the PivotGridField.SortByField property.</p><br />


<br/>


