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
    class Product : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Guid id;
        private string name;
        private string picture;
        private List<preparingStep> preparingSteps;
        private Enums.preparingStep state;
        private string stateName;
        private SolidColorBrush stateColor;

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
        public List<preparingStep> PreparingSteps
        {
            get => preparingSteps;
            set
            {
                if (value != preparingSteps)
                {
                    preparingSteps = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public Enums.preparingStep State
        {
            get => state;
            set
            {
                if (value != state)
                {
                    state = value;
                    NotifyPropertyChanged();
                };
            }
        }
        public string StateName
        {
            get => stateName;
            set
            {
                if (value != stateName)
                {
                    stateName = value;
                    NotifyPropertyChanged();
                };
            }
        }
        public SolidColorBrush StateColor
        {
            get => stateColor;
            set
            {
                if (value != stateColor)
                {
                    stateColor = value;
                    NotifyPropertyChanged();
                };
            }
        }
    }
}