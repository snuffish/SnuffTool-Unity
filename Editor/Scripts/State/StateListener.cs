
using System;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEditorInternal;
using UnityEngine;

namespace SnuffTool.Editor.Scripts.State
{
    [ExecuteAlways]
    [RequireComponent(typeof(Variables), typeof(StateMachineBehaviourContext))]
    [Obsolete]
    public class StateListener : MonoBehaviour
    {
        public string _stateName;

        public Variables _variables;
        public StateMachine _stateMachine;

        private void Awake()
        {
            _stateName = name;
            _variables = GetComponent<Variables>();
            _stateMachine = GetComponent<StateMachine>();
        }
    }
}
