using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whendonedothis : MonoBehaviour
{
    bool isTrue = true;
    [Tooltip("Thing for the player to destroy before 'Object To Spawn' gets spawned")]
    public GameObject object1;


    [Tooltip("The thing to spawn when 'Objects' has been destroyed")]
    public GameObject objectToSpawn;


    [Tooltip("The thing to destroy when 'Objects' has been destroyed")]
    public GameObject objectToDestroy; 
    
    [Tooltip("coordinates for 'Object To Spawn' when its spawned")]
    public Vector3 coordsForSpwanedObject;

    void Update(){
        if(isTrue)
        {
            //for(int i = objects.Length; i < objects.Length; i++){
                if(object1 == null)
                {
                    Debug.Log("Olé!");
                    Instantiate(objectToSpawn, coordsForSpwanedObject, Quaternion.identity);
                    Destroy(objectToDestroy);
                    isTrue = false;
                }
            //}
        }
    }

}
