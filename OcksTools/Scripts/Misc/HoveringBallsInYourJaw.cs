using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoveringBallsInYourJaw : MonoBehaviour
{
    public string HoverClarifyText = "";
    public float scale = 2f;
    RectTransform rectTransform;
    private void Start()
    {
        rectTransform=  GetComponent<RectTransform>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(RandomFunctions.Instance.CheckInsideRect(rectTransform, Gamer.Instance.MousePosMainUnScaled, Gamer.Instance.cam, scale))
        {
            Gamer.Instance.hoveringonmyballsinyourjaw = HoverClarifyText;
        }
    }
}
