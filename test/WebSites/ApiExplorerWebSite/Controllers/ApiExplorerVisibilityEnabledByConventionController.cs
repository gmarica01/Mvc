// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Mvc;

namespace ApiExplorerWebSite
{
    [Route("ApiExplorerVisbilityEnabledByConvention")]
    public class ApiExplorerVisbilityEnabledByConventionController : Controller
    {
        [HttpGet]
        public void Get()
        {
        }
    }
}