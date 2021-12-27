using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BackMenu : MonoBehaviour ,IPointerClickHandler
{
    public int SceneIndexDestination = 0;
    public void OnPointerClick(PointerEventData e)
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(0);
    }
}
