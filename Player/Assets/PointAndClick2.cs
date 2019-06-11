using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log($"Clicked on {name} from PointAndClick2");
        var body = this.GetComponent<Rigidbody2D>();
        if (body != null)
        {
            body.gravityScale = 1;
        }
    }
}
