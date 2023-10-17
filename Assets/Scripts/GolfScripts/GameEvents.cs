using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public static class GameEvents
    {
        public static event System.Action onCollisionStones;
        public static event System.Action onStickHit;
        public static event System.Action onRestart;

        public static void StickHit()
        {
            onStickHit?.Invoke();
        }

        public static void CollisionStones(Stone stone)
        {
            onCollisionStones?.Invoke();
        }

        public static void RestartGame()
        {
            onRestart?.Invoke();
        }
    }
}

