using System.Windows;

namespace CnCNet.LauncherStub;
/// <summary>
/// Interaction logic for AdvancedMessageBox.xaml.
/// </summary>
public partial class AdvancedMessageBox : Window
{
    public AdvancedMessageBox() => InitializeComponent();

    public object? Result { get; set; }
}