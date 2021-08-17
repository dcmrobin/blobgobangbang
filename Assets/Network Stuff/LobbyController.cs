using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyController : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Text buttonText;
    [SerializeField]
    private int roomSize;
    private bool connected;
    private bool starting;
    public Text usertext;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        connected = true;
        buttonText.text = "Begin Game";
    }

    public void GameButton()
    {
        if (connected)
        {
            Debug.Log("Clicked");
            //PhotonNetwork.JoinRandomRoom(); // attempt joining a room
            if (!starting)
            {
                starting = true;
                buttonText.text = "Starting Game. Click Again to Cancel";
                PhotonNetwork.JoinRandomOrCreateRoom(); // attempt joining a room
            }
            else
            {
                starting = false;
                buttonText.text = "Begin Game";
                PhotonNetwork.LeaveRoom(); // cancel the request
            }
        }
        else
            Debug.Log("Not connected to server!");
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log("Failed to join a room... creating room");
	    CreateRoom();
    }

    void CreateRoom()
    {
        Debug.Log("Creating room now");
        int randomRoomNumber = Random.Range(0, 10000);
        RoomOptions roomOps = new RoomOptions() { IsVisible = true, 
                IsOpen = true, MaxPlayers = (byte)roomSize };
        PhotonNetwork.CreateRoom("Room" + randomRoomNumber, roomOps); 
        Debug.Log(randomRoomNumber); 
    }
    public override void OnCreateRoomFailed(short returnCode, string message) 
    {
        Debug.Log("Failed to create room... trying again"); 
        CreateRoom();
    }
}
