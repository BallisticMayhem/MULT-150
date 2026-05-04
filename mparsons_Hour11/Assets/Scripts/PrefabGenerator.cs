using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
      public GameObject prefab;

      void Start()
      {
          // A loop to spawn 10 street lamps equidistant apart on the ground along one axis.
          for (int i = 0; i < 10; i++)
          {
              Instantiate(prefab, transform.position + transform.right * i * 2, transform.rotation);
          }
      }

      void Update()
      {
          // Whenever we hit the B key we will generate a prefab at the
          // position of the original prefab
          // Whenever we hit the space key, we will generate a prefab at the
          // position of the spawn object that this script is attached to
          if (Input.GetKeyDown(KeyCode.B))
          {
               Instantiate(prefab);
          }
          if (Input.GetKeyDown(KeyCode.Space))
          {
               Instantiate(prefab, transform.position, transform.rotation);
          }
      }
}
