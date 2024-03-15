using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveBy = 20;
    public Vector2 xClamp;
    public Vector2 yClamp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenSize = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        Vector3 mousePosition = Input.mousePosition;
        transform.position = (mousePosition - screenSize) / moveBy;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xClamp.x, xClamp.y), Mathf.Clamp(transform.position.y, yClamp.x, yClamp.y), 0);
    }
}
