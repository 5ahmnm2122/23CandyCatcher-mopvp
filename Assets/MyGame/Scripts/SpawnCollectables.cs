using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnCollectables : MonoBehaviour
{
    public GameObject spawnCollectable;
    public float spawnTime = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(foodLoop());
    }
    private void spawnFood1()
    {
        GameObject a = Instantiate(spawnCollectable) as GameObject;
        a.transform.position = new Vector2(Random.Range(-7, 7), 7);
    }

    IEnumerator foodLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnFood1();
        }
    }
}