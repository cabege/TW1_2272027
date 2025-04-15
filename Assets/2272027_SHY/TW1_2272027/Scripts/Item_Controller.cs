using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Item_Controller : MonoBehaviour

{

    private void OnMouseDown()

    {

        print($"{gameObject.name}을/를 클릭했습니다.");

    }


}