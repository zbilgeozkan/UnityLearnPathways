using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float fireWait = 1; // Time the player has to wait to fire again
    private float fireNext = 0; // Time after player can fire again

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, if enough time has passed since the last shoot, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > fireNext)
        {
            fireNext = Time.time + fireWait;    // fireNext = Current Time + fireWait
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
