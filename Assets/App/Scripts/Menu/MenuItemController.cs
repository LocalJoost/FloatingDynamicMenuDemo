using HoloToolkit.Unity.InputModule;
using HoloToolkitExtensions.Messaging;
using UnityEngine;

public class MenuItemController : MonoBehaviour, IInputClickHandler
{
    private TextMesh _textMesh;
    private IMenuItemData _menuItemData;

    public IMenuItemData MenuItemData
    {
        get { return _menuItemData; }
        set
        {
            if (_menuItemData == value)
            {
                return;
            }
            _menuItemData = value;
            _textMesh = GetComponentInChildren<TextMesh>();
            if (_menuItemData != null && _textMesh != null)
            {
                _textMesh.text = _menuItemData.Title;
            }
        }
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if (MenuItemData != null)
        {
            Messenger.Instance.Broadcast(new MenuSelectedMessage {MenuItem = MenuItemData});
            PlayConfirmationSound();
        }
    }

    private AudioSource _audioSource;
    private void PlayConfirmationSound()
    {
        if (_audioSource == null)
        {
            _audioSource = GetComponent<AudioSource>();
        }
        if (_audioSource != null)
        {
            _audioSource.Play();
        }
    }
}

