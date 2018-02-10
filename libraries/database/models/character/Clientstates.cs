﻿using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;


namespace Libraries.database.models.character
{

    /// <summary>
    /// Character clientstates model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "clientstates")]
    public class ModelCharacterClientStates
    {

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ModelCharacterClientStates()
        {

            Items = new Dictionary<string, ModelCharacterClientState>();

        }

        [XmlIgnore]
        public Dictionary<string, ModelCharacterClientState> Items { get; private set; }

        [XmlElement(ElementName = "clientState")]
        public ModelCharacterClientState[] ModelCharacterClientState
        {

            get
            {

                List<ModelCharacterClientState> List = new List<ModelCharacterClientState>();

                if (Items != null)
                {

                    List.AddRange(Items.Keys.Select(key => Items[key]));

                }

                return List.ToArray();

            }

            set
            {

                Items = new Dictionary<string, ModelCharacterClientState>();

                if (value != null)
                {

                    foreach (ModelCharacterClientState Item in value)
                    {

                        Items.Add(Item.Unitname, Item);

                    }

                }

            }

        }

    }

}
