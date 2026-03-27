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

    public class SetRenewalRequest : AbstractModel
    {
        
        /// <summary>
        /// Product code.
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// Region code.
        /// </summary>
        [JsonProperty("RegionCode")]
        public string RegionCode{ get; set; }

        /// <summary>
        /// Instance ID. Only one can be specified.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Renewal flag. Enumeration values are as follows:
        /// NOTIFY_AND_MANUAL_RENEW: manual renewal.
        /// NOTIFY_AND_AUTO_RENEW: automatic renewal.
        /// DISABLE_NOTIFY_AND_MANUAL_RENEW: non-renewal upon expiration.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// Automatic renewal cycle length. If left empty, the default value set by product is used.
        /// If it is month, support: 1-11
        /// If it is year, support: 1-5.
        /// Supported range mainly depends on the product side.
        /// </summary>
        [JsonProperty("RenewPeriod")]
        public string RenewPeriod{ get; set; }

        /// <summary>
        /// Automatic renewal cycle unit. If left empty, the default value set by the product is used.
        /// Year y, month m
        /// Supported range mainly depends on the product side.
        /// </summary>
        [JsonProperty("RenewPeriodUnit")]
        public string RenewPeriodUnit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "RegionCode", this.RegionCode);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "RenewPeriod", this.RenewPeriod);
            this.SetParamSimple(map, prefix + "RenewPeriodUnit", this.RenewPeriodUnit);
        }
    }
}

