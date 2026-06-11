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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Ckafka : AbstractModel
    {
        
        /// <summary>
        /// InstanceId of Ckafka.
        /// - Obtain the instance id by searching the instance list information (https://www.tencentcloud.com/document/product/597/40835?from_cn_redirect=1).
        /// - Obtain the instance id by [creating an instance](https://www.tencentcloud.com/document/product/597/53207?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// TopicName of Ckafka
        /// -Obtain the TopicName by creating a topic (https://www.tencentcloud.com/document/product/597/73566?from_cn_redirect=1).
        /// -Obtain the TopicName through [Get Topic List](https://www.tencentcloud.com/document/product/597/40847?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Vip of Ckafka.
        /// - Obtain vip information by searching the instance attributes (https://www.tencentcloud.com/document/product/597/40836?from_cn_redirect=1).
        /// -If the delivery task is created via the role ARN method, the Vip field can be empty.
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Vport of Ckafka.
        /// -Obtain vip port information by [obtaining instance attributes](https://www.tencentcloud.com/document/product/597/40836?from_cn_redirect=1).
        /// -If it is created by the role ARN method, the Vport field can be empty.
        /// </summary>
        [JsonProperty("Vport")]
        public string Vport{ get; set; }

        /// <summary>
        /// InstanceName of Ckafka.
        /// - Obtain the InstanceName by searching the instance list information (https://www.tencentcloud.com/document/product/597/40835?from_cn_redirect=1).
        /// -Get InstanceName by [creating an instance](https://www.tencentcloud.com/document/product/597/53207?from_cn_redirect=1).
        /// - If the delivery task is created via the role ARN method, the InstanceName field can be empty.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Topic ID of Ckafka.
        /// -Obtain the TopicId by creating a topic (https://www.tencentcloud.com/document/product/597/73566?from_cn_redirect=1).
        /// -Obtain the TopicId through [Get Topic List](https://www.tencentcloud.com/document/product/597/40847?from_cn_redirect=1).
        /// - If the delivery task is created via the role ARN method, the TopicId field can be empty.
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
        }
    }
}

