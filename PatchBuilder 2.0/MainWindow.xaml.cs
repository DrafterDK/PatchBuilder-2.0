using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

namespace PatchBuilder_2._0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Setting s = new Setting();
        public MainWindow()
        {            
            s.ReadXml();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
                Process procUnpackDat = new Process();
            //procUnpackDat.StartInfo.FileName = s.Fields.PatchLocation1 + "\\hi.bat";
            procUnpackDat.StartInfo.FileName = "cmd.exe";
            procUnpackDat.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                procUnpackDat.StartInfo.CreateNoWindow = true;

                procUnpackDat.StartInfo.Arguments = @"/C cd "+ s.Fields.PatchLocation1 + " & git stash & git fetch origin & git checkout origin/master patcher.xml";// J:\FSSIntegration\";// + s.Fields.PatchLocation1;// + " & /K hi.bat";
                                                                                        //  procUnpackDat.StartInfo.FileName = @"J:\FSSIntegration\hi.bat";
                procUnpackDat.Start();


            // Process procUnpackDat = new Process();
            //procUnpackDat.StartInfo.FileName = "cmd.exe";
            //procUnpackDat.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            ////procUnpackDat.StartInfo.CreateNoWindow = true;

            //procUnpackDat.StartInfo.Arguments = @"/C copy " + s.Fields.PatchLocation1 + "\\patcher.xml " + s.Fields.PatchLocation1 + "\\patcher_local.xml";// J:\FSSIntegration\";// + s.Fields.PatchLocation1;// + " & /K hi.bat";
            ////  procUnpackDat.StartInfo.FileName = @"J:\FSSIntegration\hi.bat";
            //procUnpackDat.Start();
            //}
            //catch(Exception ex)
            //{
            //    TextBoxRes.Text = ex.ToString();
            //}
            //  procUnpackDat.WaitForInputIdle(5000);
            // procUnpackDat.w

        }
    }
}
