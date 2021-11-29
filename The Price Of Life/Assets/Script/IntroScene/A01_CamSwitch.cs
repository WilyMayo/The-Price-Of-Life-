using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A01_CamSwitch : MonoBehaviour
{
    public GameObject camOne;
    public GameObject camTwo;
    public GameObject camThree;
    public GameObject creditLeadDev;
    public GameObject creditStory;
    public int secondsWaited = 3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CamSwitch());

    }

    IEnumerator CamSwitch()
    {
        yield return new WaitForSeconds(secondsWaited);
        creditLeadDev.SetActive(true);
        yield return new WaitForSeconds(4);
        creditStory.SetActive(true);
        camTwo.SetActive(true);
        camOne.SetActive(false);
        yield return new WaitForSeconds(4);
        camThree.SetActive(true);
        camTwo.SetActive(false);
    }

}
