using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace NatanG_minijeu2
{
    public class VisionDuJoueur : MonoBehaviour
    {
        //------------------------------------- les ombres se r�v�lent
        private void OnTriggerEnter2D(Collider2D collision)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }
    }
}
