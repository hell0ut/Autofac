﻿// This software is part of the Autofac IoC container
// Copyright © 2011 Autofac Contributors
// https://autofac.org
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.

using System.Diagnostics.CodeAnalysis;
using Autofac.Core.Diagnostics;
using Autofac.Core.Resolving.Pipeline;

namespace Autofac.Core.Resolving
{
    /// <summary>
    /// A <see cref="ResolveOperation"/> is a component context that sequences and monitors the multiple
    /// activations that go into producing a single requested object graph.
    /// </summary>
    internal sealed class ResolveOperation : ResolveOperationBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResolveOperation"/> class.
        /// </summary>
        /// <param name="mostNestedLifetimeScope">The most nested scope in which to begin the operation. The operation
        /// can move upward to less nested scopes as components with wider sharing scopes are activated.</param>
        public ResolveOperation(ISharingLifetimeScope mostNestedLifetimeScope)
            : base(mostNestedLifetimeScope)
        {
        }

        /// <summary>
        /// Execute the complete resolve operation.
        /// </summary>
        /// <param name="request">The resolution context.</param>
        [SuppressMessage("CA1031", "CA1031", Justification = "General exception gets rethrown in a DependencyResolutionException.")]
        public object Execute(ResolveRequest request)
        {
            return ExecuteOperation(request);
        }
    }
}
