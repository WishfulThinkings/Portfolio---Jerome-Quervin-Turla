using UnityEngine;

public class Billboard : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void LateUpdate()
    {
        if (mainCamera != null)
        {

            Vector3 direction = mainCamera.transform.position - transform.position;
            direction.y = 0f;

            if (direction.sqrMagnitude > 0.001f)
            {
                Quaternion lookRotation = Quaternion.LookRotation(direction);

                transform.localRotation = Quaternion.Euler(0f, lookRotation.eulerAngles.y, 0f);
            }
        }
    }
}
