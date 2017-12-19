using QA.Common;
using QA.DataAccess;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace taskQuestions
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IQuestionsProvider, QuestionsProvider>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}