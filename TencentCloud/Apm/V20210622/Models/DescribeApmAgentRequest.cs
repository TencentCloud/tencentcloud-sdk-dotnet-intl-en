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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeApmAgentRequest : AbstractModel
    {
        
        /// <summary>
        /// Business system id.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Access method: currently supports access and reporting via skywalking, ot, and ebpf methods. if not specified, ot is used by default.
        /// </summary>
        [JsonProperty("AgentType")]
        public string AgentType{ get; set; }

        /// <summary>
        /// Reporting environment: currently supports pl (private network reporting), public (public network), and inner (self-developed vpc) environment reporting. if not specified, the default is public.
        /// </summary>
        [JsonProperty("NetworkMode")]
        public string NetworkMode{ get; set; }

        /// <summary>
        /// Language reporting is now supported for java, golang, php, python, dotnet, nodejs. if not specified, golang is used by default.
        /// </summary>
        [JsonProperty("LanguageEnvironment")]
        public string LanguageEnvironment{ get; set; }

        /// <summary>
        /// Reporting method, deprecated.
        /// </summary>
        [JsonProperty("ReportMethod")]
        public string ReportMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AgentType", this.AgentType);
            this.SetParamSimple(map, prefix + "NetworkMode", this.NetworkMode);
            this.SetParamSimple(map, prefix + "LanguageEnvironment", this.LanguageEnvironment);
            this.SetParamSimple(map, prefix + "ReportMethod", this.ReportMethod);
        }
    }
}

