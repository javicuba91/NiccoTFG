using MediatR;
using System.Diagnostics;

namespace TFGPlastic.UseCases.Contributor.Command.CompileProyects
{
    internal class CompileProyectCommandHandler : IRequestHandler<CompileProyectCommand, string>
    {


        public Task<string> Handle(CompileProyectCommand request, CancellationToken cancellationToken)
        {
            if (!Directory.Exists(request.PathToCompile))
            {
                return Task.FromResult($"El directorio '{request.PathToCompile}' no existe.");
            }

            var projectFiles = Directory.GetFiles(request.PathToCompile, "*.csproj", SearchOption.AllDirectories);
            if (projectFiles.Length == 0)
            {
                return Task.FromResult("No se encontraron proyectos .NET en el directorio especificado.");
            }

            foreach (var projectFile in projectFiles)
            {
                var projectDirectory = Path.GetDirectoryName(projectFile);
                var projectName = Path.GetFileNameWithoutExtension(projectFile);
                var outputDirectory = Path.Combine(request.PathToCompile, "Compilados", projectName);

                Directory.CreateDirectory(outputDirectory);

                Console.WriteLine($"Compilando: {projectFile} en {outputDirectory}");

                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "dotnet",
                        Arguments = $"build \"{projectFile}\" -o \"{outputDirectory}\"",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                Console.WriteLine(output);

                if (process.ExitCode != 0)
                {
                    return Task.FromResult("Error en la compilación.");
                }


            }

            return Task.FromResult("Compilación exitosa.");
        }
    }
}
