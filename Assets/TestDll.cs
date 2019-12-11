using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DLLtest;
public class TestDll : MonoBehaviour
{
   
    void Start()
    {
        DLLClass dc = new DLLClass();
        Debug.Log(dc.Check());
        Debug.Log(dc.Add(1,2));
    }

  void Test()
    {
        Debug.Log("TestGit");
    }
}
