using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderManager : MonoBehaviour
{
    public AudioClip m_boom;
    public Text m_objective;
    public string m_text;
    public int m_count = 0;
    public bool flag = false;
    public string m_curr = "";
    void Start()
    {
        m_text = "Did you think this was about a link list or an array? No, why don’t you go look for Target A.";
        m_curr = "Sphere_A";
    }
    void Update()
    {
        
    }
    public string retText()
    {
        return m_text;
    }
    private void OnTriggerEnter(Collider other)
    {
        string name = (other.name);
        if(name == "Sphere_A" && m_count == 0)
        {
            flag = true;
            m_text = "This is going to be fun, I guarantee. Look around until you get to Target B.";
            m_objective.text = m_text;
            m_count++;
            m_curr = "Cube_B";
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(m_boom, this.gameObject.transform.position);
        }
        if (name == "Cube_B" && m_count == 1)
        {
            flag = true;
            m_text = "Two steps in, it’s not that bad, you’ll agree. Go look for Target C.";
            m_objective.text = m_text;
            m_count++;
            m_curr = "Sphere_C";
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(m_boom, this.gameObject.transform.position);
        }
        if (name == "Sphere_C" && m_count == 2)
        {
            flag = true;
            m_text = "There’s too many words that I need to rhyme you see, go on ahead, look for Target D.";
            m_objective.text = m_text;
            m_count++;
            m_curr = "Cube_D";
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(m_boom, this.gameObject.transform.position);
        }
        if (name == "Cube_D" && m_count == 3)
        {
            flag = true;
            m_text = "Is this getting boring? Making you drowsy? I promise there’s only one more step after Target E.";
            m_objective.text = m_text;
            m_count++;
            m_curr = "Capsule_E";
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(m_boom, this.gameObject.transform.position);
        }
        if (name == "Capsule_E" && m_count == 4)
        {
            flag = true;
            m_text = "I can’t think of anything that rhymes with F, you know where to go now, don’t you?";
            m_objective.text = m_text;
            m_count++;
            m_curr = "Capsule_F";
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(m_boom, this.gameObject.transform.position);
        }
        if (name == "Capsule_F" && m_count == 5)
        {
            flag = true;
            m_text = "With this, we’re done. After putting you through this, is it okay for me to ask if you’ve had good fun?";
            m_objective.text = m_text;
            m_count++;
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(m_boom, this.gameObject.transform.position);
        }
        


    }
}
