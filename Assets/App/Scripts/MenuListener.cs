using HoloToolkitExtensions.Messaging;
using UnityEngine;

public class MenuListener : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        Messenger.Instance.AddListener<MenuSelectedMessage>(ProcessMenuMessage);
    }

    private void ProcessMenuMessage(MenuSelectedMessage msg)
    {
        if (msg.MenuItem.MenuId == 1 )
        {
            Debug.Log("Taking you to " + msg.MenuItem.Title);
            Debug.Log(msg.MenuItem.SelectMessageObject.ToString());
        }
    }
}
