using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.UI.BoundsControl;
public class lerpcontroll : MonoBehaviour
{
    public BoundsControl bounds;
    public ObjectManipulator Object;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnSliderUpdated(SliderEventData eventData)
        {
            bounds.RotateLerpTime = eventData.NewValue;
            bounds.TranslateLerpTime = eventData.NewValue;
            Object.RotateLerpTime = eventData.NewValue;
            Object.MoveLerpTime = eventData.NewValue;
        }
}
