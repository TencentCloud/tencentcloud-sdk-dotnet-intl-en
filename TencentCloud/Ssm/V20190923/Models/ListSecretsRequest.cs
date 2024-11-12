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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListSecretsRequest : AbstractModel
    {
        
        /// <summary>
        /// Starting position of the list, starting at 0. If not specified, 0 is used by default.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Maximum number of returned Secrets in a query. If not set or set to 0, 20 is used by default.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Sorting order according to the creation time. If not set or set to 0, descending order is used; if set to 1, ascending order is used.
        /// </summary>
        [JsonProperty("OrderType")]
        public ulong? OrderType{ get; set; }

        /// <summary>
        /// Filter based on credential status.
        /// The default value is 0, indicating to query all.
        /// 1: query the list of credentials in `Enabled` status.
        /// 2: query the list of credentials in `Disabled` status.
        /// 3: query the list of credentials in `PendingDelete` status.
        /// 4: query the list of credentials in `PendingCreate` status.
        /// 5: query the list of credentials in `CreateFailed` status.
        /// The `PendingCreate` and `CreateFailed` status only take effect when `SecretType` is Tencent Cloud service credential
        /// </summary>
        [JsonProperty("State")]
        public ulong? State{ get; set; }

        /// <summary>
        /// Filter according to Secret names. If left empty, this filter is not applied.
        /// </summary>
        [JsonProperty("SearchSecretName")]
        public string SearchSecretName{ get; set; }

        /// <summary>
        /// Tag filter.
        /// </summary>
        [JsonProperty("TagFilters")]
        public TagFilter[] TagFilters{ get; set; }

        /// <summary>
        /// `0` (default): user-defined secret.
        /// `1`: Tencent Cloud services secret.
        /// `2`: SSH key secret.
        /// `3`: Tencent Cloud API key secret.
        /// </summary>
        [JsonProperty("SecretType")]
        public ulong? SecretType{ get; set; }

        /// <summary>
        /// This parameter only takes effect when the value of the SecretType parameter is 1.\nWhen the value of SecretType is `1`:
        /// If the ProductName value is empty, it means querying all types of Tencent Cloud product secrets;If the ProductName value is a specific cloud product value such as MySQL, it means querying MySQL database credential;If the ProductName value is multiple cloud product values, such as: Mysql, Tdsql-mysql, Tdsql_C_Mysql (multiple values are separated by commas in English), it means querying the secrets of three cloud product types;To query the list of supported cloud products, use the interface: `DescribeSupportedProducts`.
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "SearchSecretName", this.SearchSecretName);
            this.SetParamArrayObj(map, prefix + "TagFilters.", this.TagFilters);
            this.SetParamSimple(map, prefix + "SecretType", this.SecretType);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
        }
    }
}

