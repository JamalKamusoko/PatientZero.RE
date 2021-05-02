using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonCode : MonoBehaviour
{
    public Button button1;
    public Image image;
    public GameObject knapsack;
    public GameObject lightObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnter()
    {
        button1.GetComponent<Image>().color = new Color();
    }
    public void OnExit()
    {
        image.gameObject.SetActive(false);
    }

    public void ScoreButton()
    {
        knapsack.SetActive(!knapsack.activeInHierarchy);
        lightObj.SetActive(!lightObj.activeInHierarchy);
    }

    public void SetButton()
    {
        SceneManager.LoadScene("level2");
    }
}
