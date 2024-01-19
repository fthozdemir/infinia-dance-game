using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GridPlacer : MonoBehaviour
{
    public Button[] buttons; // Oyun objeleri için dizi
    public float spacing = 80f; // Objeler arasý boþluk

    private bool[] buttonStates; // Butonlarýn basýlý durumunu takip etmek için

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

        float centerX = Screen.width / 2f; // Ekranýn x ortasý
        float centerY = Screen.height / 2f; // Ekranýn y ortasý

        int index = 0;
        for (int y = -1; y <= 1; y++)
        {
            for (int x = -1; x <= 1; x++)
            {
                Button button = buttons[index];
                GameObject obj = button.gameObject;

                // Butonlarý ekranýn ortasýna yerleþtir
                float posX = centerX + x * spacing;
                float posY = centerY - y * spacing;

                obj.transform.position = new Vector3(posX, posY, 0);

                // Butona basýldýðýnda çalýþacak metodu atayýn
                int buttonIndex = index; // Her buton için özel bir index oluþtur
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
