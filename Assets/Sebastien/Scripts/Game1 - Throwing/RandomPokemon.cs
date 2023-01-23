using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SebastienMiniGame1
{
     public class RandomPokemon : MonoBehaviour
        {
            public GameObject pokemon;
            public GameObject disposableGround; //Sol désactivé lorsque le Pokémon n'est pas sur la terre
            public SpriteRenderer pokemonDisplayed;
            public Sprite[] spriteArray;
            public string locationPokemon;
            public int nbDrawnPokemon;
            
        

            void Awake()
            {
                nbDrawnPokemon = Random.Range(0,10);


               
            }
   
            // Start is called before the first frame update
            void Start()
            {

            pokemonDisplayed.sprite = spriteArray[nbDrawnPokemon];

                if (nbDrawnPokemon <= 4)
                {
                    Debug.Log("il nage ce pokemon");
                    locationPokemon = "water";
                    PokemonPositioning();
                    
                }

                else if (nbDrawnPokemon > 4 && nbDrawnPokemon <= 6)
                {
                    Debug.Log("wow, ce pokemon vole");
                    locationPokemon = "fly";
                    PokemonPositioning();
                }

                else if (nbDrawnPokemon > 6)
                {
                    Debug.Log("Pas grand chose à dire, il est par terre");
                    locationPokemon = "ground";
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
                    disposableGround.SetActive(false);
                }

                else if (locationPokemon == "fly")
                {
                    pokemon.transform.position = new Vector2(Random.Range(-5, 6), 0f);
                    disposableGround.SetActive(false);

                }

                else if (locationPokemon == "ground")
                {
                    pokemon.transform.position = new Vector2(1.75f, -2.75f);

                }

            }
        }

       

}
