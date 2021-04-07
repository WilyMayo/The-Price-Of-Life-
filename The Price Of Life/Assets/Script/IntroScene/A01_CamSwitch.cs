using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A01_CamSwitch : MonoBehaviour
{
    public GameObject camOne;
    public GameObject camTwo;
    public GameObject creditLeadDev;
    public int secondsWaited = 3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(camSwitch());

    }

    IEnumerator camSwitch()
    {
        yield return new WaitForSeconds(secondsWaited);
        creditLeadDev.SetActive(true);
        yield return new WaitForSeconds(4);
        camTwo.SetActive(true);
        camOne.SetActive(false);
    }

}
