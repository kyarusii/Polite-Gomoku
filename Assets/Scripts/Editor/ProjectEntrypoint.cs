using UnityEditor;

namespace PG.Editor
{
    public class ProjectEntrypoint
    {
        [InitializeOnLoadMethod]
        private static void Init()
        {
            UnityEngine.Debug.Log("Project Entrypoint in Editor.");
        }
    }
}
