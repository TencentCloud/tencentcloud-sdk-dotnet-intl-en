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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ShareBlueprintAcrossAccountsRequest : AbstractModel
    {
        
        /// <summary>
        /// Image ID, which can be obtained through the BlueprintId returned by the [DescribeBlueprints](https://www.tencentcloud.comom/document/product/1207/47689?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("BlueprintId")]
        public string BlueprintId{ get; set; }

        /// <summary>
        /// List of [account IDs](https://www.tencentcloud.comom/document/product/213/4944?from_cn_redirect=1#.E8.8E.B7.E5.8F.96.E4.B8.BB.E8.B4.A6.E5.8F.B7.E7.9A.84.E8.B4.A6.E5.8F.B7-id) that receive the shared images. The account ID is different from the QQ number. To query a user account ID, view the account ID column in the account information. The maximum number of accounts is 10.
        /// </summary>
        [JsonProperty("AccountIds")]
        public string[] AccountIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlueprintId", this.BlueprintId);
            this.SetParamArraySimple(map, prefix + "AccountIds.", this.AccountIds);
        }
    }
}

