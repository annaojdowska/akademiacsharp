using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace AkademiaProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public ObservableCollection<Publication> publicationList;

        public MainWindow()
        {
            InitializeComponent();
            publicationList = new ObservableCollection<Publication>();
            DataContext = new PublicationViewModel(publicationList, this);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow(this);
            addWindow.ShowDialog();
        }

        public void AddNovel(string title, string author, string description, Genres genre, int year)
        {
            this.publicationList.Add(new Novel(title, author, description, genre, year));
        }
        public void AddDrama(string title, string author, string description, int firstPlayed)
        {
            this.publicationList.Add(new Drama(title, author, description, firstPlayed));
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Publications";
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML documents (.xml)|*.xml";

            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filePath = dlg.FileName;
                WriteToXmlFile(filePath);
            }
        }

        private void WriteToXmlFile(string filePath)
        {
            using (var sw = new StreamWriter(filePath))
            {
                var serializer = new XmlSerializer(typeof(ObservableCollection<Publication>));
                serializer.Serialize(sw, this.publicationList);
            }
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".xml";
            dlg.Filter = "XML documents (.xml)|*.xml";

            Nullable<bool> result = dlg.ShowDialog();
            string filename = "";
            if (result == true)
            {
                filename = dlg.FileName;
            }

            if (File.Exists(filename))
            {
                XmlFileToList(filename);
            }
            else
            {
                MessageBox.Show("Such file doesn't exist");
            }
        }

        private void XmlFileToList(string filename)
        {
            using (var sr = new StreamReader(filename))
            {
                var deserializer = new XmlSerializer(typeof(ObservableCollection<Publication>));
                ObservableCollection<Publication> listFromFile = (ObservableCollection<Publication>)deserializer.Deserialize(sr);
                foreach (var item in listFromFile)
                {
                    publicationList.Add(item);
                }
            }
        }
    }
}
