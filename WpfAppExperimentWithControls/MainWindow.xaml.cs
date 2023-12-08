using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfAppExperimentWithControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Number.Text = NumberTextBox.Text;
        }

        private void NumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);
        }

        private void SmallSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Number.Text = SmallSlider.Value.ToString("0");
        }

        private void BigSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Number.Text = BigSlider.Value.ToString("000-000-0000");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton coCoRadioButton)
            {
                Number.Text = coCoRadioButton.Content.ToString();
            }
        }

        private void MyListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MyListBox.SelectedItem is ListBoxItem coCoListBoxItem)
            {
                Number.Text = coCoListBoxItem.Content.ToString();
            }
        }

        private void ReadOnlyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ReadOnlyComboBox.SelectedItem is ListBoxItem coCoListBoxItem)
            {
                Number.Text = coCoListBoxItem.Content.ToString();
            }
        }

        private void EditableComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EditableComboBox.SelectedItem is ListBoxItem coCoListBoxItem)
            {
                Number.Text = coCoListBoxItem.Content.ToString();
            }
        }
    }
}
