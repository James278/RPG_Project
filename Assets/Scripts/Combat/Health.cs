using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Combat
{
    public class Health : MonoBehaviour
    {
        float healthTotal = 100f;

        [SerializeField] float currentHealth;

        private void Start()
        {
            currentHealth = healthTotal;
        }

        public void TakeDamage(float damage)
        {
            currentHealth = Mathf.Clamp(currentHealth - damage, 0f, healthTotal);
        }
    }
}
