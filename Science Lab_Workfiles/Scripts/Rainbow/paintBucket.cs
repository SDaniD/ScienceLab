using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintBucket : MonoBehaviour
{
    public Color[] colorList;
    public Color curColor;
    public int colorCount; 
    public GameObject obj;

    void Update()
    {
    //  curColor = colorList[colorCount];
       var ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray, -Vector2.up);
      /*  Ray raya = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hita;*/
      
       
            if (Input.GetMouseButtonDown(0))
            {
          
                print("in");
                if (hit.collider != null)
                {
                    SpriteRenderer sp = hit.collider.gameObject.GetComponent<SpriteRenderer>();
                    Debug.Log(hit.collider.name);
                    sp.color = curColor;
                    if (hit.collider == null)
                    {
                        Camera.main.backgroundColor = curColor;
                        print("cur");
                    }
                if (sp.transform == true) Debug.Log(sp.transform.name);


            }
            }
      /*  if(Physics.Raycast(raya,out hita))
        {
            if (Input.GetMouseButtonDown(0))
            {
              if (obj.transform==true) Debug.Log(obj.transform.name); 
            }
           
      
        }*/

       
    }
   public void paint(int colorCode)
        {
            colorCount = colorCode;
        }
}
