using System;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class BadBoyTouch : MonoBehaviour
{
    [SerializeField]
    private Camera arCamera;

    private Vector2 touchPosition = default;

    private int score = 0;

    void Start()
    {

    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            touchPosition = touch.position;

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = arCamera.ScreenPointToRay(touch.position);
                RaycastHit hitObject;
                if (Physics.Raycast(ray, out hitObject))
                {
                    Debug.Log("Clicked on " + hitObject.transform.name);
                    GameObject touchedObj = hitObject.transform.gameObject;
                    //GameObject touchedObject = hitObject.transform.GetComponent<GameObject>();
                    if (touchedObj != null)
                    {
                        if(hitObject.transform.CompareTag("GoodBoy"))
                        {
                            //hitObject.transform.localScale = hitObject.transform.localScale * 2;
                            //transform.position = hitObject.point;
                            SceneManager.LoadScene("GoodBoyCaughtScreen");
                            score -= 1;
                        }
                        else
                        {
                            score += 1;
                            SceneManager.LoadScene("BadBoyCaughtScreen");
                        }
                        Debug.Log(touchedObj.name);
                        //MeshRenderer meshRenderer = targetObject.GetComponent<MeshRenderer>();
                        //meshRenderer.material.color = activeColor;
                    }
                }
            }
        }
    }
}