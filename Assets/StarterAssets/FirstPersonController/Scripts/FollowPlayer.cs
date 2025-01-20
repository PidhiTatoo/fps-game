using StarterAssets;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Transform target;

    NavMeshAgent agent;
    FirstPersonController Player;
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        Player = FindFirstObjectByType<FirstPersonController>();
    }

    void Update()
    {
        agent.SetDestination(Player.transform.position);
    }
}
