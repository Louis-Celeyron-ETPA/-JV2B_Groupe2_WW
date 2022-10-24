using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine; 

public class PathManager : MonoBehaviour
{
    public CinemachineDollyCart cart;
    public CinemachineSmoothPath startPath;
    public CinemachineSmoothPath nextPath;
    public SpriteRenderer sprite; 

    public float timer;
    private bool timerComplete = false;

    // Start is called before the first frame update
    void Start()
    {
        cart.m_Path = startPath; 
    }

    // Update is called once per frame
    void Update()
    { 
        if(timer > 0 && !timerComplete)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            timerComplete = true;
            ChangePath();
            //ChangeSprite(); 
        }

    }

    void ChangePath()
    {
        startPath.m_Waypoints[0].position = Vector3.MoveTowards(startPath.m_Waypoints[0].position, new Vector3(startPath.m_Waypoints[0].position.x, 2, startPath.m_Waypoints[0].position.z) , 0.01f);
        startPath.m_Waypoints[1].position = Vector3.MoveTowards(startPath.m_Waypoints[1].position, new Vector3(startPath.m_Waypoints[1].position.x, 2, 3) , 0.01f);
        
       
    }

    void ChangeSprite()
    {
        sprite.color = Color.blue; 
    }
}
