using Journal.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand EntriesViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }

        public EntriesViewModel EntriesVM { get; set; } 

        private object currentView;

        public object CurrentView
        {
            get { return this.currentView; }
            set {
                this.currentView = value; 
                OnPropertyChanged(); 
            }
            
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            EntriesVM = new EntriesViewModel();
            CurrentView = HomeVM;


            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            EntriesViewCommand = new RelayCommand(o =>
            {
                CurrentView = EntriesVM;
            });
        }
    }
}
