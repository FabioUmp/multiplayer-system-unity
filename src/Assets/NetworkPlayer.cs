using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class NetworkPlayer : NetworkBehaviour
{

    public Transform root;
    public Transform head;
    public Transform lefthand;
    public Transform righthand;

    public Renderer[] meshToDisable;

    public override void OnNetworkSpawn(){
        base.OnNetworkSpawn();
        if(IsOwner){
            foreach(var item in meshToDisable){
                item.enabled = false;
            }
        }
    }
  

    void Update()
    {
        if(IsOwner)
        {
        root.position = VrOriginReferences.Singleton.root.position;
        root.rotation = VrOriginReferences.Singleton.root.rotation;

        head.position = VrOriginReferences.Singleton.head.position;
        head.rotation = VrOriginReferences.Singleton.head.rotation;

        lefthand.position = VrOriginReferences.Singleton.lefthand.position;
        lefthand.rotation = VrOriginReferences.Singleton.lefthand.rotation;

        righthand.position = VrOriginReferences.Singleton.righthand.position;
        righthand.rotation = VrOriginReferences.Singleton.righthand.rotation;
        }
    }
}
