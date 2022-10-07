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
using AlternationV3_Array;

namespace PW5V3_0202
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double[] array1, array2, array3, array4, array5;
        List<int> resultNumbers;
        private void CreateFill_Click(object sender, RoutedEventArgs e)//Добавить взаимодействие с классом AlternationV3 для нахождения чередования
        {
            int sizeArrays = Convert.ToInt32(size.Text);
            array1 = new double[sizeArrays];
            array2 = new double[sizeArrays];
            array3 = new double[sizeArrays];
            array4 = new double[sizeArrays];
            array5 = new double[sizeArrays];
            Random rnd = new Random();
            for (int i = 0; i < sizeArrays; i++)
            {
                array1[i] = rnd.Next(-50, 50);
                array2[i] = rnd.Next(-50, 50);
                array3[i] = rnd.Next(-50, 50);
                array4[i] = rnd.Next(-50, 50);
                array5[i] = rnd.Next(-50, 50);
            }
            //Добавить сюда проверку массивов wrote by HB :3
            DataGrid1.ItemsSource = VisualArray.ToDataTable(array1).DefaultView;
            DataGrid2.ItemsSource = VisualArray.ToDataTable(array2).DefaultView;
            DataGrid3.ItemsSource = VisualArray.ToDataTable(array3).DefaultView;
            DataGrid4.ItemsSource = VisualArray.ToDataTable(array4).DefaultView;
            DataGrid5.ItemsSource = VisualArray.ToDataTable(array5).DefaultView;
            resultNumbers = new List<int>();
            if (AlternationV3.ElementAlternationCheck(array1))
            {
                resultNumbers.Add(1);//Заменить цифру на порядковый номер массива
            }
        }
    }
}
