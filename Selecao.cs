using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selecao : MonoBehaviour
{

 
    private void OnMouseDown()
    {
        Debug.Log("foi clicado");
 GameObject testPrefab = GameObject.Find("Led");
Vector3 objectPOS = this.transform.position;
objectPOS.z = objectPOS.z + 0.09f;
GameObject newGameObject = Instantiate(testPrefab, objectPOS, Quaternion.identity);
}
}
