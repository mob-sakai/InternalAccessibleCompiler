using CommandLine;

namespace InternalAccessibleCompiler
{
	public class Program
	{
		/// <summary>
		/// Entry point.
		/// </summary>
		/// <param name="args"></param>
		public static void Main(string[] args)
		{
			Parser.Default.ParseArguments<Options>(args)
				.WithParsed(Compiler.Compile);
		}
	}
}