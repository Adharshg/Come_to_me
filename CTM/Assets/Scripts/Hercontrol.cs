using System.Collections;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class Hercontrol : MonoBehaviour {

	//public GameObject Winscreen;	
	private Rigidbody rb;
	public float speed=100f;
	private int count;
	public GameObject mainCamera;
	//public Text countText;
	//public Text wintext;

	void Start(){
		rb = GetComponent<Rigidbody>();
		//isMoving = true;
		//count = 0;
		//SetCountText();
		//wintext.text="";
	}

	void FixedUpdate(){
		Vector3 fromCameraToMe = transform.position - mainCamera.transform.position;
		fromCameraToMe.y = 0;
		fromCameraToMe.Normalize();
		float moveHorizontal=Input.GetAxis("Horizontal");
		float moveVertical=Input.GetAxis("Vertical");

		Vector3 movement = (fromCameraToMe * moveVertical + mainCamera.transform.right * moveHorizontal) * speed;

		rb.AddForce(movement * speed);
	}
	/* 
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag("pick up")){
			other.gameObject.SetActive(false);
			count += 1;
			SetCountText();
		}
	}

	void SetCountText(){
		countText.text = count.ToString() + "/32 COINS";
		if(count>=1){
			wintext.text = "YOU WIN !!";
			countText.text="";
			Time.timeScale = 0f;
			Winscreendisp();
		}
	}

	public void Winscreendisp(){
		Winscreen.SetActive(true);
		gameObject.SetActive(false);
	}

	public void Restart(){
		SceneManager.LoadScene(1);
	}
	*/
}
