﻿namespace Smart.Resolver.Bindings
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///
    /// </summary>
    public interface IMissingPipeline
    {
        /// <summary>
        ///
        /// </summary>
        IList<IBindingResolver> Resolvers { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        IEnumerable<IBinding> Resolve(IResolverContext context, Type type);
    }
}
