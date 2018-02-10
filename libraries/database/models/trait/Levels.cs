﻿using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;


namespace Libraries.database.models.traits
{

    /// <summary>
    /// Levels model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "levels")]
    public class ModelTraitLevels
    {

        public ModelTraitLevels()
        {

            Items = new List<int>();

        }

        [XmlElement(ElementName = "level")]
        [DefaultValue(null)]
        public List<int> Items { get; set; }
    
    }

}
