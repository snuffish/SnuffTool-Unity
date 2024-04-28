
using System;
using UnityEditor;
using UnityEditor.Animations;
using UnityEditorInternal;
using UnityEngine;

namespace SnuffTool.Editor.Scripts.State
{
    public class CreateState : MonoBehaviour
    {
        [MenuItem("SnuffTool/State/Create")]
        [Obsolete("Obsolete", false)]
        static void MenuCallback()
        {
            var obj = new GameObject("NewState");
            var state = obj.AddComponent<StateListener>();
            state._stateName = "NewState";
            state._stateMachine = new StateMachine();
        }
    }
}