/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FetchOption : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether to return the permission list in response. Default false.</p>
        /// </summary>
        [JsonProperty("FetchPermissions")]
        public bool? FetchPermissions{ get; set; }

        /// <summary>
        /// <p>Whether to obtain feature table details. Valid when AssetType is TABLE.</p>
        /// </summary>
        [JsonProperty("FetchFeatureTableDetail")]
        public bool? FetchFeatureTableDetail{ get; set; }

        /// <summary>
        /// <p>Filter by permission. Pass in a list of permissions to return only entities for which the current user has the specified permissions. For example, passing in ["SELECT_TABLE"] returns only entities for which the current user has the SELECT_TABLE permission. This only takes effect for the list Interface. If empty, no permission filtering is performed.</p>
        /// </summary>
        [JsonProperty("FilterPermissions")]
        public string[] FilterPermissions{ get; set; }

        /// <summary>
        /// <p>Whether to return person in charge information in response. If this parameter is not passed or is true, the person in charge information is returned by default. If it is explicitly set to false, it is not returned.</p>
        /// </summary>
        [JsonProperty("FetchOwners")]
        public bool? FetchOwners{ get; set; }

        /// <summary>
        /// <p>Whether to convert user Uin to userName. Impact range: CreatorName/LastModifierName in Audit, OwnerName in MetaOwner. If not passed or set to true, conversion is executed (default conversion). If explicitly set to false, do not convert</p>
        /// </summary>
        [JsonProperty("FetchUserInfo")]
        public bool? FetchUserInfo{ get; set; }

        /// <summary>
        /// <p>Whether to return field masking policy information. It is not returned by default. If true is passed in, the field masking policy information corresponding to the table fields will be queried.</p>
        /// </summary>
        [JsonProperty("FetchMask")]
        public bool? FetchMask{ get; set; }

        /// <summary>
        /// <p>Whether to return tag information. By default, it is not returned. When set to true, APIs such as GetTable/ListTables/GetCatalog/ListCatalogs/GetSchema/ListSchemas/GetView/ListViews/GetFunction/ListFunctions/GetVolume/ListVolumes/GetModel/ListModels will return the Tags field in the corresponding entity.</p>
        /// </summary>
        [JsonProperty("FetchTags")]
        public bool? FetchTags{ get; set; }

        /// <summary>
        /// <p>Whether to return the dictionary dimension information associated with the returned field. Default not passed, do not return</p>
        /// </summary>
        [JsonProperty("FetchDimensions")]
        public bool? FetchDimensions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FetchPermissions", this.FetchPermissions);
            this.SetParamSimple(map, prefix + "FetchFeatureTableDetail", this.FetchFeatureTableDetail);
            this.SetParamArraySimple(map, prefix + "FilterPermissions.", this.FilterPermissions);
            this.SetParamSimple(map, prefix + "FetchOwners", this.FetchOwners);
            this.SetParamSimple(map, prefix + "FetchUserInfo", this.FetchUserInfo);
            this.SetParamSimple(map, prefix + "FetchMask", this.FetchMask);
            this.SetParamSimple(map, prefix + "FetchTags", this.FetchTags);
            this.SetParamSimple(map, prefix + "FetchDimensions", this.FetchDimensions);
        }
    }
}

