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
        public static event System.Action onWin;
        public static event System.Action onExplosion;
        public static event System.Action onShaking;

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

        public static void Win()
        {
            onWin?.Invoke();
        }

        public static void Explose()
        {
            onExplosion?.Invoke();
        }

        public static void Shake()
        {
            onShaking?.Invoke();
        }

    }
}

