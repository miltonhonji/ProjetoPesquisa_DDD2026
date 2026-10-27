using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain.Notifications
{
    public class Notifica
    {
        /// <summary>
        /// This class will be used to validate in domain and
        /// return a Json, standardized for the user who will
        ///consume the API, which will return these objects
        /// </summary>
        public Notifica()
        {
            notifications = new List<Notifica>();
        }
        
        /// <summary>
        /// This is properties will be used the properties of name, message and notification
        /// </summary>s
        //Properties
        [JsonIgnore] //Not appears in the Swagger
        [NotMapped]
        public string? PropertyName { get; set; }

        [JsonIgnore] //Not appears in the Swagger
        [NotMapped]
        public string? Message { get; set; }

        [JsonIgnore] //Not appears in the Swagger
        [NotMapped]
    public List<Notifica>? notifications;

    /// <summary>
    /// Validates a string property 
    /// </summary>
    /// <param name="value"></param>
    /// <param name="propertiesName"></param>
    /// <returns></returns>
        public bool ValidateStringPropertiy(string value, string propertiesName)
        {
            if(string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propertiesName))
            {
                notifications.Add(new Notifica
                {
                    message = "The property is required",
                    propertyName = propertiesName
                });

                return false;
            }

            return true;
        }


        /// <summary>
        /// Validates an int property 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="propertiesName"></param>
        /// <returns></returns>
        public bool ValidateIntProperty(int value, string propertiesName)
        {
            if(value < 1 || string.IsNullOrWhiteSpace(propertiesName))
            {
                notifications.Add(new Notifica
                {
                    message = "The property is required",
                    propertyName = propertiesName
                });

                return false;
            }

            return true;
        }
    }
}