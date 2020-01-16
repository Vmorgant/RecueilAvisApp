using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Malee;
    [CreateAssetMenu()]
public class achievementDatabase : ScriptableObject
{
    [Reorderable]
    public achievementsArray achievements;
    [System.Serializable]
    public class achievementsArray : ReorderableArray<achievement> { }
}
