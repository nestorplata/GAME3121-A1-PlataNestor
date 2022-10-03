using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Delay(startDelay));

    }

    // Spawn random ball at random x position at top of play area
 
 IEnumerator Delay(float secs)
    {
        yield return new WaitForSeconds(secs);
        // Generate random ball index and random spawn position
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(3, 6));
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
            int rnadom = Random.Range(0, 3);
            // instantiate ball at random spawn location
            Instantiate(ballPrefabs[rnadom], spawnPos, ballPrefabs[rnadom].transform.rotation);
        }

    }

}
