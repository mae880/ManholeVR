using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketCorrector : MonoBehaviour
{
    public Transform AttachMesh11;
    public GameObject parentSocket;
    //=+.0294f
    public Vector3 originalPos;

    public void Start()
    {
        originalPos = AttachMesh11.transform.position;
    }
    public void HoverIn()
    {
        //AttachMesh11.transform.position = (parentSocket.transform.position) - new Vector3(.052f, .0175f, .0059f);
        AttachMesh11.transform.position = originalPos + new Vector3(0.010f, 0.01f, -.08f);
        Debug.Log("Hovered In");
    }

    public void HoverOut()
    {
        //AttachMesh11.transform.position = (parentSocket.transform.position) - new Vector3(.052f, .0175f, .0059f);
        AttachMesh11.transform.position = new Vector3(.0162f, -.04f, 01f);
        Debug.Log("Hovered Out");
    }

    public void Snapped()
    {
        //AttachMesh11.transform.position = (parentSocket.transform.position) - new Vector3(.052f, .0175f, .0059f);
        AttachMesh11.transform.position = originalPos;
        Debug.Log("correction!");
    }
}
