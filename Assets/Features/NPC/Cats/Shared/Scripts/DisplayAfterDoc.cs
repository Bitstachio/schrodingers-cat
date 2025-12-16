using System.Collections;
using Features.NPC.Shared.Constants;
using Shared.EventBus.Implementation;
using Shared.EventBus.Structs;
using UnityEngine;

namespace Features.NPC.Cats.Shared.Scripts
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class DisplayAfterDoc : EventListenerBehaviour<DialogueInteractionEventArgs>
    {
        [SerializeField] private float duration = 0.5f;

        private SpriteRenderer _renderer;

        private void Awake()
        {
            _renderer = GetComponent<SpriteRenderer>();

            var c = _renderer.color;
            c.a = 0f;
            _renderer.color = c;
        }

        protected override void OnInvoked(DialogueInteractionEventArgs e)
        {
            if (e.Dialogue.Speaker == Speakers.Doc) FadeInOpacity();
        }

        private void FadeInOpacity()
        {
            StopAllCoroutines();
            StartCoroutine(FadeInRoutine());
        }

        private IEnumerator FadeInRoutine()
        {
            var c = _renderer.color;
            var time = 0f;

            while (time < duration)
            {
                time += Time.deltaTime;
                c.a = Mathf.Lerp(0f, 1f, time / duration);
                _renderer.color = c;
                yield return null;
            }

            c.a = 1f;
            _renderer.color = c;
        }
    }
}