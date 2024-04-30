using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LuigiTrigger : MonoBehaviour
{
    [SerializeField] public GameObject Text1;
    [SerializeField] public GameObject gameObj;

    private void Start()
    {
        Text1.SetActive(false);
    }

    public void OnTriggerEnter(Collider collision)
    {
        gameObj.transform.eulerAngles = new Vector3(
        gameObj.transform.eulerAngles.x,
        gameObj.transform.eulerAngles.y + 40,
        gameObj.transform.eulerAngles.z
);
    }
    public void OnTriggerStay(Collider collision)
    {
        Text1.SetActive(true);
    }

    public void OnTriggerExit(Collider collision)
    {
        Text1.SetActive(false);
    }



}