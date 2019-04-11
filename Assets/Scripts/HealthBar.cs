using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
   
    public Transform healthBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void healthCondition(float health)
    {
        if (health >= -0.1f)
        {
            healthBar.localScale = new Vector3(health,1f);

        }
       
        
      
        
        Debug.Log(health);
    }
}
