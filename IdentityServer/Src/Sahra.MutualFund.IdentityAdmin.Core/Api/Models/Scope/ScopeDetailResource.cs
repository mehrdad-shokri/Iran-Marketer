﻿/*
 * Copyright 2014 Dominick Baier, Brock Allen, Bert Hoorne
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
using System.Collections.Generic;
using System.Web.Http.Routing;
using Sahra.MutualFund.IdentityAdmin.Core.Core.Metadata;
using Sahra.MutualFund.IdentityAdmin.Core.Core.Scope;
using Sahra.MutualFund.IdentityAdmin.Core.Extensions;

namespace Sahra.MutualFund.IdentityAdmin.Core.Api.Models.Scope
{
    public class ScopeDetailResource
    {
        public ScopeDetailResource(ScopeDetail scope, UrlHelper url, IdentityAdminMetadata idmAdminMeta)
        {
            if (scope == null) throw new ArgumentNullException("scope");
            if (url == null) throw new ArgumentNullException("url");
            if (idmAdminMeta == null) throw new ArgumentNullException("idmAdminMeta");

            Data = new ScopeDetailDataResource(scope, url, idmAdminMeta);

            var links = new Dictionary<string, string>();
            if (idmAdminMeta.ClientMetaData.SupportsDelete)
            {
                links["Delete"] = url.RelativeLink(Constants.RouteNames.DeleteScope, new { subject = scope.Subject });
            }
            Links = links;
        }

        public ScopeDetailDataResource Data { get; set; }
        public object Links { get; set; }
    }
}