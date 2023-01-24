using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour
{
    [Conditional("DEBUG")]
    public static void LogString(string message)
    {
        Debug.Log(message);
    }
}
