using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPropeller : MonoBehaviour
{
    public GameObject Propeller;

    void LateUpdate()
    {
        Propeller.transform.Rotate(Vector3.forward * Time.deltaTime * 100);
        //this.transform.Rotate(Vector3.right * Time.deltaTime);
    }
}
