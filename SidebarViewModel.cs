using Playnite.SDK;
using Playnite.SDK.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SidebarExample
{
    public class SidebarViewModel
    {
        public RelayCommand<object> NavigateBackCommand { get; }
        public ObservableCollection<Game> SelectedGames { get; }

        private IPlayniteAPI playniteApi;

        public SidebarViewModel(IPlayniteAPI playniteApi)
        {
            this.playniteApi = playniteApi;
            SelectedGames = new ObservableCollection<Game>();

            NavigateBackCommand = new RelayCommand<object>((a) =>
            {
                playniteApi.MainView.SwitchToLibraryView();
            });

            // You can call setup functions now, but the full Playnite UI and DB may not be accessible yet
            // Instead you can call setup functions during Opened or move initialization of this class to OnApplicationStarted
            RefreshSelectedGames();
        }

        public void RefreshSelectedGames()
        {
            SelectedGames.Clear();
            SelectedGames.AddMissing(playniteApi.MainView.SelectedGames);
        }
    }
}
