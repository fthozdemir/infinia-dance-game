using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridController : MonoBehaviour, IGrid
{
    public Image gridImage; // Grid butonunun görselini kontrol etmek için kullanýlýr

    private Color lightUpColor = Color.white; // Açýk renk
    private Color lightDownColor = Color.gray; // Kapalý renk
    private Color lightSuccessColor = Color.green; // Baþarý rengi
    private Color lightFailColor = Color.red; // Baþarýsýzlýk rengi
    private Color lightInitialColor = Color.blue; // Ýlk renk
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
        // Burada baþlangýç ayarlarýný yapabilirsiniz
        LightInitial();
    }

    public void Pressed()
    {
        // Burada butona basýldýðýnda yapýlacak iþlemleri ekleyebilirsiniz
        LightUp();
    }
}
