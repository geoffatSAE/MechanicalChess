using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    public GameObject myCubePrefab;
    public int numberOfCubes;

    public List<GameObject> myLights = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < numberOfCubes; i++) {

            GameObject myLight;
            myLight = Instantiate(myCubePrefab, new Vector3(i*2, 3.49f, 0.0f), Quaternion.identity) as GameObject;

            //myLight.AddComponent<Light>();
            //myLight.GetComponent<Light>().intensity = 10.0f;
            myLights.Add(myLight);
        }
        //prefab 




        // primatives

        // check is light is in primatives, else objec t and add lgiht component

        TurnOffTheLights();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOffTheLights()
    {
        foreach (GameObject myCeilingLight in myLights)
        {
            Light theLightOfTheChild = myCeilingLight.GetComponentInChildren<Light>();
            theLightOfTheChild.intensity = 0.0f;
        }
    }
}
