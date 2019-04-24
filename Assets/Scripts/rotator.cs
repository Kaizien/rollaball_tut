using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        //how do we do it? lets rotate the transform (not set the transform)
        transform.Rotate(new Vector3 (15, 40, 45) * Time.deltaTime);
    }
}
