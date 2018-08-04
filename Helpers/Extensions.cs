using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Helpers
{
    public static partial class Extensions
    {
        public static string GetName(this MonoBehaviour monoBehaviour, Action action)
        {
            return action.Method.Name;
        }

        public static List<T> ToList<T>(this T[] Array)
        {
            List<T> list = new List<T>();
            foreach(T value in Array)
            {
                list.Add(value);
            }
            return list;
        }

        public static int ToPercentages(this MonoBehaviour monoBehaviour, double maxValue, double value)
        {
            return (int)(value * 100 / maxValue);
        }
    }
}