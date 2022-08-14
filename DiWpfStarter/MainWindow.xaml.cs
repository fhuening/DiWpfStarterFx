using DiWpfStarter.Helper;
using System.Windows;

namespace DiWpfStarter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IAbstractFactory<ChildWindow> _factory;

        public MainWindow(IAbstractFactory<ChildWindow> factory)
        {
            InitializeComponent();
            _factory = factory;
        }

        private void openForm_Click(object sender, RoutedEventArgs e)
        {
            _factory.Create().Show();
        }
    }
}
