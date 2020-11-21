using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheat_golem : MonoBehaviour
{
    // Start is called before the first frame update
    public void clicked()
    {
        golem_main witch = GameObject.Find("golem").GetComponent<golem_main>();

        witch.hp = witch.hp - 500;
    }
}
