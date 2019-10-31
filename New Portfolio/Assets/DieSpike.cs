using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieSpike : MonoBehaviour
{
    BoxCollider2D myBodyCollider;
    // Start is called before the first frame update
    void Start()
    {
        myBodyCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Die();
    }
    private void Die()
    {
        if (myBodyCollider.IsTouchingLayers(LayerMask.GetMask("Hazards")))
        {
            SceneManager.LoadScene(0);
        }
    }
}
