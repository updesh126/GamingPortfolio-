using System;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class GetWebReq : MonoBehaviour
{
    void Start()
    {
    
       // StartCoroutine(GetUser());
        StartCoroutine(Login("testuser","123456"));

    }

  /*  IEnumerator GetData()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/backend/GetDate.php"))
        {
            // Request and wait for the desired page.
            yield return www.SendWebRequest();

            if (www.isNetworkError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }*/

   /* IEnumerator GetUser()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost/backend/GetUser.php"))
        {
            // Request and wait for the desired page.
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }*/

    IEnumerator Login(String username, String password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPass", password);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/backend/Login.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }
}
