using UnityEngine;

public class Drone : MonoBehaviour
{
    [SerializeField] private Transform droneTransform;
    //[SerializeField] private GameObject drone;
    [SerializeField] private Collider playerCollider;
    public Transform pointer;

    void Update()
    {
        Raycast();
    }

    private void Raycast()
    {
        Ray ray = new Ray(droneTransform.transform.position, droneTransform.transform.forward);
        Debug.DrawRay(droneTransform.transform.position, droneTransform.transform.forward * 100, Color.yellow   );
        if (Physics.Raycast(ray, out RaycastHit hit, 1000))
        {
            pointer.position = hit.point;   
            //hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            if (hit.collider.gameObject.tag == "Player")
            {
                Debug.Log(hit.collider.gameObject.name);
            }
            //GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = hit.point;
        }
    }
}
