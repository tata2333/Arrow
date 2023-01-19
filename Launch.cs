using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{

    [SerializeField] Dart dartPrefab;
    Dart currentlyLoadedDart;
    private void Start()
    {
        SpawnDart();
    }
    void SpawnDart() 
    {
        currentlyLoadedDart = Instantiate(dartPrefab, transform.position, Quaternion.identity);
    }
    private void Update()
    {
        if (currentlyLoadedDart != null && Input.GetKeyDown(KeyCode.Space)) 
        {
            currentlyLoadedDart.Fire();
            currentlyLoadedDart = null;

            Invoke(nameof(SpawnDart), 1);
        }

    }
}
