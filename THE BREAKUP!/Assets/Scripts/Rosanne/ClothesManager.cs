using UnityEngine;
using UnityEngine.UI;
public class ClothesManager : MonoBehaviour
{
    public int ClothesCount; 
    public Text clothesText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clothesText.text = "Clothes Count: " + ClothesCount.ToString();
    }
}
