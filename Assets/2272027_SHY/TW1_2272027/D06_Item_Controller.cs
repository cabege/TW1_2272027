using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D06_Item_Controller : MonoBehaviour
{

    private void OnMouseDown()
    {
        PrintInfo(); 
    }

    void PrintInfo()
    {
        print($"{gameObject.name}을/를 클릭했습니다.");
    }
}
