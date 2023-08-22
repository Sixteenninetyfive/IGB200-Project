using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutilpleCharactersContoller : MonoBehaviour
{
    [SerializeField] private AnimationTest[] characters;

    private int currentCharacter = 0;

    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            characters[currentCharacter].WalkToDoor();
            if (currentCharacter < characters.Length)
                currentCharacter += 1;
        }
    }
}
