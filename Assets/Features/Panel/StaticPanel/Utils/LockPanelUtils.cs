using System.Linq;
using Features.Panel.StaticPanel.Exceptions;
using UnityEngine.UI;

namespace Features.Panel.StaticPanel.Utils
{
    public static class LockPanelUtils
    {
        public static bool CheckLockCombination(Toggle[] toggles, bool[] key)
        {
            if (toggles.Length != key.Length) throw new ToggleLengthMismatchException(toggles.Length, key.Length);
            return !toggles.Where((t, i) => t.isOn != key[i]).Any();
        }
    }
}