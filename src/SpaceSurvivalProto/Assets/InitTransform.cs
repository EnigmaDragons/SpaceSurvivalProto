using UnityEngine;

public class InitTransform : MonoBehaviour
{
    [SerializeField] private Transform initialState;
    [SerializeField] private GameObject target;

    private void Awake()
    {
        target.transform.position = initialState.position;
        target.transform.rotation = initialState.rotation;
    }
}
