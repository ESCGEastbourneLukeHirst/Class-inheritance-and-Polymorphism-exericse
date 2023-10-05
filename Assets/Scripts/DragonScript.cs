using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonScript : EnemyBase
{
    // Start is called before the first frame update
    void Start()
    {
        AttackPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void AttackPlayer()
    {
        print("Dragon is attacking player.");
    }
}
