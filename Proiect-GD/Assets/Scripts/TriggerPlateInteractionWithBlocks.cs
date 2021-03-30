 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlateInteractionWithBlocks : MonoBehaviour
{
    //[SerializeField] GameObject plate;
    //[SerializeField] GameObject plate2;
    //[SerializeField] GameObject plate3;

    [SerializeField] List<GameObject> plates;


    bool isTriggered = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(isTriggered == false)
        {
            isTriggered = true;
            foreach (GameObject i in plates) {
                i.transform.position += new Vector3(0, 50, 0);
            }
            //plate.transform.position += new Vector3(0, 50, 0);
            //plate2.transform.position += new Vector3(0, 50, 0);
            //plate3.transform.position += new Vector3(0, 50, 0);
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (isTriggered == true)
        {
            isTriggered = false;
            //plate.transform.position += new Vector3(0, -50, 0);
            //plate2.transform.position += new Vector3(0, -50, 0);
            //plate3.transform.position += new Vector3(0, -50, 0);
            foreach (GameObject i in plates)
            {
                i.transform.position += new Vector3(0, -50, 0);
            }

        }
    }
}
