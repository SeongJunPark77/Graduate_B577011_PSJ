using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticgo : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        archerhp.archer_hp = 100f;
        archermp.archer_mp = 10;
        Damage.aratk = 10;
        Damage.arskill = 20;

        wizardhp.wizard_hp = 100f;
        wizardmp.wizard_mp = 10;
        Damage.wizatk = 20;
        Damage.wizskill = 20;

        knighthp.knight_hp = 350f;
        knightmp.knight_mp = 10;
        Damage.kniatk = 3;
        Damage.kniskill = 30;

        warlordhp.warlord_hp = 140f;
        warlordmp.warlord_mp = 10;
        Damage.waratk = 25;
        Damage.warskill = 50;

        godpoint.god_point = 0;

        Damage.icebombdamage = 1;
        Damage.snowraindamage = 2;
           
    }

    private void Update()
    {
        if(archermp.archer_mp>10)
        {
            archermp.archer_mp--;
        }

        if(archerhp.archer_hp>100)
        {
            archerhp.archer_hp--;
        }

        if(wizardhp.wizard_hp>100)
        {
            wizardhp.wizard_hp--;
        }

        if(wizardmp.wizard_mp>10)
        {
            wizardmp.wizard_mp--;
        }

        if(knighthp.knight_hp>350)
        {
            knighthp.knight_hp--;
        }

        if(knightmp.knight_mp>10)
        {
            knightmp.knight_mp--;
        }

        if(warlordhp.warlord_hp>140)
        {
            warlordhp.warlord_hp--;
        }

        if(warlordmp.warlord_mp>10)
        {
            warlordmp.warlord_mp--;
        }
    }


}
