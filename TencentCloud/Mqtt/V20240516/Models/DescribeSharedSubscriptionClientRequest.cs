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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSharedSubscriptionClientRequest : AbstractModel
    {
        
        /// <summary>
        /// Tencent Cloud MQTT instance ID can be obtained from the [DescribeInstanceList](https://www.tencentcloud.com/document/api/1778/111029?from_cn_redirect=1) api or the console.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Shared subscription group name
        /// </summary>
        [JsonProperty("SharedName")]
        public string SharedName{ get; set; }

        /// <summary>
        /// Subscription expression.
        /// </summary>
        [JsonProperty("TopicFilter")]
        public string TopicFilter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SharedName", this.SharedName);
            this.SetParamSimple(map, prefix + "TopicFilter", this.TopicFilter);
        }
    }
}

