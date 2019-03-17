using UnityEngine;
using System.Collections;

public class SpawnGameObjects : MonoBehaviour {

    public Transform[] spawns;
    public GameObject coin;
    public GameObject enemy;

    // Use this for initialization
    void Start() {

        Spawn();
    }

    void Spawn() {
        for (int i = 0; i < spawns.Length; i++) {
            if (Random.Range(0, 2) > 0) {
                if (i == 1) {
                    if (Random.Range(0, 2) > 0) {
                        SpawnPrefab(enemy, spawns[i].position);
                    }
                } else {
                    if (Random.Range(0, 2) > 0) {
                        SpawnPrefab(coin, spawns[i].position);
                    }
                }
            }
        }
    }

    void SpawnPrefab(GameObject prefab, Vector3 position) {
        Instantiate(prefab, position, Quaternion.identity);
    }
}