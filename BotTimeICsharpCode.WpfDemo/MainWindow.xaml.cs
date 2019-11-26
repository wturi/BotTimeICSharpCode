using BotTimeICSharpCode.CodeCompletion;
using ICSharpCode.NRefactory.TypeSystem;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace BotTimeICsharpCode.WpfDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private int count = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Open_OnClick(object sender, RoutedEventArgs e)
        {
            var codeEditor = new CodeEditor(count.ToString());
            codeEditor.ShowDialog();
            count++;
        }

        private void Reset_OnClick(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                var assemblyList = new List<Assembly>();

                assemblyList.AddRange(AppDomain.CurrentDomain.GetAssemblies());
                assemblyList.Add(typeof(Microsoft.Win32.PowerModes).Assembly);
                assemblyList.Add(typeof(ConstructorHandling).Assembly);
                assemblyList.Add(typeof(JObject).Assembly);
                assemblyList.Add(typeof(BitmapCache).Assembly);
                assemblyList.Add(typeof(BitConverter).Assembly);
                assemblyList.Add(typeof(object).Assembly);
                assemblyList.Add(typeof(Uri).Assembly);
                assemblyList.Add(typeof(System.Xml.XmlDocument).Assembly);
                assemblyList.Add(typeof(System.Drawing.Bitmap).Assembly);
                assemblyList.Add(typeof(FormatException).Assembly);
                assemblyList.Add(typeof(Form).Assembly);
                assemblyList.Add(typeof(IProjectContent).Assembly);

                WindowFactory.Reset(typeof(CSharpCompletion), new object[] { new ScriptProvider(), assemblyList });
            });
        }
    }
}