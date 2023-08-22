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
    [SerializeField] private GameObject[] actuallityHair;
    [SerializeField] private Material[] colourHair;
    [Header("Eyes")]
    [SerializeField] private GameObject[] actuallityEyes;
    [SerializeField] private Material[] colourEyes;
    [Header("Clothes")]
    [SerializeField] private GameObject[] actuallityClothes;
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

void Start()
    {
        //Get meshes of each part of the character
        //Head
        physicalHead = new MeshRenderer[actuallityHead.Length];
        for (int i = 0; i < actuallityHead.Length; i++)
        {
            physicalHead[i] = actuallityHead[i].GetComponent<MeshRenderer>();
        }
        //Hands
        physicalHands = new MeshRenderer[actuallityHands.Length];
        for (int i = 0; i < actuallityHands.Length; i++)
        {
            physicalHands[i] = actuallityHands[i].GetComponent<MeshRenderer>();
        }
        //Hair
        physicalHair = new MeshRenderer[actuallityHair.Length];
        for (int i = 0; i < actuallityHair.Length; i++)
        {
            physicalHair[i] = actuallityHair[i].GetComponent<MeshRenderer>();
        }
        //Eyes
        physicalEyes = new MeshRenderer[actuallityEyes.Length];
        for (int i = 0; i < actuallityEyes.Length; i++)
        {
            physicalEyes[i] = actuallityEyes[i].GetComponent<MeshRenderer>();
        }
        //Clothes
        physicalClothes = new MeshRenderer[actuallityClothes.Length];
        for (int i = 0; i < actuallityClothes.Length; i++)
        {
            physicalClothes[i] = actuallityClothes[i].GetComponent<MeshRenderer>();
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
        actuallityHead[randomHead].SetActive(true);
        actuallityHair[randomHair].SetActive(true);
        actuallityEyes[randomEyes].SetActive(true);
        actuallityClothes[randomClothes].SetActive(true);

        //Change colours
        randomSkinColour = Random.Range(0, colourSkin.Length);
        randomHairColour = Random.Range(0, colourHair.Length);
        randomEyesColour = Random.Range(0, colourEyes.Length);
        randomClothesColour = Random.Range(0, colourClothes.Length);

        //Set new colours
        physicalHead[randomHead].materials[0].color = colourSkin[randomSkinColour].color;
        physicalHands[0].materials[0].color = colourSkin[randomSkinColour].color;
        physicalHair[randomHair].materials[0].color = colourHair[randomHairColour].color;
        physicalEyes[randomEyes].materials[0].color = colourEyes[randomEyesColour].color;
        physicalClothes[randomClothes].materials[0].color = colourClothes[randomClothesColour].color;

    }

    private void ResetBodyParts()
    {
        for (int i = 0; i < actuallityHead.Length; i++)
        {
            actuallityHead[i].SetActive(false);
        }
        for (int i = 0; i < actuallityHair.Length; i++)
        {
            actuallityHair[i].SetActive(false);
        }
        for (int i = 0; i < actuallityEyes.Length; i++)
        {
            actuallityEyes[i].SetActive(false);
        }
        for (int i = 0; i < actuallityClothes.Length; i++)
        {
            actuallityClothes[i].SetActive(false);
        }
    }

    public void WalkToDoor()
    {
        agent.SetDestination(targets[0].transform.position);
    }

    public void WalkToCounter()
    {
        agent.SetDestination(targets[1].transform.position);
    }

    public void WalkOut()
    {
        agent.SetDestination(targets[2].transform.position);
    }

    private void Wave()
    {

    }
}
