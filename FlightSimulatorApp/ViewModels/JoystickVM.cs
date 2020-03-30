using FlightSimulatorApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulatorApp.ViewModels
{
    class JoystickVM : INotifyPropertyChanged
    {
        private Model myModel;
        private string name = "wKKorld!";
        public event PropertyChangedEventHandler PropertyChanged;
        
        public JoystickVM(Model myModel)
        {
            this.myModel = myModel;
            myModel.PropertyChanged += delegate (Object sender, PropertyChangedEventArgs e) {
                NotifyPropertyChanged("VM_" + e.PropertyName);
            };
        }

        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    this.NotifyPropertyChanged("Name");
                }
            }
        }

        public double VM_Longitude
        {
            get { return myModel.Longitude; }
        }
        //public void moveRobot(double rudder, int elevator)
        //{
        //    myModel.move(rudder, elevator);
        //}
        //private double rudder; //x
        //private double elevator; //y

    }
}
