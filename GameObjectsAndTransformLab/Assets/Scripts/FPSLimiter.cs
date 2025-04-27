    using UnityEngine;

    public class FPSLimiter : MonoBehaviour
    {
        public int TargetFrameRate = 60;

        void Start()
        {
            Application.targetFrameRate = TargetFrameRate;
        }
    }