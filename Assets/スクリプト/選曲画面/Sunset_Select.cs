using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunset_Select : MonoBehaviour
{
    public GameObject[] song;
    static GameObject[] song_46 = new GameObject[101];
    int number;
    int count = 0;
    int wait = 0;

    // Start is called before the first frame update
    void Start()
    {
        number = Random.Range(0, 5);
        song_46[count / 100] = Instantiate(song[number], new Vector3(0, 0, -1), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        count = count + 25;

        if (count % 100 == 0 && count <= 5000)
        {
            Destroy(song_46[(count / 100) - 1]);

            number = Random.Range(0, 5);
            song_46[count / 100] = Instantiate(song[number], new Vector3(0, 0, -1), Quaternion.identity);
        }
    }
}
