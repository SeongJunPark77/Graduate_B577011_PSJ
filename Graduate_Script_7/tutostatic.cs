using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutostatic : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        archerhp.archer_hp = 100;
        archermp.archer_mp = 0;
        Damage.aratk = 10;
        Damage.arskill = 20;

        wizardhp.wizard_hp = 100;
        wizardmp.wizard_mp = 0;
        Damage.wizatk = 20;
        Damage.wizskill = 40;

        knighthp.knight_hp = 350;
        knightmp.knight_mp = 0;
        Damage.kniatk = 15;
        Damage.kniskill = 30;

        warlordhp.warlord_hp = 140;
        warlordmp.warlord_mp = 0;
        Damage.waratk = 34;
        Damage.warskill = 55;

        godpoint.god_point = 0;

        Damage.icebombdamage = 3;
        Damage.snowraindamage = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
