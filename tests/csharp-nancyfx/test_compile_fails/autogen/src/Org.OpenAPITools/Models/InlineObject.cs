using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sharpility.Extensions;
using NodaTime;

namespace Org.OpenAPITools._v1alpha1.Models
{
    /// <summary>
    /// InlineObject
    /// </summary>
    public sealed class InlineObject:  IEquatable<InlineObject>
    { 
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }


        /// <summary>
        /// Empty constructor required by some serializers.
        /// Use InlineObject.Builder() for instance creation instead.
        /// </summary>
        [Obsolete]
        public InlineObject()
        {
        }

        private InlineObject(string Name)
        {
            
            this.Name = Name;
            
        }

        /// <summary>
        /// Returns builder of InlineObject.
        /// </summary>
        /// <returns>InlineObjectBuilder</returns>
        public static InlineObjectBuilder Builder()
        {
            return new InlineObjectBuilder();
        }

        /// <summary>
        /// Returns InlineObjectBuilder with properties set.
        /// Use it to change properties.
        /// </summary>
        /// <returns>InlineObjectBuilder</returns>
        public InlineObjectBuilder With()
        {
            return Builder()
                .Name(Name);
        }

        public override string ToString()
        {
            return this.PropertiesToString();
        }

        public override bool Equals(object obj)
        {
            return this.EqualsByProperties(obj);
        }

        public bool Equals(InlineObject other)
        {
            return Equals((object) other);
        }

        public override int GetHashCode()
        {
            return this.PropertiesHash();
        }

        /// <summary>
        /// Implementation of == operator for (InlineObject.
        /// </summary>
        /// <param name="left">Compared (InlineObject</param>
        /// <param name="right">Compared (InlineObject</param>
        /// <returns>true if compared items are equals, false otherwise</returns>
        public static bool operator == (InlineObject left, InlineObject right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Implementation of != operator for (InlineObject.
        /// </summary>
        /// <param name="left">Compared (InlineObject</param>
        /// <param name="right">Compared (InlineObject</param>
        /// <returns>true if compared items are not equals, false otherwise</returns>
        public static bool operator != (InlineObject left, InlineObject right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        /// Builder of InlineObject.
        /// </summary>
        public sealed class InlineObjectBuilder
        {
            private string _Name;

            internal InlineObjectBuilder()
            {
                SetupDefaults();
            }

            private void SetupDefaults()
            {
            }

            /// <summary>
            /// Sets value for InlineObject.Name property.
            /// </summary>
            /// <param name="value">Name</param>
            public InlineObjectBuilder Name(string value)
            {
                _Name = value;
                return this;
            }


            /// <summary>
            /// Builds instance of InlineObject.
            /// </summary>
            /// <returns>InlineObject</returns>
            public InlineObject Build()
            {
                Validate();
                return new InlineObject(
                    Name: _Name
                );
            }

            private void Validate()
            { 
            }
        }

        
    }
}