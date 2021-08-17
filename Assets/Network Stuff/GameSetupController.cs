using Photon.Pun;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSetupController : MonoBehaviour
{
    //public Camera[] cameras;
    public Camera[] cameras;
    //public Camera SceneCam;
    // Start is called before the first frame update
    void Start()
    {
        CreatePlayer();
        //Destroy(GameObject.Find("theCanvas"));
        //Destroy(GameObject.Find("LobbyController"));
        GameObject.Find("theCanvas").SetActive(false);
        //GameObject.Find("LobbyController").SetActive(false);
    }

    private void CreatePlayer()
    {
        Debug.Log("Creating Player");
        GameObject myPlayerGo = (GameObject)PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Player"), Vector3.zero, Quaternion.identity);
        cameras = Resources.FindObjectsOfTypeAll<Camera>();
        //GameObject.Find("UsernameCanvas").SetActive(true);
        //myPlayerGo.GetComponentInChildren<Canvas>().enabled = true;
        //myPlayerGo.GetComponentInChildren<Text>().enabled = true;
        myPlayerGo.GetComponent<Damageable>().enabled = true;
        //SceneCam = cameras[2];

        //camera = GameObject.Find("MainCamera");
        /*for(int i = 0; i < cameras.Length; i++){
            cameras[i].enabled = true;
        }*/

        //SceneCam.enabled = false;
        cameras[1].GetComponent<Camera>().enabled = true;
        //camerathing.SetActive(true);

        //myPlayerGo.GetComponent<PlayerCharacterController>().enabled = true;
        //myPlayerGo.GetComponent<PlayerInputHandler>().enabled = true;
        myPlayerGo.GetComponent<Health>().enabled = true;
        myPlayerGo.GetComponent<PlayerWeaponsManager>().enabled = true;
        //myPlayerGo.GetComponent<Jetpack>().enabled = true;
        myPlayerGo.GetComponent<Actor>().enabled = true;
        //myPlayerGo.GetComponent<PhotonTransformView>().enabled = true;
        myPlayerGo.GetComponent<CharacterController>().enabled = true;

        /*((MonoBehaviour)myPlayerGo.GetComponent("Character Controller")).enabled = true;
        ((MonoBehaviour)myPlayerGo.GetComponent("PlayerCharacterController")).enabled = true;
        ((MonoBehaviour)myPlayerGo.GetComponent("Health")).enabled = true;
        ((MonoBehaviour)myPlayerGo.GetComponent("PlayerInputHandler")).enabled = true;
        ((MonoBehaviour)myPlayerGo.GetComponent("PlayerWeaponsManager")).enabled = true;
        ((MonoBehaviour)myPlayerGo.GetComponent("Jetpack")).enabled = true;
        ((MonoBehaviour)myPlayerGo.GetComponent("Actor")).enabled = true;
        ((MonoBehaviour)myPlayerGo.GetComponent("PhotonTransformView")).enabled = true;*/
    }
}
