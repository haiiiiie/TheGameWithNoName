using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class folowPlayer : MonoBehaviour
{
    public GameObject player;
    public float smoothing;
    // Update is called once per frame
    void LateUpdate()
    {
        if (transform.position != player.transform.position)
        {
            Vector3 playerPosition = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, playerPosition, smoothing);
        }
    }
}
