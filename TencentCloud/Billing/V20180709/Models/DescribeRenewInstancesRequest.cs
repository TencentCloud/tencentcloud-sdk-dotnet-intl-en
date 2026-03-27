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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRenewInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Maximum number of instances per page. Value range: 1-100.
        /// </summary>
        [JsonProperty("MaxResults")]
        public ulong? MaxResults{ get; set; }

        /// <summary>
        /// Token for querying the next page of returned results. NextToken is not needed when calling the API for the first time.
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// Get the sorting order of the instance. The enumerated values are as follows:
        /// false = Ascending (default)
        /// true=Descending
        /// </summary>
        [JsonProperty("Reverse")]
        public bool? Reverse{ get; set; }

        /// <summary>
        /// Renewal flag. Multiple values separated by commas. Enumeration value as follows:
        /// NOTIFY_AND_MANUAL_RENEW: manual renewal.
        /// NOTIFY_AND_AUTO_RENEW: automatic renewal.
        /// DISABLE_NOTIFY_AND_MANUAL_RENEW: non-renewal upon expiration.
        /// </summary>
        [JsonProperty("RenewFlagList")]
        public string[] RenewFlagList{ get; set; }

        /// <summary>
        /// Instance ID. Multiple IDs separated by commas, with a maximum of 100.
        /// </summary>
        [JsonProperty("InstanceIdList")]
        public string[] InstanceIdList{ get; set; }

        /// <summary>
        /// Expiry time start, format yyyy-MM-dd HH:mm:ss.
        /// </summary>
        [JsonProperty("ExpireTimeStart")]
        public string ExpireTimeStart{ get; set; }

        /// <summary>
        /// Expiry time in the format of yyyy-MM-dd HH:mm:ss.
        /// </summary>
        [JsonProperty("ExpireTimeEnd")]
        public string ExpireTimeEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamSimple(map, prefix + "Reverse", this.Reverse);
            this.SetParamArraySimple(map, prefix + "RenewFlagList.", this.RenewFlagList);
            this.SetParamArraySimple(map, prefix + "InstanceIdList.", this.InstanceIdList);
            this.SetParamSimple(map, prefix + "ExpireTimeStart", this.ExpireTimeStart);
            this.SetParamSimple(map, prefix + "ExpireTimeEnd", this.ExpireTimeEnd);
        }
    }
}

