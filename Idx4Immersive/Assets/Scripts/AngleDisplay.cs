using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngleDisplay : MonoBehaviour
{
    public LineRenderer rightAngleIndicator;
    public LineRenderer leftAngleIndicator;

    public Vector3 rightIndicatorEndpoint;
    public Vector3 leftIndicatorEndpoint;

     public GameObject rightIndicatorStartPoint;
    public GameObject leftIndicatorStartPoint;

    private Vector3 leftVector;
    private Vector3 rightVector;

    private Vector3 unitVectorA;
    private Vector3 unitVectorB;

    public float angleBetweenVectors;

    public Text angleValueDisplay;

    public GameObject leftMarkerObject;
    public GameObject rightMarkerObject;

    Vector3 leftMarkerPosition;
    Vector3 rightMarkerPosition;


    // Start is called before the first frame update
    void Start()
    {
        leftVector = new Vector3(); // (leftAngleIndicator.transform.position + leftindicatorEndPoint.transform.position);
        rightVector = new Vector3();
        unitVectorA = new Vector3();
        unitVectorB = new Vector3();

        angleValueDisplay = GetComponentInChildren<Text>();

        leftMarkerPosition = new Vector3();
        leftMarkerPosition = GameObject.Find("RedSpawner_Low").transform.position;

        Instantiate(leftMarkerObject, leftMarkerPosition, Quaternion.identity);

        rightMarkerPosition = new Vector3();
        rightMarkerPosition = GameObject.Find("BlueSpawner_Low").transform.position;

        Instantiate(rightMarkerObject, rightMarkerPosition, Quaternion.identity);

        leftIndicatorEndpoint = leftMarkerPosition;
        rightIndicatorEndpoint = rightMarkerPosition;

        leftVector = leftIndicatorStartPoint.transform.position + leftIndicatorEndpoint; 
        rightVector = rightIndicatorStartPoint.transform.position + rightIndicatorEndpoint; 

        CalculateAngle(leftVector, rightVector);
        
    }

   /// <summary>
   /// Update is called every frame, if the MonoBehaviour is enabled.
   /// </summary>
   void Update()
   {
        //rightAngleIndicator.SetPosition(0, rightVector);
        //leftAngleIndicator.SetPosition(0, leftVector);

        rightAngleIndicator.SetPosition(0, rightIndicatorStartPoint.transform.position);
        rightAngleIndicator.SetPosition(1, rightIndicatorEndpoint);

        leftAngleIndicator.SetPosition(0, leftIndicatorStartPoint.transform.position);
        leftAngleIndicator.SetPosition(1, leftIndicatorEndpoint);

   }
  

    public void CalculateAngle(Vector3 vectorA, Vector3 vectorB)
    {
        unitVectorA = vectorA / vectorA.magnitude;
        unitVectorB = vectorB / vectorB.magnitude;

        angleBetweenVectors = Mathf.Acos(Vector3.Dot(unitVectorA, unitVectorB));
        angleValueDisplay.text = (Mathf.Round(angleBetweenVectors * 10000f) / 100f).ToString() + " degrees";

    }
}
