/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class ListKeyDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// This parameter has the same meaning of the `Offset` in an SQL query, indicating that this acquisition starts from the "No. Offset value" element of the array arranged in a certain order. The default value is 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// This parameter has the same meaning of the `Limit` in an SQL query, indicating that up to `Limit` value elements can be obtained in this request. The default value is 10 and the maximum value is 200.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Filters by creator role. 0 (default value): the CMK is created by the user; 1: the CMK is created automatically by an authorized Tencent Cloud service.
        /// </summary>
        [JsonProperty("Role")]
        public ulong? Role{ get; set; }

        /// <summary>
        /// Sorts by CMK creation time. 0: descending; 1: ascending
        /// </summary>
        [JsonProperty("OrderType")]
        public ulong? OrderType{ get; set; }

        /// <summary>
        /// Filters by CMK status. 0: all CMKs; 1: CMKs in `Enabled` status only; 2: CMKs in `Disabled` status only; 3: CMKs in `PendingDelete` status only (i.e., keys with schedule deletion enabled); 4: CMKs in `PendingImport` status only; 5: CMKs in `Archived` status only.
        /// </summary>
        [JsonProperty("KeyState")]
        public ulong? KeyState{ get; set; }

        /// <summary>
        /// Performs a fuzzy query by `KeyId` or `Alias`
        /// </summary>
        [JsonProperty("SearchKeyAlias")]
        public string SearchKeyAlias{ get; set; }

        /// <summary>
        /// Filters by CMK type. "TENCENT_KMS" indicates to filter CMKs whose key materials are created by KMS; "EXTERNAL" indicates to filter CMKs of `EXTERNAL` type whose key materials are imported by users; "ALL" or empty indicates to filter CMKs of both types. This value is case-sensitive.
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// Filter by `KeyUsage` of CMKs. Valid values: `ALL` (filter all CMKs), `ENCRYPT_DECRYPT` (it will be used when the parameter is left empty), `ASYMMETRIC_DECRYPT_RSA_2048`, `ASYMMETRIC_DECRYPT_SM2`.
        /// </summary>
        [JsonProperty("KeyUsage")]
        public string KeyUsage{ get; set; }

        /// <summary>
        /// Tag filter condition
        /// </summary>
        [JsonProperty("TagFilters")]
        public TagFilter[] TagFilters{ get; set; }


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
            this.SetParamSimple(map, prefix + "KeyUsage", this.KeyUsage);
            this.SetParamArrayObj(map, prefix + "TagFilters.", this.TagFilters);
        }
    }
}

