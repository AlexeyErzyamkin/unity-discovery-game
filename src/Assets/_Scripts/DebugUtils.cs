#define DEBUG

using System;

public class DebugUtils
{
    [System.Diagnostics.Conditional("DEBUG")]
    public static void Assert(bool condition, String message = "")
    {
        if (!condition) {
            UnityEngine.Debug.LogError(message);

            throw new Exception(message);
        }
    }
}