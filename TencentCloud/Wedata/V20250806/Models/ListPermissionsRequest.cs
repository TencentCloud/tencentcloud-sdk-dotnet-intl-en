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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListPermissionsRequest : AbstractModel
    {
        
        /// <summary>
        /// Resource.
        /// ResourceType: originates from the ResourceType returned by the GetGrantPrivilegesSTD API in the TCCATALOG module, and change to capitalize the first letter, such as METALAKE corresponding to METALAKE.
        /// ResourceUri depends on ResourceType. fixed as default for Metalake. use the three-segment format of catalog for other categories, such as.
        /// -Metalake, fixed as default.
        /// -Catalog. specifies the catalogName.
        /// -Schema. valid values: catalogName.SchemaName.
        /// -Table. specifies catalogName.SchemaName.TableName.
        /// </summary>
        [JsonProperty("Resource")]
        public PrivilegeResource Resource{ get; set; }

        /// <summary>
        /// Filtering conditions (this parameter is not supported).
        /// </summary>
        [JsonProperty("Filters")]
        public SecurityFilter[] Filters{ get; set; }

        /// <summary>
        /// Sorting field (this parameter is not supported).
        /// </summary>
        [JsonProperty("OrderFields")]
        public OrderField[] OrderFields{ get; set; }

        /// <summary>
        /// Page parameter (this parameter is not supported).
        /// </summary>
        [JsonProperty("Page")]
        public Page Page{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Resource.", this.Resource);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "OrderFields.", this.OrderFields);
            this.SetParamObj(map, prefix + "Page.", this.Page);
        }
    }
}

