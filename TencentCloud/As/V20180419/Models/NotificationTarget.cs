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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NotificationTarget : AbstractModel
    {
        
        /// <summary>
        /// Target type. valid values include `CMQ_QUEUE`, `CMQ_TOPIC`, `TDMQ_CMQ_QUEUE`, `TDMQ_CMQ_TOPIC`.
        /// <li>CMQ_QUEUE, specifies tencent cloud message QUEUE - queueing model. the corresponding product is offline. it is recommended to switch to TDMQ_CMQ_QUEUE (https://intl.cloud.tencent.com/document/product/1496/83970?from_cn_redirect=1).</li>.
        /// <li>CMQ_TOPIC, specifies tencent cloud message queue - TOPIC model. the corresponding product is offline. it is recommended to switch to TDMQ_CMQ_TOPIC (https://intl.cloud.tencent.com/document/product/1496/83970?from_cn_redirect=1).</li>.
        /// <li> TDMQ_CMQ_QUEUE. specifies the tencent cloud TDMQ message QUEUE - queueing model.</li>.
        /// <Li>TDMQ_CMQ_TOPIC. specifies tencent cloud tdmq message queue - topic model.</li>.
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// Queue name. This parameter is required when `TargetType` is `CMQ_QUEUE` or `TDMQ_CMQ_QUEUE`.
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// Topic name. This parameter is required when `TargetType` is `CMQ_TOPIC` or `TDMQ_CMQ_TOPIC`.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
        }
    }
}

