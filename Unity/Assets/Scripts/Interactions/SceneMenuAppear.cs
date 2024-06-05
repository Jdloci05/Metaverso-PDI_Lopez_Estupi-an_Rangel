using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SceneMenuAppear : MonoBehaviour
{
    public static SceneMenuAppear Instance { get; private set; }
    [SerializeField] private UnityEvent activateMenu;
    [SerializeField] private UnityEvent diactivateMenu;

    private void Start()
    {
        Instance = this;
    }

    public void ActivateMenu()
    {
        activateMenu.Invoke();
    }

    public void DiactivateMenu()
    {
        diactivateMenu.Invoke();
    }
}
