using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.PlayerLoop;

namespace MidtermExam.Prob01
{
    public class GameEntity
    {
        public string id;
        private Vector3 position;
        protected int health;
        public virtual void Update()
        {

        }
        public virtual void TakeDamage(int damage)
        {
          health = damage;
        }
        private void Move(Vector3 direction)
        {
            position += direction;
        }
    }
}
