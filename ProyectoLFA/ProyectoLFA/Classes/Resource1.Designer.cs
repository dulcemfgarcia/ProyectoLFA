﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoLFA.Classes {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ProyectoLFA.Classes.Resource1", typeof(Resource1).Assembly);
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
        ///   Looks up a localized string similar to import java.util.*;
        ///
        ///namespace Scanner
        ///{
        ///    public class Scanner
        ///    {
        ///        static Scanner scanner = new Scanner(System.in);
        ///
        ///        public static void Main(String[] args)
        ///        {
        ///            Stack&lt;Character&gt; Input = new Stack&lt;Character&gt;();
        ///
        ///            while(true)
        ///            {
        ///                System.out.print(&quot;\nEscriba la cadena para analizar: &quot;);
        ///                Input = getStack(scanner.nextLine());
        ///
        ///                System.out.print(&quot;\nAnalizando&quot;);
        ///                Thread.Sleep( [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Final {
            get {
                return ResourceManager.GetString("Final", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Threading;
        ///using System.Windows.Forms;
        ///
        ///namespace Scanner
        ///{
        ///    class Program
        ///    {
        ///        static void Main(string[] args)
        ///        {
        ///            Stack&lt;char&gt; Input = new Stack&lt;char&gt;();
        ///
        ///            Inicio:
        ///
        ///            Console.Write(&quot;\nEscriba la cadena para analizar: &quot;);
        ///            Input = getStack(Console.ReadLine());
        ///
        ///            Console.Write(&quot;\nAnalizando&quot;);
        ///            Thread.Sleep(300);
        ///            C [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Program {
            get {
                return ResourceManager.GetString("Program", resourceCulture);
            }
        }
    }
}
