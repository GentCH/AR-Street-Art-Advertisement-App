//Code to start animation according to device gyroscope.
//May not start animation on some device, due to device hardware issue (not compatiple to run AR)

public class RotationGyroscope : MonoBehaviour
{
    public float pitchValue = 0.0f;
    public AudioClip punchSound;
    AudioSource audioSource;
    public Animator animRight, animLeft;
    public GameObject background;

    void Start()
    {
        animRight.GetComponent<Animator>();
        animLeft.GetComponent<Animator>();
        animRight.Play("RightNo");
        animLeft.Play("LeftNo");
        Input.gyro.enabled = true;
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        pitchValue = Input.gyro.rotationRateUnbiased.x;
        if ((pitchValue > 4) && !audioSource.isPlaying)
        {
            background.SetActive(true);
            audioSource.PlayOneShot(punchSound);
            animRight.Play("rightAnim");
            animLeft.Play("leftAnim");
            Invoke("stopAnimation", 5);
        }
    }

    public void stopAnimation()
    {
        background.SetActive(false);
        animLeft.Play("LeftNo");
        animRight.Play("RightNo");
        audioSource.Stop();
    }
}
