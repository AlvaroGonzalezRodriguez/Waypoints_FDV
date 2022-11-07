using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{

    public Transform[] waypoints;
    public float speed = 5.0f;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        this.transform.position = waypoints[index].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(waypoints[index].transform.position);
        transform.position = Vector3.MoveTowards(transform.position, waypoints[index].transform.position, speed * Time.deltaTime);

        if(transform.position == waypoints[index].transform.position) {
            index++;
        }
        if(index == waypoints.Length){
            index = 0;
        }
    }
}
