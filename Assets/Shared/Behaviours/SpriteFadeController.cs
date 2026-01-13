using System.Collections;
using Shared.Constants;
using Shared.Utils;
using UnityEngine;

namespace Shared.Behaviours
{
    [RequireComponent(typeof(Collider2D))]
    public sealed class SpriteFadeController : MonoBehaviour
    {
        private const float MinAlpha = 0f;
        private const float MaxAlpha = 1f;

        [SerializeField] private SpriteRenderer spriteRenderer;
        [SerializeField] private float duration = 0.5f;
        [SerializeField] private bool persist;

        private Coroutine _fadeRoutine;

        private void OnValidate() => ComponentValidationUtils.ValidateSingleTrigger(GetComponents<Collider2D>());

        private void Awake() => SetAlpha(MinAlpha);

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

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag(Tags.Player)) FadeTo(MaxAlpha);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (!persist && other.CompareTag(Tags.Player)) FadeTo(MinAlpha);
        }
    }
}