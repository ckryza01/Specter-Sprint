using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Used for monster or object movements. Create waypoint objects and add to the waypoints in order
 * that the waypoints should be visited. 
 */
public class WaypointFollower : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    [SerializeField] float speed = 1f;

    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[i].transform.position) < 0.1f)
        {
            i++;
            if (i >= waypoints.Length)
            {
                i = 0;
            }
        }
        transform.LookAt(waypoints[i].transform);
        transform.position = Vector3.MoveTowards(transform.position, waypoints[i].transform.position, speed * Time.deltaTime);
    }

    public void addWaypoint(GameObject obj)
    {
        if (waypoints == null)
        {
            waypoints = new GameObject[1];
            waypoints[0] = obj;
        } else
        {
            GameObject[] newArray = new GameObject[waypoints.Length + 1];
            for (int i = 0; i < waypoints.Length; i++)
            {
                newArray[i] = waypoints[i];
            }

            newArray[newArray.Length - 1] = obj;
            waypoints = newArray;
        }
    }
}
