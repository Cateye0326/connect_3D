using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovable: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnMouseDrag()
    {
        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);

        Vector3 pointScreen = new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,
            objectPos.z
            );

        Vector3 pointWorld = Camera.main.ScreenToWorldPoint(pointScreen);
        pointWorld.z = transform.position.z;

        transform.position = pointWorld;
    }

    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "blue")
        {
            Debug.Log("blue");
            GameObject.Find("Plane(1)").GetComponent<TouchController>().Break();
        }
    }
}
