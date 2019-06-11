using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{ public Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = this.transform.position;
        cameraPos.x = player.transform.position.x;
        cameraPos.y = player.transform.position.y + 0.5f;
        this.transform.position = cameraPos;
          

    }
}
