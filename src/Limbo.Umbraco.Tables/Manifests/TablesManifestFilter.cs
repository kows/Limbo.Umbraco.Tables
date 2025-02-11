﻿using System.Collections.Generic;
using Skybrud.Essentials.Strings.Extensions;
using Umbraco.Cms.Core.Manifest;

namespace Limbo.Umbraco.Tables.Manifests {

    /// <inheritdoc />
    public class TablesManifestFilter : IManifestFilter {

        /// <inheritdoc />
        public void Filter(List<PackageManifest> manifests) {
            manifests.Add(new PackageManifest {
                PackageName = TablesPackage.Alias.ToKebabCase(),
                BundleOptions = BundleOptions.Independent,
                Scripts = new[] {
                    $"/App_Plugins/{TablesPackage.Alias}/Scripts/Controllers/TableDataEditor.js",
                    $"/App_Plugins/{TablesPackage.Alias}/Scripts/Controllers/TableDataOverlay.js"
                },
                Stylesheets = new[] {
                    $"/App_Plugins/{TablesPackage.Alias}/Styles/Styles.css"
                }
            });
        }

    }

}