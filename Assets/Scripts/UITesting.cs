using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UITesting : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public string txtString;
    public int buildIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void ChangeText()
    {
        textBox.text = txtString;
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(buildIndex);
    }
}
