using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Net;
using System.IO;
using Newtonsoft.Json;

public class SQIReqs : MonoBehaviour
{
    //private object entry;

    internal class SQIEntry
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Location { get; set; }
    }

    void Start()
    {

        GameObject txt = GameObject.Find("txt_sqi");
        Text t = txt.GetComponent<Text>();

        var webRequest = WebRequest.Create("https://sheet.best/api/sheets/92710cbf-0fd2-4e48-bbd4-294fcc48cfb0") as HttpWebRequest;
        if (webRequest == null)
        {
            return;
        }

        webRequest.ContentType = "application/json";
        webRequest.UserAgent = "Nothing";
        var s = webRequest.GetResponse().GetResponseStream();
        var sr = new StreamReader(s);
        var entriesAsJson = sr.ReadToEnd();
        var entries = JsonConvert.DeserializeObject<List<SQIEntry>>(entriesAsJson);
        entries.ForEach(Console.WriteLine);

        Console.ReadLine();
        t.text = "";

        for (var i = 0; i < entries.Count; i++)
        {
            t.text += "Name: " + entries[i].Name + "\nContact: " + entries[i].Contact + "\nLocation: " + entries[i].Location + "\n\n";
        }

    }


}


