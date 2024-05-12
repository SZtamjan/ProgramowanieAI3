using Unity.AI.Navigation;
using UnityEngine;

namespace _Scripts.NavMeshPart
{
    public class NavMeshController : MonoBehaviour
    {
        private NavMeshSurface _navMeshSurface;

        private void Start()
        {
            _navMeshSurface = GetComponent<NavMeshSurface>();
        }

        private void Update()
        {
            //works but inefficient
            //_navMeshSurface.BuildNavMesh();
        }
    }
}