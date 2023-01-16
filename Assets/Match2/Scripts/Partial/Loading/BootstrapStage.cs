using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Match2.Scripts.Partial.Loading
{
    public class BootstrapStage : MonoBehaviour
    {
        private void Start()
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
