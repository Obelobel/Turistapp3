using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App5.Model;

namespace App5.Viewmodel
{
    class OpretCommentHandler
    {
        private string _Name { get; set; }
        private string _Description { get; set; }

        private ObservableCollection<Ret> _retter;

        public OpretCommentHandler(ObservableCollection<Ret> retter)
        {
            _retter = retter;
        }

        public void OpretRetter()
        {
            Ret p = new Ret(_Name, _Description);
            _retter.Add(p);
        }

        
    }
}
