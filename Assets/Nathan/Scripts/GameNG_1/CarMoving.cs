using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NatanG_minijeu1
{
    public class CarMoving : MonoBehaviour
    {

        void Update()
        {
            //------------------------------------- Les voitures bougent
            transform.position += new Vector3(-0.02f, 0);

            //------------------------------------- Les voitures sont détruite quand elles sortent de l'écran
            if (transform.position.x <= -11 && transform.position.y > -4)
            {
                Destroy(gameObject);
            }
        }
    }
}
