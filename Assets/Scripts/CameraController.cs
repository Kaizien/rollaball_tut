using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    //private so we can set value inside script
    //value = current transform position of camera subtracted by the transform position of the player
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        

    }

    //runs just like update (Every frame), but runs after all other calcs have been done.
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
