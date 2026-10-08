using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject driverToFollow;
    void LateUpdate()
    {
        transform.position = driverToFollow.transform.position + new Vector3 (0, 0, -10);
    }
}
