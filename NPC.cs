using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    public int healh = 5;
    public int level = 1;
    public float speed = 1.2f;
    Vector3 newPosition;
    void Start()
    {
        healh += level;
        print(healh);
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
