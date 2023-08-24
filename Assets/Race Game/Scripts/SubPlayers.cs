using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SubPlayers : MonoBehaviour
{

    public GameObject PlayerOnePrefab;
    public GameObject PlayerTwoPrefab;
   

    public void SpawnPlayerOne()
    {
        PlayerInput.Instantiate(prefab: PlayerOnePrefab, playerIndex: 0, controlScheme: "Player 1", pairWithDevice: Keyboard.current, splitScreenIndex: 0);
    }

    public void SpawnPlayerTwo()
    {
        PlayerInput.Instantiate(prefab: PlayerTwoPrefab, playerIndex: 1, controlScheme: "Player 2", pairWithDevice: Keyboard.current, splitScreenIndex: 1);
    }

    private void Start()
    {
        SpawnPlayerOne();
        SpawnPlayerTwo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
