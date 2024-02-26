using DataLayerLib;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WS_EF_CodeFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public HospitalContext? DB { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DB = new HospitalContext();
                DB.Database.EnsureDeleted();
                DB.Database.EnsureCreated();

                int numofDocs = DB.Doctors.Count();
                int numofPats = DB.Patients.Count();
                Console.WriteLine(numofDocs);
                Console.WriteLine(numofPats);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}