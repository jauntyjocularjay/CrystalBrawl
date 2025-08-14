using UnityEngine;
using DMBTools;



public class Bladekeeper : BoxPlayer
{
    public override int HP() => base.hp;
    public override void HP(int i) => hp = i;
    public override void IncrementHP(int i) => hp += i;
    public override void DecrementHP(int i) => hp -= i;
}
