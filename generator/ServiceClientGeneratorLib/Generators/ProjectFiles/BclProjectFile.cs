﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.ProjectFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using ServiceClientGenerator;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class BclProjectFile : BclProjectFileBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"<?xml version=""1.0"" encoding=""utf-8""?>
<Project ToolsVersion=""12.0"" DefaultTargets=""Build"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">
  <Import Project=""$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props"" Condition=""Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')"" />
  <PropertyGroup>
    <Configuration Condition="" '$(Configuration)' == '' "">Debug</Configuration>
    <Platform Condition="" '$(Platform)' == '' "">AnyCPU</Platform>
    <ProjectGuid>");
            
            #line 13 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["ProjectGuid"]));
            
            #line default
            #line hidden
            this.Write("</ProjectGuid>\r\n    <OutputType>Library</OutputType>\r\n    <AppDesignerFolder>Prop" +
                    "erties</AppDesignerFolder>\r\n    <RootNamespace>");
            
            #line 16 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["RootNamespace"]));
            
            #line default
            #line hidden
            this.Write("</RootNamespace>\r\n    <AssemblyName>");
            
            #line 17 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write("</AssemblyName>\r\n    <TargetFrameworkVersion>");
            
            #line 18 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["TargetFrameworkVersion"]));
            
            #line default
            #line hidden
            this.Write("</TargetFrameworkVersion>\r\n    <FileAlignment>512</FileAlignment>\r\n    <BaseInter" +
                    "mediateOutputPath>obj\\");
            
            #line 20 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write(@"</BaseIntermediateOutputPath>
  </PropertyGroup>
  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' "">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\");
            
            #line 26 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write("</OutputPath>\r\n    <DefineConstants>DEBUG;TRACE;");
            
            #line 27 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["DefineConstants"]));
            
            #line default
            #line hidden
            this.Write("</DefineConstants>\r\n    <ErrorReport>prompt</ErrorReport>\r\n    <WarningLevel>4</W" +
                    "arningLevel>\r\n    <NoWarn>419,1570,1591</NoWarn>\r\n    <DocumentationFile>bin\\Deb" +
                    "ug\\");
            
            #line 31 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write("\\");
            
            #line 31 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(".XML</DocumentationFile>\r\n  </PropertyGroup>\r\n  <PropertyGroup Condition=\" \'$(Con" +
                    "figuration)|$(Platform)\' == \'Release|AnyCPU\' \">\r\n    <DebugType>pdbonly</DebugTy" +
                    "pe>\r\n    <Optimize>true</Optimize>\r\n    <OutputPath>bin\\Release\\");
            
            #line 36 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write("</OutputPath>\r\n    <DefineConstants>TRACE;");
            
            #line 37 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["DefineConstants"]));
            
            #line default
            #line hidden
            this.Write("</DefineConstants>\r\n    <ErrorReport>prompt</ErrorReport>\r\n    <WarningLevel>4</W" +
                    "arningLevel>\r\n    <NoWarn>419,1570,1591</NoWarn>\r\n    <DocumentationFile>bin\\Rel" +
                    "ease\\");
            
            #line 41 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write("\\");
            
            #line 41 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(@".XML</DocumentationFile>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include=""System"" />
    <Reference Include=""System.Configuration"" />
    <Reference Include=""System.Core"" />
    <Reference Include=""System.Xml.Linq"" />
    <Reference Include=""System.Data.DataSetExtensions"" />
    <Reference Include=""System.Data"" />
    <Reference Include=""System.Xml"" />
");
            
            #line 51 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"

    object systemReferences;
    if(this.Session.TryGetValue("SystemReferences", out systemReferences) && systemReferences is IList<string>)
    {
        foreach(var reference in (IList<string>)systemReferences)
        {

            
            #line default
            #line hidden
            this.Write("    <Reference Include=\"");
            
            #line 58 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(reference));
            
            #line default
            #line hidden
            this.Write("\" />\r\n");
            
            #line 59 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n  <ItemGroup>\r\n");
            
            #line 65 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"

    foreach(string subDirectory in ((IList<string>)this.Session["SourceDirectories"]))
    {

            
            #line default
            #line hidden
            this.Write("    <Compile Include=\"");
            
            #line 69 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(subDirectory));
            
            #line default
            #line hidden
            this.Write("\\*.cs\">\r\n      <SubType>Code</SubType>\r\n    </Compile>\r\n");
            
            #line 72 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n  <ItemGroup>\r\n");
            
            #line 77 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"

    if(this.Session.ContainsKey("IndividualFileIncludes"))
    {
        foreach(string file in ((IList<string>)this.Session["IndividualFileIncludes"]))
        {
            if(file.EndsWith(".cs"))
            {

            
            #line default
            #line hidden
            this.Write("    <Compile Include=\"");
            
            #line 85 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(file));
            
            #line default
            #line hidden
            this.Write("\">\r\n      <SubType>Code</SubType>\r\n    </Compile>\r\n");
            
            #line 88 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("    <EmbeddedResource Include=\"");
            
            #line 93 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(file));
            
            #line default
            #line hidden
            this.Write("\">\r\n      <SubType>Designer</SubType>\r\n    </EmbeddedResource>\r\n");
            
            #line 96 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"

            }
        }
    }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n");
            
            #line 102 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"

    if(this.Session.ContainsKey("ProjectReferences"))
    {
        foreach(var projectReferences in (List<ProjectFileCreator.ProjectReference>)this.Session["ProjectReferences"])
        {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n    <ProjectReference Include=\"");
            
            #line 109 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(projectReferences.IncludePath));
            
            #line default
            #line hidden
            this.Write("\">\r\n        <Project>");
            
            #line 110 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(projectReferences.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("</Project>\r\n        <Name>");
            
            #line 111 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(projectReferences.Name));
            
            #line default
            #line hidden
            this.Write("</Name>\r\n    </ProjectReference>\r\n  </ItemGroup>\r\n");
            
            #line 114 "C:\code\dotnet\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\BclProjectFile.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write(@"  <ItemGroup>
    <Compile Include=""Properties\AssemblyInfo.cs"" />
  </ItemGroup>
  <Import Project=""$(MSBuildToolsPath)\Microsoft.CSharp.targets"" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name=""BeforeBuild"">
  </Target>
  <Target Name=""AfterBuild"">
  </Target>
  -->
</Project>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class BclProjectFileBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
