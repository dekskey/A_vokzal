using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_vokzal.Model;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Controls;
using A_vokzal.Help;
using System.Windows;
using A_vokzal.View;

namespace A_vokzal.ViewModel
{
    public class ScheduleService: Base
    {
        DBmodel db;
        public List<Ostanovki> allOstanovki{ get; set; }
        public List<Reis> allReis { get; set; }

        public RelayCommand BuyTicketCommand { get; set; }

        public ScheduleService()
        {
            BuyTicketCommand = new RelayCommand(BuyTicket, CanExecute);
            db = new DBmodel();
            db.Reis.Load();
            allReis = db.Reis.ToList();

        }

    /*    public bool CreateBilet(Bilet bilet)
        {
            db.Bilet.Add(bilet);
            return Save();
        }*/

        void BuyTicket(object parameter)
        {
            Random rand = new Random();
            Bilet bilet = new Bilet()
            {
                mesto = _SelectedPlace,
                platforma = rand.Next(1, 3),
                time_ot = _SelectedReis.time_ot,
                time_pr = _SelectedReis.time_pr,
                stoimost = rand.Next(200, 500),
                FIO = _SelectedFIO
            };
            Passazhir passazhir = new Passazhir()
            {
                FIO = _SelectedFIO,
                passport = _SelectedPassport
            };
            Marshrut marsh = new Marshrut()
            {
             
            };
            db.Bilet.Add(bilet);
            db.Passazhir.Add(passazhir);
            Save();
            var win = new BiletWindow(bilet);
            win.Show();
            CloseWindow();
        }

        string _SelectedFIO;
        public string SelectedFIO
        {
            get
            {
                return _SelectedFIO;
            }
            set
            {
                if (_SelectedFIO != value)
                {
                    _SelectedFIO = value;
                    RaisePropertyChanged("SelectedFIO");
                }
            }
        }

        string _SelectedPassport;
        public string SelectedPassport
        {
            get
            {
                return _SelectedPassport;
            }
            set
            {
                if (_SelectedPassport != value)
                {
                    _SelectedPassport = value;
                    RaisePropertyChanged("SelectedPassport");
                }
            }
        }

        Reis _SelectedReis;
        public Reis SelectedReis
        {
            get
            {
                return _SelectedReis;
            }
            set
            {
                if (_SelectedReis != value)
                {
                    _SelectedReis = value;
                    RaisePropertyChanged("SelectedReis");
                }
            }
        }

        int _SelectedPlace;
        public int SelectedPlace
        {
            get
            {
                return _SelectedPlace;
            }
            set
            {
                if (_SelectedPlace != value)
                {
                    _SelectedPlace = value;
                    RaisePropertyChanged("SelectedPlace");
                }
            }
        }

        public bool Save()
        {
            if (db.SaveChanges() > 0) return true;
            return false;
        }

        bool CanExecute(object parameter)
        {
            return ((SelectedReis != null) && (SelectedFIO != null) && (SelectedPassport != null));
        }

    }
}

  

