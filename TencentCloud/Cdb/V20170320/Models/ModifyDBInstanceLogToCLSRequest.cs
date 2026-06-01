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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceLogToCLSRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, which can be obtained through the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Log type. error: error log. slowlog: slow log.
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// Delivery status. ON: Enabled, OFF: Disabled.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Whether required to create logset. Default to false.
        /// </summary>
        [JsonProperty("CreateLogset")]
        public bool? CreateLogset{ get; set; }

        /// <summary>
        /// Logset name when creating a logset; logset ID when selecting an existing log set. Empty by default.
        /// Description: When the parameter Status is set to ON, you must fill in either the Logset or LogTopic parameter.
        /// </summary>
        [JsonProperty("Logset")]
        public string Logset{ get; set; }

        /// <summary>
        /// Whether required to create log topic. Default to false.
        /// </summary>
        [JsonProperty("CreateLogTopic")]
        public bool? CreateLogTopic{ get; set; }

        /// <summary>
        /// Log topic name when creating a log topic; log topic ID when selecting an existing log topic. Empty by default.
        /// Description: When the parameter Status is set to ON, you must fill in either the Logset or LogTopic parameter.
        /// </summary>
        [JsonProperty("LogTopic")]
        public string LogTopic{ get; set; }

        /// <summary>
        /// Log topic valid period. Default value: 30 days if left empty. Maximum value: 3600.
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// Whether to create an index when creating a log topic. Default to false.
        /// </summary>
        [JsonProperty("CreateIndex")]
        public bool? CreateIndex{ get; set; }

        /// <summary>
        /// The region of CLS. If left empty, it defaults to the parameter value of Region.
        /// </summary>
        [JsonProperty("ClsRegion")]
        public string ClsRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateLogset", this.CreateLogset);
            this.SetParamSimple(map, prefix + "Logset", this.Logset);
            this.SetParamSimple(map, prefix + "CreateLogTopic", this.CreateLogTopic);
            this.SetParamSimple(map, prefix + "LogTopic", this.LogTopic);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "CreateIndex", this.CreateIndex);
            this.SetParamSimple(map, prefix + "ClsRegion", this.ClsRegion);
        }
    }
}

