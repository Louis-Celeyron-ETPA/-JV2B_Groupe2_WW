using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Evan
{

    public class onclick : MonoBehaviour
    {
        public Image image;
        public Sprite newSprite;
        public Sprite originalSprite;
        private bool spriteNew;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }


        public void ImageChange()
        {
            if (spriteNew)
            {
                spriteNew = false;
                image.sprite = originalSprite;
            }
            else
            {
                spriteNew = true;
                image.sprite = newSprite;
            }

        }

    }
}