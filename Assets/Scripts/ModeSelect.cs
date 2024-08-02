using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.Animations;

public class ModeSelect : MonoBehaviour
{
    public Animator cameraAnimator;
    private NetworkManager netManager;

    public GameObject modeSelectUI;

    // Start is called before the first frame update
    void Start()
    {
        netManager = GetComponentInParent<NetworkManager>();
    }

    public void Server()
    {
        modeSelectUI.SetActive(false);
        netManager.StartServer();
        cameraAnimator.SetTrigger("Begin");
    }

    public void Client()
    {
        modeSelectUI.SetActive(false);
        netManager.StartClient();
        cameraAnimator.SetTrigger("Begin");
    }
}
