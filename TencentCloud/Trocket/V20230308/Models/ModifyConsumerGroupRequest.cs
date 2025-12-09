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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyConsumerGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// TDMQ RocketMQ instance ID. It can be obtained from the API [DescribeFusionInstanceList](https://www.tencentcloud.comom/document/api/1493/106745?from_cn_redirect=1) or the console.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Consumer group name. It can be obtained from [ConsumeGroupItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#ConsumeGroupItem) returned by the API [DescribeConsumerGroupList](https://www.tencentcloud.comom/document/api/1493/101535?from_cn_redirect=1) or from the console.
        /// </summary>
        [JsonProperty("ConsumerGroup")]
        public string ConsumerGroup{ get; set; }

        /// <summary>
        /// Whether to enable consumption.
        /// </summary>
        [JsonProperty("ConsumeEnable")]
        public bool? ConsumeEnable{ get; set; }

        /// <summary>
        /// Specifies whether to use ordered delivery. valid values: true.
        /// Concurrent delivery: false.
        /// </summary>
        [JsonProperty("ConsumeMessageOrderly")]
        public bool? ConsumeMessageOrderly{ get; set; }

        /// <summary>
        /// Maximum number of retries. Value range: 0 to 1000.
        /// </summary>
        [JsonProperty("MaxRetryTimes")]
        public long? MaxRetryTimes{ get; set; }

        /// <summary>
        /// Remarks. Up to 128 characters are allowed.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ConsumerGroup", this.ConsumerGroup);
            this.SetParamSimple(map, prefix + "ConsumeEnable", this.ConsumeEnable);
            this.SetParamSimple(map, prefix + "ConsumeMessageOrderly", this.ConsumeMessageOrderly);
            this.SetParamSimple(map, prefix + "MaxRetryTimes", this.MaxRetryTimes);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

