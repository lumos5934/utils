using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace LLib.Utils
{
    public static class DebugUtils
    {
        private const string Prefix = "[ Editor ] ";

        [HideInCallstack]
        [Conditional("UNITY_EDITOR")]
        public static void Log(object message)
        {
            Debug.Log(Prefix + message);
        }

        [HideInCallstack]
        [Conditional("UNITY_EDITOR")]
        public static void Log(object message, Object context)
        {
            Debug.Log(Prefix + message, context);
        }

        [HideInCallstack]
        [Conditional("UNITY_EDITOR")]
        public static void LogWarning(object message)
        {
            Debug.LogWarning(Prefix + message);
        }

        [HideInCallstack]
        [Conditional("UNITY_EDITOR")]
        public static void LogWarning(object message, Object context)
        {
            Debug.LogWarning(Prefix + message, context);
        }

        [HideInCallstack]
        [Conditional("UNITY_EDITOR")]
        public static void LogError(object message)
        {
            Debug.LogError(Prefix + message);
        }
        
        [HideInCallstack]
        [Conditional("UNITY_EDITOR")]
        public static void LogError(object message, Object context)
        {
            Debug.LogError(Prefix + message, context);
        }

        [HideInCallstack]
        [Conditional("UNITY_EDITOR")]
        public static void LogException(System.Exception exception)
        {
            Debug.LogException(exception);
        }

        [HideInCallstack]
        [Conditional("UNITY_EDITOR")]
        public static void LogException(System.Exception exception, Object context)
        {
            Debug.LogException(exception, context);
        }
    }
}


