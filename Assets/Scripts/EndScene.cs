using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScene : MonoBehaviour
{

    public GameObject cutscene;

    public void Ending()
    {
        cutscene.SetActive(true);
    }
}
