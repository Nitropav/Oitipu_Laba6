using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartButton : MonoBehaviour
{
    
    public GameObject startButton, spawn_bombs, savehim;

    void OnMouseDown()
    {
        startButton.SetActive(false);
        spawn_bombs.GetComponent<SpawnBombs>().enabled = true;
        savehim.SetActive(false);
    }
}
