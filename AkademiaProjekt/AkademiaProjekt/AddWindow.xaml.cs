using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace AkademiaProjekt
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        private MainWindow window;
        public AddWindow(MainWindow window)
        {
            this.window = window;
            InitializeComponent();
            GenresComboBox.ItemsSource = Enum.GetValues(typeof(Genres));
            GenresComboBox.SelectedIndex = 7;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string title = this.Title.Text;
                string author = this.Author.Text;
                string description = this.Description.Text;
                int releasedIn = 0;
                int firstPlayedIn = 0;
                if(!this.ReleasedIn.Text.Equals("")) releasedIn = int.Parse(this.ReleasedIn.Text);
                if (!this.PlayedIn.Text.Equals("")) firstPlayedIn = int.Parse(this.PlayedIn.Text);
                Genres genre = (Genres)Enum.Parse(typeof(Genres), this.GenresComboBox.Text);
                var isNovel = this.Novel.IsChecked;
                if (isNovel.Value && !title.Equals("") && !author.Equals("") && !releasedIn.Equals(0))
                {
                        window.AddNovel(title, author, description, genre, releasedIn);
                        this.Close();
                }
                else if(!isNovel.Value && !title.Equals("") && !author.Equals("") && !firstPlayedIn.Equals(0))
                {
                        window.AddDrama(title, author, description, firstPlayedIn);
                        this.Close();
                }
                else
                {
                    MessageBox.Show("     Please, fill properly all necessary fields", "Invalid Data");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("    Bad format of data", "Bad format");
            }
        }
    }
}
