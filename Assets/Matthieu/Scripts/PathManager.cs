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
    public Color initialColor;
    public Color inWaterColor; 
    public float[] initialSpeedRange; 
    private float newLength;
    private CinemachineSmoothPath currentPath;
    public FinalPosManager fpm;
    public int finalPositionIndex;
    public ChoiceManager choiceManager; 

  

    public float timer;
    public float finalTimer;
    private bool timerComplete = false;
    private bool finalTimerComplete = false;
    private bool pathChanged = false;

    // Start is called before the first frame update
    void Start()
    {
        cart.m_Speed = initialSpeedRange[0];
        currentPath = startPath;

        sprite.color = initialColor; 
    }


    // Update is called once per frame
    void Update()
    {
        if (timer > 0 && !timerComplete)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            if (!timerComplete)
            {
                ChangeSprite();
                ChangePath(); 
                timerComplete = true;
                
            }
        }
        if (timerComplete && !pathChanged)
        {
            if (cart.m_Position == 1)
            {
                FollowNewPath(); 
                pathChanged = true;
            }
        }

        if(finalTimer > 0)
        {
            finalTimer -= Time.deltaTime;
        }
        else
        {
            if (!finalTimerComplete)
            {
                GetToFinalPosition();
                finalTimerComplete = true;
                
                choiceManager.ChooseFish(); 
            }
            
        }

        


    }

   
    void ChangePath()
    {
        currentPath.m_Waypoints = new CinemachineSmoothPath.Waypoint[2];
        currentPath.m_Waypoints[0].position = new Vector3(shark.position.z, shark.position.y, shark.position.x);
        currentPath.m_Waypoints[1].position = newPath.m_Waypoints[0].position;
        currentPath.m_Looped = false;


        //Ajustements pour adapter la vitesse au nouveau chemin 
        newLength = Vector3.Distance(currentPath.m_Waypoints[0].position, currentPath.m_Waypoints[1].position); //Calcul de la distance entre les deux nouveaux points
        cart.m_PositionUnits = CinemachinePathBase.PositionUnits.PathUnits; // Changement du PositionUnits pour changer de path à la position 1
        cart.m_Position = 0;
        cart.m_Speed /= newLength; // Diminution de la vitesse en fonction de la nouvelle distance car la vitesse est adaptée au PositionUnits

    }

    void FollowNewPath()
    {
        currentPath = newPath;
        cart.m_Path = newPath;
        cart.m_Position = 0;
        cart.m_PositionUnits = CinemachinePathBase.PositionUnits.Distance;  
        cart.m_Speed = Random.Range(initialSpeedRange[0], initialSpeedRange[1]); // Réassignement de la vitesse 
    }

    void GetToFinalPosition()
    {
        currentPath.m_Waypoints = new CinemachineSmoothPath.Waypoint[2];
        currentPath.m_Waypoints[0].position = new Vector3(shark.position.z, shark.position.y, shark.position.x);
        currentPath.m_Waypoints[1].position = fpm.finalPositions[finalPositionIndex];
        currentPath.m_Looped = false;

        //Ajustements pour adapter la vitesse au nouveau chemin 
        newLength = Vector3.Distance(currentPath.m_Waypoints[0].position, currentPath.m_Waypoints[1].position); //Calcul de la distance entre les deux nouveaux points
        cart.m_PositionUnits = CinemachinePathBase.PositionUnits.PathUnits; // Changement du PositionUnits pour changer de path à la position 1
        cart.m_Position = 0;
        cart.m_Speed /= newLength; // Diminution de la vitesse en fonction de la nouvelle distance car la vitesse est adaptée au PositionUnits

    }



    void ChangeSprite()
    {
        sprite.color = inWaterColor; 
    }
   
}
