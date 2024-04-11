using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class TextOnDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public Handle handle;
    public GameObject Text;
    private Dictionary<string, string> AboutIt = new Dictionary<string, string>();

    void Start()
    {
        AboutIt.Add("Sun", "The Sun is the heart of our solar system, and its gravity is what keeps every planet and particle in orbit. This yellow dwarf star is just one of billions like it across the Milky Way galaxy.");
        AboutIt.Add("Earth", "The place we call home, Earth is the third rock from the sun and the only planet with known life on it - and lots of it too! It has only one Moon.");
        AboutIt.Add("Moon", "The only place beyond Earth that humans have explored, the Moon is the largest and brightest object in our sky - responsible for the tides and keeping Earth stable on its axis.");
        AboutIt.Add("Mercury", "The smallest and fastest planet, Mercury is the closest planet to the Sun and whips around it every 88 Earth days. It has no moon.");
        AboutIt.Add("Venus", "Spinning in the opposite direction to most planets, Venus is the hottest planet, and one of the brightest objects in the sky. It has no moon.");
        AboutIt.Add("Mars", "The red planet is dusty, cold world with a thin atmosphere and is home to four NASA robots. It has two moons - Phobos and Diemos.");
        AboutIt.Add("Phobos", "Phobos is larger and inner of the two moons of Mars.");
        AboutIt.Add("Diemos", "Diemos is smaller and outer of the two moons of Mars.");
        AboutIt.Add("Jupiter", "Jupiter is a massive planet, twice the size of all other planets combined. It has total 95 moons.");
        AboutIt.Add("Ganymede", "Ganymede is Jupiter's largest moon, and the largest moon in our solar system.");
        AboutIt.Add("Saturn", "The most recognizable planet with a system of icy rings, Saturn is a very unique and interesting planet.It has total 146 moons.");
        AboutIt.Add("Titan", "Titan is the largest moon of Saturn and the second-largest in the Solar System.");
        AboutIt.Add("Uranus", "Uranus has a unique rotation--it spins on its side at an almost 90-degree angle, unlike other planets. It has total 28 moons.");
        AboutIt.Add("Titania", "Titania is also called Uranus III. It is the largest moon of Uranus, the eighth most massive of the solar system.");
        AboutIt.Add("Neptune", "Neptune is now the most distant planet and is a cold and dark world nearly 3 billion miles from the Sun. It has total 14 moons.");
        AboutIt.Add("Triton", "Triton is the largest moon of Neptune.");
    }


    // Update is called once per frame
    void Update()
    {
        if (handle.isTop)
        {
            Text.GetComponent<TextMeshProUGUI>().text = "Solar System";
        }
        else
        {
            Text.GetComponent<TextMeshProUGUI>().text = AboutIt[handle.target.tag];
        }
    }
}
