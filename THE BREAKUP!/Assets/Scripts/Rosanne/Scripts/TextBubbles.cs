using UnityEngine;
using System.Collections;
using TMPro;

public class TextBubbles : MonoBehaviour
{
    public int isGF;
    [Header("Text Bubbles")]
    public string[] textBubblesGF;
    public string[] textBubblesBF;
    public GameObject textBF;
    public GameObject textGF;
    public GameObject bubbleGF;
    public GameObject bubbleBF;


    [Header("Time Between Bubbles")]
    public float textDelay;
    public float textDelayMin;
    public float textDelayMax;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isGF = Random.Range(0, 20);
        bubbleGF.SetActive(false);
        bubbleBF.SetActive(false);
        StartCoroutine(BubbleDelay());
    }


    IEnumerator BubbleDelay()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(textDelayMin, textDelayMax));
            if (isGF < 10)
            {
                bubbleGF.SetActive(true);
                textGF.GetComponent<TMP_Text>().text = textBubblesGF[Random.Range(0, textBubblesGF.Length)];

            }
            else
            {
                bubbleBF.SetActive(true);
                textBF.GetComponent<TMP_Text>().text = textBubblesBF[Random.Range(0, textBubblesBF.Length)];
                Debug.Log("BubbleBF");

            }
            yield return new WaitForSeconds(textDelay);
            bubbleBF.SetActive(false);
            bubbleGF.SetActive(false);
            isGF = Random.Range(0, 20);

        }
        
    }
}