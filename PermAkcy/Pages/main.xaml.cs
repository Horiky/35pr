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

namespace PermAkcy.Pages
{
    /// <summary>
    /// Логика взаимодействия для main.xaml
    /// </summary>
    public partial class main : Page
    {
        public main()
        {
            InitializeComponent();
        }
        private void OpenPageChart(object sender, RoutedEventArgs e)
        {
            // конвертируем значение текстового поля
            float value = Convert.ToInt32(tb_value.Text);
            // добавляем значение в массив
            mainWindow.pointsInfo.Add(new Classess.PointInfo(value));
            // открываем страницу с графиками
            mainWindow.OpenPages(MainWindow.pages.chart);
        }
    }
}
