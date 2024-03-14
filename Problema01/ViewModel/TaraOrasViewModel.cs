using Microsoft.EntityFrameworkCore;
using Problema01.Models;
using Problema01.windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problema01.ViewModel
{
    public class TaraOrasViewModel
    {
        OraseContext db = new OraseContext();
        RelayCommand? addCommandTari;
        RelayCommand? editCommandTari;
        RelayCommand? deleteCommandTari;
        RelayCommand? showTari;

        RelayCommand? addCommandOrase;
        RelayCommand? editCommandOrase;
        RelayCommand? deleteCommandOrase;
        RelayCommand? showOrase;

        RelayCommand? showListaOraseLocuitori;
        RelayCommand? showListaTariContinent;
        RelayCommand? showListaTaraCuOrase;

        public ObservableCollection<Tara>? Tari { get; set; }
        public ObservableCollection<Oras>? Orase { get; set; }

        public TaraOrasViewModel() 
        {
            db.Database.EnsureCreated();

            db.Tari.Load();
            Tari = db.Tari.Local.ToObservableCollection();

            db.Orase.Load();
            Orase = db.Orase.Local.ToObservableCollection();
        }

        public RelayCommand AddCommandTari
        {
            get
            {
                return addCommandTari ?? (addCommandTari = new RelayCommand((o) =>
                {
                    IntroduTari introduTari = new IntroduTari(new Tara());
                    if (introduTari.ShowDialog() == true)
                    {
                        Tara tara = introduTari.Tara;
                        db.AdaugaTara(tara);
                    }
                }));
            }
        }
        public RelayCommand ShowTari
        {
            get
            {
                return showTari ?? (showTari = new RelayCommand((obj) =>
                {
                    ListaTarilor listaTarilor = new ListaTarilor();
                    listaTarilor.ShowDialog();
                }));
            }
        }
        public RelayCommand EditCommandTari
        {
            get
            {
                return editCommandTari ?? (editCommandTari = new RelayCommand((selectedItem) =>
                {

                    Tara? tara = selectedItem as Tara;
                    if (tara == null)
                    {
                        return;
                    }
                    Tara vm = new Tara
                    {
                        CodTara = tara.CodTara,
                        Denumire = tara.Denumire,
                        Continent = tara.Continent,
                    };
                    IntroduTari introduTari = new IntroduTari(vm);
                    Button editButton = introduTari.btnAdd;
                    editButton.Content = "Modifică țara";

                    if (introduTari.ShowDialog() == true)
                    {
                        tara.Denumire = introduTari.Tara.Denumire;
                        tara.Continent = introduTari.Tara.Continent;
                        db.ActualizeazaTara(tara);
                    }
                }));
            }
        }
        public RelayCommand DeleteCommandTari
        {
            get
            {
                return deleteCommandTari ?? (deleteCommandTari = new RelayCommand((selectedItem) =>
                {
                    Tara? tara = selectedItem as Tara;
                    if (tara == null) { return; }
                    db.StergeTara(tara);
                }));
            }
        }
        public RelayCommand AddCommandOrase
        {
            get
            {
                return addCommandOrase ?? (addCommandOrase = new RelayCommand((c) =>
                {
                    IntroduOrase introduOrase = new IntroduOrase(new Oras());
                    if (introduOrase.ShowDialog() == true)
                    {
                        Oras oras = introduOrase.Oras;
                        Tara? tara = introduOrase.cbTara.SelectedItem as Tara;
                        oras.CodTara = tara.CodTara;
                        db.AdaugaOras(oras);
                    }
                }));
            }
        }
        public RelayCommand ShowOrase
        {
            get
            {
                return showOrase ?? (showOrase = new RelayCommand((oras) =>
                {
                    ListaOraselor listaOraselor = new ListaOraselor();
                    listaOraselor.ShowDialog();
                }));
            }
        }
        public RelayCommand EditCommandOrase
        {
            get
            {
                return editCommandOrase ?? (editCommandOrase = new RelayCommand((selectedItem) =>
                {
                    Oras? oras = selectedItem as Oras;
                    if (oras == null)
                    {
                        return;
                    }
                    Oras or = new Oras
                    {
                        CodOras = oras.CodOras,
                        Denumire = oras.Denumire,
                        NrLocuitori = oras.NrLocuitori,
                        CodTara = oras.CodTara
                    };
                    IntroduOrase introduOrase = new IntroduOrase(or);
                    Button editButton = introduOrase.btnAdd;
                    editButton.Content = "Modifică orașul";

                    if (introduOrase.ShowDialog() == true)
                    {
                        oras.Denumire = introduOrase.Oras.Denumire;
                        oras.NrLocuitori = introduOrase.Oras.NrLocuitori;
                        oras.CodTara = introduOrase.Oras.CodTara;
                        db.ActualizeazaOras(oras);
                    }
                }));
            }
        }
        public RelayCommand DeleteCommandOrase
        {
            get
            {
                return deleteCommandOrase ?? (deleteCommandOrase = new RelayCommand((selectedItemDel) =>
                {
                    Oras? oras = selectedItemDel as Oras;
                    if (oras == null)
                    {
                        return;
                    }
                    db.StergeOras(oras);
                }));
            }
        }
        public RelayCommand ShowListaOraseLocuitori
        {
            get
            {
                return showListaOraseLocuitori ?? (showListaOraseLocuitori = new RelayCommand((show) =>
                {
                    ListaOraseLocuitori listaOraseLocuitori = new ListaOraseLocuitori();
                    listaOraseLocuitori.ShowDialog();
                }));
            }
        }
        public RelayCommand ShowListaTariContinent
        {
            get
            {
                return showListaTariContinent ?? (showListaTariContinent = new RelayCommand((show) =>
                {
                    ListaTariContinent listaTariContinent = new ListaTariContinent();
                    listaTariContinent.ShowDialog();
                }));
            }
        }
        public RelayCommand ShowListaTaraCuOrase
        {
            get
            {
                return showListaTaraCuOrase ?? (showListaTaraCuOrase = new RelayCommand((show) =>
                {
                    ListaTaraCuOrase listaTaraCuOrase = new ListaTaraCuOrase();
                    listaTaraCuOrase.ShowDialog();
                }));
            }
        }
    }
}
