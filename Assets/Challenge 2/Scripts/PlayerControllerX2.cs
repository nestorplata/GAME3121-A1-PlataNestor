using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX2 : MonoBehaviour
{
    public GameObject dogPrefab;
    public float firingrate = 1.0f;
    public bool fired = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && fired ==false)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            fired = true;
            StartCoroutine(FiringRate(firingrate));
        }
    }

    public IEnumerator FiringRate(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        fired = false;
    }
}
