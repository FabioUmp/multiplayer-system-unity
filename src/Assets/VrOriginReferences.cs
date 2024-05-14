using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrOriginReferences : MonoBehaviour
{
    public static VrOriginReferences Singleton;

    public Transform root;
    public Transform head;
    public Transform lefthand;
    public Transform righthand;
    
    public void Awake()
    {
        Singleton = this;
    }
}
