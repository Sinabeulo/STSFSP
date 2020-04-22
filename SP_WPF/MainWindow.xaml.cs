using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SP_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> _subCategory = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            InitializeUISetting();
        }

        private void InitializeUISetting()
        {
            tv_Main_CategoryList.SelectedItemChanged += Tv_Main_CategoryList_SelectedItemChanged;
            TreeViewItem item = new TreeViewItem() { Name = "ROOT", IsExpanded = true };
            TreeViewItem mediaItem = new TreeViewItem() { Name = "Media", Header = "Media", IsExpanded = true };
            mediaItem.Items.Add(new TreeViewItem() { Name = "WebCamReader", Header = "WebCam", IsExpanded = false });
            item.Items.Add(mediaItem);//new TreeViewItem() { Header = "Media" });
            tv_Main_CategoryList.Items.Add(item);

            //lb_Sub_CategoryList.ItemsSource = _subCategory;
            //lb_Sub_CategoryList.SelectionChanged += Lb_Sub_CategoryList_SelectionChanged;
        }

        private void Tv_Main_CategoryList_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            //.....
            //switch (((TreeViewItem)tv_Main_CategoryList.SelectedItem).Name)
            //{
            //    case nameof(WebCamReader):
            //        cc_Sub_Content.Content = new WebCamReader();
            //        break;
            //}
            
        }
    }
}
