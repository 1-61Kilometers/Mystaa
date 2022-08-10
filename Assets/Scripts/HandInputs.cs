using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine.Networking;

public class HandInputs : MonoBehaviour
{
    
    public GameObject robot;
    
    public GameObject cube;
    bool letgo = false;
    private Vector3 updatedpos;
    private Vector3 updatedrot;
    private const float PinchThreshold = 0.7f;
    private const float GrabThreshold = 0.4f;
    private float x;
    /*public static float IsPinching(Handedness trackedHand)
    {
        MixedRealityPose pose;
        MixedRealityPose pose2;
        if(HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Left, out pose) && HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Left, out pose2)){
            float position = Mathf.Ceil(Vector3.Distance(pose.Position*10, pose2.Position*10)*200);
            if(position <= 30){
                position = 0;
            }
            return position;
        } else {
            return 0;
        }
    }*/

    IEnumerator GetText(float x)
    {
        using (UnityWebRequest request = UnityWebRequest.Get("http://192.168.125.50/api/dc/rgxp2/set_width/0/"+ x + "/120"))
        {
            yield return request.Send();

            if (request.isNetworkError) // Error
            {
                Debug.Log(request.error);
            }
            else // Success
            {
                Debug.Log(request.downloadHandler.text);
            }
        }
    }
    public void OnSliderUpdated(SliderEventData eventData)
    {
        StartCoroutine(GetText(eventData.NewValue * 180));
    }
    public static bool IsGrabbing(Handedness trackedHand)
    {
        return  HandPoseUtils.IsMiddleGrabbing(trackedHand) || (HandPoseUtils.MiddleFingerCurl(trackedHand) > GrabThreshold &&
                HandPoseUtils.RingFingerCurl(trackedHand) > GrabThreshold &&
                HandPoseUtils.PinkyFingerCurl(trackedHand) > GrabThreshold);
    }

    // Start is called before the first frame update
    void Start()
    {
        /*
        updatedpos = new Vector3(0,0,0);
        updatedrot = new Vector3(0,0,0);
        x = 0;
        */
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(x != IsPinching(Handedness.Right)){
            StartCoroutine(GetText(IsPinching(Handedness.Right)));
            x = IsPinching(Handedness.Right);
        }

        //This Part Needs Some Work
        if(IsGrabbing(Handedness.Right)){
            HandJointUtils.TryGetJointPose(TrackedHandJoint.Palm, Handedness.Right, out pose);
            if(letgo == false){
                Debug.Log("HE GRAB");
                cube.transform.position = pose.Position;
                cube.transform.eulerAngles = pose.Rotation.eulerAngles;
                letgo = true;
            }
            
            
            robot.transform.position = updatedpos+(pose.Position - cube.transform.position);
            robot.transform.eulerAngles = pose.Rotation.eulerAngles;
            
        } else {
            updatedpos = robot.transform.position;
            updatedrot = robot.transform.eulerAngles;
            letgo = false;
            Debug.Log("HE LET GO");
        }
        
        */
    }
    
}
