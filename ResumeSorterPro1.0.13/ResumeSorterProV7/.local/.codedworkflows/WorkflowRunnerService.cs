using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using ResumeSorterPro;

[assembly: WorkflowRunnerServiceAttribute(typeof(ResumeSorterPro.WorkflowRunnerService))]
namespace ResumeSorterPro
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main(string in_FilePath)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{{"in_FilePath", in_FilePath}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Main(string in_FilePath, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{{"in_FilePath", in_FilePath}}, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the test.xaml
        /// </summary>
        public void test(string in_FilePath)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"test.xaml", new Dictionary<string, object>{{"in_FilePath", in_FilePath}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the test.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void test(string in_FilePath, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"test.xaml", new Dictionary<string, object>{{"in_FilePath", in_FilePath}}, default, isolated, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}