using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayGo : MonoBehaviour
{
    public Rigidbody2D Weal1;
    public Rigidbody2D Weal2;
    public Rigidbody2D CarPlayer;
    private float Move ;
    public float spead  = 20 ;
    public float coup  = 20 ;
    public static float fuel  = 1f ;
    private float fuelC  = 0.01f ;
    public Image ImageFuel;
    
    private void Update() 
    {
        ImageFuel.fillAmount = fuel ;
    }
    
    
    
     void FixedUpdate() 
    {
        if(fuel > 0)
        {
            Weal1.AddTorque(-Move * spead * Time.fixedDeltaTime);
        Weal2.AddTorque(-Move * spead * Time.fixedDeltaTime);
        CarPlayer.AddTorque(-Move * coup * Time.fixedDeltaTime);
        }
        
        

        
        
        fuel -= fuelC * Mathf.Abs(Move)* Time.fixedDeltaTime;
    }
    public void OnGoButtonClicked()
    {
        Move = 10;
        
    }
       public void OnStopButtonClicked()
    {
        Move = -10;
        
    }
    public void OnUpButtonClicked()
    {
        Move = 0;
        
    }
    
    
}
