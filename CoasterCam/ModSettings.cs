using UnityEngine;

namespace CoasterCam
{
    public class ModSettings
    {
        private const string SmoothingKey = "CoasterCam_SmoothingAmount";
        public const float DefaultSmoothing = 0.15f;

        public float SmoothingAmount
        {
            get { return PlayerPrefs.GetFloat(SmoothingKey, DefaultSmoothing); }
            set
            {
                PlayerPrefs.SetFloat(SmoothingKey, Mathf.Clamp01(value));
                if (CoasterCam.Instance != null)
                    CoasterCam.Instance.SmoothingAmount = value;
            }
        }

        public void LoadSettings()
        {
            if (CoasterCam.Instance != null)
                CoasterCam.Instance.SmoothingAmount = SmoothingAmount;
        }

        public void Save()
        {
            PlayerPrefs.Save();
        }
    }
}
