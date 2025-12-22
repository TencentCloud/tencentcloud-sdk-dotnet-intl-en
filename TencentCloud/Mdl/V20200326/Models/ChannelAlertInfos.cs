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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelAlertInfos : AbstractModel
    {
        
        /// <summary>
        /// Alarm details of pipeline 0 under this channel.
        /// </summary>
        [JsonProperty("Pipeline0")]
        public ChannelPipelineAlerts[] Pipeline0{ get; set; }

        /// <summary>
        /// Alarm details of pipeline 1 under this channel.
        /// </summary>
        [JsonProperty("Pipeline1")]
        public ChannelPipelineAlerts[] Pipeline1{ get; set; }

        /// <summary>
        /// Pipeline 0 total active alarm count
        /// </summary>
        [JsonProperty("PipelineAActiveAlerts")]
        public long? PipelineAActiveAlerts{ get; set; }

        /// <summary>
        /// Pipeline 1 total active alarm count
        /// </summary>
        [JsonProperty("PipelineBActiveAlerts")]
        public long? PipelineBActiveAlerts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Pipeline0.", this.Pipeline0);
            this.SetParamArrayObj(map, prefix + "Pipeline1.", this.Pipeline1);
            this.SetParamSimple(map, prefix + "PipelineAActiveAlerts", this.PipelineAActiveAlerts);
            this.SetParamSimple(map, prefix + "PipelineBActiveAlerts", this.PipelineBActiveAlerts);
        }
    }
}

