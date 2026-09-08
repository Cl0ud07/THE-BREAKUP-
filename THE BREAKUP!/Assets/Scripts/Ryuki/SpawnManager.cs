using UnityEngine;
using System.Collections;
using static UnityEngine.Rendering.DebugUI;

public class SpawnManager : MonoBehaviour
{
    private Vector2[] positions;
    int positionNum = 9;
    int n;
    float timer = 3;
    private Rigidbody2D body;
    private SpriteRenderer sr;

    public GameObject[] myPrefabs;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        positions = new Vector2[positionNum];
        positions[0] = new Vector2(0, 7.46f);
        positions[1] = new Vector2(-3.35f, 7.46f);
        positions[2] = new Vector2(3.35f, 7.46f);
        positions[3] = new Vector2(0, 4.9f);
        positions[4] = new Vector2(-3.35f, 4.9f);
        positions[5] = new Vector2(3.35f, 4.9f);
        positions[6] = new Vector2(0, 2.32f);
        positions[7] = new Vector2(-3.35f, 2.32f);
        positions[8] = new Vector2(3.35f, 2.32f);

        StartCoroutine(ShowObject());
    }


    IEnumerator ShowObject()
    {
        Animator animator = GetComponent<Animator>();

        while (true)
        {
            var n = Random.Range(0, positions.Length);

            int randomObject = Random.Range(0, myPrefabs.Length);

            body.transform.position = positions[n];
            Instantiate(myPrefabs[randomObject], positions[n], Quaternion.identity);
            sr.enabled = true;

            animator.Play("Throw", 0, 0f);
            yield return new WaitForSeconds(2f);

            sr.enabled = false;

            yield return new WaitForSeconds(1f);
        }
    }
}