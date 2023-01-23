using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SebastienMiniGame1
{
     public class RandomPokemon : MonoBehaviour
        {
            public GameObject pokemon;
            public SpriteRenderer pokemonDisplayed;
            public Sprite[] spriteArray;
            public string locationPokemon;
            public int nbDrawnPokemon;
        

            void Awake()
            {
                nbDrawnPokemon = Random.Range(0,152);

            }
   
            // Start is called before the first frame update
            void Start()
            {

            pokemonDisplayed.sprite = GetComponent<SpriteRenderer>().sprite = spriteArray[nbDrawnPokemon];

                if (nbDrawnPokemon <= 2)
                {
                    Debug.Log("il nage ce pokemon");
                    locationPokemon = "water";
                    PokemonPositioning();
                }

                else if (nbDrawnPokemon > 2)
                {
                    Debug.Log("wow, ce pokemon vole");
                    locationPokemon = "fly";
                    PokemonPositioning();
                }
                

            }

            // Update is called once per frame
            void Update()
            {

            }


             public void PokemonPositioning()
            {
                if (locationPokemon == "water")
                {
                    pokemon.transform.position = new Vector2(Random.Range(-5, 6), -4.2f);
                }

                else if (locationPokemon == "fly")
                {
                    pokemon.transform.position = new Vector2(Random.Range(-5, 6), 0f);

                }

            }
        }

       

}
