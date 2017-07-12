using System.Collections.Generic;
using HoloToolkitExtensions.Animation;
using HoloToolkitExtensions.Messaging;

public class VistaMenuController : BaseTextScreenController
{
    public override void Start()
    {
        base.Start();
        Messenger.Instance.AddListener<ShowHelpMessage>(m => Show());
        var builder = GetComponent<MenuBuilder>();

        IList<IMenuItemData> list = new List<IMenuItemData>();
        list.Add(new MenuItemData
        {
            Title = "Mount Everest, Nepal",
            MenuId = 1,
            SelectMessageObject = new WorldCoordinate(27.91282f, 86.94221f)
        });
        list.Add(new MenuItemData
        {
            Title = "Kilomanjaro, Tanzania",
            MenuId = 1,
            SelectMessageObject = new WorldCoordinate(-3.21508f, 37.37316f)
        });

        list.Add(new MenuItemData
        {
            Title = "Mount Rainier, Washington, USA",
            MenuId = 1,
            SelectMessageObject = new WorldCoordinate(46.76566f, -121.7554f)
        });
        list.Add(new MenuItemData
        {
            Title = "Niagra falls (from Canada)",
            MenuId = 1,
            SelectMessageObject = new WorldCoordinate(43.07306f, -79.07561f)
        });
        list.Add(new MenuItemData
        {
            Title = "Mount Robson, British Columbia, Canada",
            MenuId = 1,
            SelectMessageObject = new WorldCoordinate(53.061809f, -119.168358f)
        });

        list.Add(new MenuItemData
        {
            Title = "Athabasca Glacier, Alberta, Canada",
            MenuId = 1,
            SelectMessageObject = new WorldCoordinate(52.18406f, -117.257f)
        });

        list.Add(new MenuItemData
        {
            Title = "Etna, Sicily, Italy",
            MenuId = 1,
            SelectMessageObject = new WorldCoordinate(37.67865f, 14.9964f)
        });

        builder.MenuItems = list;

    }
}
