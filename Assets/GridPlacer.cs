using Unity.VisualScripting;
using UnityEngine;

public class GridPlacer : MonoBehaviour
{
    public GameObject[] gameObjects; // Oyun objeleri için dizi
    public float spacing = 2.0f;     // Objeler arasý boþluk

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
                // Objeyi belirli bir pozisyona yerleþtir
                GameObject obj = gameObjects[index];
                float posX = x * spacing;
                float posY = y * -spacing; // Unity'de y ekseninin yukarý doðru pozitif olduðunu unutmayýn
                obj.transform.position = new Vector3(posX, posY, 0);

                index++;
            }
        }
    }
    
}
