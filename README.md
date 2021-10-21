# Playnite Sidebar Example Extension

A small sample [Playnite](https://playnite.link/) extension implementing a sidebar with the MVVM pattern.

See the docs for:

* [`GenericPlugin.GetSidebarItems()`](https://playnite.link/docs/api/Playnite.SDK.Plugins.Plugin.html#Playnite_SDK_Plugins_Plugin_GetSidebarItems)
* [`SidebarItem`](https://playnite.link/docs/api/Playnite.SDK.Plugins.SidebarItem.html)

In this project, review:

* [`SidebarExample.cs`](SidebarExample.cs) -- This is the main `GenericPlugin`. Review the `GetSidebarItems` and the `Opened` function.
* [`SidebarView.xaml.cs`](SidebarView.xaml.cs) -- Model
* [`SidebarView.xaml`](SidebarView.xaml) -- View
* [`SidebarViewModel.cs`](SidebarViewModel.cs) -- View model