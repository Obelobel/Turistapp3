using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;
using Windows.UI.Xaml.Media;
using App5.Annotations;
using App5.Common;
using App5.Model;

namespace App5.Viewmodel
{
    class MainViewModel : INotifyPropertyChanged
    {

        public string Comment { get; set; }

        private Ret _selectedRet;
        

        public Ret SelectedRet
        {
            get { return _selectedRet; }
            set
            {
                _selectedRet = value;
                fyldListe();
            }
            
        }

        //opret handler samt relaycommand som skal bindes til activeComments ObservableCollection'en som skal bindes ned til kommentarne
        public ObservableCollection<string> ActiveComments
        {
            get { return _activeComments; }
            set
            {
                _activeComments = value; 
                OnPropertyChanged("ActiveComments");
            }
            
        }

        public static Restaurant SelectedRestaurant { get; set; }

        public RestaurantListe Restauranter { get; set; }
        private OpretCommentHandler _opretRetterHandler;
        private RelayCommand _opretcommentCommand;
        private RelayCommand _opretRetterCommand;
        private ObservableCollection<string> _activeComments;

        public RelayCommand OpretcommentCommand
        {
            get { return _opretcommentCommand; }
            set { _opretcommentCommand = value; }
        }

        public OpretCommentHandler OpretRetterHandler
        {
            get { return _opretRetterHandler; }
            set { _opretRetterHandler = value; }
        }

        public RelayCommand OpretRetterCommand
        {
            get { return _opretRetterCommand; }
            set { _opretRetterCommand = value; }
        }

        public void fyldListe()
        {
           ActiveComments.Clear();
            foreach (string Comments in SelectedRet.Comments)
            {

                ActiveComments.Add(Comments);
                
            }
        }

        public void addComment()
        {
            SelectedRet.AddComment(Comment);
            fyldListe();
        }
        public MainViewModel()
        {
            ActiveComments = new ObservableCollection<string>();
            Restauranter = new RestaurantListe();
            _opretcommentCommand = new RelayCommand(addComment);
            

            #region Bones restaurant

            Restauranter.AddRestaurant("Bones", "40203060", "roskildevej 40", "/assets/download.jpg",
                "https://www.google.dk/maps/dir//Bone's+Roskilde,+Algade+55,+4000+Roskilde/@55.640602,12.090003,17z/data=!4m12!1m3!3m2!1s0x46525fc5f501daa9:0x83f407b0441786ed!2sBone's+Roskilde!4m7!1m0!1m5!1m1!1s0x46525fc5f501daa9:0x83f407b0441786ed!2m2!1d12.090003!2d55.640602",
                @"Restaurant Bone's i Roskilde bryster sig verdens bedste spareribs.
Danmarks største salatbar og byens bedste service. Her vil hele familien føle sig godt tilpas. Alle er velkomne, selv folk der spiser med kniv og gaffel

Bones har åbent alle dage med følgende tider:
man-tor: 18-22
fre-søn: 18-23
og kan kontaktes på: 40203060

Du kan finde Bones ved at trykke på Navigations knappen forneden.

Restauranten Bone's tilbyder en fantastisk god menu som du kan se nedenfor og se hvad de tilbyder!");

            #endregion

            #region Jensens Restaurant

            Restauranter.AddRestaurant("Jensens", "45724492", "Roskilde gade 55", "/assets/jensen.jpg",
                "https://www.google.dk/maps/dir//Jensens+B%C3%B8fhus,+Skomagergade+38,+4000+Roskilde/@55.640821,12.076915,15z/data=!4m12!1m3!3m2!1s0x0:0x6343104d541ed2b0!2sJensens+B%C3%B8fhus!4m7!1m0!1m5!1m1!1s0x46525fda16790413:0x6343104d541ed2b0!2m2!1d12.076915!2d55.640821",
                @"Restauranten Jensens Bøfhus, ligger godt centralt og tilbyder nogle af de bedste bøffer og andre retter Roskilde har at tilbyde.
Jensens Bøfhus har disuden også en fantastisk salatbar samt isbar for de lækresultne hjerter. Hos Jensens Bøfhus er alle velkomne lige fra uge fødselsdagsbørn, til de ældre der bare sætter pris på en god bøf!

Jensens Bøfhus har åbent alle dage med følgende tider:
man-tor: 18-22
fre-søn: 18-23
og kan kontaktes på: 45724492

Du kan finde Jensens Bøfhus ved at trykke på Navigations knappen forneden. og se deres fantastiske menu med deres endnu bedre tilbud ved at klikke på Menu.");

            #endregion


            #region bones retter

            Restauranter.Restaurants[0].AddRet("Spareribs", "Dejlige spareribs med Barbeque sovs");
            Restauranter.Restaurants[0].AddRet("hotwings", "Delikate hotwings som er ekstra spicey!");
            Restauranter.Restaurants[0].AddRet("Ribey", "400g ribey med pomfritter som tilbehør");
            Restauranter.Restaurants[0].AddRet("kæmpen", "den store bøf på 1000g uden tilbehør!");
            Restauranter.Restaurants[0].AddRet("delikaten", "den smukt skåret bøf på 350g med pomfritter");
            Restauranter.Restaurants[0].AddRet("Kartoflen", "med en 200g Ribey følger den kæmpe kartoffel på 2000g");

            #endregion


            #region Jensen retter

            Restauranter.Restaurants[1].AddRet("Bøffen", "en fantastisk hakkebøf på 350g med pomfritter og salat");
            Restauranter.Restaurants[1].AddRet("Ribey", "den fantastiske Ribey på 500g med promfritter og salat");
            Restauranter.Restaurants[1].AddRet("Hotwings",
                "Jensens egne hotwings total 450g med jensens egen barbeque sovs");
            Restauranter.Restaurants[1].AddRet("Spareribs",
                "Jensens egne spareribs total 800g med jensens egen barbequeue sovs");
            Restauranter.Restaurants[1].AddRet("Kartoffel krigen", "indeholder 4 bagte kartoffler med 400g kødstykker");
            Restauranter.Restaurants[1].AddRet("Bøf bearnaise", "den traditionelle bøf på 500g samt pomfritter");

            #endregion

            Restauranter.Restaurants[0].Retter[0].AddComment("Hej alle, jeg synes at spareribsne smagte rigtig godt");
            Restauranter.Restaurants[0].Retter[1].AddComment("Wassap! damn those hotwings are fiiiine as heeeelll");
            Restauranter.Restaurants[0].Retter[2].AddComment("nøøøj hvor smager den ribey godt... lige i mausen!");
            Restauranter.Restaurants[0].Retter[3].AddComment("det var da godt nok noget billigt kød ad ad ad!");
            Restauranter.Restaurants[0].Retter[4].AddComment("wauw man skulle næsten tro dette var Noma");
            Restauranter.Restaurants[0].Retter[5].AddComment("hold kæft en kedelig kartoffel...");

            Restauranter.Restaurants[1].Retter[0].AddComment("Heeeeej, jeg synes at bøffen var dårlig :(.");
            Restauranter.Restaurants[1].Retter[1].AddComment("ganske udsøgt Ribey...");
            Restauranter.Restaurants[1].Retter[2].AddComment("450g hotwings var godt nok ikke meget..:");
            Restauranter.Restaurants[1].Retter[3].AddComment("det var godt nok de bedste spareribs jeg længe har smagt!");
            Restauranter.Restaurants[1].Retter[4].AddComment("heeeheee fedt navn til en ret...");
            Restauranter.Restaurants[1].Retter[5].AddComment("uuhhmm dejligt traditionelt måltid");
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
