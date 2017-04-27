using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOVer : MonoBehaviour {
    public Text ActiveGameOver;

    private void OnTriggerEnter(Collider other)
    {
        GameEnd();
    }

    void GameEnd()
    {
        ActiveGameOver.enabled = true;
        print("Game over");

    }
}
