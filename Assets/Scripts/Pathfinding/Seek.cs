using UnityEngine;

namespace Pathfinding
{
    public class Seek : PathfindingBehaviour
    {
        protected override void Update()
        {
            DestTarget.position = Ball.transform.position;
        }
    }
}
