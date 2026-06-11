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

    public class ModifyRecordingRuleYamlTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Yaml configuration id</p>
        /// </summary>
        [JsonProperty("YamlID")]
        public string YamlID{ get; set; }

        /// <summary>
        /// <p>Source metric topic id</p>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>Target metric topic id</p>
        /// </summary>
        [JsonProperty("DstTopicId")]
        public string DstTopicId{ get; set; }

        /// <summary>
        /// <p>Task status: 1: Enabled; 2: Disabled</p>
        /// </summary>
        [JsonProperty("EnableFlag")]
        public ulong? EnableFlag{ get; set; }

        /// <summary>
        /// <p>Schedule start time, Unix timestamp in milliseconds</p>
        /// </summary>
        [JsonProperty("ProcessStartTime")]
        public ulong? ProcessStartTime{ get; set; }

        /// <summary>
        /// <p>Scheduling period (minutes). Supported range (0,1440] minutes.</p>
        /// </summary>
        [JsonProperty("ProcessPeriod")]
        public long? ProcessPeriod{ get; set; }

        /// <summary>
        /// <p>Execution Delay (Seconds)</p>
        /// </summary>
        [JsonProperty("ProcessDelay")]
        public long? ProcessDelay{ get; set; }

        /// <summary>
        /// <p>yaml configuration name</p>
        /// </summary>
        [JsonProperty("YamlConfigName")]
        public string YamlConfigName{ get; set; }

        /// <summary>
        /// <p>yaml configuration content</p>
        /// </summary>
        [JsonProperty("YamlContent")]
        public string YamlContent{ get; set; }

        /// <summary>
        /// <p>Whether to enable service log shipping. Valid values: 1: disable; 2: enable.</p>
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "YamlID", this.YamlID);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "DstTopicId", this.DstTopicId);
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamSimple(map, prefix + "ProcessStartTime", this.ProcessStartTime);
            this.SetParamSimple(map, prefix + "ProcessPeriod", this.ProcessPeriod);
            this.SetParamSimple(map, prefix + "ProcessDelay", this.ProcessDelay);
            this.SetParamSimple(map, prefix + "YamlConfigName", this.YamlConfigName);
            this.SetParamSimple(map, prefix + "YamlContent", this.YamlContent);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
        }
    }
}

