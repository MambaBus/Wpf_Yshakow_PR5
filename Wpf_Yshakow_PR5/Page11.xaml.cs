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
    /// Логика взаимодействия для Page11.xaml
    /// </summary>
    public partial class Page11 : Page
    {
        public Page11()
        {
            InitializeComponent();

            Table1 tb1 = new Table1();
            tb1.Место = "Вход офис";
            tb1.Точка = "У двери";
            tb1.Серийныйномер = "55484403";
            tb1.IPадрес = "192.168.201.09";
            tb1.MACадрес = "00:00:33:22:22:00";
            tb1.Состояниеподключения = "Подключено";
            tb1.ДатаивремяДетектора = "24.04.04";

            dt.Items.Add(tb1);

        }

        public class Table1
        {
            public string Место { get; set; }
            public string Точка { get; set; }
            public string Серийныйномер { get; set; }
            public string IPадрес { get; set; }
            public string MACадрес { get; set; }
            public string Состояниеподключения { get; set; }
            public string ДатаивремяДетектора { get; set; }
        }
    }
}

