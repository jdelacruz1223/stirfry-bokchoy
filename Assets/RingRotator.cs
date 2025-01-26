using UnityEngine;

public class RingRotator : MonoBehaviour
{
    [SerializeField] float rotateForce = 100;

    public void RotateRing(Vector3 dir)
    {
        // rotate in direction of dir
        // let's not worry about slowing the ring back down just yet
        // +x dir = +y rot
        // -x dir = -y rot
        // +y dir = +x rot
        // -y dir = -x rot

        Vector3 rotDir = new Vector3(dir.y, dir.x, 0);
        rotDir = rotDir.normalized * rotateForce;
        transform.Rotate(rotDir);
    }
}
