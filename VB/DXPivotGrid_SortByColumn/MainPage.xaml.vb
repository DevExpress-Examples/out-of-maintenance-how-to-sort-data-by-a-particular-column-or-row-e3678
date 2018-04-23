Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Windows
Imports System.Windows.Controls
Imports System.Xml.Serialization
Imports DevExpress.Xpf.PivotGrid

Namespace DXPivotGrid_SortByColumn
	Partial Public Class MainPage
		Inherits UserControl
		Private dataFileName As String = "nwind.xml"
		Public Sub New()
			InitializeComponent()

			' Parses an XML file and creates a collection of data items.
			Dim assembly As System.Reflection.Assembly = _
				System.Reflection.Assembly.GetExecutingAssembly()
			Dim stream As Stream = assembly.GetManifestResourceStream(dataFileName)
			Dim s As New XmlSerializer(GetType(OrderData))
			Dim dataSource As Object = s.Deserialize(stream)

			' Binds a pivot grid to this collection.
			pivotGridControl1.DataSource = dataSource
		End Sub

		Private Sub LayoutRoot_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)

			' Locks the pivot grid from updating while the Sort by Summary
			' settings are being customized.
			pivotGridControl1.BeginUpdate()
			Try

				' Specifies a data field whose summary values should be used to sort values
				' of the Country field.
				fieldCountry.SortByField = fieldFreight

				' Specifies a column by which the Country field values should be sorted.
				fieldCountry.SortByConditions.Add(New SortByCondition(fieldYear, "1995"))
				fieldCountry.SortByConditions.Add(New SortByCondition(fieldQuarter, "2"))
			Finally

				' Unlocks the pivot grid and applies changes.
				pivotGridControl1.EndUpdate()
			End Try
		End Sub
	End Class
End Namespace