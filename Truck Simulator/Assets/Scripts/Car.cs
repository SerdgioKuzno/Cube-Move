using UnityEngine;

namespace DefaultNamespace
{
    public class Car : MonoBehaviour
    {
        private const float Speed =1;
        
        [SerializeField] private Rigidbody _rigidbody;

        public void Move(Vector2 moveVector)
        {
            Transform tr = _rigidbody.transform;
            tr.position += new Vector3(moveVector.x, 0, moveVector.y) * Time.fixedDeltaTime;
        }
    }
}