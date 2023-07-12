using UnityEngine;

public class CursorLocker : MonoBehaviour
{
    private void Start()
    {
        SetCursorLockState(CursorLockMode.Locked);
    }
    public void SetCursorLockState(CursorLockMode lockState)
    {
        Cursor.lockState = lockState;
    }
}
