using System.Collections.Generic;
using UnityEngine;

namespace Assets.buttons
{
    class Leaver : MonoBehaviour
    {
        [SerializeField] private Vector3 _degreeTrue, _degreeFalse;
        [SerializeField] private GameObject _point;
        private Dictionary<bool, Vector3> dc = new Dictionary<bool, Vector3>();
        private bool _isActive = false;

        private void Awake()
        {
            dc.Add(true, _degreeTrue);
            dc.Add(false, _degreeFalse);
        }

        private void Start()
        {
            _point.transform.eulerAngles = dc[_isActive];
        }

        private void OnMouseDown()
        {
            _isActive = !_isActive;
            _point.transform.eulerAngles = dc[_isActive];
        }
    }
}
