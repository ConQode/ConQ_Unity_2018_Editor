using UnityEngine;
using UnityEditor;

public class ScalePositionsEditor : Editor
{
    private const float PositionScaleFactor = 9f;

    [MenuItem("ConQ/Multiply Positions by 9")]
    private static void ScaleSelectedPositions()
    {
        if (Selection.transforms.Length == 0)
        {
            Debug.LogWarning("No objects selected to scale position.");
            return;
        }

        Undo.RecordObjects(Selection.transforms, "Scale Positions");

        foreach (Transform t in Selection.transforms)
        {
            Vector3 oldPosition = t.position;
            t.position = oldPosition * PositionScaleFactor;
        }

        Debug.Log("Scaled positions of " + Selection.transforms.Length + " object(s) by factor " + PositionScaleFactor);
    }
}
