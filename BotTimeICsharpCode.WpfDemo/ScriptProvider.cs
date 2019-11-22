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
            return ImportNamespace;
        }
    }
}