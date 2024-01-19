using Unity.VisualScripting;
using UnityEngine;

public class GridPlacer : MonoBehaviour
{
    public GameObject[] gameObjects; // Oyun objeleri i�in dizi
    public float spacing = 2.0f;     // Objeler aras� bo�luk

    void Start()
    {
        
        if (gameObjects.Length != 9)
        {
            Debug.LogError("9 oyun objesi gerekiyor.");
            return;
        }

        int index = 0;
        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < 3; x++)
            {
                // Objeyi belirli bir pozisyona yerle�tir
                GameObject obj = gameObjects[index];
                float posX = x * spacing;
                float posY = y * -spacing; // Unity'de y ekseninin yukar� do�ru pozitif oldu�unu unutmay�n
                obj.transform.position = new Vector3(posX, posY, 0);

                index++;
            }
        }
    }
    
}
