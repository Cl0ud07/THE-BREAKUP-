using Unity.VisualScripting;
using UnityEngine;

public class FallingSway : MonoBehaviour
{
    public float swayAmount = 1f;
    public float swaySpeed = 2f;

    private float startX;

    void Start()
    {
        GameObject gf = GameObject.FindGameObjectWithTag("GF");

        if (gf != null)
        {
            startX = gf.transform.position.x;
        }
        else
        {
            startX = transform.position.x;
        }
    }

    void Update()
    {
        float newX = startX + Mathf.Sin(Time.time * swaySpeed) * swayAmount;

        transform.position = new Vector3(
            newX,
            transform.position.y,
            transform.position.z
        );
    }
}
