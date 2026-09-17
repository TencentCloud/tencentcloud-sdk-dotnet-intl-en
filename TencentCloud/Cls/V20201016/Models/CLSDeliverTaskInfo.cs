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

    public class CLSDeliverTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Task ID.</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>Task name</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>Main account id</p>
        /// </summary>
        [JsonProperty("Uin")]
        public ulong? Uin{ get; set; }

        /// <summary>
        /// <p>Source topic information</p>
        /// </summary>
        [JsonProperty("SourceTopicConfig")]
        public SourceTopicConfig SourceTopicConfig{ get; set; }

        /// <summary>
        /// <p>Target topic information</p>
        /// </summary>
        [JsonProperty("TargetTopicConfig")]
        public TargetTopicConfig TargetTopicConfig{ get; set; }

        /// <summary>
        /// <p>Shipping Rule</p>
        /// </summary>
        [JsonProperty("DeliverRule")]
        public DeliverRule DeliverRule{ get; set; }

        /// <summary>
        /// <p>Compliance guarantee</p>
        /// </summary>
        [JsonProperty("Compliance")]
        public ulong? Compliance{ get; set; }

        /// <summary>
        /// <p>Task status.</p><p>Enumeration values: </p><ul><li>0: Running, </li><li>1: Paused, </li><li>2: Completed, </li><li>3: Exception.</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>Status.</p><p>Enumeration values: </p><ul><li>0: Running, </li><li>1: Suspended.</li></ul>
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// <p>Task progress percentage</p>
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }

        /// <summary>
        /// <p>Whether delivery service log is enabled.</p><p>Enumeration values:</p><ul><li>1: Disabled</li><li>2: Enabled</li></ul>
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }

        /// <summary>
        /// <p>Creation time.</p><p>Unit: unix second-level timestamp</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>Update time</p><p>Unit: unix second-level timestamp</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamObj(map, prefix + "SourceTopicConfig.", this.SourceTopicConfig);
            this.SetParamObj(map, prefix + "TargetTopicConfig.", this.TargetTopicConfig);
            this.SetParamObj(map, prefix + "DeliverRule.", this.DeliverRule);
            this.SetParamSimple(map, prefix + "Compliance", this.Compliance);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

