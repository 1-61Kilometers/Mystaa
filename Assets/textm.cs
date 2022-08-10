using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class textm : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    public GameObject rob;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = rob.transform.eulerAngles.ToString();
    }
}
