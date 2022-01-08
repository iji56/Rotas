using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Windows.Input;
using Newtonsoft.Json;
using Rotas.Models;
using Rotas.Views;
using Xamarin.Forms;

namespace Rotas.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {

        #region Constructor
        public MainPageViewModel(INavigation navigation)
        {
            this.navigation = navigation;


            ObservableCollection<HomePageListModel> observableCollection2 = new ObservableCollection<HomePageListModel>();
            observableCollection2.Add(new HomePageListModel()
            {
                IsPending = false,
                IsAll = true,
                IsActive = false
            });
            observableCollection2.Add(new HomePageListModel()
            {
                IsPending = true,
                IsAll = false,
                IsActive = false
            });

            observableCollection2.Add(new HomePageListModel()
            {
                IsPending = false,
                IsAll = false,
                IsActive = true
            });

            this.HomePageList = observableCollection2;

        }

        #endregion


        #region Commands
        public ICommand UserEditTappedCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await navigation.PushAsync(new UserRotas_EditProfile());
                });
            }
        }

        public ICommand OverlayCommand
        {
            get
            {
                return new Command(async () =>
                {
                    await navigation.PushAsync(new OverLayLayout());
                });
            }
        }
        #endregion

        #region Private Properties
        private INavigation navigation;
        private ObservableCollection<HomePageListModel> _HomePageList;
        #endregion

        #region Public Properties
        public System.Timers.Timer CoinPopTimer;
        public ObservableCollection<HomePageListModel> HomePageList
        {
            get { return _HomePageList; }
            set { _HomePageList = value; OnPropertyChanged(nameof(HomePageList)); }
        }
        #endregion

    } }
