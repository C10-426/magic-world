using UnityEngine;
public class TargetDetector
{
    public static bool InSight(Transform who, Transform target)
    {
        if(Vector3.Distance(who.position,  target.position) < 3)
        {
            return true;
        }
        return false;
    }
}