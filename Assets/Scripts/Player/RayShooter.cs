using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour
{
    private Camera _camera;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip hitAudioClip;

    void Start()
    {
        _camera = GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void OnGUI()
    { 
        int size = 36;
        float posX = _camera.pixelWidth / 2 - size / 4;
        float posY = _camera.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "*");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
            Ray ray = _camera.ScreenPointToRay(point);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                StartCoroutine (SphereIndicator(hit.point));
                Character enemy = hit.collider.GetComponent<Character>();
                if (enemy != null)
                {
                    enemy.GetDamage(50);
                    Managers.AudioManager.PlaySound(hitAudioClip);
                }
            }
        }
        
    }

    private IEnumerator SphereIndicator(Vector3 pos)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = pos; //�������� ������ �������
        yield return new WaitForSeconds(1); // �������� ����������� �����
        Destroy(sphere); // ����������� ������
        yield return null; // 
    }
}
