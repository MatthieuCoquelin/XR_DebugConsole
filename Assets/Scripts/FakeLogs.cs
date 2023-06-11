using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeLogs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Some normal log");
        print("Another one");
        Debug.LogWarning("Warn log");
        Debug.LogError("Error log");
        Debug.LogWarning("Long Warning LogLong Warning LogLong Warning LogLong Warning LogLong Warning Log");
        print("Long Normal LogLong Normal LogLong Normal LogLong Normal LogLong Normal LogLong Normal Log");
        Debug.LogError("Long Error LogLong Error LogLong Error LogLong Error LogLong Error LogLong Error Log");
        Debug.Log("Last one");
    }

}
