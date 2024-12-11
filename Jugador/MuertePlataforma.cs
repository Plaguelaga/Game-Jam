using UnityEngine;
using UnityEngine.SceneManagement;

public class MuertePlataforma : MonoBehaviour
{

    public bool muerte;
    public BoxCollider2D platformCheck;
    public LayerMask platformMask;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void jugar(){
        SceneManager.LoadScene(2);
    }

    void FixedUpdate(){
        checkGround();
        if (muerte){
            SceneManager.LoadScene(2);
        }
    }

    void checkGround(){
        muerte = Physics2D.OverlapAreaAll(platformCheck.bounds.min, platformCheck.bounds.max,platformMask).Length >0;
    }
}
