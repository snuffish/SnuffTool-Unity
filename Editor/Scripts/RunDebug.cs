using UnityEditor;
using UnityEngine;

namespace SnuffTool.Editor.Scripts
{
    [ExecuteAlways]
    public class RunDebug : MonoBehaviour
    {
        [MenuItem("SnuffTool/Debug/Run")]
        private static void Run() {
            Debug.Log("SDSDSDSDSA");
        }
    }
}
