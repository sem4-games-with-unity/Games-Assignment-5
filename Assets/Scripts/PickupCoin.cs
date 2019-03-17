using UnityEngine;
using System.Collections;
using TMPro;

public class PickupCoin : MonoBehaviour {

    TextMeshProUGUI scoreBoard;
    private ParticleSystem _psystem;

    // Use this for initialization
    void Start() {
        scoreBoard = GameObject.Find("Score Board").GetComponent<TextMeshProUGUI>();
        _psystem = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player")) {
            PlayerStats.Score += 1;
            scoreBoard.text = "Score: " + PlayerStats.Score;
            _psystem.Emit(50);
            Destroy(gameObject);
        }
    }
}