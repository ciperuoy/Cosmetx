using BepInEx;
using System;
using UnityEngine;
using Utilla;

namespace Cosmetx
{
    /// <summary>
    /// This is your mod's main class.
    /// </summary>

    /* This attribute tells Utilla to look for [ModdedGameJoin] and [ModdedGameLeave] */
    [ModdedGamemode]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        bool inRoom;

        void Start()
        {
            GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().useGravity = false;
            /* A lot of Gorilla Tag systems will not be set up when start is called /*
			/* Put code in OnGameInitialized to avoid null references */

            string njlewfanf = "How could you.. you fucking imbecile. You tried commiting piracy, huh? ";
            string hiodwahwda = "Piracy, the unauthorized use or distribution of someone else's work, particularly in the realms of software, music, movies, and literature, poses significant threats to various sectors of society. Despite the allure of free access to content, the consequences of piracy are far-reaching, impacting creators, industries, economies, and consumers themselves. This essay explores the multifaceted reasons why piracy is detrimental.";
           string hiodfwea = "Rule 4 in Gorilla Tag Modding Group, DLC purchases support the developer and help him keep working on the game. Don't make mods that make purchasing DLC useless.";

            Console.WriteLine(njlewfanf + hiodwahwda + hiodfwea);
            Utilla.Events.GameInitialized += OnGameInitialized;
        }

        void OnEnable()
        {
            GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().useGravity = false;  
            /* Set up your mod here */
            /* Code here runs at the start and whenever your mod is enabled*/

            HarmonyPatches.ApplyHarmonyPatches();
        }

        void OnDisable()
        {
            /* Undo mod setup here */
            /* This provides support for toggling mods with ComputerInterface, please implement it :) */
            /* Code here runs whenever your mod is disabled (including if it disabled on startup)*/

            HarmonyPatches.RemoveHarmonyPatches();
        }

        void OnGameInitialized(object sender, EventArgs e)
        {
            GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().useGravity = false;

            string njlewfanf = "How could you.. you fucking imbecile. You tried commiting piracy, huh?";
            string hiodwahwda = "Piracy, the unauthorized use or distribution of someone else's work, particularly in the realms of software, music, movies, and literature, poses significant threats to various sectors of society. Despite the allure of free access to content, the consequences of piracy are far-reaching, impacting creators, industries, economies, and consumers themselves. This essay explores the multifaceted reasons why piracy is detrimental.";
            string hiodfwea = "Rule 4 in Gorilla Tag Modding Group, DLC purchases support the developer and help him keep working on the game. Don't make mods that make purchasing DLC useless.";

            Console.WriteLine(njlewfanf + hiodwahwda + hiodfwea);
            /* Code here runs after the game initializes (i.e. GorillaLocomotion.Player.Instance != null) */
        }

        void Update()
        {
            GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().useGravity = false; 
            /* Code here runs every frame when the mod is enabled */
        }

        /* This attribute tells Utilla to call this method when a modded room is joined */
        [ModdedGamemodeJoin]
        public void OnJoin(string gamemode)
        {
            /* Activate your mod here */
            /* This code will run regardless of if the mod is enabled*/

            inRoom = true;
        }

        /* This attribute tells Utilla to call this method when a modded room is left */
        [ModdedGamemodeLeave]
        public void OnLeave(string gamemode)
        {
            /* Deactivate your mod here */
            /* This code will run regardless of if the mod is enabled*/

            inRoom = false;
        }
    }
}
