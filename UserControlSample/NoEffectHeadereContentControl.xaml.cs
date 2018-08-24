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

namespace UserControlSample
{
    /// <summary>
    /// Interaction logic for NoEffectHeadereContentControl.xaml
    /// </summary>
    public partial class NoEffectHeadereContentControl : UserControl
    {
        public NoEffectHeadereContentControl()
        {
            InitializeComponent();
        }
        public static readonly DependencyProperty ChildContentProperty =
            DependencyProperty.Register("ChildContent", typeof(UIElement), typeof(NoEffectHeadereContentControl), new PropertyMetadata(null));

        public UIElement ChildContent
        {
            get { return (UIElement)GetValue(ChildContentProperty); }
            set { SetValue(ChildContentProperty, value); }
        }

        public static readonly DependencyProperty HeaderProperty =
            DependencyProperty.Register("Header", typeof(string), typeof(NoEffectHeadereContentControl));

        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }
    }
}
