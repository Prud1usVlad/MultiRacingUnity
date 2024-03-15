using Assets.Scripts.DataContainers;
using Assets.Scripts.Network.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets.Scripts.Network
{
    public class HttpService : MonoBehaviour
    {
        private readonly string _url = "https://multiracingapi.onrender.com/";

        private Dictionary<string, string> basicHeaders = new Dictionary<string, string>()
        {
            { "Content-Type", "application/json" }
        };

        public static HttpService Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }

        }

        public GameData gameData;

        public void Login(string username, string password, Action callback, Action<string> failCallback)
        {
            var data = new AuthModel { password = password, username = username };

            var json = JsonUtility.ToJson(data);

            StartCoroutine(BaseRequest(_url + "login", HttpMethod.Post, json, 
                (t) =>
                {
                    ManageAuthResponse(t);
                    callback();
                },
                failCallback
            ));
        }

        public void Register(string username, string password, Action callback, Action<string> failCallback)
        {
            var data = new AuthModel { password = password, username = username };

            var json = JsonUtility.ToJson(data);

            StartCoroutine(BaseRequest(_url + "register", HttpMethod.Post, json, 
                (t) =>
                {
                    ManageAuthResponse(t);
                    callback();
                },
                failCallback
            ));
        }

        public void GetUserData(string userId, Action callback, Action<string> failCallback)
        {
            Debug.Log("Get user data");

            StartCoroutine(BaseRequest(_url + "api/User/" + userId, HttpMethod.Get, 
                (t) =>
                {
                    ManageUserResponse(t);
                    callback();
                },
                failCallback
            ));
        }

        public void UpdateResults(string userId, List<float> results)
        {
            var data = new UpdateResultsModel { results = results, id = userId};
            var json = JsonUtility.ToJson(data);

            StartCoroutine(BaseRequest(_url + "api/User/update/results",
                HttpMethod.Put, json, (t) => { }, (t) => { }));
        }

        public void SetToken(string token)
        {
            basicHeaders["Authorization"] = "Bearer " + token;
        }

        private IEnumerator BaseRequest(string url, HttpMethod method,
            string jsonBody, Dictionary<string, string> headers,
            Action<string> onSuccess, Action<string> onFail)
        {
            UnityWebRequest req = null;
            Debug.Log("Base request");

            switch (method)
            {
                case HttpMethod.Get:
                    req = UnityWebRequest.Get(url);
                    break;
                case HttpMethod.Post:
                    req = Post(url, jsonBody);
                    break;
                case HttpMethod.Put:
                    req = UnityWebRequest.Put(url, jsonBody);
                    break;
                case HttpMethod.Delete:
                    req = UnityWebRequest.Delete(url);
                    break;
            }

            AddHeaders(req, basicHeaders);
            AddHeaders(req, headers);

            yield return req.SendWebRequest();

            if (req.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(req.error);
                onFail(req.error + ": " + req.downloadHandler.text);
            }
            else
            {
                onSuccess.Invoke(req.downloadHandler.text);
            }
        }

        private IEnumerator BaseRequest(string url, HttpMethod method, Action<string> onSuccess, Action<string> onFail)
        {
            return BaseRequest(url, method, "", null, onSuccess, onFail);
        }

        private IEnumerator BaseRequest(string url, HttpMethod method,
            string jsonBody, Action<string> onSuccess, Action<string> onFail)
        {
            return BaseRequest(url, method, jsonBody, null, onSuccess, onFail);
        }

        private UnityWebRequest Post(string url, string bodyJsonString)
        {
            var request = new UnityWebRequest(url, "POST");
            byte[] bodyRaw = Encoding.UTF8.GetBytes(bodyJsonString);
            request.uploadHandler = (UploadHandler)new UploadHandlerRaw(bodyRaw);
            request.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");
            return request;
        }

        private void ManageAuthResponse(string text)
        {
            var response = JsonUtility.FromJson<AuthResponse>(text);

            gameData.userId = response.userId;
            gameData.token = response.token;
        }

        private void ManageUserResponse(string text)
        {
            var response = JsonUtility.FromJson<UserModel>(text);

            gameData.username = response.name;
            gameData.results = response.results;
        }

        private void AddHeaders(UnityWebRequest req, Dictionary<string, string> headers)
        {
            if (headers != null)
                foreach (var kv in headers)
                    req.SetRequestHeader(kv.Key, kv.Value);
        }

        private enum HttpMethod
        {
            Get,
            Post,
            Put,
            Delete,
        }
    }
}
