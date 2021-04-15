using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceManager : MonoBehaviour
{
    public enum PieceType { Pawn, King };
    public PieceType myPieceType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(myPieceType == PieceType.King)
        {
            //i am a king
            
        }

        if(myPieceType == PieceType.Pawn)
        {
            //i am a pawn.
        }

    }
}
