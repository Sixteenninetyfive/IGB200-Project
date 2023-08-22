using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnimationTest : MonoBehaviour
{
    [Header("-------")]
    [Header("Head")]
    [SerializeField] private GameObject[] actuallityHead;
    [SerializeField] private MeshRenderer[] actuallityHands;
    [SerializeField] private Material[] colourSkin;
    [Header("Hair")]
    [SerializeField] private MeshRenderer[] actuallityHair;
    [SerializeField] private Material[] colourHair;
    [Header("Eyes")]
    [SerializeField] private MeshRenderer[] actuallityEyes;
    [SerializeField] private Material[] colourEyes;
    [Header("Clothes")]
    [SerializeField] private MeshRenderer[] actuallityClothes;
    [SerializeField] private Material[] colourClothes;
    [Header("-------")]
    [SerializeField] private GameObject[] targets;

    private MeshRenderer[] physicalHead;
    private MeshRenderer[] physicalHands;
    private MeshRenderer[] physicalHair;
    private MeshRenderer[] physicalEyes;
    private MeshRenderer[] physicalClothes;

    private int randomHead;
    private int randomHair;
    private int randomEyes;
    private int randomClothes;
    private int randomSkinColour;
    private int randomHairColour;
    private int randomEyesColour;
    private int randomClothesColour;
    private NavMeshAgent agent;

    private GameObject[][] actuallities;

void Start()
    {
        actuallities = new GameObject { actuallityHead };
        for (int i = 0; i < actuallityHead.Length; i++)
        {
            physicalHead[i] = actuallityHead[i].GetComponent<MeshRenderer>();
        }

        agent = GetComponent<NavMeshAgent>();
        ChangeCharacterAppererance();
    }

    void Update()
    {
        if (Input.GetKeyDown("z"))
            ChangeCharacterAppererance();
        if (Input.GetKeyDown("x"))
            Wave();
    }

    private void ChangeCharacterAppererance()
    {
        //Change physcial attributes
        randomHead = Random.Range(0, physicalHead.Length);
        randomHair = Random.Range(0, physicalHair.Length);
        randomEyes = Random.Range(0, physicalEyes.Length);
        randomClothes = Random.Range(0, physicalClothes.Length);
        ResetBodyParts();
        /*
        physicalHead[randomHead].SetActive(true);
        physicalHair[randomHair].SetActive(true);
        physicalEyes[randomEyes].SetActive(true);
        physicalClothes[randomClothes].SetActive(true);*/

        //Change colours
        randomSkinColour = Random.Range(0, colourSkin.Length);
        randomHairColour = Random.Range(0, colourEyes.Length);
        randomEyesColour = Random.Range(0, colourEyes.Length);
        randomClothesColour = Random.Range(0, colourClothes.Length);
        physicalHead[randomHead].materials[0].color = colourSkin[randomSkinColour].color;
        physicalHands[0].materials[0].color = colourSkin[randomSkinColour].color;
        physicalHair[randomHair].materials[0].color = colourHair[randomHairColour].color;
        physicalEyes[randomEyes].materials[0].color = colourEyes[randomEyesColour].color;
        physicalClothes[randomClothes].materials[0].color = colourClothes[randomClothesColour].color;

    }

    private void ResetBodyParts()
    {
        /*
        for (int i = 0; i < physicalHead.Length; i++)
        {
            actu[i].SetActive(false);
        }
        for (int i = 0; i < physicalHair.Length; i++)
        {
            physicalHair[i].SetActive(false);
        }
        for (int i = 0; i < physicalEyes.Length; i++)
        {
            physicalEyes[i].SetActive(false);
        }
        for (int i = 0; i < physicalClothes.Length; i++)
        {
            physicalClothes[i].SetActive(false);
        }
        */
    }

    public void WalkToDoor()
    {
        agent.SetDestination(targets[0].transform.position);
    }

    private void Wave()
    {

    }
}
