using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    static GameObject buildReq;
    static GameObject sqiReqs;
    static GameObject buildSup;

    void Start()
    {
        buildReq = GameObject.Find("c_buildReqs");
        buildReq.SetActive(false);

        sqiReqs = GameObject.Find("c_sqidir");
        sqiReqs.SetActive(false);

        buildSup = GameObject.Find("c_buildsup");
        buildSup.SetActive(false);
    }

    public void getBuildPanel()
    {
        buildReq.SetActive(true);
    }

    public void hideBuildPanel()
    {
        buildReq.SetActive(false);
    }

    public void getSQIPanel()
    {
        sqiReqs.SetActive(true);
    }

    public void hideSQIPanel()
    {
        sqiReqs.SetActive(false);
    }

    public void getBuildSupPanel()
    {
        buildSup.SetActive(true);
    }

    public void hideBuildSupPanel()
    {
        buildSup.SetActive(false);
    }


}
