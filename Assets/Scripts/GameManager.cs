using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform playerTransform;
    
    // Start is called before the first frame update
    private void Start()
    {
    
    
    }
        
    
    // Update is called once per frame
    private void Update()
    {
    }

    public void Restart()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        playerTransform.position = new Vector3(-10.53f, 6.74f, 0f);
        playerTransform.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
}