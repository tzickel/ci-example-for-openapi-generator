using System;
using Nancy;
using Nancy.ModelBinding;
using System.Collections.Generic;
using Sharpility.Base;
using Org.OpenAPITools._v1alpha1.Models;
using Org.OpenAPITools._v1alpha1.Utils;
using NodaTime;
using ;

namespace Org.OpenAPITools._v1alpha1.Modules
{ 

    /// <summary>
    /// Module processing requests of Default domain.
    /// </summary>
    public sealed class DefaultModule : NancyModule
    {
        /// <summary>
        /// Sets up HTTP methods mappings.
        /// </summary>
        /// <param name="service">Service handling requests</param>
        public DefaultModule(DefaultService service) : base("/v1alpha1")
        { 
            Post["/test"] = parameters =>
            {
                var body = this.Bind<InlineObject>();
                service.TestPost(Context, body);
                return new Response { ContentType = ""};
            };
        }
    }

    /// <summary>
    /// Service handling Default requests.
    /// </summary>
    public interface DefaultService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context">Context of request</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void TestPost(NancyContext context, InlineObject body);
    }

    /// <summary>
    /// Abstraction of DefaultService.
    /// </summary>
    public abstract class AbstractDefaultService: DefaultService
    {
        public virtual void TestPost(NancyContext context, InlineObject body)
        {
            TestPost(body);
        }

        protected abstract void TestPost(InlineObject body);
    }

}
