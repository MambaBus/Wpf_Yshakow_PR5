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

namespace Wpf_Yshakow_PR5
{
    /// <summary>
    /// Логика взаимодействия для Page12.xaml
    /// </summary>
    public partial class Page12 : Page
    {
        public Page12()
        {
            InitializeComponent();

            List<St> st = new List<St>();
            st.Add(new St() { Id = 1, JID = "1", JD = new DateTime(2015, 4, 28), UID = "Admin", IS = "Initial Logged Job", Screen = "Initial Logged Job", FI = "Initial Logged Job", JS = "Closed" });
            st.Add(new St() { Id = 2, JID = "2", JD = new DateTime(2015, 4, 28), UID = "geoffc", IS = "Test 2", Screen = "Test 2", FI = "Test 2", JS = "Open" });

            t1.ItemsSource = st;
        }

    }

    public class St
    {
        public int Id { get; set; }

        public string JID { get; set; }
        public DateTime JD { get; set; }
        public string UID { get; set; }
        public string IS { get; set; }
        public string Screen { get; set; }
        public string FI { get; set; }
        public string JS { get; set; }

    }
}


