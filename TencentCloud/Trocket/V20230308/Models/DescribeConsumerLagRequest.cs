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

    public class DescribeConsumerLagRequest : AbstractModel
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
        /// Namespace. It is required for 4.x clusters. The namespace can be obtained from [RocketMQNamespace](https://www.tencentcloud.comom/document/api/1179/46089?from_cn_redirect=1#RocketMQNamespace) returned by the API [DescribeRocketMQNamespaces](https://www.tencentcloud.comom/document/api/1179/63419?from_cn_redirect=1) or from the console.
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Subscribed topic. If it is not left blank, query heaped messages of consumer groups subscribing to the topic. The topic can be obtained from [TopicItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#TopicItem) returned by the API [DescribeTopicList](https://www.tencentcloud.comom/document/api/1493/96030?from_cn_redirect=1) or from the console.
        /// </summary>
        [JsonProperty("SubscribeTopic")]
        public string SubscribeTopic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ConsumerGroup", this.ConsumerGroup);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "SubscribeTopic", this.SubscribeTopic);
        }
    }
}

