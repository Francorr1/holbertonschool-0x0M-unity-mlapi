using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class CubeAssigner : NetworkBehaviour
{
    public GameObject playerPrefab;

    public override void OnNetworkSpawn()
    {
        if (IsServer)
        {
            NetworkManager.Singleton.OnClientConnectedCallback += OnClientConnected;
        }
    }

    private void OnClientConnected(ulong clientId)
    {
        var playerInstance = Instantiate(playerPrefab);
        var networkObject = playerInstance.GetComponent<NetworkObject>();
        networkObject.SpawnAsPlayerObject(clientId, true);
    }
}
