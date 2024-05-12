using UnityEngine;

namespace _Scripts.NavMeshPart.Influencer
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