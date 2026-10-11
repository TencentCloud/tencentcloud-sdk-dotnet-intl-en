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

    public class ListConsoleUsersRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Page number. Value range: starts from 1. Default value: 1.</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>Size per page. Default: 10; Minimum: 10; Maximum: 100</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>Fuzzy matching between username and UIN</p>
        /// </summary>
        [JsonProperty("UserKeyword")]
        public string UserKeyword{ get; set; }

        /// <summary>
        /// <p>Used to filter users associated with roles</p><p>Enumeration values:</p><ul><li>2001: Console Administrator</li><li>2002: Console Member</li></ul><p>Can be obtained through the ListConsoleRoles API</p>
        /// </summary>
        [JsonProperty("RoleIds")]
        public string[] RoleIds{ get; set; }

        /// <summary>
        /// <p>Multi-field sorting, for example [{Name: 'CreateTime', Direction: 'Desc'}, {Name: 'UserName', Direction: 'Asc'}]. By default, it sorts in descending order by creation time.</p>
        /// </summary>
        [JsonProperty("OrderBys")]
        public OrderBy[] OrderBys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "UserKeyword", this.UserKeyword);
            this.SetParamArraySimple(map, prefix + "RoleIds.", this.RoleIds);
            this.SetParamArrayObj(map, prefix + "OrderBys.", this.OrderBys);
        }
    }
}

