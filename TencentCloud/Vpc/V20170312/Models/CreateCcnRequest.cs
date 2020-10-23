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

    public class CreateCcnRequest : AbstractModel
    {
        
        /// <summary>
        /// The name of the CCN. The maximum length is 60 characters.
        /// </summary>
        [JsonProperty("CcnName")]
        public string CcnName{ get; set; }

        /// <summary>
        /// The description of the CCN. The maximum length is 100 characters.
        /// </summary>
        [JsonProperty("CcnDescription")]
        public string CcnDescription{ get; set; }

        /// <summary>
        /// CCN service quality, 'PT': Platinum, 'AU': Gold, 'AG': Silver. The default is 'AU'.
        /// </summary>
        [JsonProperty("QosLevel")]
        public string QosLevel{ get; set; }

        /// <summary>
        /// The billing method. POSTPAID: postpaid by traffic. Default: POSTPAID.
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// The bandwidth limit type. OUTER_REGION_LIMIT: regional outbound limit. INTER_REGION_LIMIT: inter-regional limit. Default: OUTER_REGION_LIMIT.
        /// </summary>
        [JsonProperty("BandwidthLimitType")]
        public string BandwidthLimitType{ get; set; }

        /// <summary>
        /// Bound tags, such as [{"Key": "city", "Value": "shanghai"}].
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnName", this.CcnName);
            this.SetParamSimple(map, prefix + "CcnDescription", this.CcnDescription);
            this.SetParamSimple(map, prefix + "QosLevel", this.QosLevel);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "BandwidthLimitType", this.BandwidthLimitType);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

