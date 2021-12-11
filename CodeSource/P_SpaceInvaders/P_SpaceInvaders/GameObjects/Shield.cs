﻿///ETML
///Auteur : Alexis Rojas
///Date : 26.11.2021
///Description: Class qui permet de créer un bouclier
namespace P_SpaceInvaders.GameObjects
{
    /// <summary>
    /// Permet de créer un bouclier
    /// </summary>
    class Shield : GameObject
    {
        /// <summary>
        /// Constructeur par game et par caractère
        /// </summary>
        /// <param name="game">Game</param>
        /// <param name="chars">String réprésentant l'objet</param>
        public Shield(Game game, string chars) : base(game, chars)
        {

        }
    }
}
