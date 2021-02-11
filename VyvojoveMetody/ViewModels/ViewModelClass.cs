using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Diagnostics;
using GalaSoft.MvvmLight.Command;
using VyvojoveMetody.Models;
using VyvojoveMetody.Views;
using System.ComponentModel;
using VyvojoveMetody.DependencyInjection.Validators;




namespace VyvojoveMetody.ViewModels
{
    public class ViewModelClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ViewModelClass() 
        {
            
        }
        private ICommand _sendCommand;
        
        public ICommand SendCommand
        {
            get
            {
                if (_sendCommand == null)
                {
                    _sendCommand = new RelayCommand(
                          () => {
                              // Tady je práce, která se má odmakat, když se spustí command
                              Person p;
                              if (new DateTime(1954,1,1) > DateBind)
                              {
                                 p = new Person(new NameValidator(), new NameValidator(), new Pre1954Validator(), new BirthDateValidator());
                              }
                              else 
                              {
                                  p = new Person(new NameValidator(), new NameValidator(), new Post1955Validator(), new BirthDateValidator());
                              }


                              // Uložení do modelu
                              p.FillInfo(NameBind, SurBind, BrnBind, DateBind);
                              Database.DatabaseManagement.persons.Add(p.Bnum,p);
                              Debug.WriteLine(p);
                          });
                }
                return _sendCommand;

            
            }
        }

        private string name;
        public string NameBind
        {
            get { return name; }
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NameBind)));
            }
        }
        private string surname;
        public string SurBind
        {
            get { return surname; }
            set
            {
                surname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SurBind)));
            }
        }

        private string birthnum;
        public string BrnBind
        {
            get { return birthnum; }
            set
            {
                birthnum = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BrnBind)));
            }
        }

        private DateTime birthdate;
       public DateTime DateBind 
        {
            get { return birthdate; }
            set 
            {
                birthdate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DateBind)));
            }
        }
    }
    
    
}
