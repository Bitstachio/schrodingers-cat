using Shared.Exceptions;
using UnityEngine;

namespace Shared.Utils
{
    public static class ComponentValidationUtils
    {
        /// <summary>
        /// Validates that the provided collection of <typeparamref name="T"/> colliders contains exactly one element,
        /// and ensures that this collider is configured as a trigger.
        ///
        /// This utility assumes that the caller uses <see cref="RequireComponent"/> to guarantee that at least one
        /// collider of type <typeparamref name="T"/> exists.
        /// </summary>
        /// <param name="colliders">The array of colliders to validate</param>
        /// <typeparam name="T">The collider type being validated</typeparam>
        /// <exception cref="TooManyComponentsException">Thrown when more than one collider is provided</exception>
        /// <exception cref="ColliderNotTriggerException">Thrown when `isTrigger` is not checked</exception>
        public static void ValidateSingleTrigger<T>(T[] colliders) where T : Collider2D
        {
            const int maxAllowed = 1;
            if (colliders.Length > maxAllowed)
                throw new TooManyComponentsException(typeof(T), maxAllowed, colliders.Length);
            if (!colliders[0].isTrigger) throw new ColliderNotTriggerException();
        }
    }
}