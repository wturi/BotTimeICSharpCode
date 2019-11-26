using BotTimeICSharpCode.CodeCompletion;
using System.Collections.Generic;
using System.Linq;

namespace BotTimeICsharpCode.WpfDemo
{
    public class ScriptProvider : ICSharpScriptProvider
    {
        private string Vars { get; set; }

        private string ImportNamespace { get; set; }

        public ScriptProvider()
        {
            Vars = "";
            var originalNamespaceList = new List<string>
            {
                "System",
                "System.Collections.Generic",
                "System.Linq",
                "System.Text"
            };

            var importNamespace = originalNamespaceList.Select(d => $"using {d};");

            ImportNamespace = string.Join("\r\n", importNamespace);
            ImportNamespace= @"using Friday.ActivityLibrary.SystemToolActivities;
            using System.Xml;
            using System.Linq;
            using Friday.StandardVariables;
            using System.Collections.Generic;
            using System;
            using System.Data;
            using System.Drawing;
            using System.Text; ";
        }

        public string GetUsing()
        {
            return ImportNamespace;
        }

        public string GetVars()
        {
            return Vars;
        }

        public string GetNamespace()
        {
            return "InvokeCodeTest";
        }
    }
}