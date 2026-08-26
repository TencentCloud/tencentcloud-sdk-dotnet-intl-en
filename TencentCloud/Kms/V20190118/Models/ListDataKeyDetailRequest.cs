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

namespace TencentCloud.Kms.V20190118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListDataKeyDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>It means the same as the Offset in SQL queries, indicating that this retrieval starts from the Offset-th element of the sequentially arranged array. It defaults to 0.</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>The meaning is consistent with the Limit in SQL queries, indicating that this time up to Limit elements can be retrieved. The default value is 10, and the maximum value is 200.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>Filter by creator role. Default value 0 indicates data keys created by the user, and 1 indicates data keys automatically created by authorized other Cloud services.</p>
        /// </summary>
        [JsonProperty("Role")]
        public ulong? Role{ get; set; }

        /// <summary>
        /// <p>Sort by DataKey creation time. 0 indicates sort in descending order, and 1 indicates sort in ascending order.</p>
        /// </summary>
        [JsonProperty("OrderType")]
        public ulong? OrderType{ get; set; }

        /// <summary>
        /// <p>Filter by DataKey status. 0 indicates all DataKeys, 1 indicates querying only Enabled DataKeys, 2 indicates querying only Disabled DataKeys, and 3 indicates querying DataKeys in PendingDelete state (keys in scheduled deletion status).</p>
        /// </summary>
        [JsonProperty("KeyState")]
        public ulong? KeyState{ get; set; }

        /// <summary>
        /// <p>Perform a fuzzy match query by DataKeyId or DataKeyName</p>
        /// </summary>
        [JsonProperty("SearchKeyAlias")]
        public string SearchKeyAlias{ get; set; }

        /// <summary>
        /// <p>Filter by DateKey type. "TENCENT_KMS" filters data keys with key material created by KMS. "EXTERNAL" filters EXTERNAL type data keys with key material to import. "ALL" or leave unset queries both types. Case-sensitive.</p>
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// <p>HSM Cluster ID corresponding to the KMS advanced edition. When specifying a cluster ID, query the key list within the specified cluster. When specifying default, query the key list of the public cloud shared version. If empty, query all key lists by default, including cluster and non-cluster.</p>
        /// </summary>
        [JsonProperty("HsmClusterId")]
        public string HsmClusterId{ get; set; }

        /// <summary>
        /// <p>Root key globally unique identifier</p>
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// <p>Length of the data key</p>
        /// </summary>
        [JsonProperty("DataKeyLen")]
        public ulong? DataKeyLen{ get; set; }

        /// <summary>
        /// <p>Tag filtering condition</p>
        /// </summary>
        [JsonProperty("TagFilters")]
        public TagFilter[] TagFilters{ get; set; }

        /// <summary>
        /// <p>Member account information array</p>
        /// </summary>
        [JsonProperty("MemberAccounts")]
        public MemberAccount[] MemberAccounts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "KeyState", this.KeyState);
            this.SetParamSimple(map, prefix + "SearchKeyAlias", this.SearchKeyAlias);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "HsmClusterId", this.HsmClusterId);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "DataKeyLen", this.DataKeyLen);
            this.SetParamArrayObj(map, prefix + "TagFilters.", this.TagFilters);
            this.SetParamArrayObj(map, prefix + "MemberAccounts.", this.MemberAccounts);
        }
    }
}

