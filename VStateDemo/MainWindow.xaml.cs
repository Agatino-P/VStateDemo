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

namespace VStateDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Toggle_Click(object sender, RoutedEventArgs e)
        {
            System.Collections.IList states = VisualStateManager.GetVisualStateGroups(dp);
            var stategroup = states[0] as VisualStateGroup;
            var state = stategroup.CurrentState;
            if (state != null && state.Name == "Landscape")
            {

            VisualStateManager.GoToElementState(dp, "Portrait", false);
            }
            else
            {
                VisualStateManager.GoToElementState(dp, "Landscape", false);

            }
            
        }


    }
}
