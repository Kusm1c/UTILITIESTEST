using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Log : MonoBehaviour
{
    [Conditional("DEBUG")]
    public static void LogString(string message)
    {
        Debug.Log(message);
    }
}
