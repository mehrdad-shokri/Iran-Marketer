﻿/*
 * Copyright 2014 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Sahra.MutualFund.IdentityAdmin.Core.Configuration
{
    /// <summary>
    /// Models the registration of a dependency within the IdentityServer dependency injection system.
    /// </summary>
    public abstract class Registration
    {
        /// <summary>
        /// The type of dependency the registration implements.
        /// </summary>
        /// <value>
        /// The dependency type.
        /// </value>
        public abstract Type DependencyType { get; }

        /// <summary>
        /// The optional name used for the registration. If provided, then the dependency 
        /// must be resolved by both type and name. This is only used for custom registrations.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; protected set; }

        /// <summary>
        /// The singleton instance that represents the registration. The same instance will be 
        /// used each time the dependency is resolved.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public object Instance { get; protected set; }

        /// <summary>
        /// The type that use for the dependency that implements <see cref="DependencyType"/>. A new instance
        /// will be created each time is the dependency is resolved. If the type impelments <see cref="System.IDisposable"/>
        /// then <c>Dispose</c> will be called after each request.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public Type Type { get; protected set; }

        /// <summary>
        /// A factory function to obtain the dependency. The function will be invoked each time the dependency is 
        /// resolved. If the returned object impelments <see cref="System.IDisposable"/>
        /// then <c>Dispose</c> will be called after each request.
        /// The <see cref="IAdminDependencyResolver"/> parameter can be 
        /// used to resolve other dependencies.
        /// </summary>
        /// <value>
        /// The factory.
        /// </value>
        public Func<IAdminDependencyResolver, object> Factory { get; protected set; }
    }


    /// <summary>
    /// Strongly typed <see cref="Registration" /> implementation.
    /// </summary>
    /// <typeparam name="T">The <see cref="DependencyType"/>.</typeparam>
    public class Registration<T> : Registration
        where T : class
    {
        /// <summary>
        /// The type of dependency the registration implements.
        /// </summary>
        /// <value>
        /// The dependency type.
        /// </value>
        public override Type DependencyType
        {
            get { return typeof(T); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Registration{T}" /> class where the <see cref="Type"/>
        /// is the same as the <see cref="DependencyType"/>.
        /// </summary>
        /// <param name="name">The name.</param>
        public Registration(string name = null)
        {
            this.Type = typeof(T);
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Registration{T}"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="name">The name.</param>
        /// <exception cref="System.ArgumentNullException">type</exception>
        public Registration(Type type, string name = null)
        {
            if (type == null) throw new ArgumentNullException("type");

            this.Type = type;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Registration{T}"/> class.
        /// </summary>
        /// <param name="factory">The factory.</param>
        /// <param name="name">The name.</param>
        /// <exception cref="System.ArgumentNullException">factory</exception>
        public Registration(Func<IAdminDependencyResolver, T> factory, string name = null)
        {
            if (factory == null) throw new ArgumentNullException("factory");

            this.Factory = factory;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Registration{T}"/> class.
        /// </summary>
        /// <param name="singleton">The singleton instance.</param>
        /// <param name="name">The name.</param>
        /// <exception cref="System.ArgumentNullException">instance</exception>
        public Registration(T singleton, string name = null)
        {
            if (singleton == null) throw new ArgumentNullException("instance");

            this.Instance = singleton;
            this.Name = name;
        }

        internal Registration(Registration<T> registration, string name)
        {
            if (registration == null) throw new ArgumentNullException("registration");
            if (name == null) throw new ArgumentNullException("name");

            this.Type = registration.Type;
            this.Factory = registration.Factory;
            this.Instance = registration.Instance;
            this.Name = name;
        }
    }

    /// <summary>
    /// Strongly typed <see cref="Registration" /> implementation.
    /// </summary>
    /// <typeparam name="T">The <see cref="Registration{T}.DependencyType"/>.</typeparam>
    /// <typeparam name="TImpl">The <see cref="Type"/>.</typeparam>
    public class Registration<T, TImpl> : Registration<T>
        where T : class
        where TImpl : T
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Registration{T, TImpl}"/> class.
        /// </summary>
        /// <param name="name">Dependency name.</param>
        public Registration(string name = null)
            : base(typeof(TImpl), name)
        {
        }
    }
}