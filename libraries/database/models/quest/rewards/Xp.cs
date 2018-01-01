﻿using System.Xml.Serialization;


namespace Libraries.database.models.quest.rewards
{

    /// <summary>
    /// Xp model
    /// </summary>
    /// <seealso cref="http://xmltocsharp.azurewebsites.net/"/>

    [XmlRoot(ElementName = "Xp")]
    public class ModelQuestRewardsXp
    {

        [XmlAttribute(AttributeName = "visible")]
        public string Visible { get; set; }

        [XmlText]
        public string Text { get; set; }

    }

}
