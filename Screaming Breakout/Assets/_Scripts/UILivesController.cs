using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILivesController : MonoBehaviour {
    
    public Text text;

    void Start () {
    }

    public void SetLives(int lives) {
        text.text = "Lives: " + lives.ToString();
    }
}