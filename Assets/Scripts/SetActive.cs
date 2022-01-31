using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject PhotoCanvas;
    public GameObject MiniPhoto;
    private Inventory yolo;

    private void Update()
    {
        if (Input.GetMouseButton(0) == true)
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider.gameObject.tag == "Photo")
            {
                PhotoCanvas.gameObject.SetActive(true);
                MiniPhoto.SetActive(false);

            }
        }
    }

    public void ClosePhoto()
    {
        PhotoCanvas.SetActive(false);
    }
}
