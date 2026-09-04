using UnityEngine;
using System.Collections;
using static UnityEngine.Rendering.DebugUI;

public class SpawnManager : MonoBehaviour
{
    private Vector2[] positions;
    int positionNum = 3;
    int n;
    float timer = 3;
    private Rigidbody2D body;
    private SpriteRenderer sr;

    public GameObject myPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        positions = new Vector2[positionNum];
        positions[0] = new Vector2(0, 4.6f);
        positions[1] = new Vector2(-3.35f, 4.6f);
        positions[2] = new Vector2(3.35f, 4.6f);

        StartCoroutine(ShowObject());
    }


    IEnumerator ShowObject()
    {
        while (true)
        {
            var n = Random.Range(0, positions.Length);

            body.transform.position = positions[n];
            Instantiate(myPrefab, positions[n], Quaternion.identity);
            sr.enabled = true;

            yield return new WaitForSeconds(2f);

            sr.enabled = false;

            yield return new WaitForSeconds(1f);
        }
    }
}