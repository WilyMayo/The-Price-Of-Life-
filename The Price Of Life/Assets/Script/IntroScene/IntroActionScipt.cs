using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroActionScipt : MonoBehaviour
{
    public AudioSource leftFoot;
    public AudioSource rightFoot;
    public bool steppingLeft = true; // check left foot first
    public GameObject mainChacater;
    public float stepsOnZ = 0.014f;
    public int stepsTaken;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WalkSequence());
    }

    // Update is called once per frame
    void Update()
    {
        mainChacater.transform.Translate(0, 0, stepsOnZ * Time.timeScale);

    }
    IEnumerator WalkSequence()
    {
        yield return new WaitForSeconds(0.4f);
        while (stepsTaken < 12)
        {
            yield return new WaitForSeconds(0.5f);
            if (steppingLeft == true)
            {
                leftFoot.Play();
                steppingLeft = false;
            }
            else
            {
                rightFoot.Play();
                steppingLeft = true;
            }
            stepsTaken += 1;
        }
        mainChacater.SetActive(false);
    }
}
