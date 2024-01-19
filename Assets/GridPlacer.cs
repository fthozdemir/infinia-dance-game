using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GridPlacer : MonoBehaviour
{
    public Button[] buttons; // Oyun objeleri i�in dizi
    public float spacing = 80f; // Objeler aras� bo�luk

    private bool[] buttonStates; // Butonlar�n bas�l� durumunu takip etmek i�in

    void Start()
    {
        InitializeButtons();
    }

    void InitializeButtons()
    {
        if (buttons.Length != 9)
        {
            Debug.LogError("9 oyun objesi gerekiyor.");
            return;
        }

        buttonStates = new bool[buttons.Length];

        float centerX = Screen.width / 2f; // Ekran�n x ortas�
        float centerY = Screen.height / 2f; // Ekran�n y ortas�

        int index = 0;
        for (int y = -1; y <= 1; y++)
        {
            for (int x = -1; x <= 1; x++)
            {
                Button button = buttons[index];
                GameObject obj = button.gameObject;

                // Butonlar� ekran�n ortas�na yerle�tir
                float posX = centerX + x * spacing;
                float posY = centerY - y * spacing;

                obj.transform.position = new Vector3(posX, posY, 0);

                // Butona bas�ld���nda �al��acak metodu atay�n
                int buttonIndex = index; // Her buton i�in �zel bir index olu�tur
                AddEventTrigger(button.gameObject, buttonIndex);

                index++;
            }
        }
    }

    void AddEventTrigger(GameObject buttonObj, int buttonIndex)
    {
        EventTrigger trigger = buttonObj.GetComponent<EventTrigger>() ?? buttonObj.AddComponent<EventTrigger>();

        var pointerDown = new EventTrigger.Entry { eventID = EventTriggerType.PointerDown };
        pointerDown.callback.AddListener((data) => { OnButtonDown(buttonIndex); });
        trigger.triggers.Add(pointerDown);

        var pointerUp = new EventTrigger.Entry { eventID = EventTriggerType.PointerUp };
        pointerUp.callback.AddListener((data) => { OnButtonUp(buttonIndex); });
        trigger.triggers.Add(pointerUp);
    }

    void OnButtonDown(int buttonIndex)
    {
        buttonStates[buttonIndex] = true;
        Debug.Log("Button " + buttonIndex + " pressed");
    }

    void OnButtonUp(int buttonIndex)
    {
        buttonStates[buttonIndex] = false;
        Debug.Log("Button " + buttonIndex + " released");
    }
}
