using BotTimeICSharpCode.AvalonEdit.Highlighting;
using BotTimeICSharpCode.CodeCompletion;
using ICSharpCode.NRefactory.TypeSystem;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;

namespace BotTimeICsharpCode.WpfDemo
{
    /// <summary>
    /// CodeEditor.xaml 的交互逻辑
    /// </summary>
    public partial class CodeEditor : Window
    {
        private CSharpCompletion completion;

        private string _language;

        public string Text { get; set; }

        public CodeEditor(string text)
        {
            InitializeComponent();
            Text = text;
        }

        protected override void OnInitialized(EventArgs eventArgs)
        {
            base.OnInitialized(eventArgs);

            _language = "C#";

            completion = WindowFactory.Get(typeof(CSharpCompletion), new object[] { new ScriptProvider() }) as CSharpCompletion;

            TabControl.Items.Add(OpenFile());
        }

        private TabItem OpenFile()
        {
            const string fileName = "csx";
            var editor = new BotTimeCodeTextEditor
            {
                FontFamily = new FontFamily("Consolas"),
                FontSize = 12,
                Completion = completion,
                SyntaxHighlighting = HighlightingManager.Instance.GetDefinition(_language)
            };

            editor.OpenFile(fileName, Text, _language);
            editor.SyntaxHighlighting = HighlightingManager.Instance.GetDefinition(_language);

            var tabItem = new TabItem
            {
                Content = editor,
                Visibility = Visibility.Collapsed
            };
            return tabItem;
        }


        private void CodeEditor_OnClosing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}