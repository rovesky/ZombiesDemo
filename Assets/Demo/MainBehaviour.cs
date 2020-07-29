//using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

namespace FootStone.Kitchen
{
    public class MainBehaviour : MonoBehaviour
    {
        private int frameCount;
        private float passedTime;
        public Text text_fps;


        // Start is called before the first frame update
        private void Start()
        {
         
        }

        // Update is called once per frame
        private void Update()
        {
       
            frameCount++;
            passedTime += UnityEngine.Time.unscaledDeltaTime;
            if (passedTime >= 1.5f && frameCount>=1)
            {
                var fps = frameCount / passedTime;
                text_fps.text = fps.ToString("#.00");
                // UIManager.Instance.UpdateFps(frameCount / passedTime);
                frameCount = 0;
                passedTime = 0.0f;

            }

        }
    }
}