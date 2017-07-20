using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 13, 2017
 * Description: This is the SuperHero class which inherits from the SuperHuman class
 * and implements the IHasKarma Interface
 * Version: 0.4 - Implemented the ITrainable interface
 */

namespace COMP123_S2017_Lesson10A
{
    /// <summary>
    /// This is the SuperHero class
    /// </summary>
    public class SuperHero : SuperHuman, IHasKarma, ITrainable
    {
        // PRIVATE INSTANCE VARIABLES
        private int _karma;

        // PUBLIC PROPERTIES
        public int Karma
        {
            get
            {
                return this._karma;
            }

            set
            {
                this._karma = value;
            }
        }


        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the SuperHero class
        /// It takes one argument - name (string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHero(string name, int karma)
            : base(name)
        {
            this.Karma = karma;
        }

        public void Trains()
        {
            Console.WriteLine("Not Implemented");
        }

        // PRIVATE METHODS

        // PUBLIC METHODS
    }
}