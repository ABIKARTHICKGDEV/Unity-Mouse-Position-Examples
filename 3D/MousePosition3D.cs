using UnityEngine;

public class MousePosition3D : MonoBehaviour
{
    [SerializeField] private Camera maincamera;
    [SerializeField] private LayerMask layerMask;
    
    
    void Update()
    {
        Ray ray = maincamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray,out RaycastHit raycastHit, float.MaxValue, layerMask)) 
        {
            transform.position = raycastHit.point;
            Debug.Log(raycastHit.point);
        }
    }
}
