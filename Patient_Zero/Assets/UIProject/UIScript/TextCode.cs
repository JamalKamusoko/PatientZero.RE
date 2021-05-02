using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TextCode : MonoBehaviour
{
    public Color colorred = Color.red;
    public Color colorwhite = Color.white;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeRed()
    {
        GetComponent<Text>().color = colorred;
    }
    public void ChangeWhite()
    {
        GetComponent<Text>().color = colorwhite;
    }

    public void LoadSetting()
    {
        SceneManager.LoadScene("level2");
    }
}
