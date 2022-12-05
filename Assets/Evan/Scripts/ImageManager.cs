using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
{

    public List<Button> images;
    public Sprite dSprite;
    public SpriteState ss;
    // Start is called before the first frame update
    void Start()
    {
        var buttonSelected = images[Random.Range(0, images.Count)];
        buttonSelected.spriteState = ss;
        (buttonSelected.targetGraphic as Image).sprite= dSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
