using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveAnimal : MonoBehaviour
{
    protected virtual void Mueve()
    {
        transform.Translate(Vector3.right * 10 * Time.deltaTime);
    }

    public virtual void GoTo(Vector3 position)
    {
        //we don't have a target anymore if we order to go to a random point.
        /* m_Target = null;
        m_Agent.SetDestination(position);
        m_Agent.isStopped = false;
        */
    }
}
