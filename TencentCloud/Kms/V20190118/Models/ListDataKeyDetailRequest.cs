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
        /// Meaning matches the Offset in SQL queries, indicates the retrieval starts from the Offset-th element in a sequentially arranged array, defaults to 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Specifies the maximum number of elements to retrieve, same as the Limit in SQL queries. default value is 10. maximum value is 200.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Filter by creator role. default 0 means data keys created by the user, 1 means data keys automatically created by authorized cloud services.
        /// </summary>
        [JsonProperty("Role")]
        public ulong? Role{ get; set; }

        /// <summary>
        /// Sorts according to the creation time of DataKey. 0 indicates descending sort. 1 indicates ascending sort.
        /// </summary>
        [JsonProperty("OrderType")]
        public ulong? OrderType{ get; set; }

        /// <summary>
        /// Filter based on DataKey state. 0 means all datakeys, 1 means querying only Enabled datakeys, 2 means querying only Disabled datakeys, 3 means querying datakeys in PendingDelete state (keys in scheduled deletion status).
        /// </summary>
        [JsonProperty("KeyState")]
        public ulong? KeyState{ get; set; }

        /// <summary>
        /// Performs a fuzzy match query based on DataKeyId or DataKeyName.
        /// </summary>
        [JsonProperty("SearchKeyAlias")]
        public string SearchKeyAlias{ get; set; }

        /// <summary>
        /// Filters data keys by DateKey type. "TENCENT_KMS" filters data keys with key material created by KMS. "EXTERNAL" filters EXTERNAL type data keys requiring user-imported key material. "ALL" or leave unset queries both types. case-sensitive.
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// HSM cluster ID corresponding to KMS advanced edition.
        /// </summary>
        [JsonProperty("HsmClusterId")]
        public string HsmClusterId{ get; set; }

        /// <summary>
        /// Specifies the globally unique identifier of the root key.
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// Length of the data key.
        /// </summary>
        [JsonProperty("DataKeyLen")]
        public ulong? DataKeyLen{ get; set; }


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
        }
    }
}

