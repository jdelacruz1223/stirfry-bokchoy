using UnityEngine;

public class RingRotator : MonoBehaviour
{
    [SerializeField] float rotateForce = 100;

    public void RotateRing(Vector3 dir)
    {
        Vector3 rotDir = new Vector3(dir.y, dir.x, 0);
        rotDir = rotDir.normalized * rotateForce;
        transform.Rotate(rotDir);
    }
}
