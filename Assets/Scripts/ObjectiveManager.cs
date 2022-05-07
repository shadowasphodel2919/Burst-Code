using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveManager : MonoBehaviour
{
    public AudioClip m_click;
    public Text m_objective;
    string m_text;
    public GameObject m_player;
    private ColliderManager m_colliderManager;
    public Material m_material;
    string m_curr = "Sphere_A";
    private void Awake()
    {
        m_curr = "Sphere_A";
    }
    // Start is called before the first frame update
    void Start()
    {
        m_material.DisableKeyword("_EMISSION");
        m_curr = "Sphere_A";
        m_colliderManager = m_player.GetComponent<ColliderManager>();
        m_text = "Did you think this was about a link list or an array? No, why don’t you go look for Target A.";
        //m_curr = m_colliderManager.m_curr;
        if (this.name == m_curr)
        {
            Debug.Log("Here");
            m_material.EnableKeyword("_EMISSION");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (m_colliderManager.flag)
        {
            m_curr = m_colliderManager.m_curr;
        }
        
        Debug.Log(m_curr);
        if(this.name == m_curr)
        {
            Debug.Log("Here");
            m_material.EnableKeyword("_EMISSION");
        }
    }

    private void OnMouseDown()
    {
        m_curr = m_colliderManager.m_curr;
        string s = m_colliderManager.retText();
        m_text = s;
        m_objective.text = m_text;
        if(this.name != m_curr)
        {
            m_objective.text = "I'm not who you are looking for!";
        }
        AudioSource.PlayClipAtPoint(m_click, this.gameObject.transform.position);
    }
}
