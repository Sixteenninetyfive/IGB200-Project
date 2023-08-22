using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(MeshFilter))]
//[RequireComponent(typeof(MeshRenderer))]

public class CharacterModelRandomisationTest : MonoBehaviour
{
    [SerializeField] SkinnedMeshRenderer skinnedMeshRenderer;
    [SerializeField] SkinnedMeshRenderer defaultBindPoses;

    private Animator animation;

    void Start()
    {
        MeshFilter[] meshFilters = GetComponentsInChildren<MeshFilter>();
        Debug.Log(meshFilters.Length);
        CombineInstance[] combine = new CombineInstance[meshFilters.Length];
        animation = gameObject.GetComponent<Animator>();

        for (int i = 0; i < meshFilters.Length; i++)
        {
            combine[i].mesh = meshFilters[i].sharedMesh;
            combine[i].transform = meshFilters[i].transform.localToWorldMatrix;
            meshFilters[i].gameObject.SetActive(false);
        }

        Mesh mesh = new Mesh();
        mesh.CombineMeshes(combine);
        mesh.bindposes = defaultBindPoses.sharedMesh.bindposes;
        //transform.GetComponent<MeshFilter>().sharedMesh = mesh;
        transform.gameObject.SetActive(true);
        skinnedMeshRenderer.sharedMesh = mesh;
        skinnedMeshRenderer.bones = defaultBindPoses.bones;

    }

    void Update()
    {
        if (Input.GetKeyDown("l"))
            animation.Play("Take 001");
    }
}
