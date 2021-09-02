using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TemperatureByCommand
{
    public class TemperatureConverter : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private RelayCommand convertToF = null;
        private RelayCommand convertToC = null;
        public ICommand ConvertToF
        {
            get { return convertToF; }
        }
        public ICommand ConvertToC
        {
            get { return convertToC; }
        }
        public TemperatureConverter()
        {
            convertToC = new RelayCommand(CalculateCelcius);
            convertToF = new RelayCommand(CalculateFarenheit);
        }
        #region ClassFields
        private double _inputF;
        public double InputF
        {
            get { return _inputF; }
            set
            {
                _inputF = value;
                PropertyChanged(this, new PropertyChangedEventArgs("InputF"));
            }
        }
        private double _resultC;
        public double ResultC
        {
            get { return _resultC; }
            set { _resultC = value; PropertyChanged(this, new PropertyChangedEventArgs("ResultC")); }
        }

        private double _inputC;
        public double InputC
        {
            get { return _inputC; }
            set
            {
                _inputC = value;
                PropertyChanged(this, new PropertyChangedEventArgs("InputC"));
            }
        }
        public double _resultF;
        public double ResultF
        {
            get { return _resultF; }
            set { _resultF = value; PropertyChanged(this, new PropertyChangedEventArgs("ResultF")); }
        } 
        #endregion
        public void CalculateFarenheit(object obj)
        {
            ResultF = (InputC *1.8) + 32;
        }
        public void CalculateCelcius(object obj)
        {
            ResultC = (InputF - 32) * 5.6;
        }
        //public bool canExecute(object obj) 
        //{ return true; }

    }
}
