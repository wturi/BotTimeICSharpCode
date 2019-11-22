using BotTimeICSharpCode.AvalonEdit.Highlighting;
using BotTimeICSharpCode.CodeCompletion;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BotTimeICsharpCode.WpfDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private CSharpCompletion completion;

        private string _language;

        public string Text { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnInitialized(EventArgs eventArgs)
        {
            base.OnInitialized(eventArgs);

            _language = "C#";

            completion = new CSharpCompletion(new ScriptProvider());
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
    }
}