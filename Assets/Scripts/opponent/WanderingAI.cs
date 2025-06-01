using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour
{
    public float speed = 3.0f;
    public float obstacleRange = 5.0f;
    public float attackDelay = 2.0f;
    private bool _alive;

    void Start()
    {
        _alive = true;
    }

    [SerializeField]
    private GameObject fireballPrefab;
    private GameObject _fireball;

    void Update()
    {
        if (_alive)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);

            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            //if (Physics.SphereCast(ray, 0.75f, out hit))
            //{
            //    if (hit.distance < obstacleRange)
            //    {
            //        float angle = Random.Range(-110, 110);
            //        transform.Rotate(0, angle, 0);
            //    }
            //}

            if (Physics.SphereCast(ray, 0.75f, out hit))
            {
                NewBehaviourScript playerMove = hit.collider.GetComponent<NewBehaviourScript>(); // MoveRotation - script
                Character character = hit.collider?.GetComponent<Character>();
                //GameObject hitObject = hit.transform.gameObject;
                if (character != null )
                {
                    if (_fireball == null)
                    {
                        _fireball = Instantiate(fireballPrefab) as GameObject;
                        _fireball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                        _fireball.transform.rotation = transform.rotation;
                    }
                }
                else if (hit.distance < obstacleRange) // ближний бой
                {
                    if (character != null && playerMove != null)
                    {
                        character.GetDamage(50 * Time.deltaTime);
                    }
                    else
                    {
                        float angle = Random.Range(-110, 110);
                        transform.Rotate(0, angle, 0);                    
                    }
                }
            }
        }
    }

    public void SetAlive(bool alive)
    { 
        _alive = alive;
    }

    IEnumerator AttackCharacter(Character character)
    {
        yield return new WaitForSeconds(attackDelay);

        if (fireballPrefab != null)
        {
            _fireball = Instantiate(fireballPrefab, transform.TransformPoint(Vector3.forward * 1.5f), transform.rotation);
            Destroy(_fireball, 5f); 
        }

    }

}
