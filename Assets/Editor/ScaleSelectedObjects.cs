using UnityEditor;
using UnityEngine;

public class ScaleSelectedObjects : MonoBehaviour
{
    [MenuItem("ConQ/Scale Children %g")]
    static void ScaleChildren()
    {
        // Get the selected game objects in the hierarchy
        GameObject[] selectedObjects = Selection.gameObjects;

        // Iterate through each selected object
        foreach (GameObject obj in selectedObjects)
        {
            // Iterate through each child of the selected object
            for (int i = 0; i < obj.transform.childCount; i++)
            {
                // Scale the child by a factor of 9 in all directions
                obj.transform.GetChild(i).localScale *= 9f;
            }
        }
    }
}
