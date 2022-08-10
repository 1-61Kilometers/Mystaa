using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class IRC5WebClient : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(webRequest());   
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator webRequest()
    {
        UnityWebRequest request = UnityWebRequest.Get("http://127.0.0.1/rw/rapid/modules?task=T_ROB_L");
        request.SetRequestHeader("authorization", getDefaultUser());
        request.SetRequestHeader("Content-Type", "application/json");
        yield return request.SendWebRequest();

    }

    string getDefaultUser()
    {
        string auth = "Default User" + ":" + "robotics";
        auth = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(auth));
        auth = "Basic " + auth;
        return auth;
    }
}

