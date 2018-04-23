using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Serialization;
using DevExpress.Xpf.PivotGrid;

namespace DXPivotGrid_SortByColumn {
    public partial class MainPage : UserControl {
        string dataFileName = "DXPivotGrid_SortByColumn.nwind.xml";
        public MainPage() {
            InitializeComponent();

            // Parses an XML file and creates a collection of data items.
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream(dataFileName);
            XmlSerializer s = new XmlSerializer(typeof(OrderData));
            object dataSource = s.Deserialize(stream);

            // Binds a pivot grid to this collection.
            pivotGridControl1.DataSource = dataSource;
        }

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e) {

            // Locks the pivot grid from updating while the Sort by Summary
            // settings are being customized.
            pivotGridControl1.BeginUpdate();
            try {

                // Specifies a data field whose summary values should be used to sort values
                // of the Country field.
                fieldCountry.SortByField = fieldFreight;

                // Specifies a column by which the Country field values should be sorted.
                fieldCountry.SortByConditions.Add(new SortByCondition(fieldYear, "1995"));
                fieldCountry.SortByConditions.Add(new SortByCondition(fieldQuarter, "2"));
            }
            finally {

                // Unlocks the pivot grid and applies changes.
                pivotGridControl1.EndUpdate();
            }
        }
    }
}