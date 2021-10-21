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

namespace SidebarExample
{
    /// <summary>
    /// Interaction logic for SidebarView.xaml
    /// </summary>
    public partial class SidebarView : UserControl
    {
        public SidebarView()
        {
            throw new NotImplementedException("Zero argument constructor not supported, DataModel required");
        }
        public SidebarView(SidebarViewModel model)
        {
            DataContext = model;
            InitializeComponent();
        }
    }
}
