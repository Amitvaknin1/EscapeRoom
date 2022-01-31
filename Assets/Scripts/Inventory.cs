using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory: MonoBehaviour
{
    public GameObject gameImage;
    public GameObject uiImage;
    public bool hasKey1 = false;
    public bool hasKey2 = false;
    public bool hasKey3 = false;
    public bool hasKey4 = false;
    public bool hasCarKeys = false;
    public Button button;
    public GameObject door1;
    public GameObject door2;

    void Start()
    {
        
    }
    void Update()
    {


    }
    private void OnMouseDown()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider.gameObject.tag == "Key1")
        {
            hasKey1 = true;
            Debug.Log("Key1 acquired");
            button.gameObject.SetActive(true);
            door1.SetActive(false);
        }
        if (hit.collider.gameObject.tag == "Key2")
        {
            hasKey2 = true;
            Debug.Log("Key2 acquired");
            door2.SetActive(false);
            button.gameObject.SetActive(true);

        }
        if (hit.collider.gameObject.tag == "Key3")
        {
            hasKey3 = true;
            Debug.Log("Key3 acquired");
            button.gameObject.SetActive(true);

        }
        if (hit.collider.gameObject.tag == "Key4")
        {
            hasKey4 = true;
            Debug.Log("Key4 acquired");
            door1.SetActive(false);
            button.gameObject.SetActive(true);
        }
        if (hit.collider.gameObject.tag == "CarKeys")
        {
           hasCarKeys = true;
            button.gameObject.SetActive(true);
           Debug.Log("Car Keys acquired");
        }

        gameImage.SetActive(false);
        uiImage.SetActive(true);
    }
}
