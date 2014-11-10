using System.Collections.ObjectModel;
using ListView.Model;

namespace ListView.ViewModel
{
    class MainviewModel
    {
        public static Person SelectedPerson { get; set; }

        public ObservableCollection<Person> Persons { get; set; }
        
        public MainviewModel()
        {
            Persons = new ObservableCollection<Person>();
            Persons.Add(new Person("Børge", "24323452", "nordvang", "23232393-5522"));
            Persons.Add(new Person("Anders", "92323823", "Roskilde", "2858392-4432"));
            
        }
        
    }
}
