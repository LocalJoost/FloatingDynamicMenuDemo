using System.Collections.Generic;
using System.Linq;
using UnityEngine;public class MenuBuilder :MonoBehaviour
{
    public float TopMargin = 0.1f;

    public float MenuItemSize = 0.1f;

    private List<GameObject> _createdMenuItems = new List<GameObject>();
    public MenuBuilder()
    {
        _menuItems = new List<IMenuItemData>();
    }
    public GameObject MenuItem;

    private IList<IMenuItemData> _menuItems;

    public IList<IMenuItemData> MenuItems
    {
        get { return _menuItems; }
        set
        {
            _menuItems = value;
            BuildMenuItems();
        }
    }

    private void BuildMenuItems()
    {
        foreach (var menuItem in _createdMenuItems)
        {
            DestroyImmediate(menuItem);
        }
        if (_menuItems == null || !_menuItems.Any())
        {
            return;
        }
        for (var index = 0; index < MenuItems.Count; index++)
        {
            var newMenuItem = MenuItems[index];
            var newGameObject = Instantiate(MenuItem, gameObject.transform);
            newGameObject.transform.localPosition -= 
                 new Vector3(0,(MenuItemSize * index) - TopMargin, 0);

            var controller = newGameObject.GetComponent<MenuItemController>();
            controller.MenuItemData = newMenuItem;
            _createdMenuItems.Add(newGameObject);
        }
    }
}
