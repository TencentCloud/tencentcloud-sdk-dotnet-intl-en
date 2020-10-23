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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InternetAccessible : AbstractModel
    {
        
        /// <summary>
        /// TRAFFIC_POSTPAID_BY_HOUR: hourly pay-as-you-go by traffic; BANDWIDTH_POSTPAID_BY_HOUR: hourly pay-as-you-go by bandwidth;
        /// BANDWIDTH_PACKAGE: billed by bandwidth package (currently, this method is supported only if the ISP is specified)
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// Maximum outbound bandwidth in Mbps, which applies only to public network CLB. Value range: 0-65,535. Default value: 10.
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// Bandwidth package type, such as SINGLEISP
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BandwidthpkgSubType")]
        public string BandwidthpkgSubType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "BandwidthpkgSubType", this.BandwidthpkgSubType);
        }
    }
}

