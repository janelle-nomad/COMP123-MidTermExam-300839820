﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam_300839820
{

        /*
                Janelle Heron
                300839820
                Date created June 24 2016
        
         */
    /**
     * <summary>
     * This abstract class is a blueprint for all Lotto Games
     * </summary>
     * 
     * @class LottoGame
     * @property {int} ElementNum;
     * @property {int} SetSize;
     */
    public abstract class LottoGame
    {
        private List<int> _elementList;
        private int _elementNumber;
        private List<int> _numberList;
        private Random _random;
        private int _setSize;

        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE private fields here --------------------------------------------

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE public properties here -----------------------------------------
        public int ElementNumber
        {
            get
            {
                return this._elementNumber;
            }

            set
            {
                this._elementNumber = value;
            }
        }

        public List<int> ElementList
        {
            get
            {
                return this._elementList; 
                
            }
            
        }

        public List<int> NumberList
        {
            get
            {
                return this._numberList;
            }

        }

        public Random random
        {
            get
            {
                return this._random;
            }
        }


        public int SetSize
        {
            get { return this._setSize; }

            set { this._setSize = value; }
        }


        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: elementNumber and setSize
         * The elementNumber parameter has a default value of 6
         * The setSize parameter has a default value of 49
         * </summary>
         * 
         * @constructor LottoGame
         * @param {int} elementNumber
         * @param {int} setSize
         */
        public LottoGame(int elementNumber = 6, int setSize = 49)
        {
            // assign elementNumber local variable to the ElementNumber property
            this.ElementNumber = elementNumber;

            // assign setSize local variable the SetSize property
            this.SetSize = setSize;

            // call the _initialize method
            this._initialize();

            // call the _build method
            this._build();
        }


        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
       


        // CREATE the private _initialize method here -----------------------------
        private void _initialize()
        {
            _elementList = new List<int>();
            _random = new Random();
            _numberList = new List<int>();
        }

        // CREATE the private _build method here -----------------------------------
        private void _build()
        {
        
            for (int i = 0; i < this.SetSize; i++)
            {
                this.NumberList.Add(i);
            }
        
        }


        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */

        public override string ToString()
        {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;

            // for each lottoNumber in ElementList, loop...
            foreach (int lottoNumber in ElementList)
            {
                // add lottoNumber and appropriate spaces to the lottoNumberString variable
                lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
            }

            return lottoNumberString;
        }
        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++        
        public void PickElements()
        {

            //If the number of elements found in ElementList is greater than 0 

            if (ElementList.Count > 0)
            {

                this.NumberList.Clear();
                this.ElementList.Clear();
                this._build();
            }


            for (int i = 0; i < this.SetSize; i++)
            {


                int random = this.Random.Next(1, 7); //Gotta fix this! 

                this.ElementList.Add(this.NumberList.(random));
            }
        }
    }




        // CREATE the public PickElements method here ----------------------------
    }
}
