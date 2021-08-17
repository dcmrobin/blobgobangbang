using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdoit : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public void TestCall()
    {
        // test
    }
}
