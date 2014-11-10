using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Storage.FileProperties;
using App5.Annotations;
using App5.Common;

namespace App5.Model
{
    class RestaurantListe : INotifyPropertyChanged
    {

        //private ICommand _addRetCommand;

        //public ICommand AddRetCommand
        //{
        //    get
        //    {
        //        if (_addRetCommand == null)
        //            _addRetCommand = new RelayCommand<String>(Ret => AddRetCommand(Ret));
        //        return _addRetCommand;
        //    }
        //    set { _addRetCommand = value; }
        //}
        public ObservableCollection<Restaurant> Restaurants { get; set; }

        public RestaurantListe()
        {
            Restaurants = new ObservableCollection<Restaurant>();
        }

        public void AddRestaurant(string Name, string Phone, string Adress, string Photo, string Route, string Beskrivelse)
        {
            Restaurants.Add(new Restaurant(Name, Phone, Adress, Photo, Route, Beskrivelse));
            OnPropertyChanged();

        }

        private async void AddNoteCommandAction(String restauranting)
        {
            Restaurants.Add(new Restaurant("name", "phone", "adress", "placeholder", " routetet", "beskrivelse command"));
            OnPropertyChanged();
        }

        #region PC

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
