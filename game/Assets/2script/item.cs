using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public enum Type {Ammo, coin, Grenade, Heart, Weapon};
    public Type type;
    public int value;
    public float rotate;

    private void Update()
    {
        transform.Rotate(Vector3.up * rotate * Time.deltaTime);
    }
}
