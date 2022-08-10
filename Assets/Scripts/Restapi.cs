using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using Microsoft.MixedReality.Toolkit.UI;
public class Restapi : MonoBehaviour
{
    void Start()
    {
        
    }
    public void Grip(SliderEventData eventData){
        float x = eventData.NewValue * 180;
        StartCoroutine(GetText(x));
    }
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
}