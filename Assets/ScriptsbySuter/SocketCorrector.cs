using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketCorrector : MonoBehaviour
{
    public Transform AttachMesh11;
    public GameObject parentSocket;
    //=+.0294f
    public Vector3 originalPos;
    public Vector3 VectorIn = new Vector3(0.010f, 0.01f, -.08f);
    public Vector3 VectorOut = new Vector3(.0162f, -.04f, 01f);
    public bool isSnapped = false;

    public void Start()
    {
        originalPos = AttachMesh11.transform.position;
        isSnapped = false;
    }
    public void HoverIn()
    {
        if (!isSnapped)
        {
            //AttachMesh11.transform.position = (parentSocket.transform.position) - new Vector3(.052f, .0175f, .0059f);
            AttachMesh11.transform.position = originalPos + VectorIn;
            Debug.Log("Hovered In");
        }

    }

    public void HoverOut()
    {
        //AttachMesh11.transform.position = (parentSocket.transform.position) - new Vector3(.052f, .0175f, .0059f);
        AttachMesh11.transform.position = originalPos - VectorOut;
        Debug.Log("Hovered Out");
    }

    public void Snapped()
    {
        //AttachMesh11.transform.position = (parentSocket.transform.position) - new Vector3(.052f, .0175f, .0059f);
        AttachMesh11.transform.position = originalPos;
        Debug.Log("correction!");
        isSnapped = true;
        if(GameObject.Find("Socket1").GetComponent<SocketCorrector>().isSnapped == true
        &&
        GameObject.Find("Socket2").GetComponent<SocketCorrector>().isSnapped == true
        &&
        GameObject.Find("Socket3").GetComponent<SocketCorrector>().isSnapped == true
        &&
        GameObject.Find("Socket4").GetComponent<SocketCorrector>().isSnapped == true)
        {
            GameObject.Find("cuttingplate2").GetComponent<ConfettiFX>().Click();
            Debug.Log("ALL SNAPPED");
        }
    }
}
