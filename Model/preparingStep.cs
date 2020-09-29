using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace VMR.Model
{
    class preparingStep : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Guid id;
        private string name;
        private string picture;

        public Guid Id
        {
            get => id;
            set
            {
                if (value != id)
                {
                    id = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (value != name)
                {
                    name = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string Picture
        {
            get => picture;
            set
            {
                if (value != picture)
                {
                    picture = value;
                    NotifyPropertyChanged();
                }
            }
        }


    }
}