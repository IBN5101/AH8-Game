using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class LevelController : MonoBehaviour
{
    public static LevelController Instance;

    private void Awake()
    {
        Instance = this;
    }

    [Header("LevelWalls")]
    [SerializeField] private GameObject level1Wall;
    [SerializeField] private GameObject level2Wall;
    [SerializeField] private GameObject level3Wall;
    [SerializeField] private GameObject level4Wall;
    // Unused
    //[SerializeField] public GameObject level5Wall;
    [Header("Camera")]
    [SerializeField] private CinemachineVirtualCamera virtualCamera1;
    [SerializeField] private CinemachineVirtualCamera virtualCamera2;
    [SerializeField] private CinemachineVirtualCamera virtualCamera3;
    //[SerializeField] private Transform cameraPosition1;
    //[SerializeField] private Transform cameraPosition2;
    //[SerializeField] private Transform cameraPosition3;
    [Header("Goals")]
    [SerializeField] private GameObject goal2;
    [SerializeField] private GameObject goal3;
    [SerializeField] private GameObject goal4;
    [SerializeField] private GameObject goal5;
    [Header("GameObjects")]
    [SerializeField] public Transform completedGoal;

    private void Start()
    {
        virtualCamera1.m_Priority = 10;

        goal2.SetActive(false);
        goal3.SetActive(false);
        goal4.SetActive(false);
        goal5.SetActive(false);
    }

    public void LevelCleared(int level)
    {
        switch (level)
        {
            case 1:
                level1Wall.SetActive(false);
                goal2.SetActive(true);
                virtualCamera2.m_Priority = 11;
                break;
            case 2:
                level2Wall.SetActive(false);
                goal3.SetActive(true);
                break;
            case 3:
                level3Wall.SetActive(false);
                goal4.SetActive(true);
                break;
            case 4:
                level4Wall.SetActive(false);
                goal5.SetActive(true);
                virtualCamera3.m_Priority = 12;
                break;
            default:
                Debug.Log("Error, no such level.");
                break;
        }
    }
}
