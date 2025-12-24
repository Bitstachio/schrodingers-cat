using UnityEngine;

namespace Features.Player.Scripts
{
    [RequireComponent(typeof(Animator))]
    public class Attack : PlayerActionBehaviour
    {
        private static readonly int AttackTrigger = Animator.StringToHash("Attack");
        private const KeyCode Key = KeyCode.Q;

        private Animator _animator;

        private void Awake() => _animator = GetComponent<Animator>();

        private void Update()
        {
            // TODO: Update control system
            if (Input.GetKeyDown(Key)) Perform();
        }

        private void Perform()
        {
            _animator.SetTrigger(AttackTrigger);
            PlayerService.Attack();
        }
    }
}