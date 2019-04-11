using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroyer : MonoBehaviour
{
    private ParticleSystem particleSys;
    // Start is called before the first frame update
    void Start()
    {
        particleSys = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!particleSys.IsAlive())
        {
            Destroy(gameObject);
        }
    }
}
