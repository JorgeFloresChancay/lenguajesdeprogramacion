using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] itemPrefabs;

    public float minTime = 1f;
    public float maxTime = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnCoRoutine(0));
    }

    IEnumerator SpawnCoRoutine(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Instantiate(itemPrefabs[Random.Range(0, itemPrefabs.Length)],transform.position, Quaternion.identity);
        StartCoroutine(SpawnCoRoutine(Random.Range(minTime,maxTime)));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
