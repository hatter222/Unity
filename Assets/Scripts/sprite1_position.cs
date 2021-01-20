using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite1_position : MonoBehaviour

{
    //public Vector3 position = new Vector3(0.2f, 0.5f, 0);
    public GameObject s_1;
    public GameObject s_2;
    public List<Vector3> f_1 = new List<Vector3>();
    public List<Vector3> f_2 = new List<Vector3>();
    private bool counter = true;
    public float speed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        //print(gameObject.name);
        s_1 = GameObject.Find("Sprite_1");
        s_2 = GameObject.Find("Sprite_2");

        f_1.Add(s_1.transform.position);
        f_2.Add(s_2.transform.position);

        // Total number of steps of f_1 and f_2 should be same!!!
        //f_1.Add(new Vector3(-8.12f, 4.32f, 0));
        //f_2.Add(new Vector3(-7.7f, 4.32f, 0));

        f_1 = MoveX(f_1, 12, 0.5f);
        f_2 = MoveX(f_2, 11, 0.5f);
        f_2 = MoveY(f_2, 1, 0.25f);

        f_1 = MoveY(f_1, 6, -0.5f);
        f_2 = MoveY(f_2, 6, -0.5f);

        f_1 = MoveX(f_1, 5, 0.25f);
        f_2 = MoveX(f_2, 4, 0.25f);
        f_2 = MoveX(f_2, 1, 0.1f);

        f_1 = MoveXY(f_1, 2, 0.15f);
        f_2 = MoveXY(f_2, 2, 0.15f);

        f_1 = MoveY(f_1, 5, 0.5f);
        f_2 = MoveY(f_2, 5, 0.5f);

        f_1 = MoveX(f_1, 3, 0.5f);
        f_2 = MoveX(f_2, 3, 0.5f);

        f_1 = MoveY(f_1, 6, -0.5f);
        f_2 = MoveY(f_2, 6, -0.5f);

        f_1 = MoveXY(f_1, 2, -0.2f);
        f_2 = MoveXY(f_2, 2, -0.1f);

        f_1 = MoveX(f_1, 3, 0.5f);
        f_2 = MoveX(f_2, 3, 0.5f);

        f_1 = MoveY(f_1, 5, -0.5f);
        f_2 = MoveY(f_2, 5, -0.5f);

        f_1 = MoveY(f_1, 1, -0.1f);
        f_2 = MoveY(f_2, 1, -0.2f);

        f_1 = MoveX(f_1, 10, -0.5f);
        f_2 = MoveX(f_2, 10, -0.5f);

        f_1 = MoveXY(f_1, 2, -0.25f);
        f_2 = MoveXY(f_2, 2, 0.25f);

        f_1 = MoveY(f_1, 2, 0.25f);
        f_2 = MoveY(f_2, 2, -0.25f);

        f_1 = MoveX(f_1, 7, 0.5f);
        f_2 = MoveX(f_2, 7, 0.4f);

        f_1 = MoveY(f_1, 5, -0.4f);
        f_2 = MoveY(f_2, 5, -0.5f);





    }

    List<Vector3> MoveX(List<Vector3> f, int num_steps, float step_size)
    {
        for (int i = 0; i < num_steps; i++)
        {
            float x0 = f[f.Count - 1].x;
            float y0 = f[f.Count - 1].y;
            f.Add(new Vector3(x0 + step_size, y0, 0));
        }
        return f;
    }

    List<Vector3> MoveY(List<Vector3> f, int num_steps, float step_size)
    {
        for (int i = 0; i < num_steps; i++)
        {
            float x0 = f[f.Count - 1].x;
            float y0 = f[f.Count - 1].y;
            f.Add(new Vector3(x0, y0 + step_size, 0));
        }
        return f;
    }

    List<Vector3> MoveXY(List<Vector3> f, int num_steps, float step_size)
    {
        for (int i = 0; i < num_steps; i++)
        {
            float x0 = f[f.Count - 1].x;
            float y0 = f[f.Count - 1].y;
            f.Add(new Vector3(x0 + step_size, y0 + step_size, 0));
        }
        return f;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter)
            StartCoroutine(Movement());



        //s_2.transform.position = new Vector3(0.5f, -0.2f, 0);
    }
    IEnumerator Movement()
    {

        //foreach (var f in f_1)
        for (int i=0; i<f_1.Count; i++)
    
        {
            counter = false;
            //s_1.transform.position = Vector3.MoveTowards(s_1.transform.position, f, speed*Time.deltaTime);
            s_1.transform.position = f_1[i];
            s_2.transform.position = f_2[i];
            
            yield return new WaitForSeconds(0.5f);
            yield return null;
            yield return null;
        }
        
        // counter = true;
        yield return null;
    }
    
    }
