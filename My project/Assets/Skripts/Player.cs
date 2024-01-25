using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Camera mainCamera;

    public Interactable previousInteractable;

    public GameObject TargetObj;
    private Interactable _light;

    private void Start()
    {
        _light = TargetObj.GetComponent<Interactable>();
    }

    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;


        if (Physics.Raycast(ray, out hit, 200))
        {
            var interactable = hit.collider.GetComponent<Interactable>();
            if (interactable != null)
            {
                if (interactable != previousInteractable)
                {
                    previousInteractable = interactable;
                    print("1");
                    _light.OnHoverEnter();
                }
            }
        }
        else
        {
            if (previousInteractable != null)
            {
                _light.OnHoverExit();
                print("2");
                previousInteractable = null;
            }

        }
    }

}
