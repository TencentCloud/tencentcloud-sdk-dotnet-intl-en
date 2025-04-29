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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetInstanceLogRequest : AbstractModel
    {
        
        /// <summary>
        /// **Project ID**.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Unique identifier of an instance.
        /// </summary>
        [JsonProperty("InstanceKey")]
        public string InstanceKey{ get; set; }

        /// <summary>
        /// Instance lifetime number, which identifies one-time execution of the instance.
        /// 
        /// For example: the number of the first run of a periodic instance is 0. when the user reruns the instance later, the number of the second execution is 1.
        /// </summary>
        [JsonProperty("LifeRoundNum")]
        public ulong? LifeRoundNum{ get; set; }

        /// <summary>
        /// Time zone.
        /// Time zone. specifies the time zone. the default value is UTC+8.
        /// </summary>
        [JsonProperty("ScheduleTimeZone")]
        public string ScheduleTimeZone{ get; set; }

        /// <summary>
        /// Indicates the Ip address of the executor where the log is located.
        /// </summary>
        [JsonProperty("BrokerIp")]
        public string BrokerIp{ get; set; }

        /// <summary>
        /// Log file.
        /// When executionJobId in instance details is empty but originFileName is not empty, originFileName and brokerIp must be included in the input parameters.
        /// If both executionJobId and originFileName are empty, it indicates that the instance has not been dispatched for execution or has not generated logs. for example, branch node or merge node.
        /// </summary>
        [JsonProperty("OriginFileName")]
        public string OriginFileName{ get; set; }

        /// <summary>
        /// **Execution ID**.
        /// 
        /// When executionJobId in instance details is not empty, executionJobId needs to be included in the input parameters. originFileName and brokerIp are not required parameters.
        /// </summary>
        [JsonProperty("ExecutionJobId")]
        public string ExecutionJobId{ get; set; }

        /// <summary>
        /// Log level.
        /// Default All.
        /// 
        /// - Info
        /// - Debug
        /// - Warn
        /// - Error
        /// - All
        /// </summary>
        [JsonProperty("LogLevel")]
        public string LogLevel{ get; set; }

        /// <summary>
        /// Start row number for obtaining logs.
        /// The default is 1.
        /// </summary>
        [JsonProperty("StartLineNum")]
        public ulong? StartLineNum{ get; set; }

        /// <summary>
        /// End line number for obtaining logs.
        /// The default value is 10000.
        /// </summary>
        [JsonProperty("EndLineCount")]
        public ulong? EndLineCount{ get; set; }

        /// <summary>
        /// Used when performing a paging query for logs. it has no specific business meaning.
        /// 
        /// Specifies that the value is null for the first query. 
        /// Use the ExtInfo field value in the returned information from the previous query for the second and subsequent queries.
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "InstanceKey", this.InstanceKey);
            this.SetParamSimple(map, prefix + "LifeRoundNum", this.LifeRoundNum);
            this.SetParamSimple(map, prefix + "ScheduleTimeZone", this.ScheduleTimeZone);
            this.SetParamSimple(map, prefix + "BrokerIp", this.BrokerIp);
            this.SetParamSimple(map, prefix + "OriginFileName", this.OriginFileName);
            this.SetParamSimple(map, prefix + "ExecutionJobId", this.ExecutionJobId);
            this.SetParamSimple(map, prefix + "LogLevel", this.LogLevel);
            this.SetParamSimple(map, prefix + "StartLineNum", this.StartLineNum);
            this.SetParamSimple(map, prefix + "EndLineCount", this.EndLineCount);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

