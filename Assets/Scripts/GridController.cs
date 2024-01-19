using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridController : MonoBehaviour, IGrid
{
    public Image gridImage; // Grid butonunun g�rselini kontrol etmek i�in kullan�l�r

    private Color lightUpColor = Color.white; // A��k renk
    private Color lightDownColor = Color.gray; // Kapal� renk
    private Color lightSuccessColor = Color.green; // Ba�ar� rengi
    private Color lightFailColor = Color.red; // Ba�ar�s�zl�k rengi
    private Color lightInitialColor = Color.blue; // �lk renk
    private void Start()
    {
        gridImage = GetComponent<Image>();
    }
    public void LightUp()
    {
        gridImage.color = lightUpColor;
    }

    public void LightDown()
    {
        gridImage.color = lightDownColor;
    }

    public void LightSuccess()
    {
        gridImage.color = lightSuccessColor;
    }

    public void LightFail()
    {
        gridImage.color = lightFailColor;
    }

    public void LightInitial()
    {
        gridImage.color = lightInitialColor;
    }

    public void Init()
    {
        // Burada ba�lang�� ayarlar�n� yapabilirsiniz
        LightInitial();
    }

    public void Pressed()
    {
        // Burada butona bas�ld���nda yap�lacak i�lemleri ekleyebilirsiniz
        LightUp();
    }
}
