using UnityEngine;
using System.Collections;

public class SpawnPlatforms : MonoBehaviour {

    public int maxPlatforms = 20;
    public GameObject platform;
    public GameObject goal;
    public float horizontalMin = 7.5f;
    public float horizontalMax = 14f;
    public float verticalMin = -5f;
    public float verticalMax = 5;


    private Vector2 originPosition;


    void Start() {

        originPosition = transform.position;
        Spawn();

    }

    void Spawn() {
        for (int i = 0; i < maxPlatforms; i++) {
            Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
            GameObject clone = Instantiate(platform, randomPosition, Quaternion.identity);
            if (i == maxPlatforms - 1) {
                Instantiate(goal, clone.transform.Find("Goal").transform.position, Quaternion.identity);
            }
            originPosition = randomPosition;
        }
    }

}