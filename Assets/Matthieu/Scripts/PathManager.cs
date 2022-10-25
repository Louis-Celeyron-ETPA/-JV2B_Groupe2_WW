using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine; 

public class PathManager : MonoBehaviour
{
    public CinemachineDollyCart cart;
    public Transform shark;
    public CinemachineSmoothPath startPath, newPath;
    public SpriteRenderer sprite;
    private float newLength; 
    //public Vector3[] initialPath;
    //public Vector3[] nextPath; 

    public float timer;
    private bool timerComplete = false;
    private bool pathChanged = false;

    // Start is called before the first frame update
    void Start()
    {
        //SetInitialPath(); 
    }


    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            if (!timerComplete)
            {
                timerComplete = true;
                startPath.m_Waypoints = new CinemachineSmoothPath.Waypoint[2];
                startPath.m_Waypoints[0].position = new Vector3(shark.position.z, shark.position.y, shark.position.x);
                startPath.m_Waypoints[1].position = newPath.m_Waypoints[0].position;
                startPath.m_Looped = false;
                newLength = Vector3.Distance(startPath.m_Waypoints[0].position, startPath.m_Waypoints[1].position);
                Debug.Log(newLength); 
                cart.m_Position = 0;
            }
        }
        if (timerComplete && !pathChanged)
        {
            if (cart.m_Position >= newLength)
            {
                cart.m_Path = newPath;
                cart.m_Position = 0;
                timerComplete = false;
                pathChanged = true;
            }
        }

    }

    //void SetInitialPath()
    //{
    //    startPath.m_Waypoints[0].position = initialPath[0];
    //    startPath.m_Waypoints[1].position = initialPath[1];
    //    startPath.m_Waypoints[2].position = initialPath[2];
    //    startPath.m_Waypoints[3].position = initialPath[3];
    //}

    void ChangePath()
    {
        //startPath.m_Resolution = 
        //startPath.m_Waypoints[0].position = Vector3.MoveTowards(startPath.m_Waypoints[0].position, newPath.m_Waypoints[0].position, 0.01f);
        //startPath.m_Waypoints[1].position = Vector3.MoveTowards(startPath.m_Waypoints[1].position, newPath.m_Waypoints[1].position, 0.01f);
        //startPath.m_Waypoints[2].position = Vector3.MoveTowards(startPath.m_Waypoints[2].position, newPath.m_Waypoints[2].position, 0.01f);
        //startPath.m_Waypoints[3].position = Vector3.MoveTowards(startPath.m_Waypoints[3].position, newPath.m_Waypoints[3].position, 0.01f);
    }



    void ChangeSprite()
    {
        sprite.color = Color.blue; 
    }
   
}
