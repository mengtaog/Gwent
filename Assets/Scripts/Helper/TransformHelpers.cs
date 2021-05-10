using UnityEngine;

public static class TransformHelpers
{
    public static Transform DeepFind(this Transform parent, string targetName)
    {
        foreach (Transform child in parent)
        {
            if (child.name == targetName) return child;
            Transform ans = DeepFind(child, targetName);
            if (ans != null) return ans;
        }
        return null;
    }
}