 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashControl : MonoBehaviour
{
    public bool isFlashing = false;
    public float timeDelay;

    void start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (isFlashing == false)
        {
            StartCoroutine(FlashingLight())    ;
        }
    }

    IEnumerator FlashingLight()
    {
        isFlashing = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(0.01f, 0.9f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(0.01f, 0.9f);
        yield return new WaitForSeconds(timeDelay);
        isFlashing = true;
    }
}