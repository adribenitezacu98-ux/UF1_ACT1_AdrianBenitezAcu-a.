using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;
using UnityEngine.Video;

public class Script_Vida : MonoBehaviour
{
    [SerializeField] public int vida = 10;
    public const int MAXHP = 10;
    public const int MINHP = 0;

    public bool vivo = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    public void TakeDmg()
    {
        if (vida > MINHP) { vida--; }
        if (vida == MINHP)
        {
            vivo = false;
        }
        
    }

    public void HealDmg()
    {
        if (vida > MINHP && vida < MAXHP) { vida++; }
        
    }


    public void KillCharacter()
    {
        if (vida > MINHP)
        {
            vida = MINHP;
            vivo = false;
        }
        
    }

    public void Revivecharacter()
    {
        if (vida == MINHP)
        {
            vida = MAXHP;
            vivo = true;
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
