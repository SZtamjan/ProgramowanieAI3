using _Scripts.NavMeshPart.Influencer;
using UnityEngine;
using UnityEngine.AI;

namespace _Scripts.NavMeshPart.Follower
{
    public class FollowerAI : MonoBehaviour
    {
        [SerializeField] private float stopDistance = 5f;
        
        private GameObject _influencer;
        private NavMeshAgent _navMeshAgent;
        private void Start()
        {
            if (InfluencerAI.Instance != null)
            {
                _influencer = InfluencerAI.Instance.gameObject;
            }
            else
            {
                Debug.LogWarning("Brak Influencera, Followersi nie beda juz nikogo podazac");
            }
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            if (_influencer == null) return;
            
            if (Vector3.Distance(_influencer.transform.position, gameObject.transform.position) > stopDistance)
            {
                _navMeshAgent.isStopped = false;
            }
            else
            {
                _navMeshAgent.isStopped = true;
            }
            
            _navMeshAgent.destination = _influencer.transform.position;
        }
    }
}