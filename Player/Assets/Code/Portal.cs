using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log($"Entered: {collider.gameObject.tag}");
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        Debug.LogWarning($"Exited: {collider.gameObject.tag}");
    }
}
