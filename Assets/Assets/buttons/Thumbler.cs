using UnityEngine;

namespace Assets.buttons
{
    class Thumbler : MonoBehaviour
    {
        [SerializeField] private int[] _degrees;
        private int _currentIndex = 0;

        private void Start()
        {
            transform.rotation = Quaternion.Euler(0, 0, _degrees[0]);
        }

        private void OnMouseDown()
        {
            _currentIndex++;
            _currentIndex %= _degrees.Length;

            transform.rotation = Quaternion.Euler(0, 0, _degrees[_currentIndex]);
        }
    }
}
