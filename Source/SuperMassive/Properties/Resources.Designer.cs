﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SuperMassive.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SuperMassive.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided string argument must not be empty..
        /// </summary>
        internal static string ArgumentMustNotBeEmpty {
            get {
                return ResourceManager.GetString("ArgumentMustNotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided string argument contains only whitespace..
        /// </summary>
        internal static string ArgumentMustNotBeWhiteSpace {
            get {
                return ResourceManager.GetString("ArgumentMustNotBeWhiteSpace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given parameter is not an instance of type {0}..
        /// </summary>
        internal static string IsNotInstanceOfType {
            get {
                return ResourceManager.GetString("IsNotInstanceOfType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {1} cannot be assigned to variables of type {0}..
        /// </summary>
        internal static string TypesAreNotAssignable {
            get {
                return ResourceManager.GetString("TypesAreNotAssignable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;unknown&gt;.
        /// </summary>
        internal static string UnknownType {
            get {
                return ResourceManager.GetString("UnknownType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not contain a valid Guid.
        /// </summary>
        internal static string Validation_NotValidGuidString {
            get {
                return ResourceManager.GetString("Validation_NotValidGuidString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 0} does not contain a valid Semantic Versioning value.
        /// </summary>
        internal static string Validation_NotValidSemverString {
            get {
                return ResourceManager.GetString("Validation_NotValidSemverString", resourceCulture);
            }
        }
    }
}
