﻿// Author:					Joe Audette
// Created:					2015-07-06
// Last Modified:			2015-07-06
//

using cloudscribe.Core.Web.ViewModels;
using System;
using System.Collections.Generic;

namespace cloudscribe.Core.Web.Components
{
    public interface IBuildPaginationLinks
    {
        List<PaginationLink> BuildPaginationLinks(
            PaginationSettings paginationSettings,
            Func<int, string> generateUrl,
            string firstPageText,
            string firstPageTitle,
            string previousPageText,
            string previousPageTitle,
            string nextPageText,
            string nextPageTitle,
            string lastPageText,
            string lastPageTitle,
            string spacerText = "...");

    }
}
