using Liquid.Library.Domain;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace Liquid.Library.UI.Controllers
{
    public class LiquidControllerFactory : DefaultControllerFactory, IControllerFactory
    {
        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            switch (controllerName)
            {
                case "Book":
                    return CreateController<Domain.Inventory.Book>(requestContext);
                case "Movie":
                    return CreateController<Domain.Inventory.Movie>(requestContext);
                default:
                    return base.CreateController(requestContext, controllerName);
            }
        }

        public IController CreateController<T>(RequestContext requestContext)
            where T : Entity
        {
            var genericType = typeof(EntityController<>);
            var controllerType = genericType.MakeGenericType(typeof(T));
            return Activator.CreateInstance(controllerType) as IController;
        }
    }
}