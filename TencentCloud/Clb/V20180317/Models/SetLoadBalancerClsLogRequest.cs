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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetLoadBalancerClsLogRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the cloud load balancer instance. you can call the [DescribeLoadBalancers](https://www.tencentcloud.comom/document/product/1108/48459?from_cn_redirect=1) API to query the ID.
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// Log set ID of cloud log service (CLS).
        /// <li>Specifies the logset ID that can be obtained by calling the [DescribeLogsets](https://www.tencentcloud.comom/document/product/614/58624?from_cn_redirect=1) API when adding or updating a log topic.</li>.
        /// <Li>When deleting a log topic, set this parameter to an empty string.</li>.
        /// </summary>
        [JsonProperty("LogSetId")]
        public string LogSetId{ get; set; }

        /// <summary>
        /// Specifies the log topic ID of cloud log service (CLS).
        /// <li>Specifies the log topic ID can be obtained by calling the [DescribeTopics](https://www.tencentcloud.comom/document/product/614/56454?from_cn_redirect=1) API when adding or updating a log topic.</li>.
        /// <Li>When deleting a log topic, set this parameter to an empty string.</li>.
        /// </summary>
        [JsonProperty("LogTopicId")]
        public string LogTopicId{ get; set; }

        /// <summary>
        /// Log type:
        /// <li>`ACCESS`: access logs</li>
        /// <li>`HEALTH`: health check logs</li>
        /// Default: `ACCESS`
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "LogSetId", this.LogSetId);
            this.SetParamSimple(map, prefix + "LogTopicId", this.LogTopicId);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
        }
    }
}

