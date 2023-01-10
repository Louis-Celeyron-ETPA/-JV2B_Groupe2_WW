using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NatanG_minijeu1
{
    public class SignalMoving : MonoBehaviour
    {
        void Update()
        {
            //------------------------------------- Les signalitiques bougent
            transform.position += new Vector3(-0.02f, 0);

            //------------------------------------- Boucle des signalitiques
            if (transform.position.x <= -11)
            {
                transform.position += new Vector3(21, 0);
            }
        }
    }
}
