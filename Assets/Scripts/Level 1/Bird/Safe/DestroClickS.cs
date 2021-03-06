using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroClickS : MonoBehaviour
{

  public GameObject Bird;
  public Variables p_score;
  public bool flag =false;
  AudioSource m_shootingSound;
  void Start()
  {
    m_shootingSound = GetComponent<AudioSource>();
  }
  void Update() 
  {  
    if (Input.GetMouseButtonDown(0)) 
    {  
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      RaycastHit hit;  
      if (Physics.Raycast(ray, out hit)) 
      {  
        //Select stage    
        m_shootingSound.Play();
        if (hit.transform.name == "BirdSafe") 
        {  
            Bird.SetActive(false);
            p_score.value+=10;
            flag=true;
        }  
      }  
    }  
  }   
}
