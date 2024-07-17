using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public GameObject footstep;
    void Start()
    {
        footstep.SetActive(false);
    }
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.S))
        {
            footsteps();
        }
        if(Input.GetKeyUp(KeyCode.W)||Input.GetKeyUp(KeyCode.A)||Input.GetKeyUp(KeyCode.D)||Input.GetKeyUp(KeyCode.S))
        {
            StopFootsteps();
        }
    }
    void footsteps()
    {
        footstep.SetActive(true);
    }
    void StopFootsteps()
    {
        footstep.SetActive(false);
    }
}