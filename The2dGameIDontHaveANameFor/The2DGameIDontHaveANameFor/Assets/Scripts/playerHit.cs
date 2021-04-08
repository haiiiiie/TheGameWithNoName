using System;
using System.Collections;
using UnityEngine;

public class playerHit : MonoBehaviour
{

    public GameObject hit;
    public float damage;
    public float waitTillDisappear; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(HitFunction());
        }
    }

    IEnumerator HitFunction()
    {
        hit.SetActive(true);
        yield return new WaitForSeconds(waitTillDisappear);
        hit.SetActive(false);
    }
}