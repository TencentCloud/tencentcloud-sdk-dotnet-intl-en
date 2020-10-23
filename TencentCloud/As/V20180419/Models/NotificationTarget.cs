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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NotificationTarget : AbstractModel
    {
        
        /// <summary>
        /// Target type. Value range: `CMQ_QUEUE`, `CMQ_TOPIC`.
        /// <li> CMQ_QUEUE: CMQ_QUEUE: CMQ queue model.</li>
        /// <li> CMQ_TOPIC: CMQ topic model.</li>
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// Queue name. If `TargetType` is `CMQ_QUEUE`, this parameter is required.
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// Topic name. If `TargetType` is `CMQ_TOPIC`, this parameter is required.
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

