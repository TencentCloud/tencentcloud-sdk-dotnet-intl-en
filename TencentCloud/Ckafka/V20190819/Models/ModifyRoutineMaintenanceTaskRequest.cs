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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRoutineMaintenanceTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the ckafka cluster instance id. can be obtained through the [DescribeInstances](https://www.tencentcloud.com/document/product/597/40835?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Automated operation and maintenance category. valid values: QUOTA, ANALYSIS, RE_BALANCE, ELASTIC_BANDWIDTH.
        /// </summary>
        [JsonProperty("MaintenanceType")]
        public string MaintenanceType{ get; set; }

        /// <summary>
        /// INSTANCE_STORAGE_CAPACITY (automatic disk scale-out)/MESSAGE_RETENTION_PERIOD (dynamic MESSAGE RETENTION policy).
        /// </summary>
        [JsonProperty("MaintenanceSubtype")]
        public string MaintenanceSubtype{ get; set; }

        /// <summary>
        /// Topic name
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Task trigger threshold.
        /// </summary>
        [JsonProperty("ConfigureThreshold")]
        public long? ConfigureThreshold{ get; set; }

        /// <summary>
        /// Specifies the step length for task adjustment.
        /// </summary>
        [JsonProperty("ConfigureStepSize")]
        public long? ConfigureStepSize{ get; set; }

        /// <summary>
        /// Task adjustment upper limit.
        /// </summary>
        [JsonProperty("ConfigureLimit")]
        public long? ConfigureLimit{ get; set; }

        /// <summary>
        /// Specifies the expected trigger time of the task, storing the offset in seconds from 0 AM of the current day.
        /// </summary>
        [JsonProperty("PlannedTime")]
        public long? PlannedTime{ get; set; }

        /// <summary>
        /// Additional task information.
        /// </summary>
        [JsonProperty("ExtraConfig")]
        public string ExtraConfig{ get; set; }

        /// <summary>
        /// Task status. 0: enabled, 1: disabled.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Specifies the day of the week.
        /// </summary>
        [JsonProperty("Week")]
        public string Week{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MaintenanceType", this.MaintenanceType);
            this.SetParamSimple(map, prefix + "MaintenanceSubtype", this.MaintenanceSubtype);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "ConfigureThreshold", this.ConfigureThreshold);
            this.SetParamSimple(map, prefix + "ConfigureStepSize", this.ConfigureStepSize);
            this.SetParamSimple(map, prefix + "ConfigureLimit", this.ConfigureLimit);
            this.SetParamSimple(map, prefix + "PlannedTime", this.PlannedTime);
            this.SetParamSimple(map, prefix + "ExtraConfig", this.ExtraConfig);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Week", this.Week);
        }
    }
}

