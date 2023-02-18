using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public static LevelController Instance;

    private Camera mainCamera;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        mainCamera = Camera.main;
    }

    [Header("LevelWalls")]
    [SerializeField] private GameObject level1Wall;
    [SerializeField] private GameObject level2Wall;
    [SerializeField] private GameObject level3Wall;
    [SerializeField] private GameObject level4Wall;
    // Unused
    //[SerializeField] public GameObject level5Wall;
    [Header("Camera Positions")]
    [SerializeField] private Transform cameraPosition2;
    [SerializeField] private Transform cameraPosition3;
    [Header("GameObjects")]
    [SerializeField] public Transform completedGoal;
    

    public void LevelCleared(int level)
    {
        switch (level)
        {
            case 1:
                level1Wall.SetActive(false);
                mainCamera.transform.position = cameraPosition2.position;
                mainCamera.orthographicSize = 15;
                break;
            case 2:
                level2Wall.SetActive(false);
                break;
            case 3:
                level3Wall.SetActive(false);
                break;
            case 4:
                level4Wall.SetActive(false);
                mainCamera.transform.position = cameraPosition3.position;
                mainCamera.orthographicSize = 20;
                break;
            default:
                Debug.Log("Error, no such level.");
                break;
        }
    }
}
