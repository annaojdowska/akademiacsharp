using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Data;
using System.Collections.ObjectModel;

namespace AkademiaProjekt
{
    class PublicationViewModel : INotifyPropertyChanged
    {
        private ICollectionView publicationsView;
        private ObservableCollection<Publication> publications;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow Window { get; set; }
        public string Description {get; set;}

        public ICollectionView PublicationsView
        {
            get { return publicationsView; }
        }

        public PublicationViewModel(ObservableCollection<Publication> publications, MainWindow win)
        {
            this.Window = win;
            this.publications = publications;
            publicationsView = CollectionViewSource.GetDefaultView(this.publications);
            publicationsView.CurrentChanged += SelectionChanged;

        }
        private void SelectionChanged(object sender, EventArgs e)
        {
           
            if (this.Window.authorsListBox.HasItems)
            {
                Publication tmp = (Publication)this.Window.authorsListBox.SelectedValue;
                this.Description = tmp.Description;
                this.OnPropertyChanged("Description");
            }

        }
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
