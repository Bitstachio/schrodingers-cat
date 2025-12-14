using System;
using Features.Panel.StaticPanel.Utils;
using Shared.EventBus.Structs;
using UnityEngine;
using UnityEngine.UI;

namespace Features.Panel.StaticPanel.Scripts.Panels
{
    public class LockPanel : MonoBehaviour
    {
        [SerializeField] private Toggle[] toggles;
        [SerializeField] private bool[] key;

        public event EventHandler<LockPanelAttemptUnlockEventArgs> UnlockAttempted;

        public void AttemptUnlock() => UnlockAttempted?.Invoke(this,
            new LockPanelAttemptUnlockEventArgs(LockPanelUtils.CheckLockCombination(toggles, key)));
    }
}