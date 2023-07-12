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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CcnBandwidthInfo : AbstractModel
    {
        
        /// <summary>
        /// The CCN ID that the bandwidth belongs to.
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// The creation time of the instance.
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// The expiration time of the instance.
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// The unique ID of the bandwidth instance.
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("RegionFlowControlId")]
        public string RegionFlowControlId{ get; set; }

        /// <summary>
        /// The billing flag.
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// The information of the bandwidth regions and bandwidth caps. The parameter is only returned for the cross-region limit mode, but not for egress limit.
        /// Note: this field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("CcnRegionBandwidthLimit")]
        public CcnRegionBandwidthLimit CcnRegionBandwidthLimit{ get; set; }

        /// <summary>
        /// Cloud marketplace instance ID.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MarketId")]
        public string MarketId{ get; set; }

        /// <summary>
        /// The list of tags to be bound.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "RegionFlowControlId", this.RegionFlowControlId);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamObj(map, prefix + "CcnRegionBandwidthLimit.", this.CcnRegionBandwidthLimit);
            this.SetParamSimple(map, prefix + "MarketId", this.MarketId);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
        }
    }
}

