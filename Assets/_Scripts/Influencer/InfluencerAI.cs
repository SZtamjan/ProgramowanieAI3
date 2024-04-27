using System;
using UnityEngine;

namespace _Scripts.Influencer
{
    public class InfluencerAI : MonoBehaviour
    {
        public static InfluencerAI Instance;

        private void Awake()
        {
            Instance = this;
        }
    }
}