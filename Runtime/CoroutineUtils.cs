using System;
using System.Collections;
using UnityEngine;
using Object = UnityEngine.Object;

namespace LLib
{
    public static class CoroutineUtils
    {
        private class Runner : MonoBehaviour { }
        private static Runner _runner;
        private static Runner Instance
        {
            get
            {
                if (_runner == null)
                {
                    var go = new GameObject("CoroutineUtils");
                    Object.DontDestroyOnLoad(go);
                    go.hideFlags = HideFlags.HideInHierarchy;
                    _runner = go.AddComponent<Runner>();
                }
                return _runner;
            }
        }

        public static Coroutine Start(IEnumerator routine)
        {
            return Instance.StartCoroutine(routine);
        }

        public static void Stop(Coroutine coroutine)
        {
            if (coroutine != null)
            {
                Instance.StopCoroutine(coroutine);
            }
        }

        public static void StopAll()
        {
            Instance.StopAllCoroutines();
        }

        public static Coroutine Delay(float seconds, Action action)
        {
            return Start(DelayRoutine(seconds, action));
        }

        public static Coroutine DelayFrame(int frameCount, Action action)
        {
            return Start(DelayFrameRoutine(frameCount, action));
        }

        public static Coroutine NextFrame(Action action)
        {
            return Start(DelayFrameRoutine(1, action));
        }

        public static Coroutine WaitUntil(Func<bool> predicate, Action action)
        {
            return Start(WaitUntilRoutine(predicate, action));
        }

        public static Coroutine Repeat(float interval, Action action, int count = -1)
        {
            return Start(RepeatRoutine(interval, action, count));
        }
        
        public static Coroutine EndOfFrame(Action action)
        {
            return Start(EndOfFrameRoutine(action));
        }

        private static IEnumerator EndOfFrameRoutine(Action action)
        {
            yield return new WaitForEndOfFrame();
            action?.Invoke();
        }

        private static IEnumerator DelayRoutine(float seconds, Action action)
        {
            yield return new WaitForSeconds(seconds);
            action?.Invoke();
        }

        private static IEnumerator DelayFrameRoutine(int frameCount, Action action)
        {
            for (int i = 0; i < frameCount; i++)
                yield return null;
            
            action?.Invoke();
        }

        private static IEnumerator WaitUntilRoutine(Func<bool> predicate, Action action)
        {
            yield return new WaitUntil(predicate);
            
            action?.Invoke();
        }

        private static IEnumerator RepeatRoutine(float interval, Action action, int count)
        {
            var wait = new WaitForSeconds(interval);
            int executed = 0;

            while (count < 0 || executed < count)
            {
                yield return wait;
                action?.Invoke();
                executed++;
            }
        }
    }
}


