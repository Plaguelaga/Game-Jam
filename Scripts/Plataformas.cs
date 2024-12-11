using UnityEngine;
using UnityEngine.Tilemaps;

public class Plataformas : MonoBehaviour
{
    //Aquí se agarra el objeto de la plataforma que queremos desactivar directamente y se desactiva y reactiva dependiendo
    //de lo que quiera hacer el jugador
    public TilemapRenderer tilemap;
    public TilemapCollider2D tilebody; 
    bool renderbool;
    bool collbool;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            if (tilemap.enabled == true){
            renderbool = false;
            collbool = false;
            }
            if(tilemap.enabled == false){
                renderbool = true;
                collbool = true;
            }
        }

        tilemap.enabled = renderbool;
        tilebody.enabled = collbool;
    }

}
