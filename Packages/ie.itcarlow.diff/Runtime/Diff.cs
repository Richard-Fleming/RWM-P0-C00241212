using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diff
{
    public static int diff(int x, int y)
    {
        return Mathf.Abs(x - y);
    }

    public static int[] diffs(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            if(i > 0)
            {
                result[i] = diff(xs[i], xs[i-1]);
            }
            else
            {
                result[i] = xs[i];
            }
        }
        return result;
    }
}