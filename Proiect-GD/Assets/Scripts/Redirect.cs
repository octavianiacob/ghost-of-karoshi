using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Redirect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waiter());
    }
    IEnumerator waiter()
    {
       
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
