using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    [SerializeField] private Material[] shirts;
    [SerializeField] private SkinnedMeshRenderer characterShirt;

    private int newShirtNumber;

    void Start()
    {
        ChangeCharacterAppererance();
    }

    void Update()
    {
        if (Input.GetKeyDown("z"))
            ChangeCharacterAppererance();
    }

    private void ChangeCharacterAppererance()
    {
        newShirtNumber = Random.Range(0, 4);

        characterShirt.materials[0].color = shirts[newShirtNumber].color;
        characterShirt.materials[1].color = shirts[newShirtNumber].color;
    }
}
