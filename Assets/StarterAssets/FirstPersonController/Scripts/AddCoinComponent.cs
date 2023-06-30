using UnityEngine;
using UnityEngine.Events;

namespace StarterAssets
{
    public class AddCoinComponent : MonoBehaviour
    {
        [SerializeField] private int _numCoins;
        [SerializeField] private AudioClip _coinSound;
        private FirstPersonController _player;

        private void Start()
        {
            _player = FindObjectOfType<FirstPersonController>();
        }

        public void Add()
        {
            _player.AddCoin(_numCoins);
            AudioSource.PlayClipAtPoint(_coinSound, transform.position);
        }
    }
}
