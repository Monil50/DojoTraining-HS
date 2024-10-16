using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class MenuButton : MonoBehaviour
{
    public InputActionProperty _MenuButton;
    public GameObject SelectionUI;
    bool OnState = false;
    bool ButtonClicked = false;
    // Start is called before the first frame update
    void OnEnable()
    {
        _MenuButton.action.Enable();
    }

    private void OnDisable()
    {
        _MenuButton.action.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        float v = _MenuButton.action.ReadValue<float>();
        
        if(v >= 1 && !ButtonClicked)
        {
            ButtonClicked = true;
            OnState = !OnState;
            SelectionUI.SetActive(OnState);
        }
        if (v < 1)
        {
            ButtonClicked = false;
        }

    }
}
