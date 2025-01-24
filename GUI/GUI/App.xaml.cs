using System.Configuration;
using System.Data;
using System.Windows;

namespace GUI {
    public partial class App : Application {
        private void ExceptionHandler(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e) {
            MessageBox.Show("An unhandled exception just occurred: " + e.Exception.Message, "Exception occured", MessageBoxButton.OK, MessageBoxImage.Error);
            e.Handled = true;
        }
    }

}
