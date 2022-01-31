using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Downable : MonoBehaviour
{
    public GameObject whoop;
    private void OnMouseDown()
    {
        if (whoop.gameObject.tag == "Downable")
        {
            whoop.gameObject.SetActive(false);

        }
    }
}
