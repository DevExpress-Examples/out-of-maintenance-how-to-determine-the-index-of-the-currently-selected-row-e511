using System.Windows;
using System.Collections;
// ...

namespace LastRow {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();

            ArrayList list = new ArrayList();
            list.Add(new TestData("1", "1"));
            list.Add(new TestData("2", "2"));
            list.Add(new TestData("3", "3"));
            list.Add(new TestData("4", "4"));
            list.Add(new TestData("5", "5"));
            list.Add(new TestData("6", "6"));
            list.Add(new TestData("7", "7"));
            list.Add(new TestData("8", "8"));
            list.Add(new TestData("9", "9"));
            list.Add(new TestData("10", "10"));
            list.Add(new TestData("11", "11"));
            grid.DataSource = list;
        }

        private void btn_Click(object sender, RoutedEventArgs e) {
            if (view.FocusedRowData == null)
                textbox.Text = "No Rows Selected";
            else 
                if (grid.GetRowVisibleIndexByHandle(view.FocusedRowData.RowHandle.Value) == 0)
                textbox.Text = "First Row!";
            else 
                if (grid.GetRowVisibleIndexByHandle(view.FocusedRowData.RowHandle.Value) == grid.VisibleRowCount - 1)
                textbox.Text = "Last Row!";
            else
                textbox.Text = "Row Index: " + 
                    grid.GetRowVisibleIndexByHandle(view.FocusedRowData.RowHandle.Value).ToString();
        }
    }

    public class TestData {
        public string column1 { get; set; }
        public string column2 { get; set; }

        public TestData(string str1, string str2) {
            column1 = str1;
            column2 = str2;
        }
    }
}
