using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deletebullethahahahahaha : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Projectile_Blaster(Clone)"){
            Destroy(col.gameObject);
            //SceneManager.LoadScene("blobgobangbang");
        }
    }
}

//Projectile_Blaster(Clone)