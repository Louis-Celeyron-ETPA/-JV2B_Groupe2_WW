using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public RectTransform myRectTreansform;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            ;
            var positionTemporaire = new Vector3(
                myRectTreansform.anchoredPosition.x / Camera.main.pixelWidth,
                myRectTreansform.anchoredPosition.y / Camera.main.pixelHeight * -1,
                Camera.main.nearClipPlane);
            var convertedPosition = Camera.main.ViewportToWorldPoint(positionTemporaire);

            var positionDansLeMonde = new Vector3(convertedPosition.x, -convertedPosition.y, convertedPosition.z);

            if (Physics.Raycast(positionDansLeMonde, Camera.main.transform.forward, out var info))
            {
                var RandomMouvement = info.transform.GetComponent<RandomMouvement>();
                if (RandomMouvement != null)
                {
                    Debug.Log(RandomMouvement);
                }
            }
        }
    }
}