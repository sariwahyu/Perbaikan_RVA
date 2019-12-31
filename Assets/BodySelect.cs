using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodySelect : MonoBehaviour
{
    public GameObject lowoireng;
    public GameObject bodylain;

    public int bodySelected;

    // Start is called before the first frame update
    void Start()
    {
        lowoireng.SetActive(true);
        bodylain.SetActive(false);

        bodySelected = 1;
    }

    public void loadLowo()
    {
        lowoireng.SetActive(true);
        bodylain.SetActive(false);

        bodySelected = 1;
    }

    public void loadbodylain()
    {
        lowoireng.SetActive(false);
        bodylain.SetActive(true);

        bodySelected = 1;
    }
}
