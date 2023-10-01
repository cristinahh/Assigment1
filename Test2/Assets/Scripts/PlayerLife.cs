using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Balls"))
        {
            Die();
        } 
    }

    private void Die()
    {
        SoundManager.PlaySound("PlayerHit");
        rb.bodyType = RigidbodyType2D.Static; // Change to static because we don't want the player to be able to move and continue playing
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reloads the level
    }
}
