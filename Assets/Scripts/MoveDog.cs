using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDog : MoveAnimal
{
    protected override void Mueve()
    {
        transform.Translate(Vector3.right * 3 * Time.deltaTime);
    }
    
    // Update is called once per frame
    void Update()
    {
        Mueve();
    }
}
