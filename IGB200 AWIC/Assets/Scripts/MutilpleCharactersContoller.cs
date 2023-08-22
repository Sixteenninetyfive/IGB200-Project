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
            if (currentCharacter >= -1 && characters.Length > currentCharacter)
            {
                characters[currentCharacter].WalkToDoor();
            }
            if (currentCharacter > 0 && characters.Length > currentCharacter - 1)
            {
                characters[currentCharacter - 1].WalkToCounter();
            }
            if (currentCharacter > 1 && characters.Length > currentCharacter - 2)
            {
                characters[currentCharacter - 2].WalkOut();
            }
            currentCharacter += 1;
        }
    }
}
