using UnityEngine;
using UnityEngine.Playables;

public class playButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public GameObject button;
    public PlayableDirector play;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("PlayScene"))
        {

            play.Play();




            button.gameObject.SetActive(false);
        }
    }
}
