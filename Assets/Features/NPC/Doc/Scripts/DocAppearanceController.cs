using System.Collections;
using UnityEngine;

namespace Features.NPC.Doc.Scripts
{
    // TODO: This script can be generalized and used as a shared utility
    [RequireComponent(typeof(Collider2D), typeof(SpriteRenderer))]
    public class DocAppearanceController : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer spriteRenderer;
        [SerializeField] private float duration = 0.5f;

        private Coroutine _fadeRoutine;

        private void Awake() => SetAlpha(0f);

        private void FadeTo(float targetAlpha)
        {
            if (_fadeRoutine != null) StopCoroutine(_fadeRoutine);
            _fadeRoutine = StartCoroutine(FadeRoutine(targetAlpha));
        }

        private IEnumerator FadeRoutine(float targetAlpha)
        {
            var startAlpha = spriteRenderer.color.a;
            var time = 0f;

            while (time < duration)
            {
                time += Time.deltaTime;
                var alpha = Mathf.Lerp(startAlpha, targetAlpha, time / duration);
                SetAlpha(alpha);
                yield return null;
            }

            SetAlpha(targetAlpha);
            _fadeRoutine = null;
        }

        private void SetAlpha(float alpha)
        {
            var color = spriteRenderer.color;
            color.a = alpha;
            spriteRenderer.color = color;
        }

        private void OnTriggerEnter2D(Collider2D other) => FadeTo(1f);
        private void OnTriggerExit2D(Collider2D other) => FadeTo(0f);
    }
}