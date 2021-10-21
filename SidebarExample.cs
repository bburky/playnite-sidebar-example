using Playnite.SDK;
using Playnite.SDK.Events;
using Playnite.SDK.Models;
using Playnite.SDK.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace SidebarExample
{
    public class SidebarExample : GenericPlugin
    {
        private static readonly ILogger logger = LogManager.GetLogger();

        private SidebarViewModel SidebarViewModel { get; set; }

        private SidebarView SidebarView { get; set; }

        public override Guid Id { get; } = Guid.Parse("c353cd1b-67e2-49c1-b56a-aa8c0c247e82");

        public SidebarExample(IPlayniteAPI api) : base(api)
        {
            // Instanciate the view model, passing it any parameters it needs
            SidebarViewModel = new SidebarViewModel(PlayniteApi);
            // Instanciate the view, passing it an instance of the view model
            SidebarView = new SidebarView(SidebarViewModel);
        }

        public override IEnumerable<SidebarItem> GetSidebarItems()
        {
            yield return new SidebarItem
            {
                Title = "Example",
                Type = SiderbarItemType.View,
                Icon = new TextBlock
                {
                    // Playnite already has IcoFont available, you can use any hex code from https://icofont.com/icons
                    // Or you can load and provide an image here
                    Text = "\ue825",
                    FontFamily = ResourceProvider.GetResource("FontIcoFont") as FontFamily,
                },
                Opened = () => {
                    // If you need to trigger a refresh of any state before showing the sidebar, do so now
                    SidebarViewModel.RefreshSelectedGames();

                    // Return an instance of a Control to show as the sidebar
                    return SidebarView;
                }
            };
        }
    }
}