using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChuckNorris : MonoBehaviour
{
    public TextMeshProUGUI jokeText;
    public void NewJoke(){
        //Aquí agregaremos el código para llamar el API
        Joke j = APIHelper.GetNewJoke();
        jokeText.text = j.value;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
