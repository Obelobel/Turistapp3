using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using App5.Annotations;

namespace App5.Model
{
    class Restaurant : INotifyPropertyChanged
    {
        private ObservableCollection<Ret> _retter;
        public string name { get; set; }
        public string telefon { get; set; }
        public string adresse { get; set; }
        public string photo { get; set; }

        public ObservableCollection<Ret> Retter
        {
            get { return _retter; }
            set { _retter = value; }
            
        }

        public string route { get; set; }
        public string beskrivelse { get; set; }


        public Restaurant(string name, string telefon, string adresse, string photo, string route, string beskrivelse)
        {
            Retter = new ObservableCollection<Ret>();
            this.name = name;
            this.telefon = telefon;
            this.adresse = adresse;
            this.photo = photo;
            this.route = route;
            this.beskrivelse = beskrivelse; 
        }

        public void AddRet(string enRet, string beskrivelse)
        {
            Retter.Add(new Ret(enRet,beskrivelse));
            OnPropertyChanged();
        }

        public override string ToString()
        {
            return string.Format("name: {0}, telefon: {1}, adresse: {2}, photo: {3}, Retter: {4}", name, telefon, adresse, photo, Retter);
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
