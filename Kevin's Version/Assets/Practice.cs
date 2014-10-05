
using System;

namespace AssemblyCSharp{
	public class Practice{
		public Practice (){
			//Debug.Log (55);
			//coffeeTemperature -= Time.deltaTime * 5f;
			//myLight.enabled = !myLight.enabled;
			//gameObject.setActive(false);

			//public GameObject myObject;
			//Debug.Log("Active Self: " + myObject.activeSelf);
			//Debug.Log("Active in Hierarchy: " + myObject.activeInHierarchy);

			//transform.Translate(new Vector3(0,0,1) * Time.deltaTime);//meters/second vs meters/frame
			//if(Input.GetKey(KeyCode.UpArrow))
			//transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
			//transform.Rotate(Vector3.up, turnspeed * Time.deltaTime);//relative to object's axis, not world axis

			//public Transform target;
			//transform.LookAt(target);
			////now drag object from hierarchy to inspector
			 
			//transform.position = Vector3.Lerp(transform.position. newPosition, Time.deltaTime *smooth);
			//light.intensity = Mathf.Lerp(light.intensity, newIntensity, Time.deltaTime * smooth);
			//light.color = Mathf.Lerp(light.color, newColor, Time.deltaTime * smooth);

			//Destroy (gameObject, 3);//optional 2nd argument for delay in seconds
			//public GameObject other;
			//Destroy (other);
			//Destroy (GetComponent<MeshRenderer>());

			//Input.GetButtonDown("Jump");//see edit>project settings>input
			//GetButtonDown, GetButton, and GetButtonUp
			//edit>project settings>input
			//gravity-how quickly it gots back to 0; sensitivity-how quickly it goes to +/-1
			//dead-how much joystick must be moved; snap-returns to zero if positive&negative buttons both held
			//Input.GetAxis("Horizontal") or ("Vertical");
			//Input.GetAxisRaw("Horizontal");//for only whole numbers
			//void OnMouseDown(){rigidbody.AddFroce(transform.forward * 500); rigidbody.useGravity=true;}

			//public GameObject otherGameObject;
			//private AnotherScript anotherScript;
			//in Awake: anotherScript = GetComponent<AnotherScript>();//<type>
			//			yetAnotherScript = otherGameObject.GetComponent<Yet...>();//get from another game object
			//boxCol = otherGameObject.GetComponent<BoxCollider>();
			//boxCol.size = new Vector3(3,3,3);

			//Transform tran = transform;
			//tran.position = new Vector3(0,2,0);

			//deltaTime uses seconds, not frame

			//public Rigidbody rocketPrefab; 
			//in Update: if (Input.GetButtonDown("Fire1")){Instantiate(rocketPrefab);}
			//{Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation);//uses empty gameObject at barrel end
			//drag empty object into script
			//Rigidbody rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
			//rocketInstance.AddForce(barrelEnd.foward * 5000);
			//prefab's rocket destruction script: void Start(){Destroy (gameObject, 1.5f);}

			//public GameObject[] players;
			//players = GameObject.FindGameObjectsWithTag("Player");

			//in start: invoke("SpawnObject", 2);//only methods w/ no parameters will work//3rd parameters = seconds between repeating calls
			//Instantiate(target, new Vector3(x, 2, z), Quaternion.identity);
			//CancelInvoke("SpawnObject");
		}
	}
}

