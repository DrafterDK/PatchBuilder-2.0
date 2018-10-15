using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PatchBuilder_2._0
{
    /// <summary>
    /// Логика взаимодействия для SettingWindow.xaml
    /// </summary>
    public partial class SettingWindow : Window
    {
        public SettingWindow()
        {
            InitializeComponent();
            Setting props = new Setting(); //экземпляр класса с настройками 
            props.ReadXml();
            TextBox1.Text = props.Fields.PatchName1;
            TextBox12.Text = props.Fields.PatchLocation1;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            Setting props = new Setting(); //экземпляр класса с настройками 

            props.Fields.PatchName1 = TextBox1.Text.Trim();
            props.Fields.PatchLocation1 = TextBox12.Text.Trim();

            props.WriteXml();
            MessageBox.Show("Настройки успешно сохранены.", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
            Close();

        }
    }
}
