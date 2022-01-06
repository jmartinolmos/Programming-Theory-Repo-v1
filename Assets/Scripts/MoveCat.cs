using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCat : MoveAnimal
{

    protected override void Mueve()
    {
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Mueve();
    }
}
