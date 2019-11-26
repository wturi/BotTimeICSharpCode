using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using BotTimeICSharpCode.CodeCompletion;
using ICSharpCode.NRefactory.TypeSystem;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Application = System.Windows.Application;

namespace BotTimeICsharpCode.WpfDemo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Application.Current.Properties[nameof(WindowFactory)] = new Dictionary<string, object>();

            var assemblyList = new List<Assembly>();

            //assemblyList.AddRange(AppDomain.CurrentDomain.GetAssemblies());
            assemblyList.Add(typeof(Microsoft.Win32.PowerModes).Assembly);
            assemblyList.Add(typeof(Form).Assembly);
            assemblyList.Add(typeof(IProjectContent).Assembly);

            var c = WindowFactory.Get(typeof(CSharpCompletion), new object[] { new ScriptProvider(), assemblyList }) as CSharpCompletion;

        }
    }
}
