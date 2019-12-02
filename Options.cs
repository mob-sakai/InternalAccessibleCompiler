using CommandLine;
using CommandLine.Text;
using System.Collections.Generic;

namespace InternalAccessibleCompiler
{
	/// <summary>
	/// Command line options.
	/// </summary>
	public class Options
	{
		/// <summary>
		/// Output path.
		/// </summary>
		[Option('o', "output", Required = false, HelpText = "Output path")]
		public string Output { get; set; }

		/// <summary>
		/// Input .csproj path.
		/// </summary>
		[Value(1, MetaName = "ProjectPath", HelpText = "Input .csproj path")]
		public string ProjectPath { get; set; }

		/// <summary>
		/// Usages.
		/// </summary>
		[Usage(ApplicationAlias = "InternalAccessibleCompiler")]
		public static IEnumerable<Example> Examples
		{
			get
			{
				return new List<Example>() {
					new Example("Compile your project to internal accessible dll", new Options { Output = "your.dll", ProjectPath = "your.csproj" })
				};
			}
		}
	}
}