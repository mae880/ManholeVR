using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBoss : MonoBehaviour
{
    public GameObject theSpeedplate;

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Keypad1))
    //    {
    //        //theSpeedplate.GetComponent<Animator>().Play("1_PinsOut");
    //        Debug.Log("1 pressed");
    //    }

    //    if (Input.GetKeyDown(KeyCode.Keypad2))
    //    {
    //        theSpeedplate.GetComponent<Animator>().Play("2_LeftRightHalvesExpand");
    //    }
    //}

    public void Play1Pins()
    {
        theSpeedplate.GetComponent<Animator>().Play("1_PinsOut");
        Debug.Log("1_PinsOut Played");
    }

    public void Play2Expand()
    {
        theSpeedplate.GetComponent<Animator>().Play("2_LeftRightHalvesExpand");
        Debug.Log("2 expand played");
    }
    public void Play3Pins ()
    {
        theSpeedplate.GetComponent<Animator>().Play("3_PinsIn");
        Debug.Log("3 Pins In");
    }
    public void Play4Spin()
    {
        theSpeedplate.GetComponent<Animator>().Play("4_SpinCircleLock");
        Debug.Log("4 Spin Circle Lock");
    }
    public void Play5Handle()
    {
        theSpeedplate.GetComponent<Animator>().Play("3_HandleLockRelease");
        Debug.Log("3 Handle Lock Release");
    }
}
