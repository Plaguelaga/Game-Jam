using UnityEngine;

public class Platsuelo : MonoBehaviour
{
    public BoxCollider2D sueloPlat;
    bool Suelobool;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            if(sueloPlat.enabled == false){
                Suelobool = true;
            }
            if(sueloPlat.enabled == true){
                Suelobool = false;
            }
        }
        sueloPlat.enabled = Suelobool;
    }
}
