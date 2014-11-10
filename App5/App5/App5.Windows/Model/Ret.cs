using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using App5.Annotations;

namespace App5.Model
{
    class Ret : INotifyPropertyChanged
    {
        private ObservableCollection<string> _comments;

        public ObservableCollection<string> Comments
        {
            get { return _comments; }
            set
            {
                _comments = value; 
                OnPropertyChanged();
            }
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public Ret(string name, string description)
        {
            Comments = new ObservableCollection<string>();
            Name = name;
            Description = description;
            
        }

        public void AddComment(string comment)
        {
            Comments.Add(comment);
            OnPropertyChanged("Comments");
        }

        public override string ToString()
        {
            //return string.Format("Comments: {0}, Comments: {1}, Name: {2}", _comments, Comments, Name);
            return Name;
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
